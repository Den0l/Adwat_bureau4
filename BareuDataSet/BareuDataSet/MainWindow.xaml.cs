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
using BareuDataSet.Adwat_bureauDataSetTableAdapters;


namespace BareuDataSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LawyerTableAdapter lawyerTable = new LawyerTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            DataTable.ItemsSource = lawyerTable.GetDataBy();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DataTable.Columns[0].Visibility = Visibility.Collapsed;
            DataTable.Columns[4].Visibility = Visibility.Collapsed;
            DataTable.Columns[5].Visibility = Visibility.Collapsed;
            DataTable.Columns[6].Visibility = Visibility.Collapsed;
            DataTable.Columns[7].Visibility = Visibility.Collapsed;


        }
    }
}
