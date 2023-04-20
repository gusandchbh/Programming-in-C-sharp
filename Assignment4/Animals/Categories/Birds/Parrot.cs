using Assignment3.Manager;

namespace Assignment3.Animals.Categories.Birds;
[Serializable]
public class Parrot : Bird
{
    private FoodSchedule foodSchedule;

    public Parrot(string id, string name, int age, Gender gender, int weight, string species,
        string favoriteWord, CategoryType category) : base(id, name, age, gender, weight, category, species)
    {
        this.FavoriteWord = favoriteWord;
        SetFoodSchedule();
    }

    public string FavoriteWord { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Favorite word:", FavoriteWord);

        return "Parrot" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
    }

    public override FoodSchedule getFoodSchedule()
    {
        return foodSchedule;
    }

    public void SetFoodSchedule()
    {
        foodSchedule = new FoodSchedule();
        foodSchedule.EaterType = EaterType.Omnivorous;
        foodSchedule.Add("Morning: nuts and fruits");
        foodSchedule.Add("Lunch: 5 spiders");
        foodSchedule.Add("Evening: bowl of seeds");
    }
}