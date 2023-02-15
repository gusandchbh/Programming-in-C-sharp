namespace Assignment3.Animals.Categories.Mammals;

public abstract class Mammal : Animal // Inherit from Animal
{
    /// <summary>
    ///     Constructor for Mammal, also calls constructor of superclass (animal)
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="gender"></param>
    /// <param name="weight"></param>
    /// <param name="expectedLifeSpan"></param>
    protected Mammal(string id, string name, int age, Gender gender, int weight, int expectedLifeSpan,
        CategoryType category) : base(id, name, age, gender, weight, category)
    {
        this.ExpectedLifeSpan = expectedLifeSpan;
    }

    /// <summary>
    ///     Property for expected lifespan
    /// </summary>

    public int ExpectedLifeSpan { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-28}, {1, -17}\n", "Expected lifespan:", ExpectedLifeSpan) +
                  Environment.NewLine;

        return strOut;
    }
}