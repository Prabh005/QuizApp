using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using QuizApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp
{
    [Activity(Label = "View All Questions")]
    public class ViewAllQuestionActivity : AppCompatActivity
    {
        Button b1;
        ListView list1;
        DataLayer layer;
        QuestionListAdapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.view_all_question_page);

            b1 = FindViewById<Button>(Resource.Id.b1);
            list1 = FindViewById<ListView>(Resource.Id.list1);

            layer = new DataLayer();

            b1.Click += B1_Click; ;

            adapter = new QuestionListAdapter(this, layer.GetAllQuestions());
            list1.Adapter = adapter;

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}