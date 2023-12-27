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
using System.Security.Principal;

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

        //HomePages
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
            string query1 = "SELECT MAX(Player_ID) FROM Player";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query1));
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(1)))
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
            string query1 = "SELECT MAX(Acc_ID) FROM Account WHERE Acc_ID LIKE '%M%'";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query1));
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(1)))
                + 1);
            string query2 = "INSERT INTO Account " +
                            "Values ('M" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            return dbMan.ExecuteNonQuery(query2);
        }
        public int RegisterAdmin(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr)
        {
            string query1 = "SELECT MAX(Acc_ID) FROM Account WHERE Acc_ID LIKE '%A%'";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query1));
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(1)))
                + 1);
            string query2 = "INSERT INTO Account " +
                            "Values ('A" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            return dbMan.ExecuteNonQuery(query2);
        }
        public int RegisterTrainer(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr, string sport_type)
        {
            string query1 = "SELECT Max(Trainer_ID) FROM Trainer";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query1));
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(2)))
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

        public string GetID(string Email)
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

            string query2 = "SELECT Max(Booking_ID) FROM Bookings WHERE Booking_ID LIKE '%TSB%' ;";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query2));
            string y = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(1)))
                + 1);

            string query3 = "INSERT INTO Bookings " +
                            "Values ('TSB" + y + "','" + m + "','" + CID + "','" + time + "');";


            string query4 = "SELECT Max(Sess_ID) FROM Training_session ";
            string maxIDexists2 = Convert.ToString(dbMan.ExecuteScalar(query4));
            string w = Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists2.Substring(3)))
                + 1);
         


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
            string Q1 = $"SELECT Count(Review_ID) from Reviews WHERE Booking_ID={BookID}  ";
            int t = Convert.ToInt16(dbMan.ExecuteScalar(Q1));
            if (t != 0)
            {
                return null;
            }

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

            string query = $"INSERT INTO Maintenance_Reviews VALUES Rev_ID={RevID},MW_ID='{MW}'";
            return dbMan.ExecuteNonQuery(query);

        }
        public int AddCommentToReview(string RevID,string comment)
        {
              string query = $"Update  Reviews SET Comment='{comment}' WHERE Review_ID='{RevID}'"; 
              return  dbMan.ExecuteNonQuery(query);
        }
        public string GetCourtIDfromBooking(string Bookid) 
        {

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
            string query = "SELECT Tournamnet_name,Court_Location,Timing FROM Tournament,Courts where Timing >'" + date + "' and Crt_ID= Court_ID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectManagers()
        {
            string query = "SELECT * FROM Account where Acc_ID LIKE '%M%';";
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


            string Q1 = "SELECT MAX(Complaint_ID) from Complaints";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(Q1));
            string maxno = maxIDexists.Substring(3);
            string ID = null;


            
            if (ComplaintAboutID.Contains('T'))
            {

                ID = "TCP" + Convert.ToString(Convert.ToInt16(maxno) + 1);


            }
            else if (ComplaintAboutID.Contains('C'))
            {

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
            string query2 = "SELECT MAX(Request_ID) from Maintenance_Requests";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query2));
         
            string newID = "MnReq" + Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(5)))
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
            string query2 = "SELECT MAX(Tournament_ID) from Tournament";
            string maxIDexists = Convert.ToString(dbMan.ExecuteScalar(query2));

            string newID = "Tour" + Convert.ToString(
                Convert.ToInt16(Convert.ToString(maxIDexists.Substring(4)))
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
            string query = $"DELETE FROM Trainers_Joined WHERE Trnmnt_ID='{TournamentID}' AND Trnr-ID='{trainerID}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteManager(string Manager_id)
        {
            string query = "UPDATE Courts SET Manager_ID = NULL WHERE Manager_ID = '"+Manager_id+"';";
            dbMan.ExecuteNonQuery(query);
            string query1 = "UPDATE Complaints SET complaint_Reviewer = NULL WHERE complaint_Reviewer = '"+Manager_id+"';";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "DELETE FROM Account WHERE Acc_ID = '"+Manager_id+"';";
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
            string query2= "UPDATE Trainer_Complaints SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query2);
            string query3 = "UPDATE Trainer_Reviews SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query3);
            string query4 = "UPDATE Training_Session SET Trnr_id = NULL WHERE Trnr_ID = '" + Trainer_id + "';";
            dbMan.ExecuteNonQuery(query4);
            string query5= "DELETE FROM Account WHERE Acc_ID = '" + Trainer_id + "';";
            return dbMan.ExecuteNonQuery(query5);
        }

        public int AddAvailableTrainingSessionTimeslots(string strt_date , string end_date,string TID)
        {
            string query = "SELECT Count(*) FROM Training_Sessions_Timeslots;";
            int z = Convert.ToInt32(dbMan.ExecuteScalar(query)) + 1;
            string y = z.ToString();

            string query1 = "INSERT INTO Timeslots " +
                "VALUES ('TS" + y + "','A','"+ strt_date + "','"+ end_date +"')";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "INSERT INTO Training_Sessions_Timeslots " +
                "VALUES ('TS" + y +"','" + TID + "','A')";
            return dbMan.ExecuteNonQuery(query2);

        }

        public int AddAvailableCourtTimeslots(string strt_date, string end_date, string CID)
        {
            string query = "SELECT Count(*) FROM Court_Timeslots;";
            int z = Convert.ToInt32(dbMan.ExecuteScalar(query)) + 1;
            string y = z.ToString();

            string query1 = "INSERT INTO Timeslots " +
                "VALUES ('C" + y + "','A','" + strt_date + "','" + end_date + "')";
            dbMan.ExecuteNonQuery(query1);
            string query2 = "INSERT INTO Court_Timeslots " +
                "VALUES ('C" + y + "','" + CID +"')";
            return dbMan.ExecuteNonQuery(query2);

        }

        public DataTable SelectCourts()
        {
            string query = "SELECT * FROM Courts ";
            return dbMan.ExecuteReader(query);
        }

    }
}

