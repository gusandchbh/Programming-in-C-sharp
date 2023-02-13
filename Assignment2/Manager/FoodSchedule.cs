namespace Assignment2.Manager;

public class FoodSchedule
{
    private readonly List<string> foodList;


    public FoodSchedule()
    {
        foodList = new List<string>();
    }

    public EaterType EaterType { get; set; }

    private int Count()
    {
        var count = 0;
        for (var i = 0; i < foodList.Count; i++) count++;
        return count;
    }

    public void Add(string item)
    {
        foodList.Add(item);
    }

    public bool ChangeAt(int index, string item)
    {
        return true;
    }

    public bool CheckIndex(int index)
    {
        return true;
    }

    public bool DeleteAt(int index)
    {
        return true;
    }

    public string[] GetFoodListInfoStrings()
    {
        return foodList.ToArray();
    }

    public string Title()
    {
        return "";
    }

    public override string ToString()
    {
        return "LOL";
    }
}