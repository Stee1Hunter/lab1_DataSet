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
using System.Windows.Shapes;
using lab1_DataSet.lab_1DataSetTableAdapters;

namespace lab1_DataSet
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        FilmsTableAdapter film = new FilmsTableAdapter();
        public Window2()
        {
            InitializeComponent();
            FilmDataGrid.ItemsSource = film.GetData();
        }

        
    }
}
