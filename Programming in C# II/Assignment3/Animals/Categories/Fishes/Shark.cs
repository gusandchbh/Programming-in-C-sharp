using Assignment3.Manager;

namespace Assignment3.Animals.Categories.Fishes;

public class Shark : Fish // Inherit from Fish
{
    private FoodSchedule foodSchedule;

    public Shark(string id, string name, int age, Gender gender, int weight, int swimSpeed, int teeth,
        CategoryType category)
        : base(id, name, age, gender, weight, swimSpeed, category) // // call constructor of superclass
    {
        this.Teeth = teeth;
        SetFoodSchedule();
    }

    public int Teeth //Property for teeth
    {
        get;
        set;
    }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Teeth:", Teeth);

        return "Shark" + Environment.NewLine + Environment.NewLine + strOut;
    }

    public override FoodSchedule getFoodSchedule()
    {
        return foodSchedule;
    }

    public void SetFoodSchedule()
    {
        foodSchedule = new FoodSchedule();
        foodSchedule.EaterType = EaterType.Carnivore;
        foodSchedule.Add("Morning: octopus sallad");
        foodSchedule.Add("Lunch: 4-5 shrimps");
        foodSchedule.Add("Evening: crabs and lobsters");
    }
}