using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TreinamentoApp
{
    [Activity(Label = "TelaDinamica")]
    public class TelaDinamica : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            string nome;

            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;

            var label = new TextView(this);
            label.Text = "Olá Xamarin.Android";

            var txtNome = new EditText(this);

            var button = new Button(this);
            button.Text = "Diga Olá";
            button.Click += (sender, e) =>
            {
                label.Text = "Olá Mundo";
            };

            var button2 = new Button(this);
            button2.Text = "Abrir tela com parametro do text";
            button2.Click += (sender, e) =>
            {
                nome = txtNome.Text;

                var intent = new Intent(this, typeof(Activity2));
                intent.PutExtra("nome", nome);
                StartActivity(intent);
            };

            var button3 = new Button(this);
            button3.Text = "Abrir Discador";

            button3.Click += (sender, e) =>
            {
                var uri = Android.Net.Uri.Parse("tel:554188385693");
                var intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);
            };

            layout.AddView(label);
            layout.AddView(txtNome);
            layout.AddView(button);
            layout.AddView(button2);
            layout.AddView(button3);

            SetContentView(layout);
        }
    }
}