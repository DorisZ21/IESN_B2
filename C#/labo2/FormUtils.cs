using System.Net;

namespace labo2{
    internal static class ForumUtils{
        public static string[] FORBIDDEN_LOGINS = new [] {"test","root","dodo"};
        
        public static bool ValidLogin(string login){
            return !FORBIDDEN_LOGINS.Contains(login) && login != "";
        }

        public static bool validPassword(string password, int passwordUser){
            return !(Encode(password) == passwordUser);
        }

         public static int Encode (string password){
            int code = 0;

            foreach (char c  in password){
                code += c;
            }

            return code;
        }


        public static void CountAndUpdate (string txt, ref int spaceCount, ref int digitCount){
            foreach(char c in txt){
                if(char.IsWhiteSpace(c)){
                    spaceCount++;
                }else if(char.IsDigit(c)){
                    digitCount++;
                }
            }
        }
    }
}