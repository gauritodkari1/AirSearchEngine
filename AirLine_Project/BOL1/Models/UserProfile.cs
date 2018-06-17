using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSearch.Business.Models;

namespace AirSearch.Business
{
    public class UserProfile : BaseModel
    {
        #region  UserProfile Field
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
        #endregion

        #region  UserProfile Properties
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId{get;set;}
        public string Gender{get;set;}
        public string Address{get;set;}
        public string City{get;set;}
        public string State{get;set;}
        public string PinCode{get;set;}
        public string UserName{get;set;}
        public string Passward{get;set;}
        #endregion

        #region  ToString method
        public override string ToString()
        {
            return string.Format(@"UserId:{0},UserName:{1},Password:{2},First Name: {3}, Last Name: {4},MobileNo: {5}
           ,EmailId:{6},Gender :{7},Address: {8},City:{9},State:{10},PinCode:{11}", userId,userName,passward,firstName, lastName, mobileNo, emailId, gender,
            address, city, state, pinCode);
        }
        #endregion
    }
}
