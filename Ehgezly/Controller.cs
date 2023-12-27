using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Data.SqlTypes;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        string date;
        public Controller()
        {
            dbMan = new DBManager();
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable CheckAccountExist(string mail, string pass)
        {
            string query = "SELECT * FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckAccountAdmin(string mail, string pass)
        {
            string query = "SELECT * FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "'and Acc_ID LIKE '%A%';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckAccountPlayer(string mail, string pass)
        {
            string query = "SELECT * FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "'and Acc_ID LIKE '%P%';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckAccountTrainer(string mail, string pass)
        {
            string query = "SELECT * FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "'and Acc_ID LIKE '%TR%';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckAccountManager(string mail, string pass)
        {
            string query = "SELECT * FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "'and Acc_ID LIKE '%M%';";
            return dbMan.ExecuteReader(query);
        }
        public int RegisterPlayer(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
            string query1 = "SELECT COUNT(*) FROM Player";
            int x = Convert.ToInt32(dbMan.ExecuteScalar(query1)) + 1;
            string y = x.ToString();
            string query2 = "INSERT INTO Account " +
                            "Values ('P" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            string query3 = "INSERT INTO Player " +
                            "Values ('P" + y + "','N');";
            dbMan.ExecuteNonQuery(query2);
            return dbMan.ExecuteNonQuery(query3);
        }
        public int RegisterManager(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
            string query1 = "SELECT COUNT(*) FROM Account WHERE Acc_ID LIKE '%M%'";
            int x = Convert.ToInt32(dbMan.ExecuteScalar(query1)) + 1;
            string y = x.ToString();
            string query2 = "INSERT INTO Account " +
                            "Values ('M" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            return dbMan.ExecuteNonQuery(query2);
        }
        public int RegisterAdmin(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
            string query1 = "SELECT COUNT(*) FROM Account WHERE Acc_ID LIKE '%A%'";
            int x = Convert.ToInt32(dbMan.ExecuteScalar(query1)) + 1;
            string y = x.ToString();
            string query2 = "INSERT INTO Account " +
                            "Values ('A" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            return dbMan.ExecuteNonQuery(query2);
        }
        public int RegisterTrainer(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr, string sport_type)
        {
            string query1 = "SELECT COUNT(*) FROM Trainer";
            int x = Convert.ToInt32(dbMan.ExecuteScalar(query1)) + 1;
            string y = x.ToString();
            string query2 = "INSERT INTO Account " +
                            "Values ('TR" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            string query3 = "INSERT INTO Trainer " +
                            "Values ('TR" + y + "','" + sport_type + "','N');";
            dbMan.ExecuteNonQuery(query2);
            return dbMan.ExecuteNonQuery(query3);
        }

        //Player HomePage
        public DataTable SelectCourt(int ind)
        {
            if (ind == 0)
            {
                string query = "SELECT Court_Location FROM Courts Where Court_ID LIKE '%F%';";
                return dbMan.ExecuteReader(query);
            }
            else
            {
                string query = "SELECT Court_Location FROM Courts Where Court_ID LIKE '%Pd%';";
                return dbMan.ExecuteReader(query);
            }
        }

        public DataTable SelectCourtname(string loc)
        {
            string query = "SELECT * FROM Courts Where Court_Location = '" + loc + "';";
            return dbMan.ExecuteReader(query);
        }
        public int BookCourt(string email, string pass, string CID, string time)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query2 = "SELECT Count(*) FROM Bookings WHERE Booking_ID LIKE '%CB%' ;";
            int z = Convert.ToInt32(dbMan.ExecuteScalar(query2)) + 1;
            string y = z.ToString();

            string query3 = "INSERT INTO Bookings " +
                            "Values ('CB" + y + "','" + m + "','" + CID + "','" + time + "');";

            return dbMan.ExecuteNonQuery(query3);
        }

        public DataTable Selectavailabletrainers()
        {
            string query = "SELECT Fname ,Trainer_ID FROM Account,trainer where Booking_status='A'and ACC_id=Trainer_id;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTrainerComplaints()
        {
            string query = "SELECT Cmplnt_Id as ID,Complaint_Date as Date FROM Trainer_Complaints, Complaints WHERE Cmplnt_Id=Complaint_ID AND Review_status='N';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectSpecTrainerComplaints(string ID)
        {
            string query = $"SELECT Complaint_Date as ComplaintDate ,Book_ID as BookingID , Complaint_Details AS Details FROM Complaints WHERE Complaint_ID='{ID}';";
            return dbMan.ExecuteReader(query);
        }
        public int MarkTrainerComplaintReviewed(string ID)
        {
            string query = $"UPDATE Complaints SET Review_Status='A' WHERE Complaint_ID='{ID}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddAdminDetailsToComplaint(string comment, string ID)
        {
            string query1 = $"UPDATE Complaints SET Admin_Comment='{comment}' WHERE Complaint_ID='{ID}'";
            return dbMan.ExecuteNonQuery(query1);
            string query2 = $"UPDATE Complaints SET ReviewDate='{DateTime.Now}' WHERE Complaint_ID='{ID}'";
            return dbMan.ExecuteNonQuery(query2);
            string query3 = $"UPDATE Complaints SET complaint_Reviewer='{ID}' WHERE Complaint_ID='{ID}'";
            return dbMan.ExecuteNonQuery(query3);
        }

        public String GetID(String Email)
        {
            string query = $"SELECT Acc_ID FROM Account WHERE Email='{Email}'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        public int BookTrainingsession(string email, string pass, string CID, string time,string TID)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query2 = "SELECT Count(*) FROM Bookings WHERE Booking_ID LIKE '%TSB%' ;";
            int z = Convert.ToInt32(dbMan.ExecuteScalar(query2)) + 1;
            string y = z.ToString();

            string query3 = "INSERT INTO Bookings " +
                            "Values ('TSB" + y + "','" + m + "','" + CID + "','" + time + "');";


            string query4 = "SELECT Count(*) FROM Training_session ";
            int w = Convert.ToInt32(dbMan.ExecuteScalar(query4))+1;


            string query5 = "INSERT INTO Training_session " +
                            "Values ('TSB" + w+"','" + TID + "');";

            dbMan.ExecuteNonQuery(query3);
            return dbMan.ExecuteNonQuery(query5);
        }
        public int DeleteBookings(string booking_id)
        {
            if (booking_id.Contains("TS"))
            {
                string query1 = "DELETE FROM Training_Session WHERE Sess_ID='" + booking_id + "' ;";
                dbMan.ExecuteNonQuery(query1);
            }
                string query2 = "DELETE FROM Bookings WHERE Booking_ID='"+booking_id+"' ;";
            
            return dbMan.ExecuteNonQuery(query2);
        }
        public DataTable ViewAccountPlayer(string mail, string pass)
        {
            string query = "SELECT Fname,Lname,Email,Acc_Password,Phone_Number,Acc_ID FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "';";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateAccInfo(string Fname, string Lname,string Email,string Password,string Phone_Number,string emailcheck)
        {
            string query2="Update Account SET Fname='"+Fname+"',Lname='"+Lname+"', Email='"+Email+"', Acc_Password='"+Password+"', Phone_Number='"+Phone_Number+"'WHERE Email='"+emailcheck+"';";
            
            return Convert.ToInt32(dbMan.ExecuteNonQuery(query2));

        }
        public DataTable View_upcoming_boookings(string email,string pass)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query2 = "SELECT Booking_ID,Booking_timing,Court_Name FROM Courts as c,Bookings as b WHERE b.Plyr_Id='"+m+ "'and Booking_timing>'"+date+ "'and Court_ID=Crt_Id;";
            return dbMan.ExecuteReader(query2);
        }

    }
}

