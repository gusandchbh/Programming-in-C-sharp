using Assignment3.Manager;

namespace Assignment3.Animals;

public interface IAnimal
{
    string Name { get; set; }

    string ID { get; set; }

    Gender Gender { get; set; }

    FoodSchedule getFoodSchedule();

    string GetExtraInfo();
}