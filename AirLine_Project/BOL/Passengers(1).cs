using System;
using System.Collections.Generic;
using System.Text;

namespace BOL
{
    class Passengers
    {
        #region Passengers Field
        private int passengerId;
        private string firstName;
        private string lastName;
        private int age;
        private string mobileNo;
        #endregion

        #region Constroctors 
        public Passengers()
        {
           
        }
        public Passengers(int passengerId, string firstName)
        {

            this.passengerId = passengerId;
            this.firstName = firstName;
        }

        public Passengers(int passengerId, string firstName, string lastName)
        {

            this.passengerId = passengerId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Passengers(int passengerId, string firstName, string lastName, int age)
        {

            this.passengerId = passengerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Passengers(int passengerId, string firstName, string lastName, int age, string mobileNo)
        {
            
            this.passengerId = passengerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.mobileNo = mobileNo;
        }
        #endregion

        #region Properties 

        public int PassengerId
        {
            get { return passengerId; }
            set { passengerId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
     
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
        #endregion
        #region Tostring method
        public override string ToString()
        {
            return string.Format(@"PassangerId:{0},First Name: {1}, Last Name: {2},Age:{3},MobileNo: {4},", passengerId, firstName, lastName, age, mobileNo);
        }
        #endregion




    }
}
