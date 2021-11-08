using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuizApp.Database
{
    public class DataLayer
    {
        private SQLiteConnection connection;

        public string ErrorMessage { get; set; }

        public DataLayer()
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            connection = new SQLiteConnection(Path.Combine(path, "quiz.db"));
            CreateAndSeedData();
        }

        public void CreateAndSeedData()
        {
            try
            {
                connection.CreateTable<User>();
                connection.CreateTable<Topic>();
                connection.CreateTable<Question>();
                List<Topic> topics = Seeding.GetTopics();
                foreach (Topic topic in topics)
                {
                    connection.Insert(topic);
                }
                User user = new User() { UserName = "admin", Password = "admin@12345" };
                connection.Insert(user);
                List<Question> questions = Seeding.GetQuestions();
                foreach (Question question in questions)
                {
                    connection.Insert(question);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool ValidUser(string username, string password)
        {
            List<User> users = connection.Query<User>("Select * from User");
            if (users != null && users.Count > 0)
            {
                foreach (User user in users)
                {
                    if (user.UserName.Equals(username) && user.Password.Equals(password))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddUser(User user)
        {
            try
            {
                connection.Insert(user);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool AddTopic(Topic topic)
        {
            try
            {
                connection.Insert(topic);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool AddQuestion(Question question)
        {
            try
            {
                connection.Insert(question);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public List<Topic> GetAllTopics()
        {
            List<Topic> topics = connection.Query<Topic>("Select * from Topic");
            return topics;
        }

        public List<Question> GetAllQuestions()
        {
            List<Question> questions = connection.Query<Question>("Select * from Question");
            return questions;
        }

        public Topic GetTopicByName(string topicname)
        {
            Topic topic = null;
            List<Topic> topics = GetAllTopics();
            if (topics != null && topics.Count > 0)
            {
                foreach (Topic topicobj in topics)
                {
                    if (topicobj.TopicName.Equals(topicname))
                    {
                        topic = topicobj;
                        break;
                    }
                }
            }
            return topic;
        }

        public List<Question> GetQuestionsByName(string topicname)
        {
            List<Question> topic_questions = new List<Question>();
            List<Question> questions = GetAllQuestions();
            if (questions != null && questions.Count > 0)
            {
                foreach (Question question in questions)
                {
                    if (question.TopicName.Equals(topicname))
                    {
                        topic_questions.Add(question);
                    }
                }
            }
            return topic_questions;
        }

        public bool DeleteQuestion(Question question)
        {
            try
            {
                connection.Delete(question);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }
    }
}