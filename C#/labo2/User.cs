using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace labo2{
    internal class User{
        private string login;
        private int password;
        private DateTime joinDate;
        private int postCount;
        private int spacesPosted;
        private int digitsPosted;


        #region constructors
        public User (string login, string password, DateTime joinDate){
            Login = login;
            Password = password;
            this.joinDate = joinDate;
        }
        
        public User (string login,string password):
            this(login,password,DateTime.Today)
        {}
        #endregion
    

        public string Login{ // Création des getter et des setter sous forme propriété
            get{
                return login;
            }
            set{
                 if(ForumUtils.ValidLogin(value)){
                    login = value;
                 }
            }
        }

        public int PostCount{
            get{
                return postCount;
            }
        }
        /*public DateTime JoinDate{
            get{
               
            }
            set{

            }
        }*/

        public string Password{
            set{
                if(ForumUtils.validPassword(value,password)){
                    password = ForumUtils.Encode(value);
                }else{
                    Console.WriteLine("NOP ce n'est pas bon");
                }
            }
        }



        public void AddPost(Post post){
            ForumUtils.CountAndUpdate(post.Contents,ref spacesPosted, ref digitsPosted);
            this.postCount++;
        }

        public int SpacesPosted{
            get{
                return spacesPosted;
            }
        }

        public int DigitsPosted{
            get{
                return digitsPosted;
            }
        }

        public override string ToString(){
           return $"{Login} (password: {this.password}),{this.joinDate.ToString("dd-MMM-yy HH:mm:ss")} - {this.postCount} post{(this.postCount > 1 ? "s" : "")}";
        }



    }
}