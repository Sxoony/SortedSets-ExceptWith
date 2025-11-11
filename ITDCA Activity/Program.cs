namespace ITDCA_Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var ingredients = new List<string>
        {
            "eggs","flour","sugar","milk","bread"
        };


            HashSet<string> recipe = new HashSet<string>(ingredients);

            HashSet<string> sandwich = new HashSet<string> { "eggs", "bread" };
            Console.WriteLine("Micaela's sandwich list: eggs, bread\n");

            Console.WriteLine("Micaela's full pantry list: ");
            foreach (var  ingredient in ingredients)
            {
                Console.Write(ingredient+" ");
            }
            Console.WriteLine("\n");

            var itemsexcluded = new HashSet<string>(recipe);
            itemsexcluded.ExceptWith(sandwich);
            foreach (var except in itemsexcluded)
            {
                Console.WriteLine(except);
            }
        }
    }
}
