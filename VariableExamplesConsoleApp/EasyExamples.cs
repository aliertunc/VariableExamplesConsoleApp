namespace VariableExamplesConsoleApp.Examples
{
    public class EasyExamples
    {
        public void Run()
        {
            BasicDataTypes();
            NullableTypes();
            ArrayExample();
            ListDictionaryExample();
            EnumExample();
            TypeConversions();
            StructExample();
        }

        private void BasicDataTypes()
        {
            int age = 25;
            double price = 19.99;
            bool isAvailable = true;
            char letter = 'A';
            string message = "Hello, World!";
            Console.WriteLine($"Age: {age}, Price: {price}, Available: {isAvailable}, Letter: {letter}, Message: {message}");
        }

        private void NullableTypes()
        {
            int? number = null;
            Console.WriteLine($"Nullable Number: {number ?? -1}");
        }

        private void ArrayExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"First Element: {numbers[0]}");
        }

        private void ListDictionaryExample()
        {
            List<int> numbers = new List<int> { 10, 20, 30 };
            Console.WriteLine($"First List Element: {numbers[0]}");
        }

        private void EnumExample()
        {
            DayOfWeek today = DayOfWeek.Monday;
            Console.WriteLine($"Today is: {today}");
        }

        private void TypeConversions()
        {
            string str = "100";
            int num = int.Parse(str);
            Console.WriteLine($"Parsed Number: {num}");
        }

        private void StructExample()
        {
            Point p = new Point(5, 10);
            Console.WriteLine($"Point: ({p.X}, {p.Y})");
        }

        struct Point
        {
            public int X, Y;
            public Point(int x, int y) { X = x; Y = y; }
        }
    }
}
