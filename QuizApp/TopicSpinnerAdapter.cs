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
    public class TopicSpinnerAdapter : BaseAdapter<Topic>
    {
        private readonly Activity context;
        private readonly List<Topic> topics;

        public TopicSpinnerAdapter(Activity context, List<Topic> topics)
        {
            this.topics = topics;
            this.context = context;
        }

        public override int Count
        {
            get { return topics.Count; }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Topic this[int position]
        {
            get { return topics[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.topic_row, null, false);
            }

            TextView txt1 = row.FindViewById<TextView>(Resource.Id.text1);
            txt1.Text = topics[position].TopicName;
            return row;
        }
    }
}