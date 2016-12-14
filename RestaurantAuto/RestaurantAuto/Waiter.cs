using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAuto
{
    /// <summary>
    /// A class for a waiter.
    /// </summary>
    public partial class Waiter
    {
        private string id;          // Waiter ID
        private string firstname;   // First name of waiter
        private string lastname;    // Last name of waiter
        private bool status;        // Status of waiter 
        private bool admin;         // Admin status of waiter  

        /********************************************
         ***            CONSTRUCTORS              ***
         ********************************************/

        /// <summary>
        /// Initializes a new instance of the <see cref="Waiter"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        /// <param name="admin">if set to <c>true</c> [admin].</param>
        public Waiter(string id, string firstname, string lastname, bool status, bool admin)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.status = status;
            this.admin = admin;
        }

        /********************************************
         ***              FUNCTION                ***
         ********************************************/

        //////////    SET FUNCTIONS    //////////

        /// <summary>
        /// Changes the status of waiter.
        /// </summary>
        public void changeStatus()
        {
            if (status)
                status = false;
            else
                status = true;
        }

        //////////    GET FUNCTIONS    //////////

        /// <summary>
        /// Gets the waiter identifier (ID).
        /// </summary>
        /// <returns>Returns string of ID.</returns>
        public string getWaiterID()
        {
            return id;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <param name="waiterID">The waiter identifier (ID).</param>
        /// <returns>Returns string of first and last name.</returns>
        public string getName(string waiterID)
        {
            return firstname + ' ' + lastname;
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <returns>Returns string of first name.</returns>
        public string getFirstName()
        {
            return firstname;
        }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <returns>Returns string of last name.</returns>
        public string getLastName()
        {
            return lastname;
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns>Boolean of the status.</returns>
        public bool getStatus()
        {
            return status;
        }

        /// <summary>
        /// Gets the admin status.
        /// </summary>
        /// <returns>Boolean of the admin status.</returns>
        public bool getAdmin()
        {
            return admin;
        }
    }
}
