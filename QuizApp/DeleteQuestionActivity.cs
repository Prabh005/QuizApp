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
    [Activity(Label = "Delete Question")]
    public class DeleteQuestionActivity : AppCompatActivity
    {
        Button b1, b2;
        Spinner spinner;
        DataLayer layer;
        QuestionSpinnerAdapter adapter;
        List<Question> questions;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.delete_question_page);

            layer = new DataLayer();

            spinner = FindViewById<Spinner>(Resource.Id.spinner);
            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);

            questions = layer.GetAllQuestions();
            adapter = new QuestionSpinnerAdapter(this, questions);
            spinner.Adapter = adapter;

            b1.Click += B1_Click;
            b2.Click += B2_Click;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (questions != null && questions.Count() > 0)
            {
                Question question = questions[spinner.SelectedItemPosition];
                if (layer.DeleteQuestion(question))
                {
                    message = "Question Details is Removed";
                    questions.RemoveAt(spinner.SelectedItemPosition);
                    adapter.NotifyDataSetChanged();
                }
                else
                {
                    message = "Question Details is not Removed";
                }

            }
            else
            {
                message = "There is Question Details is not Available For Delete.";
            }
            Toast.MakeText(this, message, ToastLength.Long).Show();
        }
    }
}