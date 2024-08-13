using System;
using Financeiro.Modelos;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class CadastrarConta : ContentPage
    {
        public Cliente cliente {get ; set;}
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();

        public CadastrarConta()
        {
            InitializeComponent();
            
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string valor = ValorEntry.Text;
            string dataValidade = DataValidadeEntry.Text;

            // Adicione aqui a lógica para salvar os dados

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            // Limpar campos ou realizar outras ações de cancelamento

            Application.Current.MainPage = new ContasAPagarPage();

            await DisplayAlert("Cancelado", "Ação cancelada", "OK");
        }
    }
}