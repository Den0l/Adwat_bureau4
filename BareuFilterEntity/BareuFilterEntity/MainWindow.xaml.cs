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

namespace BareuFilterEntity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsPage clientsPage = new ClientsPage();
        LawyerPage lawyerPage = new LawyerPage();
        CourtCasesPage courtPage = new CourtCasesPage();
        DiplomaUniversityPage diplomaPage = new DiplomaUniversityPage();
        private Adwat_bureauEntities contex = new Adwat_bureauEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, RoutedEventArgs e)
        {
            if (PageFrame.Content is ClientsPage clientsPage)
            {
                clientsPage.grid_Clients.ItemsSource = contex.Clients.ToList().Where(item => item.ClientName.Contains(SearchBox.Text));
            }
            else if (PageFrame.Content is LawyerPage lawyerPage)
            {
                lawyerPage.grid_Lawyer.ItemsSource = contex.Lawyer.ToList().Where(item => item.LawyerSurname.Contains(SearchBox.Text));
            }
            else if (PageFrame.Content is CourtCasesPage courtPage)
            {
                courtPage.grid_CourtCases.ItemsSource = contex.СourtСasesTable.ToList().Where(item => item.СourtСases.Contains(SearchBox.Text));
            }
            else if (PageFrame.Content is DiplomaUniversityPage diplomaPage)
            {
                diplomaPage.grid_DiplomaUniversity.ItemsSource = contex.DiplomaUniversityTable.ToList().Where(item => item.DiplomaUniversity.Contains(SearchBox.Text));
            }
            SearchBox.Text = null;
        }

        private void Clearbutton_Click(object sender, RoutedEventArgs e)
        {
            if (PageFrame.Content is ClientsPage clientsPage)
            {
                clientsPage.grid_Clients.ItemsSource = contex.Clients.ToList();
            }
            else if (PageFrame.Content is LawyerPage lawyerPage)
            {
                lawyerPage.grid_Lawyer.ItemsSource = contex.Lawyer.ToList();
            }
            else if (PageFrame.Content is CourtCasesPage courtPage)
            {
                courtPage.grid_CourtCases.ItemsSource = contex.СourtСasesTable.ToList();
            }
            else if (PageFrame.Content is DiplomaUniversityPage diplomaPage)
            {
                diplomaPage.grid_DiplomaUniversity.ItemsSource = contex.DiplomaUniversityTable.ToList();
            }

        }

        private void PageClients_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ClientsPage();
            FilterBox.ItemsSource = contex.СourtСasesTable.ToList();
            FilterBox.DisplayMemberPath = "СourtСases";
            FilterBox.SelectedItem = null;
        }

        private void PageСourtСases_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new CourtCasesPage();
            FilterBox.ItemsSource = contex.СourtСasesTable.ToList();
            FilterBox.DisplayMemberPath = "СourtСases";
            FilterBox.SelectedItem = null;
        }

        private void PageLawyer_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new LawyerPage();
            FilterBox.ItemsSource = contex.DiplomaUniversityTable.ToList();
            FilterBox.DisplayMemberPath = "DiplomaUniversity";
            FilterBox.SelectedItem = null;
        }

        private void PageDiplomaUniversity_Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new DiplomaUniversityPage();
            FilterBox.ItemsSource = contex.DiplomaUniversityTable.ToList();
            FilterBox.DisplayMemberPath = "DiplomaUniversity";
            FilterBox.SelectedItem = null;
        }

        private void FilterBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PageFrame.Content is ClientsPage clientsPage)
            {
                if (FilterBox.SelectedItem != null)
                {
                    var id = FilterBox.SelectedItem as СourtСasesTable;
                    clientsPage.grid_Clients.ItemsSource = contex.Clients.ToList().Where(item => item.СourtСasesTable == id);
                }

            }
            else if (PageFrame.Content is LawyerPage lawyerPage)
            {
                if (FilterBox.SelectedItem != null)
                {
                    var id = FilterBox.SelectedItem as DiplomaUniversityTable;
                    lawyerPage.grid_Lawyer.ItemsSource = contex.Lawyer.ToList().Where(item => item.DiplomaUniversityTable == id);
                }
            }
            else if (PageFrame.Content is CourtCasesPage courtPage)
            {
                if (FilterBox.SelectedItem != null)
                {
                    var id = FilterBox.SelectedItem as СourtСasesTable;
                    courtPage.grid_CourtCases.ItemsSource = contex.СourtСasesTable.ToList().Where(item => item.СourtСases == id.СourtСases);

                }
            }
            else if (PageFrame.Content is DiplomaUniversityPage diplomaPage)
            {
                if (FilterBox.SelectedItem != null)
                {
                    var id = FilterBox.SelectedItem as DiplomaUniversityTable;
                    diplomaPage.grid_DiplomaUniversity.ItemsSource = contex.DiplomaUniversityTable.ToList().Where(item => item.DiplomaUniversity == id.DiplomaUniversity);
                }
            }
        }
    }
}
