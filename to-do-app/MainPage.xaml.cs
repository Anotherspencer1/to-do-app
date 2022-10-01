using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace to_do_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Task_Creation(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("New Task:", "", "Create");
        }
    }
}
