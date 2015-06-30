using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using LinqToExcel;
using LinqToExcel.Query;
using System.Linq;

//using Remotion.Data.Linq;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        public salesforce.SforceService mySFDCConnection;
        private bool fileOpened = false;
        private string openFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;
            psaExpense1.psaConcurExpenseReport myReport = new psaExpense1.psaConcurExpenseReport();
            psaExpense1.psaConcurExpense myExpense = new psaExpense1.psaConcurExpense();


            myReport.approverId = "44";
            myReport.billable = true;
            myReport.billableSpecified = true;
            myReport.concurExtractDate = DateTime.Today;
            myReport.concurExtractDateSpecified = true;
            myReport.concurReportKey = "010";
            myReport.dateReimbursed = DateTime.Today;
            myReport.dateReimbursedSpecified = true;
            myReport.dateSubmitted = DateTime.Today;
            myReport.dateSubmittedSpecified = true;
            myReport.description = "test Run";
            myReport.projectCode = "PR-001936";
            myReport.reportName = "test me";
            myReport.resourceId = "99990";


            myExpense.billable = true;
            myExpense.billableSpecified = true;
            myExpense.concurEntryId = "987";
            myExpense.description = "Cell phone";
            myExpense.expenseAmount = 900;
            myExpense.expenseAmountSpecified = true;
            myExpense.expenseCountry = "US";
            myExpense.expenseCurrencyCode="USD";
            myExpense.expenseDate = DateTime.Today;
            myExpense.expenseDateSpecified = true;
            myExpense.expenseNonBillableAmount = 0;
            myExpense.expenseNonBillableAmountSpecified = true;
            myExpense.expenseState = "UT";
            myExpense.expenseType = "Barf";
            myExpense.expenseVendor = "ATT";
            myExpense.govAllowanceAmount = 9;
            myExpense.govAllowanceAmountSpecified = true;

            myExpense.incurredTaxAmount = 8;
            myExpense.incurredTaxAmountSpecified = true;
            myExpense.incurredTaxNonBillable = false;
            myExpense.incurredTaxNonBillableSpecified = true;
            myExpense.millage = 9;
            myExpense.millageReimbursementRate = 0.1;
            myExpense.millageReimbursementRateSpecified = true;
            myExpense.millageSpecified = true;
            myExpense.nonReimbursible = false;
            myExpense.nonReimbursibleSpecified = true;
            myExpense.notes = "kjsfdhgakj";
            myExpense.numberOfAttendees = 0;
            myExpense.numberOfAttendeesSpecified = false;
            myExpense.taxType = "raet";

            psaExpense1.psaConcurExpenseReport[] myArray;
            psaExpense1.psaConcurExpense[] myExpArr;

            myArray=new psaExpense1.psaConcurExpenseReport[1];
            myExpArr = new psaExpense1.psaConcurExpense[1];
            myExpArr[0] = myExpense;


            myReport.expenses = myExpArr;
            myArray[0]=myReport;


            mySFDCConnection = new salesforce.SforceService();

            salesforce.LoginResult loginSFDC;

            //mySFDCConnection.Url = siteLocation;

            loginSFDC = mySFDCConnection.login("itapi@manh.com.gsa", "Manhattan123");

            mySFDCConnection.SessionHeaderValue = new salesforce.SessionHeader();
            mySFDCConnection.SessionHeaderValue.sessionId = loginSFDC.sessionId;
            mySFDCConnection.Url = loginSFDC.serverUrl;

            psaExpense1.psaExpenseWSFacadeService myService = new psaExpense1.psaExpenseWSFacadeService();           

            ICredentials credentials = new NetworkCredential("itapi@manh.com.gsa", "Manhattan123", "US");

            myService.Credentials = credentials;
            myService.SessionHeaderValue = new psaExpense1.SessionHeader();

            myService.SessionHeaderValue.sessionId = loginSFDC.sessionId;

           

            myService.insertExpenses("9", myArray);           

        }

        public void SFDCLogin()
        {
            //Login to salesforce

            mySFDCConnection = new salesforce.SforceService();
            salesforce.LoginResult loginSFDC;

            //mySFDCConnection.Url = siteLocation;

            loginSFDC = mySFDCConnection.login("itapi@manh.com.gsa", "Manhattan123");


            mySFDCConnection.SessionHeaderValue = new salesforce.SessionHeader();
            mySFDCConnection.SessionHeaderValue.sessionId = loginSFDC.sessionId;
            mySFDCConnection.Url = loginSFDC.serverUrl;


        }

        #region "User"
        private void button2_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;
            psaUser.psaWorkdayResource[] myArray;

            myArray = GetUserDatafromFile();
            CreateUser(myArray);
        }

        private void CreateUser(psaUser.psaWorkdayResource[] inArray)
        {
            psaUser.psaWebServiceFacadeService myUserService = CreateSFDCConnection();

            psaUser.psaWorkDayWSResponse myresp ;//= new psaUser.psaWorkDayWSResponse();


            myresp = myUserService.upsertWorkdayResource(inArray);
            
            txtResults.Text = string.Empty;

            if (myresp.errorList != null)
            {
                foreach (var a in myresp.errorList)
                {
                    txtResults.Text += "error: " + a.referenceId + ":" + a.errorMessage + Environment.NewLine;
                }
            }

            if (myresp.successList != null)
            {

                foreach (var a in myresp.successList)
                {
                    txtResults.Text += "Winner: " + a.referenceId + ":" + a.successMessage + Environment.NewLine;
                }
            }

        }

        private psaUser.psaWebServiceFacadeService CreateSFDCConnection()
        {
            mySFDCConnection = new salesforce.SforceService();

            salesforce.LoginResult loginSFDC;

            //mySFDCConnection.Url = siteLocation;

            loginSFDC = mySFDCConnection.login("itapi@manh.com.gsa", "Manhattan123");


            mySFDCConnection.SessionHeaderValue = new salesforce.SessionHeader();
            mySFDCConnection.SessionHeaderValue.sessionId = loginSFDC.sessionId;
            mySFDCConnection.Url = loginSFDC.serverUrl;

            psaUser.psaWebServiceFacadeService myUserService = new psaUser.psaWebServiceFacadeService();

            ICredentials credentials = new NetworkCredential("itapi@manh.com.gsa", "Manhattan123", "US");

            myUserService.Credentials = credentials;
            myUserService.SessionHeaderValue = new psaUser.SessionHeader();


            myUserService.SessionHeaderValue.sessionId = loginSFDC.sessionId;
            return myUserService;
        }

        private psaUser.psaWorkdayResource[] GetUserDatafromFile()
        {
            string pathToExcelFile = openFileName;
                //+ @"C:\Code\GPWebServicesTest\WindowsFormsApplication1\WindowsFormsApplication1\HRApp.xlsx";

            string sheetName = "Sheet1";

            var excelFile = new ExcelQueryFactory(pathToExcelFile);

            
            var userData = from a in excelFile.Worksheet(sheetName)
                           where a["Employee ID"].Equals(textBox1.Text)
                          
                           select a;

            List<psaUser.psaWorkdayResource> myList = new List<psaUser.psaWorkdayResource>();

            foreach (var a in userData)
            {
               myList.Add(Assemble(a));
            }

            //psaUser.psaWorkdayResource[] myArray;

           return myList.ToArray();

        }

        private psaUser.psaWorkdayResource Assemble(LinqToExcel.Row myRow)
        {

            psaUser.psaWorkdayResource myResource = new psaUser.psaWorkdayResource();
            myResource.careerInterests = myRow["Career Interests"].ToString();
            myResource.citizenship = myRow["Citizenship Status"].ToString();
            myResource.city = myRow["Work Address - City"].ToString();
            myResource.continuousServiceDate = DateTime.Parse(myRow["Continuous Service Date"].ToString());
            myResource.continuousServiceDateSpecified = true;
            myResource.costCenter = myRow["Cost Center - ID"].ToString();
            myResource.country = myRow["Work Address - Country"].ToString();
            string tmpEmail = myRow["Email - Primary Work"].ToString().Replace("@", "=");
            myResource.email = tmpEmail + "@example.com";          
            myResource.firstName = myRow["Preferred Name - First Name"].ToString();
            myResource.lastName = myRow["Preferred Name - Last Name"].ToString();
            myResource.location = myRow["Work Address - Country"].ToString(); ;// myRow["Location"].ToString();
            myResource.managerId = myRow["Manager - Level 01 ID"].ToString();
            myResource.mobile = myRow["Mobile Phone"].ToString();
            myResource.phone = myRow["Phone - Primary Work"].ToString();
            myResource.startDate = DateTime.Parse(myRow["Original Hire Date"].ToString());
            myResource.startDateSpecified = true;
            myResource.state = myRow["Work Address - State/Province"].ToString();
            myResource.stateWitholding = myRow["State Withholding (Resident) - State"].ToString();

            string tempStreet = myRow["Work Address - Formatted Line 1"].ToString().TrimEnd() + "," + myRow["Work Address - Formatted Line 2"].ToString().TrimEnd() + "," + myRow["Work Address - Formatted Line 3"].ToString().TrimEnd();
            myResource.street = tempStreet;

            myResource.title = myRow["Position"].ToString();
            myResource.workdDayEmployeeId = myRow["Employee ID"].ToString();
            myResource.zip = myRow["Work Address - Postal Code"].ToString();
            myResource.currencyISOCode = myRow["Currency for Primary Position"].ToString(); 
            myResource.company = getCompanyData(myResource.costCenter);//"Manhattan Associates - India";
            myResource.contingentWorkerType = myRow["Contingent Worker Type"].ToString();
            myResource.departmentOwnerId = myRow["Manager - Level 03 ID"].ToString();

            DateTime temp;
            
            bool success = DateTime.TryParse(myRow["Last Day of Work"].ToString(), out temp);

            myResource.endDate = temp;
            myResource.endDateSpecified = success;

            myResource.groupLeadAltManagerId = myRow["Manager - Level 02 ID"].ToString();
            myResource.isContingentWorker = myRow["Worker is Contingent Worker"].Cast<bool>();
            myResource.isContingentWorkerSpecified = true;
            myResource.resourceRole = myRow["Work Experience"].ToString();         
            myResource.techCode = myRow["Workday Account"].ToString();
            myResource.tenure = myRow["Length of Service in Months"].ToString();            
            myResource.workerType = myRow["Position Worker Type"].ToString();

            //?????????????????????????????????
            //myResource.resourceStatus = myRow[""].ToString();  
            // myResource.level = myRow[""].ToString();
            //myResource.timeType = myRow[""].ToString();
            myResource.weeklyScheduledHours = "40";// myRow[""].ToString();

            return myResource;

        }

        private string getCompanyData(string DepartmentCode)
        {
            
            string tmp = string.Empty;

            switch (DepartmentCode.Substring(0,2))
            {


                case "10":
                    tmp="Manhattan Associates - US";
                    break;

                case "20":
                    tmp="Manhattan Associates - Netherlands";
                    break;

                case "30":
                    tmp="Manhattan Associates - United Kingdom";
                    break;
                case "40":
                    tmp="Manhattan Associates - France";
                    break;
                case "60":
                    tmp = "Manhattan Associates - Australia";
                    break;
                case "80":
                    tmp="Manhattan Associates - China";
                    break;
                case "85":
                    tmp="Manhattan Associates - Singapore";
                    break;
                case "90":
                    tmp="Manhattan Associates - India";
                    break;


            }

            return tmp;

        }

        private string getCountryData(string DepartmentCode)
        {

            string tmp = string.Empty;

            switch (DepartmentCode.Substring(0, 2))
            {


                case "10":
                    tmp = "US";
                    break;

                case "20":
                    tmp = "Netherlands";
                    break;

                case "30":
                    tmp = "United Kingdom";
                    break;
                case "40":
                    tmp = "France";
                    break;
                case "60":
                    tmp = "Australia";
                    break;
                case "80":
                    tmp = "China";
                    break;
                case "85":
                    tmp = "Singapore";
                    break;
                case "90":
                    tmp = "India";
                    break;


            }

            return tmp;

        }

#endregion

        #region "PTO"
        


        private psaUser.psaWorkdayPTO[] GetPTODatafromFile()
        {
            string pathToExcelFile = openFileName;

            //string sheetName = "Sheet1";

            var excelFile = new ExcelQueryFactory(pathToExcelFile);

            var PTOData = excelFile.Worksheet(0).Where(a => a["Employee"] != null).ToList();                          

            List<psaUser.psaWorkdayPTO> myList = new List<psaUser.psaWorkdayPTO>();

            foreach (var a in PTOData)
            {
                myList.Add(AssemblePTO(a));
            }

            return myList.ToArray();
        }

        private void CreateTimeOff(psaUser.psaWorkdayPTO[] inArray)
        {
            psaUser.psaWebServiceFacadeService myUserService = CreateSFDCConnection();

            psaUser.psaWorkDayWSResponse myresp;//= new psaUser.psaWorkDayWSResponse();

            myresp = myUserService.upsertWorkdayPTO(inArray);

            txtResults.Text = string.Empty;

            if (myresp.errorList !=null)
            {
                foreach (var a in myresp.errorList)
                {
                    txtResults.Text += "error: " + a.referenceId + ":" + a.errorMessage + Environment.NewLine;
                }
            }

            if (myresp.successList != null)
            {

                foreach (var a in myresp.successList)
                {
                    txtResults.Text += "Winner: " + a.referenceId + ":" + a.successMessage + Environment.NewLine;
                }
            }

        }

        private psaUser.psaWorkdayPTO AssemblePTO(LinqToExcel.Row myRow)
        {
            psaUser.psaWorkdayPTO myPTO = new psaUser.psaWorkdayPTO();

            myPTO.dayOfWeek = DateTime.Parse(myRow["Date"]).DayOfWeek.ToString() ;
            myPTO.hours = System.Convert.ToInt32(myRow["Requested"].Value);
            myPTO.hoursSpecified = true;
            myPTO.timeOffDate = DateTime.Parse(myRow["Date"]);
            myPTO.timeOffDateSpecified=true;
            myPTO.workDayPTOId = myRow["Spreadsheet Key"].ToString();
            myPTO.workdDayEmployeeId = myRow["Employee"].ToString();

            return myPTO;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;
            psaUser.psaWorkdayPTO[] myArray;
            myArray = GetPTODatafromFile();
            CreateTimeOff(myArray);
        }
        #endregion
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!fileOpened)
            {
                openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                openFileDialog1.FileName = null;
            }

            // Display the openFile dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // OK button was pressed. 
            if (result == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;

                //Invalidate();
            }

            // Cancel button was pressed. 
            else if (result == DialogResult.Cancel)
            {
                return;
            }


        }


//Worker.Preferred Name - First Name
//Worker.Preferred Name - Last Name
//Left 8 (Worker.Email - Primary Work) remove "@manh.com"
//((Worker.Email - Primary Work) remove "@manh.com") + count to make unique
//Worker.Email - Primary Work
//Find Default Profile ID on Practice
//Find Default Locale on Region
//Worker.Currency for Primary Position
//Worker.Email - Primary Work
//Worker.Phone - Primary Work
//Worker.Primary Position
//Worker.Company Hierarchy.Level 01 from the Top
//Worker.Cost Center (left 2 characters)
//Worker.Cost Center (right 3 characters)
//Worker.Employee ID
//Worker.Cost Center - ID
//Worker.Account
//Worker.Original Hire Date
//Worker.Continuous Service Date
//Worker.Last Day of Work
//Worker.Management Chain - Level 01
//Worker.Management Chain - Level 02
//Worker.Management Chain - Level 03
//Worker.Mobile Phone
//Worker.Work Address - Formatted Line 1+Worker.Work Address - Formatted Line 2+Worker.Work Address - Formatted Line 3
//Worker.Work Address - City
//Worker.Work Address - State/Province
//Worker.Work Address - Postal Code
//Worker.Work Address - Country
//Worker.State Withholding (Resident) - State
//Worker.Citizenship Status
//Worker.Worker Status
//Worker.Worker is Contingent Worker
//Worker.Contingent Worker Type
//Worker.Length of Service in Months
//Worker.Career Interests
//Worker.Position Worker Type
//Worker.Location
//Worker.Work Experience

    }
}
