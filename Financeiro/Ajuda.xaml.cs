using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class AjudaPage : ContentPage
    {
        public AjudaPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}
