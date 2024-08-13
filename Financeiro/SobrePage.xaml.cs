using Microsoft.Maui.Controls;

namespace Financeiro
{
    public partial class SobrePage : ContentPage
    {
        public SobrePage()
        {
            InitializeComponent();
        }

        private void SobreMenuButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MenuPage();
        }
    }
}
