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
    public class QuestionSpinnerAdapter : BaseAdapter<Question>
    {
        private readonly Activity context;
        private readonly List<Question> questions;

        public QuestionSpinnerAdapter(Activity context, List<Question> questions)
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
                row = LayoutInflater.From(context).Inflate(Resource.Layout.topic_row, null, false);
            }

            TextView txt1 = row.FindViewById<TextView>(Resource.Id.text1);

            Question question = questions[position];


            txt1.Text = question.QuizQuestion;
            return row;
        }
    }
}