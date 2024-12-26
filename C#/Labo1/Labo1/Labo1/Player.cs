using System.Text;

namespace Labo1;

public class Player
{
    #region attributes

    public const int NB_MAX_MAPS = 5;
    private string firstName;
    private string lastName;
    private DateTime birthDay;
    private int skillRating;
    private bool sponsored;
    private string[] maps = new string[NB_MAX_MAPS];

    #endregion
    
    #region constructors

    public Player(string firstName, string lastName, DateTime birthDay,bool isRanked, bool sponsored)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDay = birthDay;
        this.skillRating = (isRanked) ? 1 : 0;
        this.sponsored = sponsored;
    }
    
    public Player(string firstName, string lastName, DateTime birthDay) : 
        this(firstName,lastName,birthDay,true,true)
    {}

    #endregion
    

    public string getName()
    {
        return $"{this.firstName} {this.lastName}";
    }

    public string getBirthDay()
    {
        return this.birthDay.ToString("dd/MM/yyyy");
    }
    
    public void setRanked()
    {
        if(!isRanked())
        {
            this.skillRating = 1;
        }
        else
        {
            Console.WriteLine("Player is already ranked");
        }
    }

    private bool isRanked()
    {
        return this.skillRating != 0;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine($"Name: {this.getName()}");
        output.AppendLine($"BirthDay: {this.getBirthDay()}");
        output.AppendLine($"Skill Rating: {this.skillRating}");
        output.AppendLine($"Sponsored: {this.sponsored}");
        return output.ToString();
    }

    private int FindPosition(string map)
    {
        int iEmplacement = 0;

        while (this.maps[iEmplacement] != map && iEmplacement < NB_MAX_MAPS - 1 && this.maps[iEmplacement] != null)
        {
            iEmplacement++;
        }

        return iEmplacement;
    }

    private void ShiftRight(int iEmplacement)
    {
       
        for (int iDecal = iEmplacement; iDecal > 0; iDecal--)
        {
            this.maps[iDecal] = this.maps[iDecal - 1];
        }
       
    }
    
    public string ListingMaps()
    {
        StringBuilder result = new StringBuilder();
        int index = 1;

        foreach (string map in this.maps)
        {
            result.AppendLine($"{index} – {map ?? ""}");
            index++;
        }

        return result.ToString();
    }

    public void AddMap(string map)
    {
       int iEmplacement = FindPosition(map);
       if (iEmplacement != 0)
       {
           ShiftRight(iEmplacement);
       }
       
       this.maps[0] = map;
    }
    
    
}