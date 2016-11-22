using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAuto
{
    //Class table
    class Table
    {
        /// <summary>
        ///CLASS VARIABLES
        /// </summary>
        private int id;          //table id
        private int capcity;    //amount of chairs
        private bool active;    //activity status (if choosen on screen)
        private string status;   //status of string (can only be "empty", "busy", "booked")   
        private int waiterID;   //waiter assigned for that table

        // CONSTRUSCTORS
        public Table()      //Empty constructor
        {
            id = 0;
            capcity = 0;
            active = false;
            status = "empty";
            waiterID = 0;
        }

        public Table(int id, int capasity)      //Initial constructor for initializing at the begining of the day
        {
            this.id = id; 
            this.capcity = capasity;
            active = false;
            status = "empty";
            waiterID = 0;
        }

        public Table(int id, int capasity, string status, int waiterID )      //Contructor for intializing after system shutdown from some file
        {
            id = 0;
            capcity = 0;
            active = false;
            this.status = status;
            this.waiterID = waiterID;
        }

        /////////////FUNCTIONS//////////////////////////
        /////////////FUNCTIONS/////////////////////////

        ////////////Set Functions//////////////////

        public void setCapasity (int n) //changes number of chairs
        {
            capcity = n;
        }

        public void setStatus (string st)   ///assignes (changes) status of table
        {
            status = st;
        }

        public void setWaiterID (int i) ///assignes (change WaiterID) for table
        { waiterID = i; }

        public void setActive (bool a)  //// sets activity status (true only when table is chosen on screen)
        { active = a; }


        //////////////GET FUNTIONS//////////////////







    }
}
