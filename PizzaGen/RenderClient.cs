using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace PizzaGen
{
    public class RenderClient
    {
        public List<Image> SourceFrames = new List<Image>() { Assets.f1, Assets.f2, Assets.f3 };

        public Rectangle TextBounds = new Rectangle(0, 0, 420, 95);

        public Font font = null;

        public Image Render(string text)
        {
            List<Image> FrameBuffer = new List<Image>();

            Image HeaderText = RenderHeader(text);

            foreach (Image SourceFrame in SourceFrames)
            {
                FrameBuffer.Add(RenderSubsetFrame(SourceFrame, HeaderText));
            }

            using (MemoryStream WriteStream = new MemoryStream())
            {
                using (GifWriter writer = new GifWriter(WriteStream, 50, 0))
                {
                    writer.DefaultFrameDelay = 50;
                    writer.DefaultHeight = Assets.f1.Height;
                    writer.DefaultWidth = Assets.f1.Width;
                    foreach (Image BufferedFrame in FrameBuffer)
                    {
                        System.Console.WriteLine($"Writing frome @ {BufferedFrame.Width}x{BufferedFrame.Width}");
                        writer.WriteFrame(BufferedFrame);
                    }
                    WriteStream.Position = 0;
                    MemoryStream NS = new MemoryStream(WriteStream.ToArray());
                    return Image.FromStream(NS);
                }
            }
        }

        public void RenderToStream(string text, Stream stream)
        {
            List<Image> FrameBuffer = new List<Image>();

            Image HeaderText = RenderHeader(text);

            foreach (Image SourceFrame in SourceFrames)
            {
                FrameBuffer.Add(RenderSubsetFrame(SourceFrame, HeaderText));
            }

            using (GifWriter writer = new GifWriter(stream, 50, 0))
            {
                writer.DefaultFrameDelay = 50;
                writer.DefaultHeight = Assets.f1.Height;
                writer.DefaultWidth = Assets.f1.Width;
                foreach (Image BufferedFrame in FrameBuffer)
                {
                    System.Console.WriteLine($"Writing frome @ {BufferedFrame.Width}x{BufferedFrame.Width}");
                    writer.WriteFrame(BufferedFrame);
                }
                stream.Flush();
            }
        }

        public Font GetMaxFontSize(Size Bounds, string Text)
        {
            Bitmap bmp = new Bitmap(1, 1);
            var g = Graphics.FromImage(bmp);

            for (float f = 1; f < 500; f++)
            {
                Font Mod = new Font(font.FontFamily, f);
                SizeF NewSize = g.MeasureString(Text, Mod);
                if (NewSize.Height > Bounds.Height || NewSize.Width > Bounds.Width)
                {
                    return new Font(font.FontFamily, f - 1);
                }
            }
            return new Font(font.FontFamily, 50);
        }

        public Image RenderHeader(string text)
        {
            Bitmap bmpBase = new Bitmap(420, 95);
            Graphics g = Graphics.FromImage(bmpBase);

            Size InnerBound = new Size(380, 80);

            Font RenderFont = GetMaxFontSize(InnerBound, text);

            SizeF MeasuredSize = g.MeasureString(text, RenderFont);

            float MaxWidth = 420;
            float MaxHeight = 95;

            float WidthRemainder = MaxWidth - MeasuredSize.Width;
            float MeightRemainder = MaxHeight - MeasuredSize.Height;

            float WidthBuffer = WidthRemainder / 2;
            float HeightGuffer = MeightRemainder / 2;

            PointF Renderorigin = new PointF(WidthBuffer, HeightGuffer);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g.DrawString(text, RenderFont, Brushes.Black, Renderorigin);

            g.Save();
            return bmpBase;
        }

        public Image RenderSubsetFrame(Image Frame, Image Header)
        {
            Image FrameCopy = new Bitmap(Frame);

            Graphics g = Graphics.FromImage(FrameCopy);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g.DrawImage(Header, TextBounds);
            g.Save();
            return FrameCopy;
        }
    }
}