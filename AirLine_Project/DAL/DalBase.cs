using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSearch.DataAccess
{
    public abstract class DalBase
    {
        internal static string connectionString;

        public DalBase()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AirlineDbConnectionString"].ConnectionString;
        }

        public virtual bool Create()
        {
            // Intentionally left empty as it will be override by derived classes.
            throw new NotImplementedException();
        }
    }
}