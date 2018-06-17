using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirSearch.Business.Models;
using AirSearch.Common;
using MySql.Data.MySqlClient;

namespace AirSearch.DataAccess
{
    class PassengerBookingDal:DalBase
    {
        public static bool Insert(PassengerBooking passengerBooking)
        {

            bool status;
            try
            {
                using (var mySqlConnection = new MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();

                    string query = "INSERT passengerBooking(bookingId,passengerId) " +
                                   "VALUES (@bookingId,@passengerId)";

                    var sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.Add(new MySqlParameter("@bookingId", passengerBooking.BookingId));
                    sqlCommand.Parameters.Add(new MySqlParameter("@passengerId", passengerBooking.PassangerId));
                    sqlCommand.ExecuteNonQuery();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception("Error while connecting with database, please contact site admin for more detail.");
            }
            finally
            {

            }

            return status;
        }

       
        public static PassengerBooking Get(int passengerId)
        {
            PassengerBooking passengerBooking = null;
            try
            {
               // string connectionString = null;
                using (var con = new MySqlConnection(connectionString))

                {


                    string query = "SELECT * FROM passengerBooking WHERE passengerId=@passengerId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@passengerId", passengerId));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                passengerBooking = new PassengerBooking()
                                {
                                    PassangerId = int.Parse(reader["passengerId"].ToString()),
                                   BookingId  = int.Parse(reader["firstName"].ToString())
                                   
                                };
                            }
                            reader.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            { throw ex; }
            return passengerBooking;
        }

        public static List<PassengerBooking> GetAll()
        {
            List<PassengerBooking> passaPassengerses = new List<PassengerBooking>();
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM  passengerBooking";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                PassengerBooking passengerbooking = new PassengerBooking()
                                {
                                    PassangerId= int.Parse(reader["passengerId"].ToString()),
                                    BookingId = int.Parse(reader["bookingId"].ToString())
                                };
                                passaPassengerses.Add(passengerbooking);
                            }
                            reader.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return passaPassengerses;
        }
    }
}
