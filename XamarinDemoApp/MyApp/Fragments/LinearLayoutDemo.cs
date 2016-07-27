using Android.Support.V4.App;
using Android.OS;
using Android.Views;

namespace MyApp.Fragments
{
    public class LinearLayoutDemo : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static LinearLayoutDemo NewInstance()
        {
            var LinearLayoutDemo = new LinearLayoutDemo { Arguments = new Bundle() };
            return LinearLayoutDemo;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var view = inflater.Inflate(Resource.Layout.LinearLayoutDemo, null);
            return view;
        }
    }
}