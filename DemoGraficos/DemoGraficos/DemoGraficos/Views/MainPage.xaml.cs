﻿using System.Collections.Generic;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace DemoGraficos.Views
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void Barras(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GraficoBarras());
        }

        private async void Circular(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GraficoCircular());
        }

        private async void Linha(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GraficoLinha());
        }

        private async void Pontos(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GraficoPontos());
        }

        private async void Gauge(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GraficoGauge());
        }
    }
}
