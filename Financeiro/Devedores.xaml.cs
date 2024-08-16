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

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Lógica para deletar devedor
        }

         void Dev(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new DevedoresPage();
        Application.Current.MainPage = page;
    }
    }
}
