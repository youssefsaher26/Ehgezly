using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Data.SqlTypes;
using System.Collections;
using Ehgezly;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        public DataTable SelectCourtComplaints()
        {
            string query = "SELECT Cmplnt_Id as ID,Complaint_Date as Date FROM Court_Complaints , Complaints WHERE Cmplnt_Id=Complaint_ID AND Review_status='N';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectSpecTrainerComplaints(string ID)
        {
            string query = $"SELECT Complaint_Date as ComplaintDate ,Book_ID as BookingID , Complaint_Details AS Details FROM Complaints WHERE Complaint_ID='{ID}';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectSpecCourtComplaints(string ID)
        {
            string query = $"SELECT Complaint_Date as ComplaintDate ,Book_ID as BookingID , Complaint_Details AS Details FROM Complaints WHERE Complaint_ID='{ID}';";
            return dbMan.ExecuteReader(query);
        }
        public int MarkComplaintReviewed(string ID)
        {
            string query = $"UPDATE Complaints SET Review_Status='R' WHERE Complaint_ID='{ID}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddReviewerDetailsToComplaint(string comment, string ID)
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
        public DataTable SelectOldPlayerCourtBookings(string ID)
        {
            string query = $"SELECT  Booking_ID as Booking_ID ,Booking_timing , Court_Location FROM Bookings," +
                $"Courts WHERE Plyr_Id='{ID}' AND Court_ID=Crt_Id";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectOldPlayertrainingSession(string ID)
        {
            string query = $"SELECT  Booking_ID as Booking_ID, Booking_timing as Timing, Court_Location as Location" +
                $" , Fname TrainerFirstName,Lname as  TrainerLastName FROM Bookings as B ,Courts as C ,Trainer as T," +
                $"Account as A, Training_Session as TT WHERE Plyr_Id='{ID}' AND C.Court_ID=B.Crt_Id AND TT.Trnr_ID=T.Trainer_ID AND T.Trainer_ID=A.Acc_ID";
            return dbMan.ExecuteReader(query);
        
        }
        public DataTable SelectOldTrainertrainingSession(string ID)
        {
            string query = $"SELECT Booking_ID, Booking_timing as Timing, Court_Id as CourtID , Court_Location as Location  , Fname as PlayerFirstName,Lname as  PlayerLastName FROM Bookings as B ,Courts as C ,Trainer as T,Account as A, Training_Session as TT WHERE T.Trainer_ID='{ID}' AND C.Court_ID=B.Crt_Id AND TT.Trnr_ID=T.Trainer_ID AND B.Plyr_Id=A.Acc_ID AND B.Booking_ID=TT.Sess_ID";
            return dbMan.ExecuteReader(query);

        }
        public DataTable SelectOldmaintenanceBookings(string ID)
        {
            string query = $"SELECT  Request_ID , Request_Date , Maintenance_Date  ,Court_Name FROM Maintenance_Requests as MN ,Courts as C WHERE C.Manager_ID='{ID}' AND C.Court_ID=MN.court_ID ";
            return dbMan.ExecuteReader(query);

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
        public string AddRating(int rate, string BookID,string ReviewerID)
        {
            string Q = "SELECT MAX(Review_ID) from Reviews";
            string maxIDexists=Convert.ToString(dbMan.ExecuteScalar(Q));
                string maxno = null;
            string ID=null;


            if (maxIDexists.Contains('T') || maxIDexists.Contains('C')) { maxno = Convert.ToString(maxIDexists.Substring(4)); }
            else if (maxIDexists.Contains('M')) { maxno = Convert.ToString(maxIDexists.Substring(5)); }
            if (BookID.Contains('T'))
            {

                ID = "TREV" + Convert.ToString(Convert.ToInt16(maxno) + 1);


            }
            else if (BookID.Contains('C'))
            {

                ID = "CREV" + Convert.ToString(Convert.ToInt16(maxno) + 1);
            }
            else if (BookID.Contains('M'))
            {

                ID = "MnREV" + Convert.ToString(Convert.ToInt16(maxno) + 1);
            }
            string query = $"INSERT INTO Reviews VALUES('{ID}','{date}','{ReviewerID}',{rate},null)  ";
          int  test = dbMan.ExecuteNonQuery(query);
            if (test == 0)
            {
                MessageBox.Show("falied to add the review");
            }
            else
            {
                MessageBox.Show("Review Added");
            }
            return ID;


        }
        public int AddCourtReview(string RevID, string Crt_ID)
        {

             string  query = $"INSERT INTO Court_Reviews VALUES Rev_ID={RevID},Crt_ID='{Crt_ID}'";
             return dbMan.ExecuteNonQuery(query);

        }
        public int AddTrainerReview(string RevID, string trainer_id)
        {

            string query = $"INSERT INTO Trainer_Reviews VALUES Rev_ID={RevID},Trnr_ID='{trainer_id}'";
            return dbMan.ExecuteNonQuery(query);

        }
        public int AddMaintenanceReview(string RevID, string MW)
        {

            String query = $"INSERT INTO Maintenance_Reviews VALUES Rev_ID={RevID},MW_ID='{MW}'";
            return dbMan.ExecuteNonQuery(query);

        }
        public int AddCommentToReview(string RevID,string comment)

        {
          
           string query = $"Update  Reviews SET Comment='{comment}' WHERE Review_ID='{RevID}'"; 
                
                
              return  dbMan.ExecuteNonQuery(query);
         
           

        }
        public string GetCourtIDfromBooking(string Bookid) {

            string query = $"SELECT Crt_Id FROM Bookings WHERE Booking_ID='{Bookid}' ";
            return Convert.ToString(dbMan.ExecuteScalar(query));

        }
        public string GetTrainerIDfromTrainingSession(string Bookid)
        {

            string query = $"SELECT Trnr_ID FROM Training_session WHERE Sess_ID='{Bookid}' ";
            return Convert.ToString(dbMan.ExecuteScalar(query));

        }
        public DataTable View_upcoming_boookings(string email,string pass)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query2 = "SELECT Booking_ID,Booking_timing,Court_Name FROM Courts as c,Bookings as b WHERE b.Plyr_Id='"+m+ "'and Booking_timing>'"+date+ "'and Court_ID=Crt_Id;";
            return dbMan.ExecuteReader(query2);
        }
        //public string GetMaintenanceID(string Bookid)
        //{

        //    string query = $"SELECT Trnr_ID FROM Training_session WHERE Sess_ID='{Bookid}' ";
        //    return Convert.ToString(dbMan.ExecuteScalar(query));

        //}


        public DataTable ViewUpcomingTournaments()
        {
            string query = "SELECT Tournamnet_name,Court_Location,Timing FROM Tournament,Courts where Timing >'"+date+"' and Crt_ID= Court_ID;";
            return dbMan.ExecuteReader(query);
        }

        public int AddPlayertoTournmaent(string name, string C,  string date )
        {
            string query1 = "SELECT Court_ID FROM Courts WHERE ;";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query2 = "SELECT Count(*) FROM Tournament;";
            int z = Convert.ToInt32(dbMan.ExecuteScalar(query2)) + 1;
            string y = z.ToString();

            string query = "INSERT INTO Tournament " +
                            "Values ('TOUR" + y + "','" + name  + "','" + m + "','" + date + "');";
            return dbMan.ExecuteNonQuery(query);

        }

    }
    }

