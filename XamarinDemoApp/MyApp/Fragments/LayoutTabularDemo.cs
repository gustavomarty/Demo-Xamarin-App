using Android.Support.V4.App;
using Android.OS;
using Android.Views;

namespace MyApp.Fragments
{
    public class LayoutTabularDemo : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static LayoutTabularDemo NewInstance()
        {
            var LayouTabularDemo = new LayoutTabularDemo { Arguments = new Bundle() };
            return LayouTabularDemo;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.LayoutTabularDemo, container, false);
            return view;
        }
    }
}