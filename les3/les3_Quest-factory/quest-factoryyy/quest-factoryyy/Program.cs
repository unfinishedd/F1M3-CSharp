using System;


namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Quest q = QuestFactory.CreateQuest(QuestType.Water);
            Console.WriteLine($"{q.Description}");
            Console.ReadKey();
        }

        public enum QuestType
        {
            Fire,
            Water,
            Wind
        }

        public static class QuestFactory
        {
            public static Quest CreateQuest(QuestType questType)
            {
                switch (questType)
                {
                    case QuestType.Fire:
                        return new Quest("Fire ", "Set the water on fire");
                    case QuestType.Water:
                        return new Quest("Water", "Just tsunami the pandemic already");
                    case QuestType.Wind:
                        return new Quest("Wind", "Fire is nice and all.. but throwing a strong wind full of oxygen won't stop it");
                    default:
                        Console.WriteLine("No quests were found for type " + questType);
                        return null;
                }
            }
        }
        public class Quest
        {
            public string Title
            {
                get; private set;
            }

            public string Description
            {
                get; private set;
            }

            public Quest(string title, string description)
            {
                Title = title;
                Description = description;
            }
        }
    }
}