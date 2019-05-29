using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HypeTeam_ProjectTele.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter your Username.")]
        [Display(Name = "Username: ")]
        public string userID { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your Password.")]
        [Display(Name = "Password: ")]
        public string password { get; set; }

        public string username { get; set; }

        //This method validates the Login credentials
        public String LoginProcess(String strUsername, String strPassword)
        {
            String message = "";
            //my connection string
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Users where userID=@username", con);
            cmd.Parameters.AddWithValue("@username", strUsername);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Boolean login = (strPassword.Equals(reader["password"].ToString(), StringComparison.InvariantCulture)) ? true : false;
                    if (login)
                    {
                        message = "1";
                        username = reader["username"].ToString();

                    }
                    else
                        message = "Invalid Credentials";
                }
                else
                    message = "Invalid Credentials";

                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString() + "Error.";

            }
            return message;
        }
    }
}