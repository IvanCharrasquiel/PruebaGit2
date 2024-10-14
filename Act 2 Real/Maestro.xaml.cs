using System;
using System.Collections.Generic;
using System.Linq;
using Act_2_Real.Pages;
using Microsoft.Maui.Controls;

namespace Act_2_Real
{
    public partial class Maestro : ContentPage
    {
        public Maestro()
        {
            InitializeComponent();
        }

        public static void OcultarDetalles()
        {
            App.FlyoutPage.IsPresented = false;
        }


        public static void NavigationToPage(ContentPage nuevaPagina)
        {
            App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
        }

        private void GoToPaisesPage(object sender, EventArgs e)
        {

            NavigationToPage(new Paises());

            OcultarDetalles();
        }

    }
}
