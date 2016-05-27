using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        #region Fields
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;
        #endregion

        #region Properties

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**
         * This is a property for our _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }

        }

        #endregion
        /**
         * This is the default empty constructor for the Person class
        * 
        * @constructor Person
        */
        public Person()
        {
            this._name = "Tom";
        }

        /**
        * This is a consructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * 
         * @constructor Person
         * @param {string} name
         */

        public Person(string _name)
        {
            this._name = _name;
        }

        public static void SayHello()
        {
            /*SayHello - this method should print the private name value and then "says hello" to the console.
   *  (e.g. if the private name value is "Tom" then when the SayHello method is called it should output "Tom says hello" to the console).*/
        }
    }
}
