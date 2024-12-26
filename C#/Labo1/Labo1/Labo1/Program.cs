namespace Labo1
{
    internal class Program
    {
        public static void AssertMaps(string expected, Player p)
        {
            Console.WriteLine("Expected answer : " + expected);
            Console.WriteLine(p.ListingMaps());
        }
        
        public static void TestMaps() {
            // Mise en place
            Player p = new Player("Indiana", "Jones", new DateTime(1899,7,1));
            // Test
            AssertMaps("aucune", p);
            // Mise en place
            p.AddMap("Canyon");
            // Test
            AssertMaps("Canyon", p);

            // Mise en place
            p.AddMap("Forteresse");
            p.AddMap("Forêt");
            // Test
            AssertMaps("Forêt, Forteresse, Canyon", p);
            
            // Mise en place
            p.AddMap("Forteresse");
            // Test
            AssertMaps("Forteresse, Forêt, Canyon", p);

            // Mise en place
            p.AddMap("Desert");
            p.AddMap("Oasis");
            // Test
            AssertMaps("Oasis, Desert, Forteresse, Forêt, Canyon", p);
            
            // Mise en place
            p.AddMap("Forêt");
            // Test
            AssertMaps("Forêt, Oasis, Desert, Forteresse, Canyon", p);

            // Mise en place
            p.AddMap("Caverne");
            // Test
            AssertMaps("Caverne, Forêt, Oasis, Desert, Forteresse", p);
        }

        
        static void Main(string[] args)
        {
            Player player1 = new Player("John", "Doe", new DateTime(1990, 1, 1), false, false);
            Player player2 = new Player("Jane", "Doe", new DateTime(1990, 1, 1));
            
           Console.WriteLine(player1.getName());
           Console.WriteLine(player1.getBirthDay());
           Console.WriteLine(player1.ToString());
           Console.WriteLine(player2.ToString());
           
           TestMaps();
        }
    }
}

