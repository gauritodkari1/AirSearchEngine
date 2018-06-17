using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AirSearch.Business;
using MySql.Data.MySqlClient;
using AirSearch.Common;

namespace AirSearch.DataAccess
{
    public class TripInfoDal : DalBase
    {       
        public static bool Insert(TripInfo tripInfo)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                 string query = "INSERT INTO tripInfo(tId,source,destination,arrDateTime,depDateTime,avalSeats,fare) " +
                        "VALUES (@tId,@source,@destination,@arrDateTime,@depDateTime,@avalSeats,@fare)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@tId", tripInfo.TripId));
                    cmd.Parameters.Add(new MySqlParameter("@source", tripInfo.Source));
                    cmd.Parameters.Add(new MySqlParameter("@destination", tripInfo.Destination));
                    cmd.Parameters.Add(new MySqlParameter("@arrDateTime", tripInfo.ArrivalDateTime));
                    cmd.Parameters.Add(new MySqlParameter("@depDateTime", tripInfo.DepartureDateTime));
                    cmd.Parameters.Add(new MySqlParameter("@avalSeats", tripInfo.AvailableSeats));
                    cmd.Parameters.Add(new MySqlParameter("@fare", tripInfo.Fare));
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception("Error while connecting with database, please contact site admin for more detail.");
            }
            return status;
        }

        public static bool Update(TripInfo tripInfo)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE tripInfo SET source=@source,destination=@destination,arrDateTime=@arrDateTime,depDateTime=@depDateTime,avalSeats=@avalSeats,fare=@fare" +
                        "WHERE tId=@tId";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@tId", tripInfo.TripId));
                    cmd.Parameters.Add(new MySqlParameter("@source", tripInfo.Source));
                    cmd.Parameters.Add(new MySqlParameter("@destination", tripInfo.Destination));
                    cmd.Parameters.Add(new MySqlParameter("@arrDateTime", tripInfo.ArrivalDateTime));
                    cmd.Parameters.Add(new MySqlParameter("@depDateTime", tripInfo.DepartureDateTime));
                    cmd.Parameters.Add(new MySqlParameter("@avalSeats", tripInfo.AvailableSeats));
                    cmd.Parameters.Add(new MySqlParameter("@fare", tripInfo.Fare));
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception("Error while connecting with database, please contact site admin for more detail.");
            }

            return status;
        }

        public static bool Delete(int tId)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM tripInfo  WHERE tId=@tId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@tId", tId));
                    cmd.ExecuteNonQuery();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception("Error while connecting with database, please contact site admin for more detail.");
            }

            return status;
        }

        public static List<TripInfo> GetAll()
        {
         List<TripInfo> tripInfos = new List<TripInfo>();
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tripInfo";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TripInfo tripInfo = new TripInfo()
                                {
                                    TripId = int.Parse(reader["tId"].ToString()),
                                    Source = reader["source"].ToString(),
                                    Destination = reader["destination"].ToString(),
                                    ArrivalDateTime = DateTime.Parse(reader["arrDateTime"].ToString()),
                                    DepartureDateTime = DateTime.Parse(reader["depDateTime"].ToString()),
                                    AvailableSeats = int.Parse(reader["avalSeats"].ToString()),
                                    Fare = decimal.Parse(reader["fare"].ToString())

                                };
                                tripInfos.Add(tripInfo);
                            }
                            reader.Close();
                        }
                    }
                   

                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception("Error while connecting with database, please contact site admin for more detail.");
            }

            return tripInfos;
        }




        public static List<TripInfo> GetListByDateSourceDest(string Source,string Destination,DateTime ArrivalDateTime)
        {
         List<TripInfo> tripInfos = new List<TripInfo>();
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tripInfo WHERE source=@Source AND destination=@Destination AND arrDateTime=@ArrivalDateTime";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TripInfo tripInfo = new TripInfo()
                                {
                                    TripId = int.Parse(reader["tId"].ToString()),
                                    Source = reader["source"].ToString(),
                                    Destination = reader["destination"].ToString(),
                                    ArrivalDateTime= DateTime.Parse(reader["arrDateTime"].ToString()),
                                    DepartureDateTime = DateTime.Parse(reader["depDateTime"].ToString()),
                                    AvailableSeats = int.Parse(reader["avalSeats"].ToString()),
                                    Fare = decimal.Parse(reader["fare"].ToString())

                                };
                                tripInfos.Add(tripInfo);
                            }
                            reader.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception("Error while connecting with database, please contact site admin for more detail.");
            }

            return tripInfos;
        }
    }
}

