using Android.Support.V4.App;
using Android.OS;
using Android.Views;

namespace MyApp.Fragments
{
    public class LayoutRelativoDemo : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static LayoutRelativoDemo NewInstance()
        {
            var LayoutRelativoDemo = new LayoutRelativoDemo { Arguments = new Bundle() };
            return LayoutRelativoDemo;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.LayoutRelativoDemo, container, false);
            return view;
        }
    }
}