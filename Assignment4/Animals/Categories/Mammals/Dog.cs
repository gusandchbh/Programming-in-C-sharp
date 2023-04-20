using Assignment3.Manager;

namespace Assignment3.Animals.Categories.Mammals;
[Serializable]
public class Dog : Mammal
{
    private FoodSchedule foodSchedule;


    /// <summary>
    ///     Constructor for Dog, also calls constructor of superclass (mammal)
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="gender"></param>
    /// <param name="weight"></param>
    /// <param name="expectedLifeSpan"></param>
    /// <param name="breed"></param>
    public Dog(string id, string name, int age, Gender gender, int weight, int expectedLifeSpan, string breed,
        CategoryType category) : base(id, name, age, gender, weight, expectedLifeSpan, category)
    {
        this.Breed = breed;
        SetFoodSchedule();
    }


    /// <summary>
    ///     Property for breed
    /// </summary>
    public string Breed { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Breed:", Breed);

        return "Dog" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
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