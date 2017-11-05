using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Atividade_1.App_Code;

namespace XF.Atividade_1
{
    public partial class MainPage : ContentPage
    {
        Email emailmodel;

        public MainPage()
        {
            InitializeComponent();

            if (emailmodel == null)
                emailmodel = new Email();
        }

        async void OnClickConfig(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage() { BindingContext = emailmodel });
        }

        async void OnSend(object sender, EventArgs e)
        {
            if ((emailmodel.Ativo) && (!string.IsNullOrEmpty(emailmodel.ContaEmail)))
                await DisplayAlert("Mensagem",
                    $"E-mail enviado para {emailmodel.ContaEmail}", "Ok");
            else
                await DisplayAlert("Mensagem", "Envio não autorizado", "Ok");
        }
    }
}
