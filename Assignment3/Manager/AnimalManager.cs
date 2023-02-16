using Assignment3.Animals;

namespace Assignment3.Manager;

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