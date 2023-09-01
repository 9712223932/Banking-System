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
        public void AllTablesetAccountorTransectionType()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            string retriveQuery = "select *  from CustomerInformation";
            string retriveQuery1 = "select *  from CustomerAccountManage";
            string retriveQuery2 = "select *  from AccountorTransectionType";
            string retriveQuery3 = "select *  from AccountorTransectionValue";
            string retriveQuery4 = "select *  from Transection";

            SqlCommand cmd = new SqlCommand(retriveQuery, sqlConnetion);
            SqlCommand cmd1 = new SqlCommand(retriveQuery1, sqlConnetion);
            SqlCommand cmd2 = new SqlCommand(retriveQuery2, sqlConnetion);
            SqlCommand cmd3 = new SqlCommand(retriveQuery3, sqlConnetion);
            SqlCommand cmd4 = new SqlCommand(retriveQuery4, sqlConnetion);

            sqlConnetion.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", rdr["CustomerInformationId"] + "\t", rdr["CustomerName"] + "\t", rdr["CustomerMobileNumber"] + "\t", rdr["CustomerAddress"] + "\t", rdr["CreatedOn"]);
                }
                Console.ReadKey();
            }
            sqlConnetion.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);


            DataSet ds = new DataSet();
            da.Fill(ds, "CustomerInformation");
            da1.Fill(ds, "CustomerAccountManage");
            da2.Fill(ds, "AccountorTransectionType");
            da3.Fill(ds, "AccountorTransectionValue");
            da4.Fill(ds, "Transection");

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
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //string query = "Insert into CustomerInformation values ('Console',96661414,'Kolkata',getdate())";
            string query = "CustomerInfo1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
             cmd.Parameters.Add("@ciId", SqlDbType.Int).Value = 108;
             cmd.Parameters.Add("@custName", SqlDbType.VarChar).Value = "Store SP";
             cmd.Parameters.Add("@custmobileNo", SqlDbType.Int).Value = 87945122;
             cmd.Parameters.Add("@custAdd", SqlDbType.VarChar).Value = "Pune";
             cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "U";

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("CustomerInformation Record Inserted Successfully");
        }

        public void InsertCustomerAccountManage()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into CustomerAccountManage values (12128,402,5800,'Kolkata','KT123',107,getdate())";
            //string query = "CustomerAccountManage1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            /*cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@camid", SqlDbType.Int).Value = 209;
            cmd.Parameters.Add("@accNumber", SqlDbType.VarChar).Value = 12128;
            cmd.Parameters.Add("@atvid", SqlDbType.Int).Value = 402;
            cmd.Parameters.Add("@accBalance", SqlDbType.Int).Value = 8500;
            cmd.Parameters.Add("@branch", SqlDbType.VarChar).Value = "Pune";
            cmd.Parameters.Add("@ifsc", SqlDbType.VarChar).Value = "PN123";
            cmd.Parameters.Add("@ciId", SqlDbType.Int).Value = "107";
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "U";*/


            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("CustomerAccountManage Record Inserted Successfully");
        }

        public void InsertAccountorTransectionType()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into AccountorTransectionType values ('Banking')";
            //string query = "AccountorTransectionType1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            /*cmd.CommandType = System.Data.CommandType.StoredProcedure;
             cmd.Parameters.Add("@attid", SqlDbType.Int).Value = 304;
             cmd.Parameters.Add("@attname", SqlDbType.VarChar).Value = "Store SP";
             cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "U";*/

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("AccountorTransectionType Record Inserted Successfully");
        }

        public void InsertAccountorTransectionValue()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into AccountorTransectionValue values ('System',301)";
            //string query = "AccountorTransectionValue1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            /*cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@atvid", SqlDbType.Int).Value = 406;
            cmd.Parameters.Add("@atvname", SqlDbType.VarChar).Value = "Store SP";
            cmd.Parameters.Add("@attid", SqlDbType.Int).Value = 302;
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "U";*/

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("AccountorTransectionValue Record Inserted Successfully");
        }

        public void InsertTransection()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into Transection values (403,4800,205,getdate())";
            //string query = "Transection1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            /*cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@atvid", SqlDbType.Int).Value = 404;
            cmd.Parameters.Add("@tamount", SqlDbType.Int).Value = 1000;
            cmd.Parameters.Add("@camid", SqlDbType.Int).Value = "209";
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "U";*/


            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("Transection Record Inserted Successfully");
        }
    }
}
