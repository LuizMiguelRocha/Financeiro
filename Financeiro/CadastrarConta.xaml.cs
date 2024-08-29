using System;
using Controles;
using Financeiro.Modelos;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class CadastrarConta : ContentPage
    {
        public ContaPagar contapagar { get; set; }
        PagarControle pagarControle = new PagarControle();
        public CadastrarConta()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var cp = new ContaPagar();
            cp.Id = 0;
            cp.Nome = NomeEntry.Text;
            cp.Valor = ValorEntry.Text;
            cp.DataValidade = DataValidadeEntry.Text;
            pagarControle.CriarOuAtualizar(cp);

            Application.Current.MainPage = new ContasAPagarPage();

            // Adicione aqui a lógica para salvar os dados

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ContasAPagarPage();

            await DisplayAlert("Cancelado", "Ação cancelada", "OK");
        }

        private void Voltar1(object sender, EventArgs e)
        {
           Application.Current.MainPage = new ContasAPagarPage();
        }

        private async void LixeiraButton(object sender, EventArgs e)
        {
            IdLabel.Text = contapagar.Id.ToString();
            NomeEntry.Text = string.Empty;
            ValorEntry.Text = string.Empty;

            if (contapagar == null)
                await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse cliente?", "Excluir Cliente", "cancelar"))
            {
                pagarControle.Apagar(contapagar.Id);
                Application.Current.MainPage = new ContasAPagarPage();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (contapagar != null)
            {
                 IdLabel.Text = contapagar.Id
                 .ToString();
                NomeEntry.Text = contapagar.Nome;
                ValorEntry.Text = contapagar.Valor;
                DataValidadeEntry.Text = contapagar.DataValidade;
            }
        }
    }
}