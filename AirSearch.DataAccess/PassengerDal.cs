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
    class PassengerDal : DalBase
    {
        public static bool Insert(Passengers passanger)
        {

            bool status;
            try
            {

                using (var mySqlConnection = new MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();

                    string query = "INSERT passengers (passengerId,firstName,lastName,mobileNo,adharNo) " +
                                   "VALUES (@passengerId,@firstName,@lastName,,@mobileNo,@adharNo)";

                    var sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.Add(new MySqlParameter("@passengerId", passanger.PassengerId));
                    sqlCommand.Parameters.Add(new MySqlParameter("@firstName", passanger.FirstName));
                    sqlCommand.Parameters.Add(new MySqlParameter("@lastName", passanger.LastName));
                    sqlCommand.Parameters.Add(new MySqlParameter("@mobileNo", passanger.MobileNo));
                    sqlCommand.Parameters.Add(new MySqlParameter("@adharNo", passanger.AdharNo));
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

        public static bool Update(Passengers passanger)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "UPDATE passengers SET passengerId=@passengerId,firstName=@firstName,lastName=@lastName,mobileNo=@mobileNo " +
                        "WHERE adharNo=@adharNo";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@passangerId",passanger.PassengerId));
                    cmd.Parameters.Add(new MySqlParameter("@firstName",passanger.FirstName));
                    cmd.Parameters.Add(new MySqlParameter("@lastName", passanger.LastName));
                    cmd.Parameters.Add(new MySqlParameter("@mobileNo", passanger.MobileNo));
                    cmd.Parameters.Add(new MySqlParameter("@adharNo", passanger.AdharNo));
                    cmd.ExecuteNonQuery();

                    status = true;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return status;
        }

        public static bool Delete(int passangerId)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "DELETE FROM passengers WHERE passangerId=@passangerId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@passangerId", passangerId));
                    cmd.ExecuteNonQuery();

                    status = true;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return status;
        }

        public static Passengers Get(int passengerId)
        {
            Passengers passenger = null;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM passengers WHERE passengerId=@passengerId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@passengerId", passengerId));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                passenger = new Passengers()
                                {
                                    PassengerId= int.Parse(reader["passengerId"].ToString()),
                                    FirstName = reader["firstName"].ToString(),
                                    LastName = reader["lastName"].ToString(),
                                    MobileNo=reader["mobileNo"].ToString(),
                                    AdharNo = reader["adharNo "].ToString()
                                };
                            }
                            reader.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            { throw ex; }
            return passenger;
        }

        public static List<Passengers> GetAll()
        {
            List<Passengers> passaPassengerses = new List<Passengers>();
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM  passengers";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Passengers passenger = new Passengers()
                                {
                                    PassengerId = int.Parse(reader["passengerId"].ToString()),
                                    FirstName = reader["firstName"].ToString(),
                                    LastName = reader["lastName"].ToString(),
                                    MobileNo = reader["mobileNo"].ToString(),
                                    AdharNo = reader["adharNo "].ToString()

                                };
                                passaPassengerses.Add(passenger);
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



    



