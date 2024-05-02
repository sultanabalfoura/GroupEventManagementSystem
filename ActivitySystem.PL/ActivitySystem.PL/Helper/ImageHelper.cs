using System;
using static System.Net.Mime.MediaTypeNames;

namespace ActivitySystem.PL.Helper
{
	public static class ImageHelper
	{
        public static byte[] ImageToByteArray(Stream imageStream)
        {
            using (var ms = new MemoryStream())
            {
                imageStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static byte[] ImageToByteArray(byte[] imageData)
        {
            return imageData;
        }
    }
}

