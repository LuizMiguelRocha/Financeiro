using System;
using Controles;
using Financeiro.Modelos;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class CadastrarDevedor : ContentPage
    {
        public Devedores devedores { get; set; }
        DevControles devControle = new DevControles();
        public CadastrarDevedor()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var dv = new Devedores();
            dv.Nome = NomeEntry.Text;
            dv.Valor = ValorEntry.Text;
            devControle.CriarOuAtualizar(dv);


            // Adicione aqui a lógica para salvar os dados

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            // Limpar campos ou realizar outras ações de cancelamento

            Application.Current.MainPage = new DevedoresPage();

            await DisplayAlert("Cancelado", "Ação cancelada", "OK");
        }
        private void VoltarButton2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new DevedoresPage();
        }

        private async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            ValorEntry.Text = string.Empty;

            if (devedores == null)
                await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir", "Tem certeza que deseja excluir esse cliente?", "Excluir Cliente", "cancelar"))
            {
                devControle.Apagar(devedores.Id);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (devedores != null)
            {
                 IdLabel.Text        = devedores.Id
                 
                 
                 
                 
                 
                 
                 
                 .ToString();
                NomeEntry.Text = devedores.Nome;
                ValorEntry.Text = devedores.Valor;
            }
        }

    }
}
