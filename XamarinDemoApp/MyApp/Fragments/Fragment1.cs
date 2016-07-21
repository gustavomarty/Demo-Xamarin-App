using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Shared;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Fragments
{
    public class Fragment1 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static Fragment1 NewInstance()
        {
            var frag1 = new Fragment1 { Arguments = new Bundle() };

            return frag1;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.fragment1, null);

            var lstaVagas = view.FindViewById<ListView>(Resource.Id.lstVagas);
            var vagas = Vaga.GetAll();
            lstaVagas.Adapter = new ArrayAdapter(view.Context, Android.Resource.Layout.SimpleListItemSingleChoice, vagas.Select( i => string.Format("{0} em {1}/{2}" ,i.Funcao, i.Cidade,i.Estado)).ToList() );


            return view;
        }

    }
}