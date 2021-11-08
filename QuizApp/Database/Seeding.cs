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

namespace QuizApp.Database
{
    public class Seeding
    {
        public static List<Topic> GetTopics()
        {
            List<Topic> topics = new List<Topic>();
            topics.Add(new Topic() { TopicName = "History", Description= "History is the study of the past as it is described in written documents. Events occurring before written record are considered prehistory. It is an umbrella term that relates to past events as well as the memory, discovery, collection, organization, presentation, and interpretation of information about these events." });
            topics.Add(new Topic() { TopicName = "Geography", Description = "Geography is the study of places and the relationships between people and their environments. Geographers explore both the physical properties of Earth's surface and the human societies spread across it." });
            topics.Add(new Topic() { TopicName = "Space", Description = "The concept of space is considered to be of fundamental importance to an understanding of the physical universe. However, disagreement continues between philosophers over whether it is itself an entity, a relationship between entities, or part of a conceptual framework." });
            topics.Add(new Topic() { TopicName = "Programming", Description = "A programming language is a formal language comprising a set of strings that produce various kinds of machine code output. Programming languages are one kind of computer language, and are used in computer programming to implement algorithms." });
            topics.Add(new Topic() { TopicName = "Engineering", Description = "Engineering is the use of scientific principles to design and build machines, structures, and other items, including bridges, tunnels, roads, vehicles, and buildings. The discipline of engineering encompasses a broad range of more specialized fields of engineering, each with a more specific emphasis on particular areas of applied mathematics, applied science, and types of application. See glossary of engineering." });
            topics.Add(new Topic() { TopicName = "Business", Description = "The business description is meant to provide an overview of the business, including what the business does and how the company is unique from others in the same industry. Names of the people who own the company and any senior-level employees. " });
            return topics;
        }

        public static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question { TopicName="History", QuizQuestion = "During which decade was slavery abolished in the United States?", Answer = "1860s", OptionA = "1860s", OptionB = "1840s", OptionC = "1850s", OptionD = "1870" });
            questions.Add(new Question { TopicName = "History", QuizQuestion = "During which year did Christopher Columbus first arrive in the Americas?", Answer = "1495", OptionA = "1495", OptionB = "1492", OptionC = "1498", OptionD = "1501" });
            questions.Add(new Question { TopicName = "History", QuizQuestion = "Which year was the first edition of FIFA World Cup played", Answer = "1930", OptionA = "1985", OptionB = "1920", OptionC = "1930", OptionD = "2002" });
            questions.Add(new Question { TopicName = "History", QuizQuestion = "World War II also known as the Second World War, was a global war that lasted from 1939 to ?", Answer = "1945", OptionA = "1986", OptionB = "1922", OptionC = "1945", OptionD = "1939" });
            questions.Add(new Question { TopicName = "History", QuizQuestion = "The assassination of Julius Caesar was the result of a conspiracy by many Roman senators, he was stabbed by?", Answer = "Junius Brutus", OptionA = "Uchenna Nnodim", OptionB = "Cassius Longinus", OptionC = "Junius Brutus", OptionD = "Orsa Kemi" });
            questions.Add(new Question { TopicName = "Geography", QuizQuestion = "What is the largest country in the world (by Area)?", Answer = "Russia", OptionA = "Russia", OptionB = "Canada", OptionC = "United Sates", OptionD = "China" });
            questions.Add(new Question { TopicName = "Geography", QuizQuestion = "Which of the following countries does NOT have a population exceeding 200 million?", Answer = "Nigeria", OptionA = "Brazil", OptionB = "Indonesia", OptionC = "Pakistan", OptionD = "Nigeria" });
            questions.Add(new Question { TopicName = "Geography", QuizQuestion = "Muscat is the capital of which country?", Answer = "Oman", OptionA = "Oman", OptionB = "Jordan", OptionC = "Yemen", OptionD = "Bahrain" });
            questions.Add(new Question { TopicName = "Geography", QuizQuestion = "Which is the world's smallest continent (by area)?", Answer = "Oceania", OptionA = "Oceania", OptionB = "Antractica", OptionC = "South America", OptionD = "Europe" });
            questions.Add(new Question { TopicName = "Geography", QuizQuestion = "Which of the following countries is NOT a member state of the European Union?", Answer = "Norway", OptionA = "Finland", OptionB = "Sweden", OptionC = "Norway", OptionD = "Denmark" });
            questions.Add(new Question { TopicName = "Space", QuizQuestion = "Who was the first man to ever walk on the Moon?", Answer = "Niel Armstrong", OptionA = "Uchenna Nnodim", OptionB = "Niel Armstrong", OptionC = "Benjamin Franklin", OptionD = "Pele Pele" });
            questions.Add(new Question { TopicName = "Space", QuizQuestion = "The coldest and farthest Planet from the Sun is ?", Answer = "Pluto", OptionA = "Earth", OptionB = "Pluto", OptionC = "Neptune", OptionD = "Saturn" });
            questions.Add(new Question { TopicName = "Space", QuizQuestion = "The galaxy that contains Solar System which Earth belongs to is called what?", Answer = "Milky Way", OptionA = "Chocolate Path", OptionB = "Phantom Zone", OptionC = "Milky Way", OptionD = "Solar Container" });
            questions.Add(new Question { TopicName = "Space", QuizQuestion = "How many days does it take the Earth to complete her orbit", Answer = "365 Days", OptionA = "365 Days", OptionB = "30 Days", OptionC = "272 Days", OptionD = "None of the Above" });
            questions.Add(new Question { TopicName = "Space", QuizQuestion = "An explosion which leads to gigantic explosion throwing star's outer layers are thrown out is called", Answer = "Supernova", OptionA = "Black hole", OptionB = "Double ring", OptionC = "Massive Explosion", OptionD = "Supernova" });
            return questions;
        }
    }
}