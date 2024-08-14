using System;
using Controles;
using Financeiro.Modelos;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class CadastrarConta : ContentPage
    {
        PagarControle pagarControle = new PagarControle();
        public CadastrarConta()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var cp = new ContaPagar();
            cp.Nome = NomeEntry.Text;
            cp.Valor = ValorEntry.Text;
            cp.DataValidade = DataValidadeEntry.Text;
            pagarControle.CriarOuAtualizar(cp);

            // Adicione aqui a lógica para salvar os dados

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            // Limpar campos ou realizar outras ações de cancelamento

            Application.Current.MainPage = new ContasAPagarPage();

            await DisplayAlert("Cancelado", "Ação cancelada", "OK");
        }

                private void Voltar1(object sender, EventArgs e)
        {
           Application.Current.MainPage = new ContasAPagarPage();
        }
    }
}