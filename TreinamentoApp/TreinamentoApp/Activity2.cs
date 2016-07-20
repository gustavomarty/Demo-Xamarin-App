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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            string nome = Intent.GetStringExtra("nome");

            var layout = new TableLayout(this);
            layout.Orientation = Orientation.Horizontal;

            var label = new TextView(this);
            label.Text = "Meu nome é: " + nome;

            layout.AddView(label);

            SetContentView(layout);


            // Create your application here
        }
    }
}