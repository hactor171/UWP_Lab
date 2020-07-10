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

namespace Laboratorium2_w2_
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double value1 = 0;
        double value2 = 0;
        int operation = 0;

        public MainPage()
        {
            this.InitializeComponent();
            myFrame.Navigate(typeof(FirstPage), "MainPage");
        }

        private void buttonNext_Click(Object sender, RoutedEventArgs e)
        {
            if (myFrame.CanGoForward)
            {
                myFrame.GoForward();
            }
        }

        private void buttonPrevious_Click(Object sender, RoutedEventArgs e)
        {
            if (myFrame.CanGoBack)
            {
                myFrame.GoBack();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "1");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "1");
            }
            update();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "2");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "2");
            }
            update();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "3");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "3");
            }
            update();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "4");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "4");
            }
            update();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "5");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "5");
            }
            update();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "6");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "6");
            }
            update();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "7");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "7");
            }
            update();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "8");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "8");
            }
            update();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "9");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "9");
            }
            update();
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 = Convert.ToDouble(value1.ToString() + "0");
            }
            else
            {
                value2 = Convert.ToDouble(value2.ToString() + "0");
            }
            update();
        }

        private void update()
        {
            String result = value1.ToString();
            if (operation != 0)
            {
                switch (operation)
                {
                    case 1:
                        result += " + ";
                        break;
                    case 2:
                        result += " - ";
                        break;
                    case 3:
                        result += " * ";
                        break;
                    case 4:
                        result += " / ";
                        break;
                }
                result += value2.ToString();
            }
            display.Text = result;
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = 1;
            update();
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = 2;
            update();
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = 3;
            update();
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = 4;
            update();
        }

        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            Double result = 0;
            switch (operation)
            {
                case 1:
                    result = value1 + value2;
                    break;
                case 2:
                    result = value1 - value2;
                    break;
                case 3:
                    result = value1 * value2;
                    break;
                case 4:
                    result = value1 / value2;
                    break;
            }
            history.Text = display.Text + "\n" + history.Text;
            value1 = result;
            operation = 0;
            value2 = 0;
            update();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            value1 = 0;
            value2 = 0;
            operation = 0;
            update();
            
        }

        private void buttonSign_Click(object sender, RoutedEventArgs e)
        {
            if (operation == 0)
            {
                value1 *= -1;
            }
            else
            {
                value2 *= -1;
            }
        }


    }
}
