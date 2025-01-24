using System.Collections.Concurrent;

namespace VariableExamplesConsoleApp
{
    public class HardExamples
    {
        public void Run()
        {
            MemoryOptimization();
            ConcurrentDataStructures();
            ParallelProgramming();
            ImmutableTypes();
        }

        private void MemoryOptimization()
        {
            Span<int> numbers = stackalloc int[] { 1, 2, 3 };
            Console.WriteLine($"First Stackalloc Element: {numbers[0]}");
        }

        private void ConcurrentDataStructures()
        {
            var bag = new ConcurrentBag<int>();
            bag.Add(1);
            Console.WriteLine($"Bag Count: {bag.Count}");
        }

        private void ParallelProgramming()
        {
            Parallel.For(0, 5, i => Console.WriteLine($"Task {i} running..."));
        }

        private void ImmutableTypes()
        {
            ImmutableData data = new ImmutableData(10, 20);
            Console.WriteLine($"Immutable Data: {data.A}, {data.B}");
        }

        readonly struct ImmutableData
        {
            public int A { get; }
            public int B { get; }
            public ImmutableData(int a, int b) { A = a; B = b; }
        }
    }
}
