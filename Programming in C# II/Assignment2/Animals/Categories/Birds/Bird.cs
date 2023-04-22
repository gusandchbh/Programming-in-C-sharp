namespace Assignment2.Animals.Categories.Birds;

public abstract class Bird : Animal
{
    public Bird(string id, string name, int age, Gender gender, int weight, CategoryType category, string species) :
        base(id, name, age, gender, weight, category)
    {
        this.Species = species;
    }

    public string Species { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-28}, {1, -17}\n", "Species:", Species).Replace(",", "") +
                  Environment.NewLine;

        return strOut;
    }
}