using Assignment5_ABC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ABC
{
    internal class CustomerManager
    {
        private List<Customer> customerList;
        
        public CustomerManager()
        {
            this.customerList = new List<Customer>();
        }

        /// <summary>
        /// Adds a customer to the customer list
        /// </summary>
        /// <param name="customer"></param>

        public void AddCustomer(Customer customer)
        {
            this.customerList.Add(customer);
        }

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="index"></param>

 
        public void ChangeCustomer(Customer customer, int index)
        {
            this.customerList[index] = customer;
        }

        /// <summary>
        /// Retrieves/gets a customer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        public Customer GetCustomer(int index)
        {
            return customerList[index];
        }

        /// <summary>
        /// Gets the current highest ID
        /// </summary>
        /// <returns></returns>

        public int GetCurrentID()
        {
            int id = 99;
            foreach(Customer c in this.customerList)
            {
                if (c.Id > id)
                    id = c.Id;
            } return id + 1;
        }

        /// <summary>
        /// Removes a customer using the index
        /// </summary>
        /// <param name="index"></param>

        public void RemoveCustomer(int index)
        {
            customerList.RemoveAt(index);
        }

        /// <summary>
        /// Retrieves the customer list
        /// </summary>
        /// <returns></returns>

        public List<Customer> GetCustomerList()
        {
            return this.customerList;
        }


    }
}
