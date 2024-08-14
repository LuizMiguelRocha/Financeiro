using System;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class ContasAPagarPage : ContentPage
    {
        public ContasAPagarPage()
        {
            InitializeComponent();
        }

        private void Botaovoltar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastrarConta();
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Lógica para deletar conta a pagar
        }
        
        void Conta(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new ContasAPagarPage();
        Application.Current.MainPage = page;
    }
    }
}
