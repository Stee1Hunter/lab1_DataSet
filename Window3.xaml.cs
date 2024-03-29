﻿using lab1_DataSet.lab_1DataSetTableAdapters;
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

namespace lab1_DataSet
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        TicketsTableAdapter ticket = new TicketsTableAdapter();
        public Window3()
        {
            InitializeComponent();
            TicketsDataGrid.ItemsSource = ticket.GetData();
        }

        
    }
}