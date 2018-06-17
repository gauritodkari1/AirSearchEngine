using System;
using System.Collections.Generic;
using AirSearch.Business;
using AirSearch.Common;
using MySql.Data.MySqlClient;

namespace AirSearch.DataAccess
{

    public class BookingInfoDal : DalBase
    {
        public bool Insert(BookingInfo bookinginfo)
        {
            bool status;

            try
            {
                using (var con = new MySqlConnection(connectionString))
                {


                    string query = "INSERT INTO bookingInfo(BookingId,TripId,UserId,BookingDate) " +
                        "VALUES (@bookingId,@tripId,@userId,@bookingDate)";

                    var sqlCommand = new MySqlCommand(query, con);
                    sqlCommand.Parameters.Add(new MySqlParameter("@bookingId", bookinginfo.BookingId));
                    sqlCommand.Parameters.Add(new MySqlParameter("@tripId", bookinginfo.TripId));
                    sqlCommand.Parameters.Add(new MySqlParameter("@userId", bookinginfo.UserId));
                    sqlCommand.Parameters.Add(new MySqlParameter("@bookingDate", bookinginfo.BookingDate));


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

        public static List<BookingInfo> GetAll()
        {
            List<BookingInfo> bookingInfos = new List<BookingInfo>();
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM  bookingInfo";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                BookingInfo bookingInfo = new BookingInfo()
                                {
                                    BookingId = int.Parse(reader["bookingId"].ToString()),
                                    TripId = int.Parse(reader["tId"].ToString()),
                                    UserId = int.Parse(reader["userId"].ToString()),
                                    BookingDate = DateTime.Parse(reader["bookingDate"].ToString()),

                                };
                                bookingInfos.Add(bookingInfo);
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

            return bookingInfos;
        }

        public static BookingInfo Get(int bookingId)
        {
            BookingInfo bookingInfo = null;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM bookingInfo WHERE bookingId=@bookingId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@bookingId", bookingId));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                bookingInfo = new BookingInfo()
                                {
                                    BookingId = int.Parse(reader["bookingId"].ToString()),
                                    TripId = int.Parse(reader["tId"].ToString()),
                                    UserId = int.Parse(reader["userId"].ToString()),
                                    BookingDate = DateTime.Parse(reader["bookingDate"].ToString())

                                };
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
            return bookingInfo;
        }

        public static bool Delete(int bookingId)
        {
            bool status;
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {

                    string query = "DELETE FROM bookingInfo WHERE bookingId=@bookingId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@bookingId", bookingId));
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

    }
}

