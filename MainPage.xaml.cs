using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace PaintBlaszkiewicz
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        SolidColorBrush pedzel = new SolidColorBrush(Colors.Black);

        Point pktStartowy;
        bool czyRysuje = false;  
      
       
        Stack<UIElement> listaUndo = new Stack<UIElement>();


        Windows.UI.Xaml.Shapes.Line kreskaPoprzednia;


        private void poleRysowania_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            pktStartowy = e.GetCurrentPoint(poleRysowania).Position;
            czyRysuje = true;
        }

        private void poleRysowania_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            czyRysuje = false;
            kreskaPoprzednia = null;
        }

        private void poleRysowania_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (czyRysuje)
            {
                
                    Point pktAkt = e.GetCurrentPoint(poleRysowania).Position;
                    
                    Rysuj(pktStartowy, pktAkt);
                    if (rdbDowolna.IsChecked == true)
                        pktStartowy = pktAkt;
  
            }
        }
        private void Rysuj(Point pktStartowy, Point pktAkt)
        {
           var kreska = new Windows.UI.Xaml.Shapes.Line()
             {
                 X1 = pktStartowy.X,
                 Y1 = pktStartowy.Y,
                 X2 = pktAkt.X,
                 Y2 = pktAkt.Y,
                 Stroke = pedzel,
                 StrokeThickness = sliderGrubosc.Value,
                 StrokeEndLineCap = PenLineCap.Round,
                 StrokeStartLineCap = PenLineCap.Round

             };

            
            if (rdbProsta.IsChecked == true)
            {
                poleRysowania.Children.Remove(kreskaPoprzednia);

                kreskaPoprzednia = kreska;

            }
            poleRysowania.Children.Add(kreska);
            listaUndo.Push(kreska);
            

        }
        


        async private void btnKoniec_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog potwierdzWyjscie = new ContentDialog()
            {
                Title = "Czy na pewno chcesz zakończyć?",
                PrimaryButtonText = "Nie",
                SecondaryButtonText = "Tak",
                DefaultButton = ContentDialogButton.Primary
            };

            var res = await potwierdzWyjscie.ShowAsync();
            if (res == ContentDialogResult.Secondary)
                Environment.Exit(0);



        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            poleRysowania.Children.Clear();
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {

            int count = poleRysowania.Children.Count;
            if (count > 0)
                poleRysowania.Children.RemoveAt(count - 1);
        }

     
        private void poleRysowania_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            poleRysowania.Clip = new RectangleGeometry() { Rect = new Rect(0, 0, poleRysowania.ActualWidth, poleRysowania.ActualHeight) };
        }

        private void StackPanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            var kwadracik = e.OriginalSource as Windows.UI.Xaml.Shapes.Rectangle;
            pedzel = (SolidColorBrush)kwadracik.Fill;
            
            
        }

     
        private void paleta_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            pedzel = new SolidColorBrush(paleta.Color);
            btnKolor.Flyout.Hide();
        }

        private void paleta_PointerMoved_1(object sender, PointerRoutedEventArgs e)
        {
            pedzel = new SolidColorBrush(paleta.Color);
        }

        

    }
}
