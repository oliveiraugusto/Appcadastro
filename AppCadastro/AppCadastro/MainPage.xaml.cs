using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadastro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(entryLogin.Text) || string.IsNullOrEmpty(entrySenha.Text))
            {
                await DisplayAlert("Ops...", "Não deixe os Campos em branco", "OK");
            }
            else
            {
                if(entryLogin.Text == "admin" && entrySenha.Text == "admin")
                {
                    //await DisplayAlert("SUCESSO", "SUCESSO", "OK");

                    var page = new Menu();
                    await Navigation.PushModalAsync(page);

                }
                else
                {
                    await DisplayAlert("Ops..", "Login e/ou senha invalidos", "OK");
                }
            }

        }
    }
}
