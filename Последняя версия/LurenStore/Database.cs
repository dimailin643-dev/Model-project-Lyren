using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;

namespace LurenStore
{
    internal static class Database
    {
        public static string FilePath
        {
            get
            {
                return Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "LurenStore", "luren.db");
            }
        }

        private static SQLiteConnection OpenConnection()
        {
            var connection = new SQLiteConnection("Data Source=" + FilePath + ";");
            connection.Open();
            return connection;
        }

        public static void Initialize()
        {
            string folder = Path.GetDirectoryName(FilePath);
            Directory.CreateDirectory(folder);
            bool firstStart = !File.Exists(FilePath);

            string template = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "luren.db");
            if (firstStart && File.Exists(template))
            {
                File.Copy(template, FilePath);
                firstStart = false;
            }

            using (var connection = OpenConnection())
            {
                Execute(connection, @"
CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Login TEXT NOT NULL UNIQUE COLLATE NOCASE,
    PasswordSalt BLOB NOT NULL,
    PasswordHash BLOB NOT NULL
);
CREATE TABLE IF NOT EXISTS Products (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Article TEXT NOT NULL UNIQUE COLLATE NOCASE,
    Name TEXT NOT NULL,
    Category TEXT NOT NULL,
    Size TEXT NOT NULL,
    Color TEXT NOT NULL,
    Price REAL NOT NULL CHECK(Price >= 0),
    Quantity INTEGER NOT NULL CHECK(Quantity >= 0)
);
CREATE TABLE IF NOT EXISTS Clients (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    LastName TEXT NOT NULL,
    FirstName TEXT NOT NULL,
    MiddleName TEXT,
    Phone TEXT NOT NULL UNIQUE,
    Email TEXT
);
");

                if (firstStart)
                {
                    AddDemoUser(connection);
                    SeedProducts(connection);
                    SeedClients(connection);
                }
            }
        }

        private static void Execute(SQLiteConnection connection, string sql)
        {
            foreach (string statement in sql.Split(';'))
            {
                if (string.IsNullOrWhiteSpace(statement)) continue;
                using (var command = new SQLiteCommand(statement, connection))
                    command.ExecuteNonQuery();
            }
        }

        private static void AddDemoUser(SQLiteConnection connection)
        {
            var salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(salt);
            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes("1234", salt, 100000, HashAlgorithmName.SHA256))
                hash = pbkdf2.GetBytes(32);

            using (var command = new SQLiteCommand(
                "INSERT INTO Users (Login, PasswordSalt, PasswordHash) VALUES (@login, @salt, @hash)", connection))
            {
                command.Parameters.AddWithValue("@login", "admin");
                command.Parameters.AddWithValue("@salt", salt);
                command.Parameters.AddWithValue("@hash", hash);
                command.ExecuteNonQuery();
            }
        }

        private static void SeedProducts(SQLiteConnection connection)
        {
            AddProduct(connection, "LR-001", "Куртка из денима", "Куртки", "M", "Синий", 7990m, 8);
            AddProduct(connection, "LR-002", "Джинсы прямые", "Джинсы", "30", "Чёрный", 4590m, 13);
            AddProduct(connection, "LR-003", "Футболка базовая", "Футболки", "L", "Белый", 1790m, 25);
            AddProduct(connection, "LR-004", "Брюки свободные", "Брюки", "M", "Серый", 3990m, 10);
            AddProduct(connection, "LR-005", "Рубашка хлопковая", "Рубашки", "XL", "Бежевый", 3490m, 7);
        }

        private static void SeedClients(SQLiteConnection connection)
        {
            AddClient(connection, "Иванов", "Михаил", "Андреевич", "+79990000001", "ivanov@example.com");
            AddClient(connection, "Петрова", "Алина", "Сергеевна", "+79990000002", "petrova@example.com");
            AddClient(connection, "Смирнов", "Егор", "", "+79990000003", "");
        }

        public static bool CheckLogin(string login, string password)
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(
                "SELECT PasswordSalt, PasswordHash FROM Users WHERE Login = @login", connection))
            {
                command.Parameters.AddWithValue("@login", login);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read()) return false;
                    var salt = (byte[])reader[0];
                    var expected = (byte[])reader[1];
                    byte[] actual;
                    using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
                        actual = pbkdf2.GetBytes(expected.Length);
                    if (actual.Length != expected.Length) return false;
                    int difference = 0;
                    for (int i = 0; i < actual.Length; i++) difference |= actual[i] ^ expected[i];
                    return difference == 0;
                }
            }
        }

        public static DataTable LoadProducts(string search = "")
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(@"
SELECT Id, Article, Name, Category, Size, Color, Price, Quantity FROM Products
WHERE @search = '' OR Article LIKE @pattern OR Name LIKE @pattern OR Category LIKE @pattern
ORDER BY Id DESC", connection))
            {
                command.Parameters.AddWithValue("@search", search);
                command.Parameters.AddWithValue("@pattern", "%" + search + "%");
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public static bool ArticleExists(string article, int exceptId)
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(
                "SELECT COUNT(*) FROM Products WHERE Article = @article COLLATE NOCASE AND Id <> @id", connection))
            {
                command.Parameters.AddWithValue("@article", article);
                command.Parameters.AddWithValue("@id", exceptId);
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public static void AddProduct(string article, string name, string category, string size,
            string color, decimal price, int quantity)
        {
            using (var connection = OpenConnection())
                AddProduct(connection, article, name, category, size, color, price, quantity);
        }

        private static void AddProduct(SQLiteConnection connection, string article, string name, string category,
            string size, string color, decimal price, int quantity)
        {
            using (var command = new SQLiteCommand(@"
INSERT INTO Products (Article, Name, Category, Size, Color, Price, Quantity)
VALUES (@article, @name, @category, @size, @color, @price, @quantity)", connection))
            {
                ProductParameters(command, article, name, category, size, color, price, quantity);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateProduct(int id, string article, string name, string category,
            string size, string color, decimal price, int quantity)
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(@"
UPDATE Products SET Article=@article, Name=@name, Category=@category, Size=@size,
Color=@color, Price=@price, Quantity=@quantity WHERE Id=@id", connection))
            {
                ProductParameters(command, article, name, category, size, color, price, quantity);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        private static void ProductParameters(SQLiteCommand command, string article, string name,
            string category, string size, string color, decimal price, int quantity)
        {
            command.Parameters.AddWithValue("@article", article);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@size", size);
            command.Parameters.AddWithValue("@color", color);
            command.Parameters.AddWithValue("@price", Convert.ToDouble(price));
            command.Parameters.AddWithValue("@quantity", quantity);
        }

        public static void DeleteProduct(int id)
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand("DELETE FROM Products WHERE Id=@id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable LoadClients(string search = "")
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(@"
SELECT Id, LastName, FirstName, MiddleName, Phone, Email FROM Clients
WHERE (@search = '' OR LastName LIKE @pattern OR Phone LIKE @pattern)
ORDER BY Id DESC", connection))
            {
                command.Parameters.AddWithValue("@search", search);
                command.Parameters.AddWithValue("@pattern", "%" + search + "%");
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public static bool PhoneExists(string phone, int exceptId)
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(
                "SELECT COUNT(*) FROM Clients WHERE Phone = @phone AND Id <> @id", connection))
            {
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@id", exceptId);
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public static void AddClient(string lastName, string firstName, string middleName,
            string phone, string email)
        {
            using (var connection = OpenConnection())
                AddClient(connection, lastName, firstName, middleName, phone, email);
        }

        private static void AddClient(SQLiteConnection connection, string lastName, string firstName,
            string middleName, string phone, string email)
        {
            using (var command = new SQLiteCommand(@"
INSERT INTO Clients (LastName, FirstName, MiddleName, Phone, Email)
VALUES (@last, @first, @middle, @phone, @email)", connection))
            {
                ClientParameters(command, lastName, firstName, middleName, phone, email);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateClient(int id, string lastName, string firstName, string middleName,
            string phone, string email)
        {
            using (var connection = OpenConnection())
            using (var command = new SQLiteCommand(@"
UPDATE Clients SET LastName=@last, FirstName=@first, MiddleName=@middle,
Phone=@phone, Email=@email WHERE Id=@id", connection))
            {
                ClientParameters(command, lastName, firstName, middleName, phone, email);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        private static void ClientParameters(SQLiteCommand command, string lastName, string firstName,
            string middleName, string phone, string email)
        {
            command.Parameters.AddWithValue("@last", lastName);
            command.Parameters.AddWithValue("@first", firstName);
            command.Parameters.AddWithValue("@middle", middleName);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
        }
    }
}
