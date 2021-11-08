using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace QuizApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        LinearLayout historyLayout;
        LinearLayout spaceLayout;
        LinearLayout geographyLayout;
        LinearLayout engineeringLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            historyLayout = FindViewById<LinearLayout>(Resource.Id.historyLayout);
            spaceLayout = FindViewById<LinearLayout>(Resource.Id.spaceLayout);
            geographyLayout = FindViewById<LinearLayout>(Resource.Id.geograpyLayout);
            engineeringLayout = FindViewById<LinearLayout>(Resource.Id.engineeringLayout);
            programmingLayout = FindViewById<LinearLayout>(Resource.Id.programmingLayout);
            businessLayout = FindViewById<LinearLayout>(Resource.Id.businessLayout);

            historyLayout.Click += HistoryLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            engineeringLayout.Click += EngineeringLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Programming");
            StartActivity(intent);
        }

        private void EngineeringLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Engineering");
            StartActivity(intent);
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescripTionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent);
        }
    }
}