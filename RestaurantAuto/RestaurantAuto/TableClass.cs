using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAuto
{
    public partial class Table
    {
        /// <summary>
        ///CLASS VARIABLES
        /// </summary>
        private int id;             //table id
        private int capacity;       //amount of chairs
        private string status;      //status of string (can only be "Empty", "Occupied", "Reserved")   
        private string waiterID;    //waiter assigned for that table

        /********************************************
         ***            CONSTRUCTORS              ***
         ********************************************/

        // Empty constructor
        public Table()      
        {
            id = 0;
            capacity = 0;
            status = "Empty";
            waiterID = "0";
        }

        // Initial constructor for initializing at the begining of the day
        public Table(int id, int capacity)      
        {
            this.id = id; 
            this.capacity = capacity;
            status = "Empty";
            waiterID = "0";
        }

        // Contructor for intializing after system shutdown from some file
        public Table(int id, int capacity, string status, string waiterID )
        {
            id = 0;
            capacity = 0;
            this.status = status;
            this.waiterID = waiterID;
        }

        /********************************************
         ***              FUNCTION                ***
         ********************************************/

        //////////    SET FUNCTIONS    //////////

        // Changes the number of chairs
        public void setCapacity (int n)
        {
            capacity = n;
        }

        // Changes the status of the table
        public void setStatus (string st)   
        {
            status = st;
        }

        // Changes the waiter ID for the table
        public void setWaiterID (string i)
        {
            waiterID = i;
        }

        //////////    GET FUNCTIONS    //////////

        // Returns the table number
        public int getTableNum()
        {
            return id;
        }

        // Returns the table status
        public string getStatus()
        {
            return status;
        }

        // Returns the waiter ID
        public string getWaiterID()
        {
            return waiterID;
        }

    }
}
