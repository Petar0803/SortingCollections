namespace SortingCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");

            //double[] doubles = { 1.237, 2.4876, 3.5, 4.01234 }; // Плаваща запетая, дробно число

            //List<String> formatted = doubles.Select(
            //  d => string.Format("{0:F3}", d)
            //).ToList();

            //formatted.ForEach(Console.WriteLine);


            var products = new Dictionary<int, string>{
                    {1, "Apple"},
                    {2, "Banana"},
                    {3, "Orange"},
            };

            var sorted = products
              .OrderByDescending(e => e.Value)
              .ThenBy(e => e.Key);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}


