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
        {;
            if(Convert.ToUInt16(dbMan.ExecuteScalar($"SELECT Count(Player_ID) from Player WHERE Email='{email}'"))!=0)
            {
                MessageBox.Show("Email is used for another user please use another one");
                return 0;

            }
            else if (Convert.ToUInt16(dbMan.ExecuteScalar($"SELECT Count(Player_ID) from Player WHERE Phone_Number='{phone_numbr}'")) != 0)
            {

                MessageBox.Show("Mobile Number is used for another user please use another one");
                return 0;


            }


            string query5 = "SELECT Count(Player_ID) from Player";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query1 = "SELECT MAX(Player_ID) FROM Player  GROUP BY Player_ID ORDER BY CAST(SUBSTRING(Player_ID, 2, LEN(Player_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query1);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(1)))
                + 1);
            string query2 = "INSERT INTO Account " +
                            "Values ('P" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            string query3 = "INSERT INTO Player " +
                            "Values ('P" + y + "','N');";
            dbMan.ExecuteNonQuery(query2);
            return dbMan.ExecuteNonQuery(query3);
        }
        public int RegisterManager(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
           


            string query5 = "SELECT Count(Acc_ID) from Account WHERE Acc_ID LIKE '%M%'";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query1 = "SELECT MAX(Acc_ID) FROM Account WHERE Acc_ID LIKE '%M%'  GROUP BY Acc_ID  ORDER BY CAST(SUBSTRING(Acc_ID, 2, LEN(Acc_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query1);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);

            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(1)))
                + 1);
            string query2 = "INSERT INTO Account " +
                            "Values ('M" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            return dbMan.ExecuteNonQuery(query2);
        }
        public int RegisterAdmin(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
       


            string query5 = "SELECT Count(Player_ID) from Tournament";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query1 = "SELECT MAX(Acc_ID) FROM Account WHERE Acc_ID LIKE '%A%'   GROUP BY Acc_ID  ORDER BY CAST(SUBSTRING(Acc_ID, 2, LEN(Acc_ID)) AS INT) ASC;";
            DataTable MaxTable = dbMan.ExecuteReader(query1);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);










            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(1)))
                + 1);
            string query2 = "INSERT INTO Account " +
                            "Values ('A" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            return dbMan.ExecuteNonQuery(query2);
        }
        public int RegisterTrainer(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr, string sport_type)
        {
            string query5 = "SELECT Count(Player_ID) from Tournament";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query1 = "SELECT Max(Trainer_ID) FROM Trainer  GROUP BY Trainer_ID   ORDER BY CAST(SUBSTRING(Trainer_ID, 2, LEN(Trainer_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query1);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(2)))
                + 1);
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
            int z = Convert.ToInt32(dbMan.ExecuteScalar(query2));
            string y = z.ToString();



            string query6 = "SELECT Max(Booking_ID) FROM Bookings WHERE Booking_ID LIKE '%CB%' GROUP BY Booking_ID   ORDER BY CAST(SUBSTRING(Booking_ID, 3, LEN(Booking_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query6);
            string maxidexists = Convert.ToString(MaxTable.Rows[z - 1][0]);
            string r = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(2)))
                + 1);
            string query3 = "INSERT INTO Bookings " +
                            "Values ('CB" + r + "','" + m + "','" + CID + "','" + time + "');";

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
                $"Courts WHERE Plyr_Id='{ID}' AND Court_ID=Crt_Id and Booking_ID LIKE '%C%';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectOldPlayertrainingSession(string ID)
        {
            string query = $" SELECT  Booking_ID as Booking_ID, Booking_timing as Timing, Court_Location as Location, Fname TrainerFirstName,Lname as  TrainerLastName FROM Bookings as B ,Courts as C ,Trainer as T,Account as A, Training_Session as TT WHERE Plyr_Id='{ID}' AND C.Court_ID=B.Crt_Id AND TT.Trnr_ID=T.Trainer_ID AND T.Trainer_ID=A.Acc_ID AND B.Booking_ID=TT.Sess_ID\r\n            ";
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

            string query5 = "SELECT Count(Booking_ID) from Bookings  WHERE Booking_ID LIKE '%TSB%'";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query8 = "SELECT Max(Booking_ID) FROM Bookings   WHERE Booking_ID LIKE '%TSB%' GROUP BY Booking_ID  ORDER BY CAST(SUBSTRING(Booking_ID, 4, LEN(Booking_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query8);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(3)))
                + 1);



            string query3 = "INSERT INTO Bookings " +
                            "Values ('TSB" + y + "','" + m + "','" + CID + "','" + time + "');";


            string query4 = "SELECT Max(Sess_ID) FROM Training_session ";
            string maxIDexists2 = Convert.ToString(dbMan.ExecuteScalar(query4));
            string w = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists2.Substring(3)))
                + 1);



            string query10 = "INSERT INTO Training_session " +
                            "Values ('TSB" + w + "','" + TID + "');";

            dbMan.ExecuteNonQuery(query3);
            return dbMan.ExecuteNonQuery(query10);








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
            string Q=null;
            int rowno=0;
            if (BookID.Contains('M'))
            {
                string query5 = "SELECT Count(Review_ID) from Reviews WHERE Review_ID LIKE  '%M%'";
                rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
                Q = "SELECT MAX(Review_ID) from Reviews WHERE Review_ID LIKE  '%M%'  GROUP BY Review_ID   ORDER BY CAST(SUBSTRING(Review_ID, 6, LEN(Review_ID)) AS INT) ASC";
            }
            else if (BookID.Contains('C'))
            {
                string query5 = "SELECT Count(Review_ID) from Reviews WHERE Review_ID LIKE '%C%'";
                rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
                Q = "SELECT MAX(Review_ID) from Reviews  WHERE Review_ID LIKE  '%C%' GROUP BY Review_ID ORDER BY CAST(SUBSTRING(Review_ID, 5, LEN(Review_ID)) AS INT) ASC"; }
            else if (BookID.Contains('T'))
            {
                string query5 = "SELECT Count(Review_ID) from Reviews WHERE Review_ID LIKE  '%T%'";
                rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
                Q = "SELECT MAX(Review_ID) from Reviews WHERE Review_ID LIKE  '%T%' GROUP BY Review_ID  ORDER BY CAST(SUBSTRING(Review_ID, 5, LEN(Review_ID)) AS INT) ASC";
            }


            DataTable MaxTable = dbMan.ExecuteReader(Q);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string maxno = null;
            string ID=null;
            string Q1 = $"SELECT Count(Review_ID) from Reviews WHERE Booking_ID={BookID}  ";
            int t = Convert.ToInt16(dbMan.ExecuteScalar(Q1));
            if (t != 0)
            {
                return null;
            }

            if (maxidexists.Contains('T') || maxidexists.Contains('C')) { maxno = Convert.ToString(maxidexists.Substring(4)); }
            else if (maxidexists.Contains('M')) { maxno = Convert.ToString(maxidexists.Substring(5)); }
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
            string query = "SELECT Tournament_ID,Tournament_name,Court_Location,Timing FROM Tournament,Courts where Timing >'" + date+"' and Crt_ID= Court_ID;";
            return dbMan.ExecuteReader(query);
        }

        public int AddPlayertoTournmaent(string tournament_id, string email, string pass)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query2 = "INSERT Players_Joined Values ('" + tournament_id + "','" + m + "');";

            return dbMan.ExecuteNonQuery(query2);

        }


        public int AddTrainertoTournmaent(string tournament_id, string email, string pass)
        {


            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();

            string query3 = "SELECT COUNT(Trnmnt_ID) FROM Trainers_Joined  WHERE Trnmnt_ID='" + tournament_id + "' AND Trnr_ID ='" + m + "';";
            if( Convert.ToInt16(dbMan.ExecuteScalar(query3))!=0)
            { MessageBox.Show("Can't Join , You already Joined this tournament");
                return 0;
            }

            string query2 = "INSERT Trainers_Joined Values ('" + tournament_id + "','" + m + "');";

            int test = dbMan.ExecuteNonQuery(query2);
            if (test<=0)
            {
                MessageBox.Show("Couldn't Join!");
                return 0; }
            else
            {
                MessageBox.Show("Joined Tournament Successfully!");
                return test; }

        }

        public string AddComplaint(string ComplaintMsg, string BookID, string ComplaintWriterID , string cptype)
        {
            string Q = null;
            if(cptype== "Trainer")
            {  Q = $"SELECT Trnr_ID from Bookings WHERE Booking_ID='{BookID}'"; }
            else
            { Q = $"SELECT Crt_Id from Bookings WHERE Booking_ID='{BookID}'"; }
            string Q2 = $"SELECT Count(Complaint_ID) from Complaints WHERE Booking_ID='{BookID}' AND Complaint_Details='{ComplaintMsg}'  ";
            int t = Convert.ToInt16(dbMan.ExecuteScalar(Q2));
            if (t != 0)
            {
                MessageBox.Show("Sorry, You can't write the same Complaint more than one time!");
                return null;
            }



            string ComplaintAboutID = Convert.ToString(dbMan.ExecuteScalar(Q));

            string query5 = null;
            int rowno = 0;

            string ID = null;


            if (ComplaintAboutID.Contains('T'))
            {
                 query5 = "SELECT Count(Complaint_ID) from Complaints WHERE Complaint_ID LIKE '%TCP%'";
                 rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
                string Q1 = "SELECT MAX(Complaint_ID) from Complaints  WHERE Complaint_ID LIKE '%TCP%'  GROUP BY Complaint_ID  ORDER BY CAST(SUBSTRING(Complaint_ID, 4, LEN(Complaint_ID)) AS INT) ASC";
                DataTable MaxTable = dbMan.ExecuteReader(Q1);
                string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
                string maxno = maxidexists.Substring(3);
                ID = "TCP" + Convert.ToString(Convert.ToInt16(maxno) + 1);



            }
            else if (ComplaintAboutID.Contains('P') || ComplaintAboutID.Contains('F') || ComplaintAboutID.Contains('C'))
            {
                query5 = "SELECT Count(Complaint_ID) from Complaints WHERE Complaint_ID LIKE '%CCP%'";
                rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
                string Q1 = "SELECT MAX(Complaint_ID) from Complaints  WHERE Complaint_ID LIKE '%CCP%'  GROUP BY Complaint_ID  ORDER BY CAST(SUBSTRING(Complaint_ID, 4, LEN(Complaint_ID)) AS INT) ASC";
                DataTable MaxTable = dbMan.ExecuteReader(Q1);
                string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
                string maxno = maxidexists.Substring(3);
                ID = "CCP" + Convert.ToString(Convert.ToInt16(maxno) + 1);
            }

            string query = $"INSERT INTO Complaints VALUES('{ID}',null,'{date}','{BookID}','N',null,'{ComplaintMsg}',null)  ";
            int test = dbMan.ExecuteNonQuery(query);



            if (test == 0)
            {
                MessageBox.Show("falied to Send the Complaint");
            }
            else
            {
                MessageBox.Show("Compalint Sent");
            }
            return ID;


        }


        public DataTable SelectMaintenanceWorkers(string Spec)
        {

            string query = $"SELECT  Maintenance_Worker_ID as ID, FName as  FirstName ,Lname as LastName , AVG(Reviewer_grade) as Rating FROM Maintenance as MN , Reviews as R , Maintenance_Reviews as MR WHERE MR.MW_Id=MN.Maintenance_Worker_ID AND R.Review_ID=MR.Rev_ID AND MN.Specialty='{Spec}' GROUP BY Maintenance_Worker_ID ,Lname,FName ";
            return dbMan.ExecuteReader(query);
        
        }

        public DataTable SelectSpecialty()
        {
            
            string query = "SELECT DISTINCT Specialty FROM Maintenance";
        return dbMan.ExecuteReader(query);


        }
        public DataTable ViewUpcomingTournaments2(string email, string pass)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();
            if (m.Contains("P"))
            {
                string query = "SELECT DISTINCT Trnmnt_ID, Tournament_name,Timing,Court_Name FROM Tournament, Players_Joined as p,Courts where p.Plyr_ID = '" + m + "' and Trnmnt_ID = Tournament_ID and Crt_ID = Court_ID and Timing >'" + date + "';";
                return dbMan.ExecuteReader(query);
            }
            else
            {
                string query = "SELECT DISTINCT Trnmnt_ID, Tournament_name,Timing,Court_Name FROM Tournament, Trainers_Joined as t,Courts where t.Trnr_ID = '" + m + "' and Trnmnt_ID = Tournament_ID and Crt_ID = Court_ID and Timing >'" + date + "';";
                return dbMan.ExecuteReader(query);
            }

        }

        public int AddMaintenanceRequest (string managerID, string workerID,DateTime maintenanceDate)
        {
            string query1 = $"SELECT COUNT() FROM Maintenance_Requests WHERE MW_ID='{workerID}', Maintenance_Date='{maintenanceDate.ToString("yyyy-MM-dd HH:mm:ss")}' ";
            if (Convert.ToInt16(dbMan.ExecuteScalar(query1))!=0) {
                MessageBox.Show("Sorry this worker is booked, Please choose another date or another worker");
                return 0;
            }
            else if (maintenanceDate<DateTime.Now)
            {
                MessageBox.Show("this Date has passed,Plaese choose another date");
                return 0;

            }
            string query5 = "SELECT Count(Request_ID) from Maintenance_Requests";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query2 = "SELECT MAX(Request_ID) from Maintenance_Requests GROUP BY Request_ID   ORDER BY CAST(SUBSTRING(Request_ID, 6, LEN(Request_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query2);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);


            string newID = "MnReq" + Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(5)))
                + 1);


            string query3 = $"SELECT Court_ID from Courts WHERE Manager_ID='{managerID}'";
            string CourtId = Convert.ToString(dbMan.ExecuteScalar(query3));
            string query4 = $"INSERT INTO Maintenance_Requests VALUES ('{newID}','{workerID}','{CourtId}','{date}','{maintenanceDate.ToString("yyyy-MM-dd HH:mm:ss")}')";
            
                
                
                int test= dbMan.ExecuteNonQuery(query4);
            if (test < 0)
            {

                MessageBox.Show("Couldn't add Request");
                return test;
            }
            MessageBox.Show("Request Added");
            return test;

        }

        public int AddNewTournament(string managerID,string TournamentName,DateTime tourdate)
        {
            string query3 = $"SELECT Court_ID from Courts WHERE Manager_ID='{managerID}'";
            string CourtId = Convert.ToString(dbMan.ExecuteScalar(query3));
            string query1 = $"SELECT COUNT() FROM Tournament WHERE Court_ID='{CourtId}', Tournament_Date='{tourdate.ToString("yyyy-MM-dd HH:mm:ss")}' ";
            if (Convert.ToInt16(dbMan.ExecuteScalar(query1)) != 0)
            {
                MessageBox.Show("There is an existing tournament at the court on this day, Please choose another day");
                return 0;
            }
            else if (tourdate < DateTime.Now)
            {
                MessageBox.Show("this Date has passed,Plaese choose another date");
                return 0;

            }

            string query5 = "SELECT Count(Tournament_ID) from Tournament";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query2 = "SELECT MAX(Tournament_ID) from Tournament GROUP BY Tournament_ID ORDER BY CAST(SUBSTRING(Tournament_ID, 5, LEN(Tournament_ID)) AS INT) ASC;";
            DataTable MaxTable = dbMan.ExecuteReader(query2);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno-1][0]);

            string newID = "Tour" + Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(4)))
                + 1);

           
            string query4 = $"INSERT INTO Tournament VALUES ('{newID}','{TournamentName}','{CourtId}','{tourdate.ToString("yyyy-MM-dd HH:mm:ss")}')";

            int test = dbMan.ExecuteNonQuery(query4);
            if (test < 0)
            {

                MessageBox.Show("Couldn't Create Tournament");
                return test;
            }
            MessageBox.Show("Tournament Created");
            return test;

        }

        public DataTable SelectTournamentAtCourt(string managerID) {

            string query3 = $"SELECT Court_ID from Courts WHERE Manager_ID='{managerID}'";
            string CourtId = Convert.ToString(dbMan.ExecuteScalar(query3));
            String query = $"Select Tournament_ID as ID, Tournament_name ,Timing From Tournament WHERE Crt_ID='{CourtId}' AND Timing>'{date}'";
            return dbMan.ExecuteReader(query);
        }
        public int DeleteTouranment(string Tournament)
        {


            String query = $"Delete From Tournament WHERE Tournament_ID='{Tournament}'";
            int test =  dbMan.ExecuteNonQuery (query);
            if (test > 0)
            {
                MessageBox.Show("Tournament deleted");
                return test;
            }
            MessageBox.Show("Couldn't delete tournament");
            return test;
        }
        public DataTable SelectTournamentData(string TournamentID)
        {
            String query = $"Select Tournament_name ,Timing From Tournament WHERE Tournament_ID='{TournamentID}'";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateTournament(string TournamentID,DateTime timing,String name)
        {
            String query = $"Update  Tournament SET Tournament_name='{name}',Timing='{timing.ToString("yyyy-MM-dd HH:mm:ss")}'  WHERE Tournamnet_ID='{TournamentID}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectPlayersJoined(string TournamentID)
        {
            String query = $"Select Plyr_ID as playerID ,Fname as FirstName, Lname as LastName From Players_Joined, Account WHERE Acc_ID=Plyr_ID AND Trnmnt_ID='{TournamentID}' ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelecttrainersJoined(string TournamentID)
        {
            String query = $"Select Trnr_ID as TrainerID ,Fname as FirstName, Lname as LastName From Trainers_Joined, Account WHERE Acc_ID=Trnr_Id AND Trnmnt_ID='{TournamentID}' ";
            return dbMan.ExecuteReader(query);
        }
        public int DeletePlayerJoined(string TournamentID,string PlayerID)
        {
            string query = $"DELETE FROM Players_Joined WHERE Trnmnt_ID='{TournamentID}' AND Plyr_ID='{PlayerID}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteTrainerJoined(string TournamentID, string trainerID)
        {
            string query = $"DELETE FROM Trainers_Joined WHERE Trnmnt_ID='{TournamentID}' AND Trnr_ID='{trainerID}'";
            return dbMan.ExecuteNonQuery(query);
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

     
        public int Cancel_Tournament_Particpation(string Tour_Id, string email, string pass)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();
            if (m.Contains("P"))
            {
                string query = "DELETE FROM Players_Joined WHERE Trnmnt_ID='" + Tour_Id + "'and Plyr_ID='" + m + "';";
                return dbMan.ExecuteNonQuery(query);
            }
            else
            {
                string query = "DELETE FROM Trainers_Joined WHERE Trnmnt_ID='" + Tour_Id + "'and Trnr_ID='" + m + "';";
                return dbMan.ExecuteNonQuery(query);
            }
        }
        public DataTable View_sessions_for_trainer(string email, string pass)
        {
            string query1 = "SELECT Acc_ID FROM Account WHERE Email='" + email + "'and acc_password = '" + pass + "';";
            string m = dbMan.ExecuteScalar(query1).ToString();
            string query2 = $"Select Sess_ID,Fname,Lname,Booking_timing,Court_Name,Court_Location FROM Training_Session,Account,Bookings,Courts WHERE Booking_ID=Sess_ID AND Plyr_Id=Acc_ID AND Court_ID=Crt_Id AND Trnr_ID='{m}' AND Booking_timing >'{date}';";
            return dbMan.ExecuteReader(query2);

        }
  
     
        public int DeleteManager(string Manager_id)
        {
            string query = "UPDATE Courts SET Manager_ID = NULL WHERE Manager_ID = '" + Manager_id + "';";
            dbMan.ExecuteNonQuery(query);
            string query1 = "UPDATE Complaints SET complaint_Reviewer = NULL WHERE complaint_Reviewer = '" + Manager_id + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "DELETE FROM Account WHERE Acc_ID = '" + Manager_id + "';";
            return dbMan.ExecuteNonQuery(query2);
        }

        public DataTable SelectTrainer()
        {
            string query = "SELECT * FROM Account where Acc_ID LIKE '%TR%';";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteTrainer(string Trainer_id)
        {
            string query1 = "UPDATE Training_Sessions_Timeslots SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "UPDATE Trainer_Complaints SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query2);
            string query3 = "UPDATE Trainer_Reviews SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query3);
            string query4 = "UPDATE Training_Session SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query4);
            string query5 = "DELETE FROM Account WHERE Acc_ID = '" + Trainer_id + "';";
            return dbMan.ExecuteNonQuery(query5);
        }

        public int AddAvailableTrainingSessionTimeslots(string strt_date, string end_date, string TID)
        {
            
            string query5 = "SELECT Count(Slot_ID) from Training_Sessions_Timeslots";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query6 = "SELECT MAX(Slot_ID) FROM Training_Sessions_Timeslots GROUP BY Slot_ID ORDER BY CAST(SUBSTRING(Slot_ID, 3, LEN(Slot_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query6);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(2)))
                + 1);


            string query1 = "INSERT INTO Timeslots " +
                "VALUES ('TS" + y + "','A','" + strt_date + "','" + end_date + "')";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "INSERT INTO Training_Sessions_Timeslots " +
                "VALUES ('TS" + y + "','" + TID + "','A')";
            return dbMan.ExecuteNonQuery(query2);

        }

        public int AddAvailableCourtTimeslots(string strt_date, string end_date,string managerID)
        {
            string query15 = $"SELECT Court_ID from Courts WHERE Manager_Id='{managerID}'";
            String CID = Convert.ToString(dbMan.ExecuteScalar(query15));
            string query5 = "SELECT Count(Slot_ID) from Court_Timeslots";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query6 = "SELECT MAX(Slot_ID) FROM Court_Timeslots GROUP BY Slot_ID  ORDER BY CAST(SUBSTRING(Slot_ID, 2, LEN(Slot_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query6);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(1)))
                + 1);


            string query1 = "INSERT INTO Timeslots " +
                "VALUES ('C" + y + "','A','" + strt_date + "','" + end_date + "')";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "INSERT INTO Court_Timeslots " +
                "VALUES ('C" + y + "','" + CID + "')";
            return dbMan.ExecuteNonQuery(query2);

        }

        public DataTable SelectCourts()
        {
            string query = "SELECT * FROM Courts ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectManagers()
        {
            string query = "SELECT * FROM Account where Acc_ID LIKE '%M%';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAverageBookingsData()
        {
            string query = "SELECT c.Court_ID, c.Court_Name, AVG(b.BookingCount) AS Average_Bookings " +
                           "FROM Courts AS c " +
                           "LEFT OUTER JOIN (SELECT Crt_Id, COUNT(Booking_ID) AS BookingCount FROM Bookings GROUP BY Crt_Id) AS b " +
                           "ON c.Court_ID = b.Crt_Id " +
                           "GROUP BY c.Court_ID, c.Court_Name ";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAverageTrainingSessionsData()
        {
            string query = "SELECT c.Court_ID, c.Court_Name, AVG(Subquery.TrainingSessionsCount) AS AvgTrainingSessions " +
                           "FROM Courts AS c " +
                           "LEFT OUTER JOIN " +
                           "(SELECT b.Crt_Id, COUNT(ts.Sess_ID) AS TrainingSessionsCount " +
                           " FROM Bookings AS b " +
                           " LEFT OUTER JOIN Training_Session AS ts ON b.Booking_ID = ts.Sess_ID " +
                           " GROUP BY b.Crt_Id) AS Subquery ON c.Court_ID = Subquery.Crt_Id " +
                           "GROUP BY c.Court_ID, c.Court_Name";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCourtReviewsData()
        {
            string query = "SELECT r.Review_Date, r.Reviewer_ID, r.Reviewer_grade, r.Comment " +
                           "FROM Court_Reviews AS cr " +
                           "INNER JOIN Reviews AS r ON cr.Rev_ID = r.Review_ID";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetTopRatedCourts()
        {
            string query = "SELECT C.Court_Name " +
                           "FROM Courts AS C " +
                           "INNER JOIN Court_Reviews AS CR ON C.Court_ID = CR.Crt_ID " +
                           "INNER JOIN Reviews AS R ON CR.Rev_ID = R.Review_ID " +
                           "GROUP BY C.Court_Name " +
                           "ORDER BY AVG(R.Reviewer_grade) DESC";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetTopRatedTrainers()
        {
            string query = "SELECT A.Fname, A.Lname " +
                           "FROM Trainer AS T " +
                           "INNER JOIN Trainer_Reviews AS TR ON T.Trainer_ID = TR.Trnr_ID " +
                           "INNER JOIN Reviews AS R ON TR.Rev_ID = R.Review_ID " +
                           "INNER JOIN Account AS A ON T.Trainer_ID = A.Acc_ID " +
                           "GROUP BY T.Trainer_ID, A.Fname, A.Lname " +
                           "ORDER BY AVG(R.Reviewer_grade) DESC, T.Trainer_ID";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetPlayerVisitsCount()
        {
            string query = "SELECT A.Fname AS Player_FirstName, A.Lname AS Player_LastName, C.Court_Name, COUNT(B.Crt_Id) AS VisitsCount " +
                           "FROM Account AS A " +
                           "INNER JOIN Player AS P ON A.Acc_ID = P.Player_ID " +
                           "INNER JOIN Bookings AS B ON P.Player_ID = B.Plyr_Id " +
                           "INNER JOIN Courts AS C ON B.Crt_Id = C.Court_ID " +
                           "GROUP BY A.Fname, A.Lname, C.Court_Name " +
                           "ORDER BY VisitsCount DESC";

            return dbMan.ExecuteReader(query);
        }
        public DataTable PlayersTournament(string tournamentid)
        {
            string query = "SELECT Plyr_ID FROM Players_Joined WHERE Trnmnt_ID = '" + tournamentid + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable TrainersTournament(string tournamentid)
        {
            string query = "SELECT Trnr_ID FROM Trainers_Joined WHERE Trnmnt_ID = '" + tournamentid + "'";
            return dbMan.ExecuteReader(query);
        }


        public int InsertManager(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {



            string query5 = "SELECT Count(Acc_ID) from Account WHERE Acc_ID LIKE '%M%'";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query1 = "SELECT MAX(Acc_ID) FROM Account WHERE Acc_ID LIKE '%M%'  GROUP BY Acc_ID  ORDER BY CAST(SUBSTRING(Acc_ID, 2, LEN(Acc_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query1);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);

            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(1)))
                + 1);
            string StoredProcedureName = Stored_Procedure.insertManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Acc_ID", 'M' + y);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Birth_Date", birth_date);
            Parameters.Add("@Email", email);
            Parameters.Add("@Acc_Password", password);
            Parameters.Add("@Phone_number", phone_numbr);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertPlayer(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
            ;
            if (Convert.ToUInt16(dbMan.ExecuteScalar($"SELECT Count(Player_ID) from Player WHERE Email='{email}'")) != 0)
            {
                MessageBox.Show("Email is used for another user please use another one");
                return 0;

            }
            else if (Convert.ToUInt16(dbMan.ExecuteScalar($"SELECT Count(Player_ID) from Player WHERE Phone_Number='{phone_numbr}'")) != 0)
            {

                MessageBox.Show("Mobile Number is used for another user please use another one");
                return 0;


            }


            string query5 = "SELECT Count(Player_ID) from Player";
            int rowno = Convert.ToUInt16(dbMan.ExecuteScalar(query5));
            string query1 = "SELECT MAX(Player_ID) FROM Player  GROUP BY Player_ID ORDER BY CAST(SUBSTRING(Player_ID, 2, LEN(Player_ID)) AS INT) ASC";
            DataTable MaxTable = dbMan.ExecuteReader(query1);
            string maxidexists = Convert.ToString(MaxTable.Rows[rowno - 1][0]);
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxidexists.Substring(1)))
                + 1);
            string StoredProcedureName = Stored_Procedure.Insertplayer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Acc_ID", 'P' + y);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Birth_Date", birth_date);
            Parameters.Add("@Email", email);
            Parameters.Add("@Acc_Password", password);
            Parameters.Add("@Phone_number", phone_numbr);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectManagers2()
        {
            string StoredProcedureName = Stored_Procedure.SelectManager;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }


    }
}



