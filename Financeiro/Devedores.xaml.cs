using System;
using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class DevedoresPage : ContentPage
    {
        public DevedoresPage()
        {
            InitializeComponent();
        }

        private void VoltarButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SelecionarPage();
        }

        private void ButtonMais(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CadastrarDevedor();
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            // Lógica para editar devedor
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Lógica para deletar devedor
        }
    }
}
