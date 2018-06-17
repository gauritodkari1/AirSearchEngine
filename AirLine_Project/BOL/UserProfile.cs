using System;

namespace BOL
{
    public class UserProfile
    {
        #region  UserProfile Fields
        private int userId;
        private string userName;
        private string passward;
        private string firstName;
        private string lastName;
        private string mobileNo;
        private string emailId;
        private string gender;
        private string address;
        private string city;
        private string state;
        private string pinCode;
       
        #endregion

        #region  UserProfile Constructor
        public UserProfile()
        {

        }

       
        public UserProfile(int userId, string firstName )
        {

            this.userId = userId;
            this.firstName = firstName;
           
        }

        public UserProfile(int userId, string firstName,string lastName)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;

        }
        public UserProfile(int userId, string firstName, string lastName, string mobileNo)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;

        }

        public UserProfile(int userId, string firstName, string lastName, string mobileNo,string emailId)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.emailId = emailId;

        }
        public UserProfile(int userId, string firstName, string lastName, string mobileNo, string emailId, string gender)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.emailId = emailId;
            this.gender = gender;

        }

        public UserProfile(int userId, string firstName, string lastName, string mobileNo, string emailId, string gender,string address)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.emailId = emailId;
            this.gender = gender;
            this.address = address;

        }

        public UserProfile(int userId, string firstName, string lastName, string mobileNo, string emailId, string gender, string address,string city)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.emailId = emailId;
            this.gender = gender;
            this.address = address;
            this.city = city;

        }



        public UserProfile(int userId, string firstName, string lastName, string mobileNo, string emailId, string gender, string address, string city, string state)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.emailId = emailId;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.state = state;

        }
        public UserProfile(int userId, string firstName, string lastName, string mobileNo, string emailId, string gender,
          string address, string city, string state, string pinCode)
        {

            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNo = mobileNo;
            this.emailId = emailId;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.state = state;
            this.pinCode = pinCode;

        }
        #endregion

        #region  UserProfile Properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
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
        public string MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
        
             public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
       
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }
        public string UserName { get; set; }
        public string Passward { get; set; }
        #endregion

        #region  ToString method
        public override string ToString()
        {
            return string.Format(@"UserId:{0},First Name: {1}, Last Name: {2},MobileNo: {3}
           ,EmailId:{4},Gender :{5},Address: {6},City:{7},State:{8},PinCode:{9}", userId, firstName, lastName, mobileNo, emailId, gender,
            address, city, state, pinCode);
       }
        #endregion

    }
}
