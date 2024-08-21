using System;
using Financeiro.Modelos;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class ContasAPagarPage : ContentPage
    {

        Controles.PagarControle pagarControles = new Controles.PagarControle();
        public ContasAPagarPage()
        {
            InitializeComponent();

            ListaContaPagar.ItemsSource = pagarControles.LerTodos();
        }

        private void Botaovoltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrarConta();
        }

    
        void Conta(object sender, SelectedItemChangedEventArgs e)
    {
        var pape = new CadastrarConta();
        pape.contapagar = e.SelectedItem as ContaPagar;
        Application.Current.MainPage = pape;
    }
    }
}
