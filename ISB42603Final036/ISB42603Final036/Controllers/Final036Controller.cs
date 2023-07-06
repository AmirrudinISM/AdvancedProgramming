using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ISB42603Final036.Models;


namespace ISB42603Final036.Controllers {
    public class Final036Controller : Controller {
        private readonly IConfiguration configuration;
        public Final036Controller(IConfiguration config) {
            this.configuration = config;
        }

        IList<HousingLoan> GetDbList() {
            IList<HousingLoan> dbList = new List<HousingLoan>();
            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("ConnLoan"));
            string sql = @"SELECT * FROM Loan036";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    dbList.Add(new HousingLoan() {
                        CustomerID = reader.GetString(0),
                        Name = reader.GetString(1),
                        Gender = reader.GetString(2),
                        CreditStatus = reader.GetString(3),
                        Principal = reader.GetDouble(4),
                        InterestRate = reader.GetDouble(5),
                        NumberOfYears = reader.GetInt32(6),
                        MonthlyPayment = reader.GetDouble(7)
                    });
                }
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
            finally {
                conn.Close();
            }
            return dbList;

        }
        public IActionResult Index() {
            IList<HousingLoan> dbList = GetDbList();
            ViewBag.HighestPrincipal = dbList.Max(x => x.Principal);
            ViewBag.LowestPrincipal = dbList.Min(x => x.Principal);
            ViewBag.AveragePaymentFemale = dbList.Where(x => x.Gender == "F").Average(x => x.MonthlyPayment);
            ViewBag.AveragePaymentMale = dbList.Where(x => x.Gender == "M").Average(x => x.MonthlyPayment);
            return View(dbList);
        }

        [HttpGet]
        public IActionResult LoanApplication036() {
            HousingLoan loan = new HousingLoan();
            return View(loan);
        }

        [HttpPost]
        public IActionResult LoanApplication036(HousingLoan loan) {
            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("ConnLoan"));
            SqlCommand cmd = new SqlCommand("spInsertData036", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", loan.CustomerID);
            cmd.Parameters.AddWithValue("@name", loan.Name);
            cmd.Parameters.AddWithValue("@gender", loan.Gender);
            cmd.Parameters.AddWithValue("@creditRisk", loan.CreditStatus);
            cmd.Parameters.AddWithValue("@principal", loan.Principal);
            cmd.Parameters.AddWithValue("@interestrate", loan.InterestRate);
            cmd.Parameters.AddWithValue("@numberofyears", loan.NumberOfYears);
            cmd.Parameters.AddWithValue("@monthlypayment", loan.MonthlyPayment);

            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                return View(loan);
            }
            finally {
                conn.Close();
            }

            return View("LoanApplicationResult036", loan);
        }
    }
}
