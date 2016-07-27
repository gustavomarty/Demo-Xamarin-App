﻿using System;
using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;


namespace XamarinDemoApp
{
    [Activity(Label = "StoreFood", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var txtUser = FindViewById<EditText>(Resource.Id.txtUser);
            var btnSearch = FindViewById<Button>(Resource.Id.btnSearch);
            var lvwRepositories = FindViewById<ListView>(Resource.Id.lvwRepositories);
            
            btnSearch.Click += async (object sender, EventArgs e) =>
            {
                var github = new Shared.GitHubApi();
                var repositories = await github.GetAsync(txtUser.Text);
                lvwRepositories.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice, repositories);
            };
        }
    }
}

