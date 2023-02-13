using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Manager
{
    public class FoodSchedule
    {
        private EaterType eaterType;
        private List<string> foodList;


        public FoodSchedule()
        {
            foodList = new List<string>();
        }

        private int Count()
        {
            int count = 0;
            for (int i = 0; i < foodList.Count; i++)
            {
                count++;
            }
            return count;
        }

        public EaterType EaterType {
            get { return eaterType; }
            set { eaterType = value; }
        }

        public void Add(String item)
        {
            foodList.Add(item);
        }

        public bool ChangeAt(int index, string item)
        {
            return true;
        }

        public bool CheckIndex(int index)
        {
            return true;
        }

        public bool DeleteAt(int index)
        {
            return true;
        }

        public string[] GetFoodListInfoStrings()
        {
            return foodList.ToArray();
        }

        public string Title()
        {
            return "";
        }

        public override string ToString()
        {
            return "LOL";
        }
    }
}
