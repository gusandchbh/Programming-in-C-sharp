using Assignment2.Manager;

namespace Assignment2.Animals
{
    public interface IAnimal
    {
        string Name
        {
            get;
            set;
        }

        string ID
        {
            get;
            set;
        }

        Gender Gender
        {
            get; 
            set;
        }

        FoodSchedule getFoodSchedule();

        string GetExtraInfo();
    }
}
