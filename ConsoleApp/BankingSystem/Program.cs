using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BS.Model.Generic;
using BS.DataAccess;

namespace BankingSystem 
{
    public class Program 
    {
        static void Main(string[] args)
        {

           // new BS.DataAccess.Class1().AllTablesetAccountorTransectionType();
            //new BS.DataAccess.Class1().InsertCustomerInformation();
            //new BS.DataAccess.Class1().InsertCustomerAccountManage();
            //new BS.DataAccess.Class1().InsertAccountorTransectionType();
            //new BS.DataAccess.Class1().InsertAccountorTransectionValue();
            //new BS.DataAccess.Class1().InsertTransection();

            CustomerInformation objCustomerInformation = new CustomerInformation();
            objCustomerInformation.Id = 101;
            objCustomerInformation.CustomerName = "Darshan";
            objCustomerInformation.CustomerMobileNumber = 9712223932;
            objCustomerInformation.CustomerAddress = "Surat";
            objCustomerInformation.createdon = DateTime.Now;

            CustomerAccountManage objcustomerAccountManage = new CustomerAccountManage();
            objcustomerAccountManage.Id = 201;
            objcustomerAccountManage.AccountNumber = 10111;
            objcustomerAccountManage.AccountType = 401;
            objcustomerAccountManage.AccountBalance = 5000;
            objcustomerAccountManage.BranchId = 1001;
            objcustomerAccountManage.CustomerInformationId = 101;
            objcustomerAccountManage.createdon = DateTime.Now;

            AccountorTransectionType objAccountorTransectionType = new AccountorTransectionType();
            objAccountorTransectionType.Id = 301;
            objAccountorTransectionType.AccountorTransectionTypeName = "Account";

            AccountorTransectionValue objAccountorTransectionValue = new AccountorTransectionValue();
            objAccountorTransectionValue.Id = 401;
            objAccountorTransectionValue.AccountorTransectionValueName = "Savings";
            objAccountorTransectionValue.AccountorTransectionTypeId = 301;


            Transection objTransection = new Transection();
            objTransection.Id = 501;
            objTransection.TransectionType = 403;
            objTransection.TransectionAmmount = 500;
            objTransection.TransectionMethod = 405;
            objTransection.CustomerAccountManageId = 201;
            objcustomerAccountManage.createdon = DateTime.Now;

            CreditCardDetail objCreditCardDetail = new CreditCardDetail();
            objCreditCardDetail.Id = 601;
            objCreditCardDetail.CardNumber = 6186;
            objCreditCardDetail.createdon = DateTime.Now;
            objCreditCardDetail.CardLimit = 50000;
            objCreditCardDetail.CustomerAccountManageId = 201;

            Loan objLoan = new Loan();
            objLoan.Id = 701;
            objLoan.LoanType = 409;
            objLoan.LoanNumber = 10101;
            objLoan.IssuedLoanAmount = 100000;
            objLoan.RemainingLoanAmmount = 98000;
            objLoan.BranchId = 1001;
            objLoan.CustomerAccountManageId = 201;

            LoanPayment objLoanPayment = new LoanPayment();
            objLoanPayment.Id = 801;
            objLoanPayment.PaymentAmount = 2000;
            objLoanPayment.LoanID = 701;

            Bank objBank = new Bank();
            objBank.Id = 901;
            objBank.BankerName = "Mitesh";
            objBank.BranchId = 1001;

            Branch objBranch = new Branch();
            objBranch.Id = 901;
            objBranch.BranchName = "ST123";
            objBranch.BranchAddress = "Surat";
            objBranch.BranchIFSC = "123456";

            BankServer objBankServer = new BankServer();
            objBankServer.Id = 1101;
            objBankServer.CustomerAccountManageId = 201;
            objBankServer.TransectionId = 501;
            objBankServer.CreditCardDetailID = 601;
            objBankServer.LoanID = 701;
            objBankServer.createdon = DateTime.Now;

            Console.WriteLine($"\n{objCustomerInformation.Id}\t{objCustomerInformation.CustomerName}\t{objCustomerInformation.CustomerMobileNumber}\t{objCustomerInformation.CustomerAddress}\t{objCustomerInformation.createdon}");
            Console.WriteLine($"\n{objcustomerAccountManage.Id}\t{objcustomerAccountManage.AccountNumber}\t{objcustomerAccountManage.AccountType}\t{objcustomerAccountManage.AccountBalance}\t{objcustomerAccountManage.BranchId}\t{objcustomerAccountManage.CustomerInformationId}\t{objcustomerAccountManage.createdon}");
            Console.WriteLine($"\n{objAccountorTransectionType.Id}\t{objAccountorTransectionType.AccountorTransectionTypeName}\t");
            Console.WriteLine($"\n{objAccountorTransectionValue.Id}\t{objAccountorTransectionValue.AccountorTransectionValueName}\t{objAccountorTransectionValue.AccountorTransectionTypeId}\t");
            Console.WriteLine($"\n{objTransection.Id}\t{objTransection.TransectionType}\t{objTransection.TransectionAmmount}\t{objTransection.TransectionMethod}\t{objTransection.CustomerAccountManageId}\t{objTransection.createdon}\t");
            Console.WriteLine($"\n{objCreditCardDetail.Id}\t{objCreditCardDetail.CardNumber}\t{objCreditCardDetail.createdon}\t{objCreditCardDetail.CardLimit}\t{objCreditCardDetail.CustomerAccountManageId}");
            Console.WriteLine($"\n{objLoan.Id}\t{objLoan.LoanNumber}\t{objLoan.LoanType}\t{objLoan.IssuedLoanAmount}\t{objLoan.RemainingLoanAmmount}\t{objLoan.BranchId}\t{objLoan.CustomerAccountManageId}\t");
            Console.WriteLine($"\n{objLoanPayment.Id}\t{objLoanPayment.PaymentAmount}\t{objLoanPayment.LoanID}\t");
            Console.WriteLine($"\n{objBank.Id}\t{objBank.BankerName}\t{objBank.BranchId}\t");
            Console.WriteLine($"\n{objBranch.Id}\t{objBranch.BranchName}\t{objBranch.BranchAddress}\t{objBranch.BranchIFSC}\t");
            Console.WriteLine($"\n{objBankServer.Id}\t{objBankServer.Id}\t{objBankServer.CustomerAccountManageId}\t{objBankServer.TransectionId}\t{objBankServer.CreditCardDetailID}\t{objBankServer.LoanID}\t{objBankServer.createdon}\t");
            Console.ReadKey();
        }
    }
}
