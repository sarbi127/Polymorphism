using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_3
{

    /// <summary>
    /// 1.Create a ​class ​Person ​and give it the following ​private ​fields​:age, fName, lName, height, weight.
    /// Q1: Can access to the Variables because get and set are public
    /// </summary>
    class Person
    {
        private int age;
        public int Age
        {
            //get { return age; }
            //set { age = value; }
            get;
            set;
        }


        private string fName;
        public string FName
        {
            //get { return fName; }
            //set { fName = value; }
            get;
            set;
        }


        private string lName;
        public string LName
        {
            //get { return lName; }
            //set { lName = value; }
            get;
            set;
        }

        private double height;
        public double Height
        {
            //    get { return height; }
            //    set { height = value; }

            get;
            set;
        }
        private double weight;

        public double Weight
        {
            //get { return Weight; }
            //set { Weight = value; }

            get;
            set;
        }


    }
    /// <summary>
    ///2.handle our ​Person​-objects​
    /// </summary>
    class PersonHandler 
    {
        //create CreatePerson and set age, fname, lname, height, weight
        public Person CreatePerson(int age, string fname, string lname, double height, double weight​)
        {
            var person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

           // Console.WriteLine($" {person.Age},  {person.FName} , {person.LName}, {person.Height}, {person.Weight}  ");
            return (person);
        }

        //public Person GetPerson(​)
        //{
            
        //    var person = new Person();
        //    //return $" {person.Age},  {person.FName} , {person.LName}, {person.Height}, {person.Weight} ";
        //}

        //set person age
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;

        }

        //set person name
        public void SetName(Person pers,string fname, string lname)
        {
           
            pers.FName = fname;
            pers.LName = lname;

        }
        // set person weight
        public void SetWeight(Person pers,double weight)
        {
        
            pers.Weight = weight;

        }

        // set person hight
        public void SetHight(Person pers, double height)
        {
            pers.Height = height;


        }



    }





}
