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
    [Activity(Label = "Quiz Description", Theme = "@style/AppTheme")]
    public class QuizDescripTionActivity : AppCompatActivity
    {
        TextView quizTopicTextView;
        TextView descriptionTextView;
        ImageView quizImageView;
        Button startQuizButton;
        DataLayer layer;
        // Varibales
        string quizTopic;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.selected_topic);
            layer = new DataLayer();

            quizTopicTextView = (TextView)FindViewById(Resource.Id.quizTopicText);
            descriptionTextView = (TextView)FindViewById(Resource.Id.quizDescriptionText);
            quizImageView = (ImageView)FindViewById(Resource.Id.quizImage);
            startQuizButton = (Button)FindViewById(Resource.Id.startQuizButton);


            quizTopic = Intent.GetStringExtra("topic");
            quizTopicTextView.Text = quizTopic;
            quizImageView.SetImageResource(GetImage(quizTopic));

            Topic topic = layer.GetTopicByName(quizTopic);
            descriptionTextView.Text = topic.Description;
            startQuizButton.Click += StartQuizButton_Click;
        }

        private void StartQuizButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizActivity));
            intent.PutExtra("topic", quizTopic);
            StartActivity(intent);
            Finish();
        }

        int GetImage(string topic)
        {
            int imageInt = 0;

            if (topic == "History")
            {
                imageInt = Resource.Drawable.history;
            }
            else if (topic == "Geography")
            {
                imageInt = Resource.Drawable.geography;
            }
            else if (topic == "Space")
            {
                imageInt = Resource.Drawable.space;
            }
            else if (topic == "Programming")
            {
                imageInt = Resource.Drawable.programming;
            }
            else if (topic == "Engineering")
            {
                imageInt = Resource.Drawable.engineering;
            }
            else if (topic == "Business")
            {
                imageInt = Resource.Drawable.business;
            }

            return imageInt;
        }

    }
}