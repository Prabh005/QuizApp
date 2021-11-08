using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace QuizApp.Database
{
    public class Topic
    {
        [PrimaryKey, AutoIncrement]
        public int TopicID { get; set; }

        [Unique]
        public string TopicName { get; set; }

        public string Description { get; set; }

    }
}