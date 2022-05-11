using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Clicked(object sender, EventArgs e)
        {
            String Usuario = User.Text;
            String Contraseña = Password.Text;

            if (Usuario == "fserrano" && Contraseña == "61734")
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                DisplayAlert("Error", "Wrong username and/or password", "Retry");
            }
        }
    }
}