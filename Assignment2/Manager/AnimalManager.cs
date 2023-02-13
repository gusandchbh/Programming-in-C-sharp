using Assignment2.Animals;
using Assignment2.Animals.Categories;

namespace Assignment2.Manager;

public class AnimalManager
{
    private readonly List<Animal> animalList;
    private int startID;


    public AnimalManager(List<Animal> animalList, int startID)
    {
        this.animalList = animalList;
        this.startID = startID;
    }


    // The Add method is called by the MainForm, and it adds a new Animal object. Perform
    // some validation of the object before adding, for instance, controlling so the object is not
    // null.

    public bool Add(Animal animal)
    {
        if (animal == null) return false;
        animalList.Add(animal);
        return true;
    }

    private int Count()
    {
        var count = 0;
        for (var i = 0; i < animalList.Count; i++) count++;

        return count;
    }

    public Animal GetAnimalAt(int index)
    {
        if (index < 0 || index >= animalList.Count) return null;
        return animalList[index];
    }

    public string[] GetAnimalInfoStrings()
    {
        var arr = new string[Count()];
        for (var i = 0; i < arr.Length; i++) arr[i] = animalList[i].ToString();
        return arr;
    }


    // You can set an ID to every animal object being added to the list. Referring to the GUI
    // figure above, the IDs of the animals are set by the method GetNewID that combines a
    //    letter, e.g. 'M' for Mammal, and the recent value of the startID.This is only an example.
    //    You can use any other simple method(like numbers 1, 2, …) or a more complex system
    //    like GUID.

    public string GetNewID(CategoryType category)
    {
        var strOut = string.Empty;
        strOut += category.ToString().Substring(0, 1) + startID;
        startID++;
        return strOut;
    }
}