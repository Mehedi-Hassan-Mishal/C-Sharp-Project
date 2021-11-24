using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DigitalVotingSystem.Model;

namespace DigitalVotingSystem.Model
{
   
    class Candidate
    {
        //string obtainedvote;
        public int chng;
        public string obtainedvote,bnr;
        DBAccess dbobj = new DBAccess();
        public DataTable dtcandidate = new DataTable();
        
        public void Show()
        {
            string query = "Select * from CandidateList";
            dbobj.readDatathroughAdapter(query, dtcandidate);
        }
        public void ShowInVoteClass()
        {
            string query = "Select IdNumber,Name,Banner from CandidateList";
            dbobj.readDatathroughAdapter(query, dtcandidate);
        }
        public void Close()
        {
            dbobj.closeConn();
        }

        public void performOperation()
        {
            string query = "Select * from CandidateList";
            chng = dbobj.executeDataAdapter(dtcandidate, query);

        }
   
          public void Authentication()
          {
              string query = "Select * from CandidateList Where Banner='" +bnr+  "'";
              dbobj.readDatathroughAdapter(query, dtcandidate);

              if (dtcandidate.Rows.Count == 1)
              {
                  obtainedvote = dtcandidate.Rows[0]["obtained"].ToString(); 
                  dbobj.closeConn();
              }
              int x = (Int32.Parse(obtainedvote)) + 1;
              query = "Update CandidateList SET obtained='" + @x + "' where Banner='"+bnr+"'";
              SqlCommand updateCommand = new SqlCommand(query);
              updateCommand.Parameters.AddWithValue("@x",@x);
              int row = dbobj.executeQuery(updateCommand);

          }



    }
}
