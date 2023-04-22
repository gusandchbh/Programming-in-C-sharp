using Assignment3.Manager;

namespace Assignment3.Animals.Categories.Birds;
[Serializable]
public class Penguin : Bird
{
    private FoodSchedule foodSchedule;

    public Penguin(string id, string name, int age, Gender gender, int weight, string species, int cuteness,
        CategoryType category) : base(id, name, age, gender, weight, category, species)
    {
        this.Cuteness = cuteness;
        SetFoodSchedule();
    }

    public int Cuteness { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Cuteness:", Cuteness);

        return "Penguin" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
    }

    public override FoodSchedule getFoodSchedule()
    {
        return foodSchedule;
    }

    public void SetFoodSchedule()
    {
        foodSchedule = new FoodSchedule();
        foodSchedule.EaterType = EaterType.Carnivore;
        foodSchedule.Add("Morning: 1-2 large squids");
        foodSchedule.Add("Lunch: mixed fish");
        foodSchedule.Add("Evening: fish soup");
    }
}