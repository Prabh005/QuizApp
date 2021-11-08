using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp.Database
{
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int QuestionID { get; set; }
        public string QuizQuestion { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
        public string TopicName { get; set; }
    }
}