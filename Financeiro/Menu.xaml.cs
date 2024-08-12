using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

            private void MenuButton2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }

             private void SobreButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SobrePage();
        }

                private void AjudaButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AjudaPage();
        }
    }
}
