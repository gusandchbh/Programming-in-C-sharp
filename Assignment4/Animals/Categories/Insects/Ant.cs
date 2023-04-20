using Assignment3.Manager;

namespace Assignment3.Animals.Categories.Insects;
[Serializable]
internal class Ant : Insect // Omni
{
    private FoodSchedule foodSchedule;

    public Ant(string id, string name, int age, Gender gender, int weight, int numberOfLegs, int colonySize,
        CategoryType category) : base(id, name, age, gender, weight, category, numberOfLegs)
    {
        this.ColonySize = colonySize;
        SetFoodSchedule();
    }

    public int ColonySize { get; set; }


    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Size of colony:", ColonySize);

        return "Ant" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
    }

    public override FoodSchedule getFoodSchedule()
    {
        return foodSchedule;
    }

    public void SetFoodSchedule()
    {
        foodSchedule = new FoodSchedule();
        foodSchedule.EaterType = EaterType.Omnivorous;
        foodSchedule.Add("Morning: bones and milk");
        foodSchedule.Add("Lunch: beef and water");
        foodSchedule.Add("Evening: chicken");
    }
}