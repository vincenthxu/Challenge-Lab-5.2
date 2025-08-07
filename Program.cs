namespace Challenge_Lab_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(FindMissingElement(elements));

            elements = [3, 0, 1];
            Console.WriteLine(FindMissingElement(elements));

            elements = [0, 1];
            Console.WriteLine(FindMissingElement(elements));

            elements = [9, 6, 4, 2, 3, 5, 7, 0, 1];
            Console.WriteLine(FindMissingElement(elements));
        }

        static int FindMissingElement(int[] elements)
        {
            HashSet<int> missing = new HashSet<int>();

            for (int i = 0; i <= elements.Length; i++)
            {
                missing.Add(i);
            }

            foreach (int element in elements)
            {
                missing.Remove(element);
            }

            return missing.First();
        }
    }
}
