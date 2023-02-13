using Assignment2.Animals.Categories;
using Assignment2.Manager;

namespace Assignment2.Animals;

public abstract class Animal : IAnimal
{
    /// <summary>
    ///     Constructor for Animal
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="gender"></param>
    /// <param name="weight"></param>
    protected Animal(string id, string name, int age, Gender gender, int weight, CategoryType category)
    {
        this.ID = id;
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
        this.Weight = weight;
        this.Category = category;
    }

    public CategoryType Category { get; set; }

    /// <summary>
    ///     Property for age
    /// </summary>

    public int Age { get; set; }

    /// <summary>
    ///     Property for weight
    /// </summary>

    public int Weight { get; set; }


    public virtual string GetExtraInfo()
    {
        var strOut = string.Empty;

        strOut = string.Format("{0,-20} {1,15}\n", "Category:", Category.ToString()) + Environment.NewLine;

        return strOut;
    }

    /// <summary>
    ///     Property for name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Property for gender
    /// </summary>

    public Gender Gender { get; set; }

    /// <summary>
    ///     Property for id
    /// </summary>

    public string ID { get; set; }

    public abstract FoodSchedule getFoodSchedule();

    public override string ToString()
    {
        var strOut = string.Empty;

        strOut = string.Format("{0,-15} {1,-30} {2, -25} {3, -10}\n", ID, Name, Age, Gender);

        return strOut;
    }
}