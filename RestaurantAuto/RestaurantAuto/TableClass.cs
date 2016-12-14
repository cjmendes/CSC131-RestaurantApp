using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAuto
{
    /// <summary>
    /// Creates instance of a Table.
    /// </summary>
    public partial class Table
    {

        private int id;             //table id
        private int capacity;       //amount of chairs
        private string status;      //status of string (can only be "Empty", "Occupied", "Reserved")   
        private string waiterID;    //waiter assigned for that table
        private string rotation;

        /********************************************
         ***            CONSTRUCTORS              ***
         ********************************************/

        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        public Table()      
        {
            id = 0;
            capacity = 0;
            status = "Empty";
            waiterID = "0";
            rotation = "normal";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="capacity">The capacity.</param>
        /// <param name="rotation">The rotation.</param>
        public Table(int id, int capacity, string rotation)      
        {
            this.id = id; 
            this.capacity = capacity;
            status = "Empty";
            waiterID = "0";
            this.rotation = rotation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="capacity">The capacity.</param>
        /// <param name="status">The status.</param>
        /// <param name="waiterID">The waiter identifier.</param>
        /// <param name="rotation">The rotation.</param>
        public Table(int id, int capacity, string status, string waiterID, string rotation)
        {
            this.id = id;
            this.capacity = capacity;
            this.status = status;
            this.waiterID = waiterID;
            this.rotation = rotation;
        }

        /********************************************
         ***              FUNCTION                ***
         ********************************************/

        //////////    SET FUNCTIONS    //////////

        /// <summary>
        /// Sets the capacity.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public void setCapacity (int capacity)
        {
            this.capacity = capacity;
        }

        /// <summary>
        /// Sets the status.
        /// </summary>
        /// <param name="status">The status.</param>
        public void setStatus (string status)   
        {
            this.status = status;
        }

        /// <summary>
        /// Sets the waiter identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void setWaiterID (string id)
        {
            waiterID = id;
        }

        //////////    GET FUNCTIONS    //////////

        /// <summary>
        /// Gets the table number.
        /// </summary>
        /// <returns>Returns int of table number.</returns>
        public int getTableNum()
        {
            return id;
        }

        /// <summary>
        /// Gets the table capacity.
        /// </summary>
        /// <returns>Returns number (int) of table capacity.</returns>
        public int getTableCapacity()
        {
            return capacity;
        }

        /// <summary>
        /// Gets the table status.
        /// </summary>
        /// <returns>Returns string of table status.</returns>
        public string getStatus()
        {
            return status;
        }

        /// <summary>
        /// Gets the waiter identifier.
        /// </summary>
        /// <returns>Returns string of waiter ID.</returns>
        public string getWaiterID()
        {
            return waiterID;
        }

        /// <summary>
        /// Gets the orientation of table.
        /// </summary>
        /// <returns>Returns string of orientation.</returns>
        public string getRotation()
        {
            return rotation;
        }

    }
}
