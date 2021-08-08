using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageEditor
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        Point currentPoint = new Point();
        Item CurrItem;
        BitmapImage img;

        public enum Item
        {
            Brush, Pencil, Highlighter, Rectangle, Text
        }
        private Point startPoint;
        private Rectangle rect;
        private void CanvasMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(Drawing);
            if (CurrItem == Item.Rectangle)
            {
                startPoint = e.GetPosition(Drawing);

                rect = new Rectangle
                {
                    Stroke = Brushes.Red,
                    StrokeThickness = 2
                };
                Canvas.SetLeft(rect, startPoint.X);
                Canvas.SetTop(rect, startPoint.Y);
                Drawing.Children.Add(rect);
            }
            else if (CurrItem == Item.Text)
            {
                TextBox box = new TextBox();
                box.HorizontalAlignment = HorizontalAlignment.Left;
                box.VerticalAlignment = VerticalAlignment.Top;
                Thickness margin = new Thickness(e.GetPosition(Drawing).X, e.GetPosition(Drawing).Y, 0, 0);
                box.Margin = margin;
                Drawing.Children.Add(box);
            }
        }

        public void loadImage(BitmapImage img)
        {

            border.Reset();

            double width = img.Width / border.ActualWidth;
            double height = img.Height / border.ActualHeight;
            double divisor = 0.0;
            if (width <= height)
            {
                divisor = height;
            }
            else
            {
                divisor = width;
            }


            Drawing.Width = img.Width / divisor;
            Drawing.Height = img.Height / divisor;
            Back.Width = img.Width / divisor;
            Back.Height = img.Height / divisor;
            Component.Width = img.Width / divisor;
            Component.Height = img.Height / divisor;
            Back.Source = img;
            //Drawing.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            //Background.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            //Drawing.Arrange(new Rect(new Size((int)Background.Width, (int)Background.Height)));


        }
        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (CurrItem == Item.Rectangle)
                {
                    if (e.LeftButton == MouseButtonState.Released || rect == null)
                        return;

                    var pos = e.GetPosition(Drawing);

                    var x = Math.Min(pos.X, startPoint.X);
                    var y = Math.Min(pos.Y, startPoint.Y);

                    var w = Math.Max(pos.X, startPoint.X) - x;
                    var h = Math.Max(pos.Y, startPoint.Y) - y;

                    rect.Width = w;
                    rect.Height = h;

                    Canvas.SetLeft(rect, x);
                    Canvas.SetTop(rect, y);
                }
                else
                {
                    Line line = new Line();
                    if (CurrItem == Item.Brush)
                    {
                        line.Stroke = Brushes.Red;
                        line.StrokeThickness = 4;
                    }
                    else if (CurrItem == Item.Pencil)
                    {
                        line.Stroke = SystemColors.WindowFrameBrush;
                    }
                    else if (CurrItem == Item.Highlighter)
                    {
                        line.Stroke = Brushes.Yellow;
                        line.StrokeThickness = 10;
                        line.Opacity = 0.2;
                    }


                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(Drawing).X;
                    line.Y2 = e.GetPosition(Drawing).Y;

                    currentPoint = e.GetPosition(Drawing);

                    //Drawing.Children.Add(line);
                    Drawing.Children.Add(line);
                }

            }
        }


        private void Upload_Image(object sender, RoutedEventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                img = new BitmapImage(new Uri(op.FileName));
                double width = img.Width / border.ActualWidth;




                double height = img.Height / border.ActualHeight;
                double divisor = 0.0;
                if (width <= height)
                {
                    divisor = height;
                }
                else
                {
                    divisor = width;
                }


                Drawing.Width = (int)img.Width / divisor;
                Drawing.Height = (int)img.Height / divisor;
                Back.Width = (int)img.Width / divisor;
                Back.Height = (int)img.Height / divisor;
                Back.Source = img;
                ZoomAmount.Value = 100;

            }
        }

        public BitmapImage save()
        {


            DrawingVisual drawingVisual = new DrawingVisual();
            DrawingContext drawingContext = drawingVisual.RenderOpen();
            int width = ((int)Back.Width) * 2;
            int height = ((int)Back.Height) * 2;

            drawingContext.DrawImage(Back.Source, new Rect(0, 0, (int)Back.Width, (int)Back.Height));
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap((int)Drawing.Width, (int)Drawing.Height, 96, 96, PixelFormats.Pbgra32);

            //RenderTargetBitmap renderBmap = new RenderTargetBitmap(img.PixelWidth, img.PixelHeight, 96d, 96d, PixelFormats.Pbgra32);
            var intermediate = Drawing;
            intermediate.Measure(new Size((int)Drawing.Width, (int)Drawing.Height));


            intermediate.Arrange(new Rect(new Size((int)Back.Width, (int)Back.Height)));

            //Drawing.Measure(new Size((int)Drawing.Width, (int)Drawing.Height));


            //Drawing.Arrange(new Rect(new Size((int)Background.Width, (int)Background.Height)));


            renderBitmap.Render(intermediate);

            drawingContext.DrawImage(renderBitmap, new Rect(0, 0, Back.Width, Back.Height));

            drawingContext.Close();

            RenderTargetBitmap renderBmap = new RenderTargetBitmap(width, height, 192, 192, PixelFormats.Pbgra32);
            renderBmap.Render(drawingVisual);


            border.Reset();
            Back.Source = TargetToBitmap(renderBmap);

            //loadImage(TargetToBitmap(renderBmap));
            Drawing.Children.Clear();
            //border.RestoreQuality();
            return TargetToBitmap(renderBmap);

        }

        private BitmapImage TargetToBitmap(RenderTargetBitmap img)
        {
            var renderTargetBitmap = img;
            var bitmapImage = new BitmapImage();
            var bitmapEncoder = new PngBitmapEncoder();
            bitmapEncoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

            using (var stream = new MemoryStream())
            {
                bitmapEncoder.Save(stream);
                stream.Seek(0, SeekOrigin.Begin);

                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }

        private void Save_Image(object sender, RoutedEventArgs e)
        {


            DrawingVisual drawingVisual = new DrawingVisual();
            DrawingContext drawingContext = drawingVisual.RenderOpen();
            int width = ((int)Back.Width) * 2;
            int height = ((int)Back.Height) * 2;

            drawingContext.DrawImage(Back.Source, new Rect(0, 0, (int)Back.Width, (int)Back.Height));
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap((int)Drawing.Width, (int)Drawing.Height, 96, 96, PixelFormats.Pbgra32);

            //RenderTargetBitmap renderBmap = new RenderTargetBitmap(img.PixelWidth, img.PixelHeight, 96d, 96d, PixelFormats.Pbgra32);
            var intermediate = Drawing;
            intermediate.Measure(new Size((int)Drawing.Width, (int)Drawing.Height));


            intermediate.Arrange(new Rect(new Size((int)Back.Width, (int)Back.Height)));

            //Drawing.Measure(new Size((int)Drawing.Width, (int)Drawing.Height));


            //Drawing.Arrange(new Rect(new Size((int)Background.Width, (int)Background.Height)));     


            renderBitmap.Render(intermediate);

            drawingContext.DrawImage(renderBitmap, new Rect(0, 0, Back.Width, Back.Height));

            drawingContext.Close();

            RenderTargetBitmap renderBmap = new RenderTargetBitmap(width, height, 192, 192, PixelFormats.Pbgra32);
            renderBmap.Render(drawingVisual);


            border.Reset();
            Back.Source = TargetToBitmap(renderBmap);

            BitmapImage saveimage = TargetToBitmap(renderBmap);
            Drawing.Children.Clear();

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document";
            dlg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (dlg.ShowDialog() == true)
            {
                var encoder = new JpegBitmapEncoder(); // Or PngBitmapEncoder, or whichever encoder you want
                encoder.Frames.Add(BitmapFrame.Create(saveimage));
                using (var stream = dlg.OpenFile())
                {
                    encoder.Save(stream);
                }
            }








        }

        private void Click_Pencil(object sender, RoutedEventArgs e)
        {
            CurrItem = Item.Pencil;
            border.CanMove = false;
        }

        private void Click_Brush(object sender, RoutedEventArgs e)
        {
            CurrItem = Item.Brush;
            border.CanMove = false;
        }

        private void Click_Reset(object sender, RoutedEventArgs e)
        {
            border.Reset();
            border.CanMove = true;
            percentage.Content = "100 %";
        }

        private void Click_Pan(object sender, RoutedEventArgs e)
        {
            border.CanMove = true;
        }

        private void Click_Highlight(object sender, RoutedEventArgs e)
        {
            CurrItem = Item.Highlighter;
            border.CanMove = false;
            //Colors.Visibility = Visibility.Visible;
        }



        private void Click_Zoom(object sender, RoutedEventArgs e)
        {

            border.zoomIn(ZoomAmount.Value / 100.0 + 0.5, new Point(border.ActualWidth / 2, border.ActualHeight / 2));
            ZoomAmount.Value = ZoomAmount.Value + 50;
            percentage.Content = ((int)ZoomAmount.Value).ToString() + " %";
        }

        private void Slider_move(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            border.zoomIn(ZoomAmount.Value / 100.0, new Point(border.ActualWidth / 2, border.ActualHeight / 2));
            percentage.Content = ((int)ZoomAmount.Value).ToString() + " %";
        }

        private void Click_ZoomOut(object sender, RoutedEventArgs e)
        {
            border.zoomIn(ZoomAmount.Value / 100.0 - 0.5, new Point(border.ActualWidth / 2, border.ActualHeight / 2));
            ZoomAmount.Value = ZoomAmount.Value - 50;
            percentage.Content = ((int)ZoomAmount.Value).ToString() + " %";
        }

        private void Click_Rectangle(object sender, RoutedEventArgs e)
        {
            CurrItem = Item.Rectangle;
            border.CanMove = false;
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            rect = null;
        }

        private void Click_Text(object sender, RoutedEventArgs e)
        {
            CurrItem = Item.Text;
            border.CanMove = false;
        }

        private void Click_RemoveEdits(object sender, RoutedEventArgs e)
        {
            Drawing.Children.Clear();

        }
    }
}
