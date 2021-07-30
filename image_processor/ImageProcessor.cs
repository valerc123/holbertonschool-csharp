using System;
using System.Drawing;
using System.Threading.Tasks;

/// <summary>
/// Class imageProcessor
/// </summary>
class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (filename) => {
            BitmapHelper(byte[] bytes, filename, "_grayscale");
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = (byte)(255 - bytes[i]);
        });
    }
}
