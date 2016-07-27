using System;
using Android.Support.V4.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace MyApp.Fragments
{
    public class RequestGit : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.RequestGit, null);

            var txtUser = view.FindViewById<EditText>(Resource.Id.txtUser);
            var btnSearch = view.FindViewById<Button>(Resource.Id.btnSearch);
            var lvwRepositories = view.FindViewById<ListView>(Resource.Id.lvwRepositories);

            btnSearch.Click += async (object sender, EventArgs e) =>
            {
                var github = new Shared.GitHubApi();
                var repositories = await github.GetAsync(txtUser.Text);
                lvwRepositories.Adapter = new ArrayAdapter(view.Context, Android.Resource.Layout.SimpleListItemSingleChoice, repositories);
            };

            return view;
        }

        public static RequestGit NewInstance()
        {
            var RequestGit = new RequestGit { Arguments = new Bundle() };
            return RequestGit;
        }
    }
}