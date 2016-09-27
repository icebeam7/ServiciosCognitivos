using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ServiciosCognitivos.Paginas
{
	public partial class PaginaNavegacion : ContentPage
	{
		public PaginaNavegacion ()
		{
			InitializeComponent ();
		}

        void btnEmociones_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaAnalisisEmociones());
        }

        void btnVision_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaAnalisisComputerVision());
        }

    }
}
