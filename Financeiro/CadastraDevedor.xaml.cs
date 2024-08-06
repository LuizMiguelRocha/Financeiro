using System;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class CadastrarDevedor : ContentPage
    {
        public CadastrarDevedor()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string valor = ValorEntry.Text;
            string pedido = PedidoEntry.Text;

            // Adicione aqui a lógica para salvar os dados

            await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            // Limpar campos ou realizar outras ações de cancelamento
            NomeEntry.Text = string.Empty;
            ValorEntry.Text = string.Empty;
            PedidoEntry.Text = string.Empty;

            await DisplayAlert("Cancelado", "Ação cancelada", "OK");
        }
               private void VoltarButton2(object sender, EventArgs e)
        {
           Application.Current.MainPage = new DevedoresPage();
        }
    }
}
