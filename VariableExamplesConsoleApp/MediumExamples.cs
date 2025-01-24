using System.Collections.Concurrent;

namespace VariableExamplesConsoleApp
{
    public class MediumExamples
    {
        public void Run()
        {
            AdvancedListDictionary();
            EnumParsing();
            SafeTypeConversion();
            StructAndClass();
            ThreadSafeDictionary();
        }

        private void AdvancedListDictionary()
        {
            Dictionary<int, string> users = new Dictionary<int, string> { { 1, "Alice" }, { 2, "Bob" } };
            Console.WriteLine($"User 1: {users[1]}");
        }

        private void EnumParsing()
        {
            DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Tuesday");
            Console.WriteLine($"Parsed Enum: {today}");
        }

        private void SafeTypeConversion()
        {
            string input = "123";
            if (int.TryParse(input, out int result))
                Console.WriteLine($"Parsed: {result}");
        }

        private void StructAndClass()
        {
            User u = new User("Alice", 25);
            Console.WriteLine($"{u.Name}, {u.Age}");
        }

        struct User
        {
            public string Name;
            public int Age;
            public User(string name, int age) { Name = name; Age = age; }
        }

        private void ThreadSafeDictionary()
        {
            ConcurrentDictionary<int, string> concurrentDict = new();
            concurrentDict.TryAdd(1, "Admin");
            Console.WriteLine($"Concurrent Dictionary: {concurrentDict[1]}");
        }
    }
}
