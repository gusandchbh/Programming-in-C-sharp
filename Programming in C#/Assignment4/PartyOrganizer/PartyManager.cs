using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
    internal class PartyManager
    {
        /// <summary>
        ///  Setting these fields to private so that they can only be accessed and altered through getter and setter methods
        /// </summary>
        private double costPerPerson;
        private double feePerPerson;
        private string[] guestList;

        public PartyManager(int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];
        }
        /// <summary>
        ///  Creating getters and setters for the fields
        /// </summary>
        public void SetCostPerPerson(double val)
        {
            costPerPerson = val;
        }

        public void SetFeePerPerson(double val)
        {
            feePerPerson = val;
        }

        public double GetFeePerPerson()
        {
            return feePerPerson;
        }

        public double GetCostPerPerson()
        {
            return costPerPerson;
        }
        /// <summary>
        ///  Convinience method to return the length of the guestlist, it returns an integer
        /// </summary>
        /// <returns></returns>
        public int NumOfGuests()
        {
            int counter = 0;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    counter++;
                }
            } return counter;
        }

        private int FindVacantPosition()
        {
            int vacantPosition = -1;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    vacantPosition = i;
                    break;
                }
            } return vacantPosition;
        }

        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPosition = FindVacantPosition();
            if (vacantPosition != -1)
            {
                guestList[vacantPosition] = FullName(firstName, lastName);
            } else
            {
                ok = false;
            }
            return ok;
        }

        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }


        public string[]? GetGuestList()
        {
            int size = NumOfGuests();

            if (size <= 0) return null;

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i];
                }
            } return guests;
        }

        private bool CheckIndex(int index)
        {
            if (index < 0 || index >= guestList.Length)
            {
                return false;
            }
            return true;
        }

        public string GetItemAt(int index)
        {
            if (CheckIndex(index))
            {
                return guestList[index];
            }
            return string.Empty;
        }

        public bool DeleteAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                guestList[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
                ok = true;
            }
            return ok;
        }

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = String.Empty;
            }
        }
       
    }
}
