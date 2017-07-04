using Steamworks;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace SteamMinge.Classes
{
    public static class ImageExtension
    {
        public static void DeleteFilesInDirectory(string DirPath, string Extension)
        {
            DirectoryInfo di = new DirectoryInfo(DirPath);
            FileInfo[] files = di.GetFiles("*." + Extension).Where(p => p.Extension == "." + Extension).ToArray();
            foreach (FileInfo file in files)
            {
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                }
                catch (Exception ex) { }
            }
        }

        public static Image GetSteamAvatar(CSteamID sID, string filename, int width, int height)
        {
            // Create the images directory if it doesnt exist
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\images"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\images");

            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\images\friends"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\images\friends");

            // Set full path
            string FullPath = Directory.GetCurrentDirectory() + @"\images\" + filename + @".bmp";

            // Try to get the avatar
            try
            {
                int AvatarBytes = SteamFriends.GetSmallFriendAvatar(sID);
                byte[] ImgArray = new byte[width * height * 4];
                bool Success = SteamUtils.GetImageRGBA(AvatarBytes, ImgArray, (int)(width * height * 4));

                if (Success)
                    SteamMinge.Classes.ImageExtension.WriteBitmapFile(FullPath, width, height, ImgArray);
            }
            catch(Exception ex) { }

            // Read the image in, avoid using Image.FromFile to avoid process lock on the image
            Image Avatar = null;
            if (File.Exists(FullPath))
            {
                using (FileStream fileStream = File.Open(FullPath, FileMode.Open))
                {
                    Bitmap Img = new Bitmap(fileStream);
                    Avatar = Img;
                }
            }

            // return the image we got
            return Avatar;
        }

        public static int WriteBitmapFile(string filename, int width, int height, byte[] imageData)
        {
            byte[] newData = new byte[imageData.Length];

            for (int x = 0; x < imageData.Length; x += 4)
            {
                byte[] pixel = new byte[4];
                Array.Copy(imageData, x, pixel, 0, 4);

                byte r = pixel[0];
                byte g = pixel[1];
                byte b = pixel[2];
                byte a = pixel[3];

                byte[] newPixel = new byte[] { b, g, r, a };

                Array.Copy(newPixel, 0, newData, x, 4);
            }

            imageData = newData;

            using (var stream = new MemoryStream(imageData))
            using (var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            {
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0,
                                                                bmp.Width,
                                                                bmp.Height),
                                                  ImageLockMode.WriteOnly,
                                                  bmp.PixelFormat);

                IntPtr pNative = bmpData.Scan0;
                Marshal.Copy(imageData, 0, pNative, imageData.Length);

                bmp.UnlockBits(bmpData);

                bmp.Save(filename);
            }

            return 1;
        }
    }
}
