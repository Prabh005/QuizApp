using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using QuizApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp
{
    public class QuestionListAdapter : BaseAdapter<Question>
    {
        private readonly Activity context;
        private readonly List<Question> questions;

        public QuestionListAdapter(Activity context, List<Question> questions)
        {
            this.questions = questions;
            this.context = context;
        }

        public override int Count
        {
            get { return questions.Count; }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Question this[int position]
        {
            get { return questions[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.question_row, null, false);
            }

            TextView txt1 = row.FindViewById<TextView>(Resource.Id.text1);
            TextView txt2 = row.FindViewById<TextView>(Resource.Id.text2);
            TextView txt3 = row.FindViewById<TextView>(Resource.Id.text3);
            TextView txt4 = row.FindViewById<TextView>(Resource.Id.text4);
            TextView txt5 = row.FindViewById<TextView>(Resource.Id.text5);
            TextView txt6 = row.FindViewById<TextView>(Resource.Id.text6);
            TextView txt7 = row.FindViewById<TextView>(Resource.Id.text7);

            Question question = questions[position];


            txt1.Text = "Topic: " + question.TopicName;
            txt2.Text = "Question Text: " + question.QuizQuestion;
            txt3.Text = " Option 1: " + question.OptionA;
            txt4.Text = " Option 2: " + question.OptionB;
            txt5.Text = " Option 3: " + question.OptionC;
            txt6.Text = " Option 4: " + question.OptionD;
            txt7.Text = " Answer: " + question.Answer;
            return row;
        }
    }
}