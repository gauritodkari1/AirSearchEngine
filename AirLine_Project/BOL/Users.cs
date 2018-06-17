using System;
using System.Collections.Generic;
using System.Text;


namespace BOL
{
    class Users
    {
        string userName;
        string passward;
        string role;
      

        public string UserName { get; set; }
        public string Passward { get; set; }
        public string Role{ get; set; }


        public UserProfile UserId { get; set; }

    }
}
