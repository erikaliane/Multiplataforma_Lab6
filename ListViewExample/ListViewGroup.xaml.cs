using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        private ObservableCollection<GroupedContactModel> grouped { get; set; }

        public ListViewGroup()
        {
            InitializeComponent();

            grouped = new ObservableCollection<GroupedContactModel>();
            var lettersA = new GroupedContactModel() { Letter = "A" };
            var lettersB = new GroupedContactModel() { Letter = "B" };
            var lettersC = new GroupedContactModel() { Letter= "C" };
            var lettersD = new GroupedContactModel() { Letter= "D" };

            lettersA.Add(new GroupedModel() { Name = "Alvaro",Number = "989551423" });
            lettersA.Add(new GroupedModel() { Name = "Adrian", Number = "989554126" });
            lettersA.Add(new   GroupedModel() { Name = "Amanda",Number = "989554126" });
            lettersA.Add(new   GroupedModel() { Name = "Aracely",Number = "989555126" });


            lettersB.Add(new   GroupedModel() { Name = "Brenda",Number = "989589632" });
            lettersB.Add(new   GroupedModel() { Name = "Barbara",Number = "989551423" });
            lettersB.Add(new   GroupedModel() { Name = "Blanca", Number= "989551423" });

            lettersC.Add(new GroupedModel() { Name = "Camilo",Number = "989589632" });
            lettersC.Add(new GroupedModel() { Name = "Carla",Number = "989551423" });
            lettersC.Add(new GroupedModel() { Name = "Claudia",Number = "989551423" });
            lettersC.Add(new GroupedModel() { Name = "Clara", Number = "941256325" });

            lettersD.Add(new GroupedModel() { Name = "Daniela", Number = "974159632" });
            lettersD.Add(new GroupedModel() { Name = "David", Number = "980456987" });
            lettersD.Add(new GroupedModel() { Name = "Danna", Number = "994852636" });

            grouped.Add(lettersA); grouped.Add(lettersB); grouped.Add(lettersC); grouped.Add(lettersD);

            lstView.ItemsSource = grouped;
            
        }
    }
}