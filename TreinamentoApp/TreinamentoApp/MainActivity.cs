using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Controls;
using Android.Util;

namespace TreinamentoApp
{
    [Activity(Label = "TreinamentoApp", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTeme")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var btnTelaDinamica = FindViewById<Button>(Resource.Id.btnTelaDinamica);
            btnTelaDinamica.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(TelaDinamica)));
            };

            var btnLayoutRelativo = FindViewById<Button>(Resource.Id.btnLayoutRelativo);
            btnLayoutRelativo.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(LayoutRelativoDemo)));
            };

            var btnLayoutLinear = FindViewById<Button>(Resource.Id.btnLayoutLinear);
            btnLayoutLinear.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(LinearLayoutDemo)));
            };

            var btnLayoutTabular = FindViewById<Button>(Resource.Id.btnLayoutTabular);
            btnLayoutTabular.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(LayoutTabularDemo)));
            };


            var btnDemoDesenhador = FindViewById<Button>(Resource.Id.btnDemoDesenhador);
            btnLayoutTabular.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(LayoutTabularDemo)));
            };

            var btnDemoListView = FindViewById<Button>(Resource.Id.btnDemoListView);
            btnLayoutTabular.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(ListViewDemo)));
            };

        }

    }
}

