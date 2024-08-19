using System;
using Controles;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class DevedoresPage : ContentPage
    {
         Controles.DevControles devControles = new Controles.DevControles();
        public DevedoresPage()
        {
            InitializeComponent();

            ListaDevedores.ItemsSource = devControles.LerTodos();
        }

        private void VoltarButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }

        private void ButtonMais(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CadastrarDevedor();
        }


         void Dev(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new CadastrarDevedor();
        page.devedor = e.SelectedItem as Devedores;
        Application.Current.MainPage = page;
    }
    }
}
