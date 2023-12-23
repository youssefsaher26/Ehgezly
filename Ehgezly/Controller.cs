using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable CheckAccountExist(string mail , string pass)
        {
            string query = "SELECT * FROM Account WHERE Email='"+ mail +"'and acc_password= '"+ pass +"';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckAccountAdmin(string mail , string pass)
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
        public int RegisterPlayer(string Fname, string lname , char Gender ,string birth_date, string email, string password,string phone_numbr)
        {
            string query1= "SELECT COUNT(*) FROM Player";
            int x=Convert.ToInt32( dbMan.ExecuteScalar(query1))+1;
            string y = x.ToString();
            string query2 = "INSERT INTO Account " +
                            "Values ('P"+y+"','" + Fname + "','" + lname + "','" + Gender +"','"+birth_date+"','"+email+"', '"+password+"','"+phone_numbr+"');";
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
        public int RegisterTrainer(string Fname, string lname, char Gender, string birth_date, string email, string password, string phone_numbr,string sport_type)
        {
            string query1 = "SELECT COUNT(*) FROM Trainer";
            int x = Convert.ToInt32(dbMan.ExecuteScalar(query1)) + 1;
            string y = x.ToString();
            string query2 = "INSERT INTO Account " +
                            "Values ('TR" + y + "','" + Fname + "','" + lname + "','" + Gender + "','" + birth_date + "','" + email + "', '" + password + "','" + phone_numbr + "');";
            string query3 = "INSERT INTO Trainer " +
                            "Values ('TR" + y + "','"+sport_type+"','N');";
            dbMan.ExecuteNonQuery(query2);
            return dbMan.ExecuteNonQuery(query3);
        }
        public DataTable ViewAccountPlayer(string mail, string pass)
        {
            string query = "SELECT Fname FROM Account WHERE Email='" + mail + "'and acc_password= '" + pass + "';";
            return dbMan.ExecuteReader(query);
        }

    }
}
