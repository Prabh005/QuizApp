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
    [Activity(Label = "Add New Question")]
    public class AddQuestionActivity : AppCompatActivity
    {
        Button b1, b2;
        EditText et1, et2, et3, et4, et5, et6;
        Spinner spinner1;
        DataLayer layer;
        TopicSpinnerAdapter adapter;
        List<Topic> topics;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.add_question_page);
            layer = new DataLayer();

            et1 = FindViewById<EditText>(Resource.Id.text1);
            et2 = FindViewById<EditText>(Resource.Id.text2);
            et3 = FindViewById<EditText>(Resource.Id.text3);
            et4 = FindViewById<EditText>(Resource.Id.text4);
            et5 = FindViewById<EditText>(Resource.Id.text5);
            et6 = FindViewById<EditText>(Resource.Id.text6);
            spinner1 = FindViewById<Spinner>(Resource.Id.spinner1);
            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);

            topics = layer.GetAllTopics();
            adapter = new TopicSpinnerAdapter(this, topics);
            spinner1.Adapter = adapter;
            b1.Click += B1_Click;
            b2.Click += B2_Click;
        }
        private void B2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            string question = et1.Text;
            string optiona = et2.Text;
            string optionb = et3.Text;
            string optionc = et4.Text;
            string optiond = et5.Text;
            string answer = et6.Text;
            if (question.Length == 0 || optiona.Length == 0 || optionb.Length == 0 || optionc.Length == 0 || optiond.Length == 0 || answer.Length == 0 )
            {
                Toast.MakeText(this, "Please Fill Full Form", ToastLength.Long).Show();
            }
            else
            {
                Topic topic = topics[spinner1.SelectedItemPosition];
                Question questionObj = new Question();
                questionObj.QuizQuestion = question;
                questionObj.OptionA = optiona;
                questionObj.OptionB = optionb;
                questionObj.OptionC = optionc;
                questionObj.OptionD = optiond;
                questionObj.Answer = answer;
                questionObj.TopicName = topic.TopicName;
                if (layer.AddQuestion(questionObj))
                {
                    Toast.MakeText(this, "Question Details are Saved", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Question Details are not Saved", ToastLength.Long).Show();
                }
            }
        }
    }
}