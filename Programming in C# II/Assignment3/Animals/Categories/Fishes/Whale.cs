using Assignment3.Manager;

namespace Assignment3.Animals.Categories.Fishes;

public class Whale : Fish // Inherit from Fish
{
    private FoodSchedule foodSchedule;


    public Whale(string id, string name, int age, Gender gender, int weight, int swimSpeed, int blowholes,
        CategoryType category)
        : base(id, name, age, gender, weight, swimSpeed, category) // call constructor of superclass
    {
        this.Blowholes = blowholes;
        SetFoodSchedule();
    }

    public int Blowholes // Property for blowholes
    {
        get;
        set;
    }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Blowholes:", Blowholes);

        return "Whale" + Environment.NewLine + Environment.NewLine + strOut;
    }

    public override FoodSchedule getFoodSchedule()
    {
        return foodSchedule;
    }

    public void SetFoodSchedule()
    {
        foodSchedule = new FoodSchedule();
        foodSchedule.EaterType = EaterType.Carnivore;
        foodSchedule.Add("Morning: squid sallad");
        foodSchedule.Add("Lunch: plankton");
        foodSchedule.Add("Evening: 2-3 sharks");
    }
}