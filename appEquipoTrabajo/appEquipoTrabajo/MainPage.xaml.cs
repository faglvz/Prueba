using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appEquipoTrabajo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        [Obsolete]
        private async void UnirmeBtn_Clicked(object sender, EventArgs e)
        {
            //se define un arreglo para las opciones que se mostrarán en el mensaje de tipo
            //DisplayActionSheet
            var list = new string[] { "Classroom", "Telegram", "Whatsapp", "Facebook" };

            //Await muestra el DisplayActionSheet con las opciones que estan en el array
            var resp = await DisplayActionSheet("Únete a nosotros en:", "", null, list);

            //Depende la opción elegida, se ejecutará el Case indicado
            switch (resp)
            {
                case "Classroom":
                    Device.OpenUri(new Uri("https://classroom.google.com/c/NDUwMTA0OTEyNjc4?cjc=lcfffoo"));
                    break;
                case "Telegram":
                    Device.OpenUri(new Uri("https://t.me/+DqYx490GKkVkMWUx"));
                    break;
                case "Whatsapp":
                    Device.OpenUri(new Uri("https://chat.whatsapp.com/J8U6l9lmANT4UXCRgtZYuH"));
                    break;
                case "Facebook":
                    Device.OpenUri(new Uri("https://www.facebook.com"));
                    break;
                default:
                    break;
            }
        }


    }
}
