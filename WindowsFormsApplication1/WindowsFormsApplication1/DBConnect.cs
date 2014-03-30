using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace WindowsFormsApplication1
{
    class DBConnect
    {
        //connections are used for connecting to database and tables
        private MySqlConnection connection;
        private MySqlConnection connection2;
        private MySqlConnection connection3;
        private MySqlConnection connection4;

        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "patrondb";
            uid = "root";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection2 = new MySqlConnection(connectionString);
            connection3 = new MySqlConnection(connectionString);
            connection4 = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                connection2.Close();
                connection3.Close();
                connection4.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CloseAll()
        {
            connection.Close();
            connection2.Close();
            connection3.Close();
            connection4.Close();
        }

        //Query statement
        public void Query(String query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                
                    cmd.ExecuteNonQuery();
                
       
                //close connection
                this.CloseConnection();
            }
        }

        public List<PreviousVisit> SelectPreviousVisit(String query)
        {
            List<PreviousVisit> list = new List<PreviousVisit>();
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = 0;
                    int numChild = 0;
                    int numAdult = 0;
                    DateTime date = new DateTime();
                    //get patron prev.visit data based on id
                    id = (int)dataReader.GetValue(0);
                    date = (DateTime)dataReader.GetValue(1);
                    numChild = (int)dataReader.GetValue(2);
                    numAdult = (int)dataReader.GetValue(3);
                    PreviousVisit prevVis = new PreviousVisit(id, numChild, numAdult, date);
                    list.Add(prevVis);
                }
                connection.Close();
                dataReader.Close();
            }
            return list;
        }

        //Select statement
        public List<Patron> SelectPatron(String query)
        {
            //Create a list to store the result
            List<Patron> list = new List<Patron>();

            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    String id = dataReader.GetString(0);//gets id column data 
                    String fName = dataReader.GetString(1);//gets first name column data
                    String lName = dataReader.GetString(2);//continues...
                    String mInitial = dataReader.GetString(3);
                    String phone = dataReader.GetString(4);

                    String stNum = "";
                    String addrLine2 = "";
                    String city = "";
                    String state = "";
                    String zip = "";
                   



                    connection2.Open();
                    String query2 = "SELECT * FROM address WHERE patron_id = '" + id + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection2);
                    MySqlDataReader dataReader2 = cmd2.ExecuteReader();

                    while (dataReader2.Read())
                    {
                        //THIS NESTED LOOP WILL NOT WORK PROPERLY IF TWO PEOPLE HAVE THE SAME PATRON_ID (which shouldn't exist anyways)
                        //The loop will assign the address of the last person with the last patron id to the object being stored 
                        stNum = dataReader2.GetString(1);
                        addrLine2 = dataReader2.GetString(2);
                        city = dataReader2.GetString(3);
                        state = dataReader2.GetString(4);
                        zip = dataReader2.GetString(5);
                      

                    }



                    int numChild = 0;
                    int numAdult = 0;
                    DateTime date = new DateTime();



                    connection3.Open();
                    //get patron prev.visit data based on id
                    String query3 = "SELECT * FROM previousvisits WHERE patron_id = '" + id + "'";
                    MySqlCommand cmd3 = new MySqlCommand(query3, connection3);
                    MySqlDataReader dataReader3 = cmd3.ExecuteReader();

                    while (dataReader3.Read())
                    {
                        date = (DateTime)dataReader3.GetValue(1);
                        numChild = (int)dataReader3.GetValue(2);
                        numAdult = (int)dataReader3.GetValue(3);

                    }




                    connection2.Close();
                    dataReader2.Close();
                    connection3.Close();
                    dataReader3.Close();



                    //Build data for patron
                    Address address = new Address(Int32.Parse(id), stNum, addrLine2, city, state, zip);
                    PreviousVisit prevVis = new PreviousVisit(Int32.Parse(id), numChild, numAdult, date);
                    Patron patron = new Patron(Int32.Parse(id), fName, lName, mInitial, phone, address, prevVis);

                    list.Add(patron);//add the patron to the list until all patrons of query are selected
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                MessageBox.Show("Cannot connect to server.");
                return list;
            }
        }

        //Add a new patron to the database
        public void addPatron(Patron pat)
        {
            if (this.OpenConnection() == true)
            {
                //patron table 
                String query1 = "INSERT INTO patron VALUES ('" +
                    pat.Id + "', '" +
                    pat.FirstName + "', '" +
                    pat.LastName + "', '" +
                    pat.MiddleInitial + "', '" +
                    pat.Phone + "')";
                //address table
                String query2 = "INSERT INTO address VALUES ('" +
                   pat.Id + "', '" +
                  
                   pat.StreetName1 + "', '" +
                   pat.AddressLine2 + "', '" +
                   pat.City + "', '" +
                   pat.State + "', '" +
                   pat.Zip + "')";

                //Date should be YYYY-MM-DD format
                String formattedDate = pat.Date.Year + "-" + pat.Date.Month + "-" + pat.Date.Day;

                
                //previsousvisits table
                String query3 = "INSERT INTO previousvisits VALUES ('" +
                   pat.Id + "', '" +
                   formattedDate + "', '" +
                   pat.NumChildren + "', '" +
                   pat.NumAdults + "')";

                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete a patron from the database based on patron id
        public void deletePatron(int id)
        {

            if (this.OpenConnection())
            {
                String query = "DELETE  FROM patron WHERE patron_id='" + id + "'";
                String query1 = "DELETE FROM address WHERE patron_id='" + id + "'";
                String query2 = "DELETE FROM previousvisits WHERE patron_id='" + id + "'";

                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                MySqlCommand cmd2 = new MySqlCommand(query1, connection);
                MySqlCommand cmd3 = new MySqlCommand(query2, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                CloseAll(); 
            }


        }

        //Count statement
        public int Count(String query)
        {
            int Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");
 
                    //close Connection
                    this.CloseConnection();

                    return Count;
                }
                catch
                {

                }
                return Count; 

            }
            else
            {
                return Count;
            }
        }

        //Get adult and children statistics based on time
        public int[] getStats(String query)
        {
            int[] stats = new int[2];//first element will have number of children and second element will have adults

            try
            {
                connection4.Open();//open a connection
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection4);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        stats[0] = stats[0] + (int)dataReader.GetInt32(0);//get sum of adults
                        stats[1] = stats[1] + (int)dataReader.GetInt32(1);//get sum of children
                    }
                }
                return stats;
            }
            catch
            {
                return stats;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
