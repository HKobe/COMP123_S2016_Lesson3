using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    class Person
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
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        //Getters 
       // public string getName()
        //{
          //  return _name;
        //}
        //Setters
        //public void setName(string name)
        //{
        //   this._name = name;
       // }

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

        public Person(string name)
        {
            this._name = name;
        }

        public void SayHello()
        {
            Console.WriteLine(this._name + " says hello");
        }

        public void ShowAge()
        {
            Console.WriteLine(this._name + " is " +this._age + " years old.");//"Tom is 47 years old"
        }
    }
}
