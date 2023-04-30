using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {

        ObservableCollection<Employe> employees = new ObservableCollection<Employe>();

        public ObservableCollection<Employe>  Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            EmployeView.ItemsSource = employees;
            employees.Add(new Employe { DisplayName = "Rob Finnerty " });
            employees.Add(new Employe { DisplayName = "Bill Wrestler" });
            employees.Add(new Employe { DisplayName = "Dr. Geri Betch Hooper " });
            employees.Add(new Employe { DisplayName = "Dr. Keitch Joyce-Purdy " });
            employees.Add(new Employe { DisplayName = "Sheri Spruce " });
            employees.Add(new Employe { DisplayName = "Burt Indybrick" });


        }
    }
}