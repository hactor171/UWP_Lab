using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Laboratorium1_W1_
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RatingBar1.Value = -1;
            RatingBar2.Value = -1;
            Text_Napiwki.Text = "";
            Text_rachunek.Text = "";
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculate();
        }

        private void RatingChanged(RatingControl sender, object args)
        {
            Calculate();
        }

        private void Calculate()
        {
            if (string.IsNullOrEmpty(Text_rachunek.Text) || string.Equals(RatingBar1.Value.ToString("0.######"), "-1") || string.Equals(RatingBar2.Value.ToString("0.######"), "-1"))
            {
                Console.WriteLine("Jakies pole jest puste");
            }
            else 
            {
                var proc = 0.00;
                var result = 0.00;
                var n_stars1 = RatingBar1.Value;
                var n_stars2 = RatingBar2.Value;
                var rachunek = Convert.ToDouble(Text_rachunek.Text);
                if ((n_stars1 <= 5 && n_stars1 >= 4) && (n_stars2 <= 5 && n_stars2 >= 4))
                {
                    proc = 12;
                    result = (rachunek / 100) * proc;
                    Text_Napiwki.Text = result.ToString("0.######");
                }
                else if ((n_stars1 <= 4 && n_stars1 >= 2) && (n_stars2 <= 4 && n_stars2 >= 2))
                {
                    proc = 7;
                    result = (rachunek / 100) * proc;
                    Text_Napiwki.Text = result.ToString("0.######");
                }
                else if ((n_stars1 <= 2 && n_stars1 >= 0) && (n_stars2 <= 2 && n_stars2 >= 0))
                {
                    proc = 5;
                    result = (rachunek / 100) * proc;
                    Text_Napiwki.Text = result.ToString("0.######");
                }
                else if ((n_stars1 <= 5 && n_stars1 >= 3) && (n_stars2 <= 3 && n_stars2 >= 0))
                {
                    proc = 9;
                    result = (rachunek / 100) * proc;
                    Text_Napiwki.Text = result.ToString("0.######");
                }
                else if ((n_stars1 <= 3 && n_stars1 >= 0) && (n_stars2 <= 5 && n_stars2 >= 3))
                {
                    proc = 9;
                    result = (rachunek / 100) * proc;
                    Text_Napiwki.Text = result.ToString("0.######");
                }
            }
        }
    }
}
