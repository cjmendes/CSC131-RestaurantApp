using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAuto
{
    public partial class Waiter
    {
        private string id;          // Waiter ID
        private string firstname;   // First name of waiter
        private string lastname;    // Last name of waiter
        private bool status;        // Status of waiter   

        /********************************************
         ***            CONSTRUCTORS              ***
         ********************************************/

        // Contructor for intializing a waiter
        public Waiter(string id, string firstname, string lastname, bool status)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.status = status;
        }

        /********************************************
         ***              FUNCTION                ***
         ********************************************/

        //////////    SET FUNCTIONS    //////////

        // Changes the status of the waiter
        public void changeStatus()
        {
            if (status)
                status = false;
            status = true;
        }

        //////////    GET FUNCTIONS    //////////

        // Returns the waiter ID
        public string getWaiterID()
        {
            return id;
        }

        // Returns the first and last name of the waiter
        public string getName(string waiterID)
        {
            return firstname + ' ' + lastname;
        }

        // Returns the first name of the waiter
        public string getFirstName()
        {
            return firstname;
        }

        // Returns the last name of the waiter
        public string getLastName()
        {
            return lastname;
        }

        // Returns the status of the waiters
        public bool getStatus()
        {
            return status;
        }
    }
}
