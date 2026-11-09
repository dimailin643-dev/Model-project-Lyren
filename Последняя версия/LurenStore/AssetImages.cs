using System;
using System.Drawing;
using System.IO;

namespace LurenStore
{
    internal static class AssetImages
    {
        public static Image Load(string imageName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", imageName + ".jpg");
            if (!File.Exists(path)) return null;
            using (var fileImage = Image.FromFile(path))
                return new Bitmap(fileImage);
        }
    }
}
