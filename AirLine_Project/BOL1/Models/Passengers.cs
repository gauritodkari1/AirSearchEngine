using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSearch.Business
{
    class Passengers
    {
        #region Passengers Field
        private int passengerId;
        private string firstName;
        private string lastName;
        private string mobileNo;
        private string adharNo;
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
        public int AdharNo { get; set; }
        public string MobileNo { get; set; }
        #endregion
        #region Tostring method
        public override string ToString()
        {
            return string.Format(@"PassangerId:{0},First Name: {1}, Last Name: {2},Adhhar number:{3},MobileNo: {4},", passengerId, firstName, lastName, adharNo, mobileNo);
        }
        #endregion
    }
}

