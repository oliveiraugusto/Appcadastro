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

        private void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(entryLogin.Text) || string.IsNullOrEmpty(entrySenha.Text))
            {
                DisplayAlert("Ops...", "Não deixe os Campos em branco", "OK");
            }
            else
            {
                if(entryLogin.Text == "admin" && entrySenha.Text == "admin")
                {
                    
                }
                else
                {
                    DisplayAlert("Ops..", "Login e/ou senha invalidos", "OK");
                }
            }

        }
    }
}
