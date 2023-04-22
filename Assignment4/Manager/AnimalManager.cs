using Assignment3.Animals;
using Assignment3.Utilities;
using System.Collections.Generic;

namespace Assignment3.Manager;
[Serializable]
public class AnimalManager : ListManager<Animal>
{
    private int startID;


    public AnimalManager(int startID) 
    {
        this.startID = startID;
    }

    public int GetNewId()
    {
        return Count +1;
    }


}