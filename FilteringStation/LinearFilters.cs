using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringStation
{
    internal class LinearFilters
    {
        private double[] _args;

        public LinearFilters(double[] args)
        {
            _args = args;
        }

        public Image ProcessImage(Filters type, Image input)
        {
            switch (type)
            {
                case Filters.LinearArythmetic:
                    return LinearArythmetic(input);
                case Filters.LinearGeometric:
                    return LinearGeometric(input);
                case Filters.LinearHarmonic:
                    return LinearHarmonic(input);
                case Filters.LinearCounterHarmonic:
                    return LinearCounterHarmonic(input);
                case Filters.LinearGaussian:
                    return LinearGaussian(input);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        private Image LinearArythmetic(Image img)
        {
            Bitmap outImage = new Bitmap(img.Width, img.Height);
            using (Bitmap bmp = new Bitmap(img))
            {
                double coeff = 1 / (_args[0] * _args[1]);
                bool flag = (Math.Abs(coeff - 1.0) < 0.0000001);
                int p1 = (int)(_args[0] - 1), p2 = (int)(_args[1] - 1);

                for (int w = 0; w < img.Width; w++)
                {
                    for (int h = 0; h < img.Height; h++)
                    {
                        double rSum = 0, gSum = 0, bSum = 0;
                        Color newPixel;
                        if (flag)
                        {
                            newPixel = bmp.GetPixel(w, h);
                        }
                        else
                        {
                            double gone = 0.0;
                            for (int k = w; k < w + p1; k++)
                            {
                                for (int j = h; j < h + p2; j++)
                                {
                                    try
                                    {
                                        Color oldPixel = bmp.GetPixel(k, j);
                                        gone += 1.0;
                                        rSum += oldPixel.R;
                                        gSum += oldPixel.G;
                                        bSum += oldPixel.B;
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            newPixel = Color.FromArgb((int)(rSum / gone), (int)(gSum / gone), (int)(bSum / gone));
                        }
                        outImage.SetPixel(w, h, newPixel);
                    }
                }
            }
            return outImage;
        }

        private Image LinearGeometric(Image img)
        {
            Bitmap outImage = new Bitmap(img.Width, img.Height);
            using (Bitmap bmp = new Bitmap(img))
            {
                double coeff = 1 / (_args[0] * _args[1]);
                bool flag = (Math.Abs(coeff - 1.0) < 0.0000001);
                int p1 = (int)(_args[0] - 1), p2 = (int)(_args[1] - 1);

                for (int w = 0; w < img.Width; w++)
                {
                    for (int h = 0; h < img.Height; h++)
                    {
                        double rSum = 1, gSum = 1, bSum = 1;
                        Color newPixel;
                        if (flag)
                        {
                            newPixel = bmp.GetPixel(w, h);
                        }
                        else
                        {
                            double gone = 0.0;
                            for (int k = w; k < w + p1; k++)
                            {
                                for (int j = h; j < h + p2; j++)
                                {
                                    try
                                    {
                                        Color oldPixel = bmp.GetPixel(k, j);
                                        gone += 1.0;
                                        rSum *= oldPixel.R;
                                        gSum *= oldPixel.G;
                                        bSum *= oldPixel.B;
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            gone = 1 / gone;
                            newPixel = Color.FromArgb((int)Math.Pow(rSum, gone), (int)Math.Pow(gSum, gone), (int)Math.Pow(bSum, gone));
                        }
                        outImage.SetPixel(w, h, newPixel);
                    }
                }
            }
            return outImage;
        }

        private Image LinearHarmonic(Image img)
        {
            Bitmap outImage = new Bitmap(img.Width, img.Height);
            using (Bitmap bmp = new Bitmap(img))
            {
                double coeff = 1 / (_args[0] * _args[1]);
                bool flag = (Math.Abs(coeff - 1.0) < 0.0000001);
                int p1 = (int)(_args[0] - 1), p2 = (int)(_args[1] - 1);

                for (int w = 0; w < img.Width; w++)
                {
                    for (int h = 0; h < img.Height; h++)
                    {
                        double rSum = 0, gSum = 0, bSum = 0;
                        Color newPixel;
                        if (flag)
                        {
                            newPixel = bmp.GetPixel(w, h);
                        }
                        else
                        {
                            double gone = 0.0;
                            for (int k = w; k < w + p1; k++)
                            {
                                for (int j = h; j < h + p2; j++)
                                {
                                    try
                                    {
                                        Color oldPixel = bmp.GetPixel(k, j);
                                        gone += 1.0;
                                        rSum += 1.0 / oldPixel.R;
                                        gSum += 1.0 / oldPixel.G;
                                        bSum += 1.0 / oldPixel.B;
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            newPixel = Color.FromArgb((int)(gone / rSum), (int)(gone / gSum), (int)(gone / bSum));
                        }
                        outImage.SetPixel(w, h, newPixel);
                    }
                }
            }
            return outImage;
        }

        private Image LinearCounterHarmonic(Image img)
        {
            Bitmap outImage = new Bitmap(img.Width, img.Height);
            double rank = _args[2];

            using (Bitmap bmp = new Bitmap(img))
            {
                double coeff = 1 / (_args[0] * _args[1]);
                bool flag = (Math.Abs(coeff - 1.0) < 0.0000001);
                int p1 = (int)(_args[0] - 1), p2 = (int)(_args[1] - 1);

                for (int w = 0; w < img.Width; w++)
                {
                    for (int h = 0; h < img.Height; h++)
                    {
                        double rSum = 0, gSum = 0, bSum = 0;
                        double rdSum = 0, gdSum = 0, bdSum = 0;
                        Color newPixel;
                        if (flag)
                        {
                            newPixel = bmp.GetPixel(w, h);
                        }
                        else
                        {
                            for (int k = w; k < w + p1; k++)
                            {
                                for (int j = h; j < h + p2; j++)
                                {
                                    try
                                    {
                                        Color oldPixel = bmp.GetPixel(k, j);
                                        if (oldPixel.R != 0)
                                        {
                                            rSum += Math.Pow(oldPixel.R, rank + 1);
                                            rdSum += Math.Pow(oldPixel.R, rank);
                                        }
                                        if (oldPixel.G != 0)
                                        {
                                            gSum += Math.Pow(oldPixel.G, rank + 1);
                                            gdSum += Math.Pow(oldPixel.G, rank);
                                        }
                                        if (oldPixel.B != 0)
                                        {
                                            bSum += Math.Pow(oldPixel.B, rank + 1);
                                            bdSum += Math.Pow(oldPixel.B, rank);
                                        }
                                    }
                                    catch
                                    {

                                    }
                                }
                            }

                            newPixel = Color.FromArgb(
                                (int)(rSum / (Math.Abs(rdSum) < 0.000000000001 ? 1 : rdSum)),
                                (int)(gSum / (Math.Abs(gdSum) < 0.000000000001 ? 1 : gdSum)), 
                                (int)(bSum / (Math.Abs(bdSum) < 0.000000000001 ? 1 : bdSum)));
                        }
                        outImage.SetPixel(w, h, newPixel);
                    }
                }
            }
            return outImage;
        }

        private Image LinearGaussian(Image img)
        {
            return null;
        }
    }
}
