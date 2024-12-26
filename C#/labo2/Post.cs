using System;
using System.Reflection.Metadata.Ecma335;

namespace labo2{
    internal class Post{
        private const int INC_LIKEDBY_SIZE = 3;
        private User author;
        private string contents;
        private DateTime date;
        private User[] likedBy = new User[INC_LIKEDBY_SIZE];
        private int nbLikes;

        #region constructors
            public Post (User author, string contents, DateTime date){
            this.author = author;
            this.contents = contents;
            this.date = date;
            author.AddPost(this);
            }

            public Post (User author, string contents):
                this(author,contents,DateTime.Today)
            {}
        #endregion

        #region Search users
        private int SearchUser(){
            int iUser = 0;

            while(iUser < likedBy.Length && likedBy[iUser] != null){
                iUser++;
            }

            return iUser;
        }

        private int SearchUser(string login){
            int iUser = 0;

            while(iUser < likedBy.Length && likedBy[iUser].Login != login){
                iUser++;
            }

            return iUser;
        }
        #endregion

       public string Contents{
            get{
                return contents;
            }
       }
       public void AddLike(User user){
            int iUser = SearchUser();

            if(iUser == likedBy.Length){
                User[] newlikedBy =  new User[likedBy.Length + INC_LIKEDBY_SIZE];
                Console.WriteLine(likedBy.Length);
                Array.Copy(likedBy,newlikedBy,likedBy.Length);
                likedBy = newlikedBy;
                Console.WriteLine(likedBy.Length);
            }

            likedBy[iUser] = user;
            nbLikes++;
       }

       public void AddLike(params User[] userList){

          int emptySlots = likedBy.Length - nbLikes;
          int additionalSlotsNeeded = userList.Length - emptySlots;
          
          if(userList.Length > emptySlots){
            int blocksNeeded = (additionalSlotsNeeded / INC_LIKEDBY_SIZE) + 1;
            int newSize = likedBy.Length + (blocksNeeded * INC_LIKEDBY_SIZE);

            User[] newLikeBy = new User[newSize];
            Array.Copy(likedBy, newLikeBy, likedBy.Length); // Copier dans le nouveau tableau les éléments existants
            likedBy = newLikeBy;
          }


          foreach(User user in userList){
            AddLike(user);
          }
       }

       public void RemoveLike(User user){
            int iUser = SearchUser(user.Login);

            if(iUser < likedBy.Length){
                for(int iRemove = iUser; iRemove < likedBy.Length - 1; iRemove++){
                    likedBy[iRemove] = likedBy[iRemove + 1];
                }

                likedBy[likedBy.Length - 1] = null;
                nbLikes--;
            }            
       }


       public override string ToString()
       {
         return $"{author.Login} {this.contents} {this.date.ToString("dd-MMM-yy")}";
       }



    }
}