using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_16
{
    public partial class MainPage : ContentPage
    {
        ApplicationvVewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ApplicationvVewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            await viewModel.GetFriends();
            base.OnAppearing();
        }
    }
}
