using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AirSearch.Business;
using AirSearch.Business.Models;
using AirSearch.Common;
using MySql.Data.MySqlClient;

namespace AirSearch.DataAccess
{
    public class FlightsDal : DalBase
    {       
        public static bool Insert(Flights flight)
        {
            bool status;

            try
            {
                using (var mySqlConnection = new MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();

                    string query = "INSERT INTO flights (flightId,flightName,capacity) " +
                        "VALUES (@flightId,@flightName,@capacity)";

                    var sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.Add(new MySqlParameter("@flightId", flight.FlightId));
                    sqlCommand.Parameters.Add(new MySqlParameter("@flightName", flight.FlightName));
                    sqlCommand.Parameters.Add(new MySqlParameter("@capacity", flight.Capacity));

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

        public static bool Update(Flights flight)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    
                    string query = "UPDATE flights SET flightName=@flightName,capacity=@capacity " +
                        "WHERE flightId=@flightId";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@flightId", flight.FlightId));
                    cmd.Parameters.Add(new MySqlParameter("@flightName", flight.FlightName));
                    cmd.Parameters.Add(new MySqlParameter("@capacity", flight.Capacity));
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return status;
        }

        public static bool Delete(int flightId)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    
                    string query = "DELETE FROM flights WHERE flightId=@flightId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@flightId", flightId));
                    cmd.ExecuteNonQuery();
                    
                    status = true;
                }
            }
            catch (Exception ex)
            { throw ex; }

            return status;
        }

        public static Flights Get(int flightId)
        {
            Flights flight = null;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    
                    string query = "SELECT * FROM flights WHERE flightId=@flightId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@flightId", flightId));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                flight = new Flights()
                                {
                                    FlightId = int.Parse(reader["flightId"].ToString()),
                                    FlightName = reader["flightName"].ToString(),
                                    Capacity = int.Parse(reader["capacity"].ToString())

                                };
                            }
                            reader.Close();
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            { throw ex; }
            return flight;
        }

        public static List<Flights> GetAll()
        {
            List<Flights> flights = new List<Flights>();
            try
            {
                using ( var con = new MySqlConnection(connectionString))
                {
                    
                    string query = "SELECT * FROM  flights";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Flights flight = new Flights()
                                {
                                    FlightId = int.Parse(reader["flightId"].ToString()),
                                    FlightName = reader["flightName"].ToString(),
                                    Capacity = int.Parse(reader["capacity"].ToString())

                                };
                                flights.Add(flight);
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

            return flights;
        }
    }
}

