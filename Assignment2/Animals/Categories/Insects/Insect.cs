namespace Assignment2.Animals.Categories.Insects;

public abstract class Insect : Animal
{
    protected Insect(string id, string name, int age, Gender gender, int weight, CategoryType category,
        int numberOfLegs) : base(id, name, age, gender, weight, category)
    {
        this.NumberOfLegs = numberOfLegs;
    }

    public int NumberOfLegs { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine +
                  string.Format("{0,-28}, {1, -17}\n", "Number of legs:", NumberOfLegs).Replace(",", "") +
                  Environment.NewLine;

        return strOut;
    }
}