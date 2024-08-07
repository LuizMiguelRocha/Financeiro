using System;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class SelecionarPage : ContentPage
    {
        public SelecionarPage()
        {
            InitializeComponent();
        }

        private void DevedoresButton(object sender, EventArgs e)
        {
            Application.Current.MainPage= new DevedoresPage();
        }

         private void ContaPagarButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ContasAPagarPage();
        }

          private void MenuButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}
