using System;
using System.Collections.Generic;
using System.Data;
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
using lab1_DataSet.lab_1DataSetTableAdapters;

namespace lab1_DataSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 client = new Window1();
            client.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 film = new Window2();
            film.Show();
            
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            Window3 ticket = new Window3();
            ticket.Show();
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window4 da = new Window4();
            da.Show();
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            Window5 da = new Window5();
            da.Show();
        }
    }
}
