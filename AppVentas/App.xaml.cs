﻿using AppVentas.Backend.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVentas
{
    public partial class App : Application
    {
        public static string cedula = string.Empty;//Se actualiza cuando se hace login
        public static string url = "https://a945482ed86d.ngrok.io/api/";//se debe cambiar
        public static IList<ArticuloModel> Carrito = new ObservableCollection<ArticuloModel>();//Variable estatica de carrito
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
