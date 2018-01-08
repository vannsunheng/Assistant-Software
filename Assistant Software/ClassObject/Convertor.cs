using System;
using System.Drawing;
public class Convertor
{
    public static byte[] convertImageToByte(Image Img) {
        byte[] b;
        System.IO.MemoryStream MS = new System.IO.MemoryStream();
        try
        {
            Img.Save(MS, System.Drawing.Imaging.ImageFormat.Png);
        }
        catch (Exception ex1) {
            try
            {
                Img.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex2) {
                try
                {
                    Img.Save(MS, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                catch (Exception ex3)
                {
                    try
                    {
                        Img.Save(MS, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    catch (Exception ex4) {
                        try
                        {
                            Img.Save(MS, System.Drawing.Imaging.ImageFormat.Icon);
                        }
                        catch (Exception ex5) {
                            try
                            {
                                Img.Save(MS, System.Drawing.Imaging.ImageFormat.Exif);
                            }
                            catch (Exception ex6) {
                                try
                                {
                                    Img.Save(MS, System.Drawing.Imaging.ImageFormat.MemoryBmp);
                                }
                                catch (Exception ex7) {

                                }
                            }
                        }
                    }
                }
            }
        }
        b = MS.GetBuffer();
        return b;
    }
    public static Image ConvertByteToImage(byte[] b) {
        Image img;
        System.IO.MemoryStream st = new System.IO.MemoryStream(b);
        img = Image.FromStream(st);
        return img;
    }
}

