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

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar novo devedor
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
