using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DigitalVotingSystem.Model
{
    class Voters
    {
        DBAccess objDbAccess = new DBAccess();
          public DataTable dtvoters = new DataTable();
         public int row,x,c,change;
        public static string name, email, vid, paaword, gender, address,VoatingStatus;
        public void INSERT(string userName, string userEmail, string userVoterId,string userPassword, string userGender, string userAddress)
        {
            string query = "Insert into Voters(Name,Email,VoterID,Password,Gender,Address) values(@userName,@userEmail,@userVoterId,@userPassword,@userGender,@userAddress)";
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@userName", userName);
            insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
            insertCommand.Parameters.AddWithValue("@userVoterId", userVoterId);
            insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
            insertCommand.Parameters.AddWithValue("@userGender", userGender);
            insertCommand.Parameters.AddWithValue("@userAddress", userAddress);
            
            row = objDbAccess.executeQuery(insertCommand);
        }

        public void Authentication(string username , string password)
        {
            string query = "Select * from Voters Where Name ='"+username+"' AND Password='"+password+"'";
            objDbAccess.readDatathroughAdapter(query, dtvoters);

            if (dtvoters.Rows.Count == 1)
            {
                name = dtvoters.Rows[0]["Name"].ToString();
                email= dtvoters.Rows[0]["Email"].ToString();
                vid= dtvoters.Rows[0]["VoterID"].ToString();
                paaword= dtvoters.Rows[0]["Password"].ToString();
                gender= dtvoters.Rows[0]["Gender"].ToString();
                address= dtvoters.Rows[0]["Address"].ToString();
                VoatingStatus = dtvoters.Rows[0]["VotingStatus"].ToString();

                x = 1;
                objDbAccess.closeConn();
            }
          
            
        }

        public void list() 
        {
            string Query = "Select * from Voters";
            objDbAccess.readDatathroughAdapter(Query,dtvoters);
           
        }
        public void close()
        {
            objDbAccess.closeConn();
        }

        public void Perform_Operation()
        {
            string Query = "Select * from Voters";
            change = objDbAccess.executeDataAdapter(dtvoters,Query);
              
        }
        public void changeVotingStatus()
        {
            VoatingStatus = "1";
            string query = "Update Voters SET VotingStatus='" + @VoatingStatus + "'where Name ='" + Voters.name + "' AND VoterID='" + Voters.vid + "'";
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.AddWithValue("@VoatingStatus",@VoatingStatus);
            int row = objDbAccess.executeQuery(updateCommand);
            
            Console.WriteLine(name);
        }

    }
}
