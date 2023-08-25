using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS.Model;
using BS.Model.Generic;
using BS.DataAccess;

namespace BankingSystem 
{
    class Program 
    {
        static void Main(string[] args)
        {
            CustomerInformation objCustomerInformation = new CustomerInformation();
            objCustomerInformation.Id = 101;
            objCustomerInformation.customerName = "Darshan";
            objCustomerInformation.customerMobileNumber = 9712223932;
            objCustomerInformation.customerAddress = "Surat";
            objCustomerInformation.createdon = DateTime.Now;

            CustomerAccountManage objcustomerAccountManage = new CustomerAccountManage();
            objcustomerAccountManage.Id = 201;
            objcustomerAccountManage.accountNumber = 10111;
            objcustomerAccountManage.accountType = 401;
            objcustomerAccountManage.accountBalance = 5000;
            objcustomerAccountManage.branch = "Surat";
            objcustomerAccountManage.ifscCode = "ST123";
            objcustomerAccountManage.customerInformationId = 101;
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
            objTransection.transectionType = 403;
            objTransection.transectionAmmount = 500;
            objTransection.Id = 201;
            objcustomerAccountManage.createdon = DateTime.Now;

            CreditCardDetail objCreditCardDetail = new CreditCardDetail();
            objCreditCardDetail.Id = 601;
            objCreditCardDetail.CardNumber = 6186;
            objCreditCardDetail.createdon = DateTime.Now;
            objCreditCardDetail.CardLimit = 50000;
            objCreditCardDetail.Id = 201;

            Console.WriteLine($"{objCustomerInformation.Id}\t{objCustomerInformation.customerName}\t{objCustomerInformation.customerMobileNumber}\t{objCustomerInformation.customerAddress}\t{objCustomerInformation.createdon}");
            Console.WriteLine($"\n{objcustomerAccountManage.Id}\t{objcustomerAccountManage.accountNumber}\t{objcustomerAccountManage.accountType}\t{objcustomerAccountManage.accountBalance}\t{objcustomerAccountManage.branch}\t{objcustomerAccountManage.ifscCode}\t{objcustomerAccountManage.customerInformationId}\t{objcustomerAccountManage.createdon}");
            Console.WriteLine($"\n{objAccountorTransectionType.Id}\t{objAccountorTransectionType.AccountorTransectionTypeName}\t");
            Console.WriteLine($"\n{objAccountorTransectionValue.Id}\t{objAccountorTransectionValue.AccountorTransectionValueName}\t{objAccountorTransectionValue.AccountorTransectionTypeId}\t");
            Console.WriteLine($"\n{objTransection.Id}\t{objTransection.transectionType}\t{objTransection.transectionAmmount}\t{objTransection.Id}\t{objcustomerAccountManage.createdon}\t");
            Console.WriteLine($"\n{objCreditCardDetail.Id}\t{objCreditCardDetail.CardNumber}\t{objCreditCardDetail.createdon}\t{objCreditCardDetail.CardLimit}\t{objCreditCardDetail.Id}");
            Console.ReadKey();
        }
    }
}
