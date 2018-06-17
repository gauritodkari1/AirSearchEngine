using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL1
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
        
        #endregion

        #region Properties 

        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        #endregion
        #region Tostring method
        public override string ToString()
        {
            return string.Format(@"PassangerId:{0},First Name: {1}, Last Name: {2},Age:{3},MobileNo: {4},", passengerId, firstName, lastName, age, mobileNo);
        }
        #endregion

    }
}

