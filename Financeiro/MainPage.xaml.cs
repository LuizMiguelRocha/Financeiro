using System;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ComeçarButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }
    }
}
