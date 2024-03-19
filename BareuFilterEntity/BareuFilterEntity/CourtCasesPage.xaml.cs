﻿using System;
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

namespace BareuFilterEntity
{
    /// <summary>
    /// Логика взаимодействия для CourtCasesPage.xaml
    /// </summary>
    public partial class CourtCasesPage : Page
    {
        private Adwat_bureauEntities contex = new Adwat_bureauEntities();
        public CourtCasesPage()
        {
            InitializeComponent();
            grid_CourtCases.ItemsSource = contex.СourtСasesTable.ToList();
        }
    }
}
