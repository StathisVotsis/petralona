using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace petralona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public SecondPage()
        {
            InitializeComponent();
            //NavigationPage.SetHasBackButton(this, false);
            Items = new ObservableCollection<string>
            {
                "Room 1",
                "Room 2",
                "Room 3",
                "Room 4",
                "Room 5",
                "Room 6",
                "Room 7",
                "Room 8",
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("You are going to enter", e.Item.ToString(), "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
            LastPage(e.Item.ToString());
        }

        private void LastPage(string st5)
        {
            Navigation.PushAsync(new ThirdPage(st5));
        }
    }
}
