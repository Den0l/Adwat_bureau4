﻿using BareusFilterDataSet.Adwat_bureauDataSetTableAdapters;
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

namespace BareusFilterDataSet
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        ClientsTableAdapter clients = new ClientsTableAdapter();
        public ClientsPage()
        {
            InitializeComponent();
            grid_Clients.ItemsSource = clients.GetData();
        }
    }
}
