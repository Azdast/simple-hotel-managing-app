using MySql.Data.MySqlClient;
using System.Data;

namespace Hotal_Manager
{

    public class GuestClass
    {
        DBConnect connect = new DBConnect();

        public bool insertGuest(string id, string fname, string lname, string phone, string city)
        {
            string insertQuerrt =
                "INSERT INTO `guest`(`GuestId`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES (@id, @fname, @lname, @phone, @city);";
            MySqlCommand command = new MySqlCommand(insertQuerrt, connect.GetConnection());
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname",MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname",MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone",MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city",MySqlDbType.VarChar).Value = city;
            
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        public DataTable getGuest()
        {
            string selectQuerrt = "SELECT * FROM `guest`";
            MySqlCommand command =new MySqlCommand(selectQuerrt, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool editGuest(string id, string fname, string lname, string phone, string city)
        {
            string editQuerrt =
                "UPDATE `guest` SET ,`GuestFirstName`= [@fname] ,`GuestLastName`= [@lname],`GuestPhone`= [@phone] ,`GuestCity`= [@city] WHERE `GuestId`= [@id]";
            MySqlCommand command = new MySqlCommand(editQuerrt, connect.GetConnection());
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname",MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname",MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone",MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city",MySqlDbType.VarChar).Value = city;
            
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        
    }
}