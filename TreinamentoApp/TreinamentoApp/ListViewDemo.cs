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
    [Activity(Label = "ListViewDemo")]
    public class ListViewDemo : ListActivity
    {
        string[] items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            items = new string[] { "teste 1", "teste 2", "teste 3", "teste 4", "teste 5", "teste 6" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
            // Create your application here
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = items[position];
            Android.Widget.Toast.MakeText(this, t, Android.Widget.ToastLength.Short).Show();
            //base.OnListItemClick(l, v, position, id);
        }
    }
}