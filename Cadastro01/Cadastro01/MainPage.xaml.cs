using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cadastro01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void swt(object sender, ToggledEventArgs e)
        {
            {
                if (SwitchCelular.On)
                {
                    TxtCelular.IsEnabled = true;
                }
                else
                {
                    TxtCelular.Text = null;
                    TxtCelular.IsEnabled = false;
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            {
                //lbNome.Text += "\n" + TxtNome.Text;
                if (TxtNome.Text != null)
                {
                    lbNome.Text += "\n" + "Nome: " + TxtNome.Text;
                }
                else
                {
                    DisplayAlert("Atenção", "Preencha o campo Nome", "Ok");
                }

                if (TxtEmail.Text != null)
                {
                    lbNome.Text += "\n" + "E-mail: " + TxtEmail.Text;
                }
                else
                {
                    DisplayAlert("Atenção", "Preencha o campo E-mail", "Ok");
                }
                if (SwitchCelular.On)
                {
                    if (TxtCelular.Text == null)
                    {
                        DisplayAlert("Atenção", "Preencha o nº de telefone para contato", "Ok");
                    }
                    else
                    {
                        lbNome.Text += "\n" + "Celular: " + TxtCelular.Text;
                    }


                }

                if (pck1.SelectedItem == null)
                {
                    DisplayAlert("Atenção", "Escolha uma profissão", "Ok");
                }
                else
                {
                    lbNome.Text += "\n" + "Profissão: " + pck1.SelectedItem;
                }

            }
        }
    }
}