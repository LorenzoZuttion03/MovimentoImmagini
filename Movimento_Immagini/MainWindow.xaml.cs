using System;
using System.Collections.Generic;
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
using System.Threading;

namespace Movimento_Immagini
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * readonly Uri uriDelfino = new Uri("delfino.jpg" , UriKind.Relative);
         */
        public MainWindow()
        {
            InitializeComponent();
            Thread t1 = new Thread(new ThreadStart(muoviDelfino));
            //ImageSource imm = new BitmapImage(uriDelfino);
            //imgDelfino.Source = imm;
            t1.Start();
           
        }
        public void muoviDelfino()
        {
            for (int i = 100; i < 500; i += 50)
            {
                //imgDelfino.Margin = new Thickness(i, 100, 100, 100);
                Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                }));
            }
            




        }
    }
}
