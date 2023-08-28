﻿using System;
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
        public void InsertCustomerInformation()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into CustomerInformation values ('Console',96661414,'Kolkata',getdate())";
            //string query = "CustomerInfo1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            /* cmd.CommandType = System.Data.CommandType.StoredProcedure;
             cmd.Parameters.Add("@ciId", SqlDbType.Int).Value = 0;
             cmd.Parameters.Add("@custName", SqlDbType.VarChar).Value = "Store SP";
             cmd.Parameters.Add("@custmobileNo", SqlDbType.Int).Value = 87945122;
             cmd.Parameters.Add("@custAdd", SqlDbType.VarChar).Value = "Pune";
             cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";*/

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
            cmd.Parameters.Add("@camid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@accNumber", SqlDbType.VarChar).Value = 12128;
            cmd.Parameters.Add("@atvid", SqlDbType.Int).Value = 402;
            cmd.Parameters.Add("@accBalance", SqlDbType.Int).Value = 8500;
            cmd.Parameters.Add("@branch", SqlDbType.VarChar).Value = "Pune";
            cmd.Parameters.Add("@ifsc", SqlDbType.VarChar).Value = "PN123";
            cmd.Parameters.Add("@ciId", SqlDbType.Int).Value = "107";
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";*/


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
             cmd.Parameters.Add("@attid", SqlDbType.Int).Value = 0;
             cmd.Parameters.Add("@attname", SqlDbType.VarChar).Value = "Store SP";
             cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";*/

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
            cmd.Parameters.Add("@atvid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@atvname", SqlDbType.VarChar).Value = "Store SP";
            cmd.Parameters.Add("@attid", SqlDbType.Int).Value = 302;
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";*/

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("AccountorTransectionValue Record Inserted Successfully");
        }

        public void InsertTransection()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //string query = "Insert into Transection values (403,4800,205,getdate())";
            string query = "Transection1";

            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@atvid", SqlDbType.Int).Value = 404;
            cmd.Parameters.Add("@tamount", SqlDbType.Int).Value = 500;
            cmd.Parameters.Add("@camid", SqlDbType.Int).Value = "209";
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";


            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            Console.WriteLine("Transection Record Inserted Successfully");
        }
    }
}
