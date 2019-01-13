using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Models
{
    public class Account
    {
        public Int64 DiscordID { get; set; }
        public string OldschoolName { get; set; }
        public string Rs3Name { get; set; }

        public Account(Int64 DiscordID) {
            this.DiscordID = DiscordID;
        }

        public Account Get(Int64 DiscordID)
        {
            Account result = new Account(DiscordID);
            
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OSRSTrackerConnection"].ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("Account_Merge", connection) {
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.Add(new SqlParameter("DiscordID", System.Data.SqlDbType.BigInt) { Value = DiscordID });

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read()) {

                                result.DiscordID = reader.GetInt32(0);
                                result.OldschoolName = reader.GetString(1);
                                result.Rs3Name = reader.GetString(2);
                            }
                        }
                    }
                }

                connection.Close();
            }

            return result;
        }

        public string ToResponse()
        {
            string result = "";

            result += '\n';
            result += "Old school username: " + (this.OldschoolName.Length != 0 ? this.OldschoolName : "Not assigned") + '\n';
            result += "Runescape 3 username: " + (this.Rs3Name.Length != 0 ? this.Rs3Name : "Not assigned");

            return result;
        }
    }
}
