// See https://aka.ms/new-console-template for more information
using System;

namespace labo2
{
    internal class Program
    {
         public static void AssertBool (string test, bool expected, bool observed)
        {
            Console.WriteLine("Test: " + test);
            Console.WriteLine("Expected: " + expected + ", observed: " + observed);
            Console.WriteLine(expected == observed ? "Ok!" : "KO !!!");
            Console.WriteLine();
        }

        public static void TestValidLogin()
        {
            AssertBool("Herbert", true, ForumUtils.ValidLogin("Herbert"));
            AssertBool("root",false,ForumUtils.ValidLogin("root"));
            AssertBool("empty string", false, ForumUtils.ValidLogin(""));
            AssertBool("fart", true, ForumUtils.ValidLogin("fart"));
            AssertBool("FART", true, ForumUtils.ValidLogin("FART"));
            AssertBool("FaRt", true, ForumUtils.ValidLogin("FaRt"));
        }
        static void Main(string[] args)
        {
           

            /*User user1 = new User("dodo","root",DateTime.Now);
            User user2 = new User("dodo","root");*/


            User u = new User("Mélusine", "12345");
            // 0 post, 0 space, 0 digit
            Post p1 = new Post(u, "Un deux trois");
            // 1 post, 2 spaces, 0 digit
            Post p2 = new Post(u, "456");
            // 2 posts, 2 spaces, 3 digits
            Post p3 = new Post(u, "7 8 neuf !");
            // 3 posts, 5 spaces, 5 digits

          
            Console.WriteLine(u.SpacesPosted);
            Console.WriteLine(u.DigitsPosted);


           /* TestValidLogin();

            

            Console.WriteLine(user2);

            user2.Password = "test";
            
            Console.WriteLine(user1);
            Console.WriteLine(user2);*/
        }
    }
}