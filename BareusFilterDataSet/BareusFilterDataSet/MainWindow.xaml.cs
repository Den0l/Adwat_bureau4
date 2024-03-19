using BareusFilterDataSet.Adwat_bureauDataSetTableAdapters;
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

namespace BareusFilterDataSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsPage clientsPage = new ClientsPage();
        ClientsTableAdapter clients = new ClientsTableAdapter();
        LawyerPage lawyerPage = new LawyerPage();
        LawyerTableAdapter lawyer = new LawyerTableAdapter();
        CourtCasesPage courtPage = new CourtCasesPage();
        СourtСasesTableTableAdapter courtcases = new СourtСasesTableTableAdapter();
        DiplomaUniversityPage diplomaPage = new DiplomaUniversityPage();
        DiplomaUniversityTableTableAdapter diploma = new DiplomaUniversityTableTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Searchbutton_Click(object sender, RoutedEventArgs e)
        {
            if(PageFrame.Content is ClientsPage clientsPage)
            {
                clientsPage.grid_Clients.ItemsSource = clients.SearchNameClientsBy(SearchBox.Text);
            }
            else if(PageFrame.Content is LawyerPage lawyerPage)
            {
                lawyerPage.grid_Lawyer.ItemsSource = lawyer.SearchSurNameLawyerBy(SearchBox.Text);
            }
            else if (PageFrame.Content is CourtCasesPage courtPage)
            {
                courtPage.grid_CourtCases.ItemsSource = courtcases.SearchCourtCasesBy(SearchBox.Text);
            }
            else if (PageFrame.Content is DiplomaUniversityPage diplomaPage)
            {
                diplomaPage.grid_DiplomaUniversity.ItemsSource = diploma.SearchDiplomaBy(SearchBox.Text);
            }
            SearchBox.Text = null;
        }

        private void Clearbutton_Click(object sender, RoutedEventArgs e)
        {

            if (PageFrame.Content is ClientsPage clientsPage)
            {
                clientsPage.grid_Clients.ItemsSource = clients.GetData();
            }
            else if (PageFrame.Content is LawyerPage lawyerPage)
            {
                lawyerPage.grid_Lawyer.ItemsSource = lawyer.GetData();
            }
            else if (PageFrame.Content is CourtCasesPage courtPage)
            {
                courtPage.grid_CourtCases.ItemsSource = courtcases.GetData();
            }
            else if (PageFrame.Content is DiplomaUniversityPage diplomaPage)
            {
                diplomaPage.grid_DiplomaUniversity.ItemsSource = diploma.GetData();
            }

        }

        private void PageLawyer_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new LawyerPage();
            DataTable courtCasesTable = diploma.GetData();
            FilterBox.DisplayMemberPath = "DiplomaUniversity";
            FilterBox.ItemsSource = courtCasesTable.DefaultView;
            FilterBox.SelectedItem = null;
        }
        private void PageClients_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ClientsPage();
            DataTable courtCasesTable = courtcases.GetData();
            FilterBox.DisplayMemberPath = "СourtСases";
            FilterBox.ItemsSource = courtCasesTable.DefaultView;
            FilterBox.SelectedItem = null;
        }

        private void PageСourtСases_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new CourtCasesPage();
            DataTable courtCasesTable = courtcases.GetData();
            FilterBox.DisplayMemberPath = "СourtСases";
            FilterBox.ItemsSource = courtCasesTable.DefaultView;
            FilterBox.SelectedItem = null;
        }

        private void PageDiplomaUniversity_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DiplomaUniversityPage();
            DataTable courtCasesTable = diploma.GetData();
            FilterBox.DisplayMemberPath = "DiplomaUniversity";
            FilterBox.ItemsSource = courtCasesTable.DefaultView;
            FilterBox.SelectedItem = null;
        }

        private void FilterBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PageFrame.Content is ClientsPage clientsPage)
            {
                if(FilterBox.SelectedItem != null)
                {
                    var id = (int)(FilterBox.SelectedItem as DataRowView).Row[0];
                    clientsPage.grid_Clients.ItemsSource = clients.FilClientBy(id);
                }

            }
            else if (PageFrame.Content is LawyerPage lawyerPage)
            {
                if (FilterBox.SelectedItem != null)
                { 
                    var id = (int)(FilterBox.SelectedItem as DataRowView).Row[0];
                    lawyerPage.grid_Lawyer.ItemsSource = lawyer.FilLawyerBy(id);
                }
            }
            else if (PageFrame.Content is CourtCasesPage courtPage)
            {
                if (FilterBox.SelectedItem != null)
                {
                   var id = (int)(FilterBox.SelectedItem as DataRowView).Row[0];
                   courtPage.grid_CourtCases.ItemsSource = courtcases.FilCourtBy(id);
                    
                }
            }
            else if (PageFrame.Content is DiplomaUniversityPage diplomaPage)
            {
                if (FilterBox.SelectedItem != null)
                {
                    var id = (int)(FilterBox.SelectedItem as DataRowView).Row[0];
                    diplomaPage.grid_DiplomaUniversity.ItemsSource = diploma.FilDiplomaBy(id);
                }
            }
            
        }
    }
}
