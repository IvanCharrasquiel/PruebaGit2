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

        public static void NavigationToPage(ContentPage nuevaPagina)
        {
            App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
        }

        public static void OcultarDetalles()
        {
            App.FlyoutPage.IsPresented = false;
        }

        private void Programacion_Clicked(object sender, EventArgs e)
        {
            NavigationToPage(new ProgramacionPage());
            OcultarDetalles();
        }

        private void Futbol_Clicked(object sender, EventArgs e)
        {
            NavigationToPage(new Futbol());
            
        private void GoToCafePage(object sender, EventArgs e)
        {

            NavigationToPage(new Cafe());

            OcultarDetalles();
        }



    }
}
