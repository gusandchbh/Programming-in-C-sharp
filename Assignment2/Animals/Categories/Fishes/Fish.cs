namespace Assignment2.Animals.Categories.Fishes;

public abstract class Fish : Animal // Inherit from Animal
{
    /// <summary>
    ///     Constructor for Fish, also calls constructor in superclass (animal)
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="gender"></param>
    /// <param name="weight"></param>
    /// <param name="swimSpeed"></param>
    public Fish(string id, string name, int age, Gender gender, int weight, int swimSpeed, CategoryType category) :
        base(id, name, age, gender, weight, category)
    {
        this.SwimSpeed = swimSpeed;
    }

    public int SwimSpeed { get; set; }

    public override string GetExtraInfo()
    {
        var strOut = base.GetExtraInfo();

        strOut += Environment.NewLine + string.Format("{0,-28}, {1, -17}\n", "Swimspeed:", SwimSpeed).Replace(",", "") +
                  Environment.NewLine;

        return strOut;
    }
}