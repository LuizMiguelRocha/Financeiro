using System;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class ContasAPagarPage : ContentPage
    {

          Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public ContasAPagarPage()
        {
            InitializeComponent();

              ContaPagar.ItemsSource = clienteControle.LerTodos();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new SelecionarPage();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrarConta();
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            // Lógica para editar conta a pagar
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Lógica para deletar conta a pagar
        }
        
    }
}
