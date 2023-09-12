using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BS.DataAccess 
{
    public class Class1 
    {
        public object CustomerName { get; private set; }
        public object CustomerMobileNumber { get; private set; }
        public object CustomerAddress { get; private set; }
        public object CustomerEmail { get; private set; }
        public object CustomerPassword { get; private set; }

        public void AllTablesetAccountorTransectionType()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string retriveQuery = "select *  from CustomerInformation";
            string retriveQuery1 = "select *  from CustomerAccountManage";
            string retriveQuery2 = "select *  from AccountorTransectionType";
            string retriveQuery3 = "select *  from AccountorTransectionValue";
            string retriveQuery4 = "select *  from Transection";
            string retriveQuery5 = "select *  from CreditCardDetail";
            SqlCommand cmd = new SqlCommand(retriveQuery, sqlConnection);
            SqlCommand cmd1 = new SqlCommand(retriveQuery1, sqlConnection);
            SqlCommand cmd2 = new SqlCommand(retriveQuery2, sqlConnection);
            SqlCommand cmd3 = new SqlCommand(retriveQuery3, sqlConnection);
            SqlCommand cmd4 = new SqlCommand(retriveQuery4, sqlConnection);
            SqlCommand cmd5 = new SqlCommand(retriveQuery5, sqlConnection);
            sqlConnection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", rdr["CustomerInformationId"] + "\t", rdr["CustomerName"] + "\t", rdr["CustomerMobileNumber"] + "\t", rdr["CustomerAddress"] + "\t", rdr["CreatedOn"]);
                }
                Console.ReadKey();
            }
            sqlConnection.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerInformation");
            da1.Fill(ds, "CustomerAccountManage");
            da2.Fill(ds, "AccountorTransectionType");
            da3.Fill(ds, "AccountorTransectionValue");
            da4.Fill(ds, "Transection");
            da5.Fill(ds, "CreditCardDetail");
            /*ds.Tables.Add("CustomerInformation");
             ds.Tables.Add("CustomerAccountManage");
             ds.Tables.Add("AccountorTransectionType");
             ds.Tables.Add("AccountorTransectionValue");
             ds.Tables.Add("Transection");*/
            Console.WriteLine("\n" + "CustomerInformation Using Data Set");
            foreach (DataRow row in ds.Tables["CustomerInformation"].Rows)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", row["CustomerInformationId"] + "\t", row["CustomerName"] + "\t", row["CustomerMobileNumber"] + "\t", row["CustomerAddress"] + "\t", row["CreatedOn"]);
            }
            Console.WriteLine("\n" + "CustomerAccountManage Using Data Set");
            foreach (DataRow row in ds.Tables["CustomerAccountManage"].Rows)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", row["CustomerAccountManageId"] + "\t", row["AccountNumber"] + "\t", row["AccountType"]+"\t",
                    row["AccountBalance"] + "\t", row["BranchId"] + "\t", row["CustomerInformationId"] + "\t", row["CreatedOn"]);
            }
            Console.WriteLine("\n" + "AccountorTransectionType Using Data Set");
            foreach (DataRow row in ds.Tables["AccountorTransectionType"].Rows)
            {
                Console.WriteLine("{0}{1}", row["AccountorTransectionTypeId"] + "\t", row["AccountorTransectionTypeName"]);
            }
            Console.WriteLine("\n"+"AccountorTransectionValue Using Data Set");
            foreach (DataRow row in ds.Tables["AccountorTransectionValue"].Rows)
            {
                Console.WriteLine("{0}{1}{2}", row["AccountorTransectionValueId"] +"\t", row["AccountorTransectionValueName"]+"\t", row["AccountorTransectionTypeId"]);
            }
            Console.WriteLine("\n" + "Transection Using Data Set");
            foreach (DataRow row in ds.Tables["Transection"].Rows)
            {
                Console.WriteLine("{0}{1}{2}{3}", row["TransectionId"] + "\t", row["TransectionType"] + "\t", row["TransectionAmmount"] + "\t", row["CustomerAccountManageId"] + "\t", row["CreatedOn"]);
            }
            Console.WriteLine("\n" + "CreditCardDetail Using Data Set");
            foreach (DataRow row in ds.Tables["CreditCardDetail"].Rows)
            {
                Console.WriteLine("{0}{1}{2}{3}", row["CreditCardDetailId"] + "\t", row["CardNumber"] + "\t", row["createdon"] + "\t", row["CardLimit"] + "\t", row["CustomerInformationId"]);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            da2.Fill(dt);

            Console.WriteLine("\n" + "CustomerInformation Using Data Table");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", row["CustomerInformationId"] + "\t", row["CustomerName"] + "\t", row["CustomerMobileNumber"] + "\t", row["CustomerAddress"] + "\t", row["CreatedOn"]);
            }

            Console.WriteLine("AccountorTransectionType Using Data Table");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0}{1}", row["AccountorTransectionTypeId"] + "\t", row["AccountorTransectionTypeName"]);
            }
            Console.ReadKey();
        }

        public void InsertCustomerInformation()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "Insert into CustomerInformation values ('Console',96661414,'Kolkata','Cn@gmail.com','Cn123',getdate())";
            //string query = "CustomerInfo1";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ciId", SqlDbType.Int).Value = 0;
            //cmd.Parameters.Add("@cName", SqlDbType.VarChar).Value = "Store SP";
            //cmd.Parameters.Add("@cMno", SqlDbType.Int).Value = 87945122;
            //cmd.Parameters.Add("@cdd", SqlDbType.VarChar).Value = "Pune";
            //cmd.Parameters.Add("@cEmail", SqlDbType.VarChar).Value = "Sp@gmail.com";
            //cmd.Parameters.Add("@CPass", SqlDbType.VarChar).Value = "Sp123";
            //cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";
            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("CustomerInformation Record Inserted Successfully");
        }

        public void InsertCustomerAccountManage()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "Insert into CustomerAccountManage values (12128,402,5800,'Kolkata','KT123',107,getdate())";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("CustomerAccountManage Record Inserted Successfully");
        }

        public void InsertAccountorTransectionType()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "Insert into AccountorTransectionType values ('Banking')";   
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("AccountorTransectionType Record Inserted Successfully");
        }

        public void InsertAccountorTransectionValue()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "Insert into AccountorTransectionValue values ('System',301)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("AccountorTransectionValue Record Inserted Successfully");
        }

        public void InsertTransection()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "Insert into Transection values (403,4800,205,getdate())";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("Transection Record Inserted Successfully");
        }

        public bool Authenticateuser(string email, string pass, out string validationmessage)
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "select count(*) from CustomerInformation where CustomerEmail=@email";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            sqlConnection.Open();
            int row = (int)cmd.ExecuteScalar();
            sqlConnection.Close();
            if (row ==0)
            {
                validationmessage = "user Email not Exists";
                return false;
            }

            string q = "select count(*) from CustomerInformation where CustomerEmail=@email and CustomerPassword=@pass";
            //SqlCommand cmd = new SqlCommand(q, sqlConnection);
            cmd = new SqlCommand(q, sqlConnection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            sqlConnection.Open();
            row = (int)cmd.ExecuteScalar();
            sqlConnection.Close();
            validationmessage = row == 0 ? "Credential not match" : string.Empty;
            return row > 0;
        }

        public bool Signup(string CustomerName, int CustomerMobileNumber, string CustomerAddress, string CustomerEmail, string CustomerPassword, out string validationmessage)
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            sqlConnection.Open();
                string query = "INSERT INTO CustomerInformation VALUES  (@CustomerName, @CustomerMobileNumber,@CustomerAddress,@CustomerEmail,@CustomerPassword,@CreatedOn)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@CustomerMobileNumber", CustomerMobileNumber);
                cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                cmd.Parameters.AddWithValue("@CustomerPassword", CustomerPassword);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    validationmessage = "data inserted";
                    return true;
                }
                else
                {
                    validationmessage = "data not inserted";
                    return false;
                }            
        }

        public int Customer(int CustomerAccountManageId)
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string q = "select AccountBalance from CustomerAccountManage where CustomerAccountManageId=@camid";
            SqlCommand cmd = new SqlCommand(q, sqlConnection);
            cmd.Parameters.AddWithValue("@camid", CustomerAccountManageId);
            sqlConnection.Open();
            int count = (int)cmd.ExecuteScalar();
            sqlConnection.Close();
            return count;
        }

        public void TransectionAmount(int CustomerAccountManageId, int TransectionAmmount, out string msg)
        {

            msg = string.Empty;
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            sqlConnection.Open();
            int count = Customer(CustomerAccountManageId);
            if (count < TransectionAmmount)
            {
                msg = "Account Balance amount is less than Withdraw Amount..can't insert ";
            }
            string q = "insert into Transection values(404,@Tam,408,@camid,getdate())";
            SqlCommand cmd = new SqlCommand(q, sqlConnection);
            cmd.Parameters.AddWithValue("@Tam", TransectionAmmount);
            cmd.Parameters.AddWithValue("@camid", CustomerAccountManageId);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            msg = "inserted";
        }

        public DataTable Gridview()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "select * from CustomerInformation";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Repeater()
        {
            SqlConnection sqlConnection = ConnectionString.GetConnection();
            string query = "select * from CustomerInformation";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
