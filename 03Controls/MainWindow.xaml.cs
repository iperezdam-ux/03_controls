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

namespace _03Controls
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid elMeuGrid = new Grid();
                this.Content = elMeuGrid;
                elMeuGrid.Background = Brushes.HotPink;

            Button btn = new Button();
                btn.Width = 100;
                btn.Height = 50;
                btn.Background = Brushes.LightYellow;
                elMeuGrid.Children.Add(btn);

            WrapPanel wrapPanel = new WrapPanel();
                btn.Content = wrapPanel;

            TextBlock txt = new TextBlock();
                txt.Text = "Hola";
                wrapPanel.Children.Add(txt);
                txt.Foreground = Brushes.Red;

            TextBlock txt2 = new TextBlock();
                txt2.Text = "Mundo";
                wrapPanel.Children.Add(txt2);
                txt2.Foreground = Brushes.Blue;

            TextBlock txt3 = new TextBlock();
                txt3.Text = "!";
                wrapPanel.Children.Add(txt3);
                txt3.Foreground = Brushes.Green;

            TextBlock txt4 = new TextBlock();
            txt4.Text = "Quim Test";
            wrapPanel.Children.Add(txt4);
            txt3.Foreground = Brushes.Green;







        }
    }
}
