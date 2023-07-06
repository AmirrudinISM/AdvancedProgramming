using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using MVC1036.Models;
using MVC1036.MailSettings;
using System.Diagnostics;

namespace MVC1036.Controllers {
    public class PosLajuParcelController : Controller {
        private readonly IConfiguration configuration;
        public PosLajuParcelController(IConfiguration config) {
            this.configuration = config;
        }
        public IActionResult Index() {
            IList<PosLajuParcel> dbList = GetDbList();
            return View(dbList);
        }

        public IActionResult Error() {
            return View();
        }

        [HttpGet]
        public IActionResult ParcelDelivery() {
            PosLajuParcel parcel = new PosLajuParcel();
            parcel.IndexWeight = parcel.IndexZone = -1;
            return View(parcel);
        }

        [HttpPost]
        public IActionResult ParcelDelivery(PosLajuParcel parcel) {
            if (ModelState.IsValid) {
                Console.WriteLine("Model state is valid");
                SqlConnection conn = new SqlConnection(configuration.GetConnectionString("ParcelConnStr"));
                SqlCommand cmd = new SqlCommand("spInsertParcel", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@parcelid", parcel.ParcelId); 
                cmd.Parameters.AddWithValue("@parceldatetime", parcel.ParcelDateTime); 
                cmd.Parameters.AddWithValue("@sendername", parcel.SenderName); 
                cmd.Parameters.AddWithValue("@senderaddress", parcel.SenderAddress); 
                cmd.Parameters.AddWithValue("@senderphone", parcel.SenderPhone);
                //cmd.Parameters.AddWithValue("@senderemail", parcel.SenderEmail);
                if (parcel.SenderEmail != null)
                    cmd.Parameters.AddWithValue("@senderemail", parcel.SenderEmail);
                else
                    cmd.Parameters.AddWithValue("@senderemail", "");

                cmd.Parameters.AddWithValue("@receivername", parcel.ReceiverName); 
                cmd.Parameters.AddWithValue("@receiveraddress", parcel.ReceiverAddress); 
                cmd.Parameters.AddWithValue("@receiverphone", parcel.ReceiverPhone);
                //cmd.Parameters.AddWithValue("@receiveremail", parcel.ReceiverEmail);
                if (parcel.ReceiverEmail != null)
                    cmd.Parameters.AddWithValue("@receiveremail", parcel.ReceiverEmail); 
                else
                    cmd.Parameters.AddWithValue("@receiveremail", "");

                cmd.Parameters.AddWithValue("@indexweight", parcel.IndexWeight); 
                cmd.Parameters.AddWithValue("@indexzone", parcel.IndexZone); 
                cmd.Parameters.AddWithValue("@amount", parcel.Amount);

                try {
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e) {
                    Console.WriteLine(e.ToString());
                    return View(parcel);
                }
                finally {
                    conn.Close();
                }
                return View("ParcelDeliveryInvoice", parcel);
            }
            else {
                
                return View(parcel);
                
            }
        }

        public IActionResult Details(string id) {
            IList<PosLajuParcel> dbList = GetDbList();
            var result = dbList.First(x => x.ViewId == id);
            return View(result);
        }

        [HttpGet]
        public IActionResult Edit(string id) {
            IList<PosLajuParcel> dbList = GetDbList();
            var result = dbList.First(x => x.ViewId == id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(string id, PosLajuParcel parcel) {
            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("ParcelConnStr"));
            SqlCommand cmd = new SqlCommand("spUpdateParcel", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@receivername", parcel.ReceiverName);
            cmd.Parameters.AddWithValue("@receiveraddress", parcel.ReceiverAddress);
            cmd.Parameters.AddWithValue("@receiverphone", parcel.ReceiverPhone);
            cmd.Parameters.AddWithValue("@receiveremail", parcel.ReceiverEmail);
            try {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                RedirectToAction("Error");
            }
            finally {
                conn.Close();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(string id) {
            IList<PosLajuParcel> dbList = GetDbList();
            var result = dbList.First(x => x.ViewId == id);
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(string id) {
            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("ParcelConnStr"));
            SqlCommand cmd = new SqlCommand("spDeleteParcel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            try {
                conn.Open();
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
            finally {
                conn.Close();
            }
        }

        IList<PosLajuParcel> GetDbList() {
            IList<PosLajuParcel> dbList = new List<PosLajuParcel>();
            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("ParcelConnStr"));
            string sql = @"SELECT * FROM PosLajuParcels";
            SqlCommand cmd = new SqlCommand(sql, conn);
            Console.WriteLine("TEST HERE");

            try {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    dbList.Add(new PosLajuParcel() {
                        ViewId = reader.GetString(0),
                        ViewDateTime = reader.GetDateTime(1),
                        SenderName = reader.GetString(2),
                        SenderAddress = reader.GetString(3),
                        SenderPhone = reader.GetString(4),
                        SenderEmail = reader.GetString(5),
                        ReceiverName = reader.GetString(6),
                        ReceiverAddress = reader.GetString(7),
                        ReceiverPhone = reader.GetString(8),
                        ReceiverEmail = reader.GetString(9),
                        IndexWeight = reader.GetInt32(10),
                        IndexZone = reader.GetInt32(11),
                        Amount = reader.GetDouble(12)
                    });
                }
            }
            catch(SqlException e) {
                Console.WriteLine(e.Message);
                RedirectToAction("Error");
            }
            finally {
                conn.Close();
            }
            return dbList;

        }

        public IActionResult SearchIndex(string searchString = "") {
            IList<PosLajuParcel> dbList = GetDbList();
            var result = dbList.Where(x => x.ViewId.ToLower().Contains(searchString.ToLower()) || x.SenderName.ToLower().Contains(searchString.ToLower())).OrderBy(x => x.SenderName).ThenByDescending(x => x.ViewDateTime);
            return View("Index", result);
        }

        public IActionResult SendMail(string id) {
            IList<PosLajuParcel> dbList = GetDbList();
            var result = dbList.First(x => x.ViewId == id);
            var subject = "Parcel Information " + result.ViewId;
            var body = "Parcel id: " + result.ViewId + "<br>" +
                "Date and time: " + result.ViewDateTime + "<br>" +
                "Sender name: "+ result. SenderName + " <br> " +
                "Receiver name: "+ result.ReceiverName + " <br> " +
                "Receiver address: " + result.ReceiverAddress + "<br>" +
                "Receiver phone: " + result.ReceiverPhone + "<br>" +
                "Weight: " + result.DictWeight[result.IndexWeight] + "<br>" +
                "Zone: " + result.DictZone[result.IndexZone] + "<br>" +
                "Amount: "+ result.Amount.ToString("c2");
            
            var mail = new Mail(configuration);

            if (mail.Send(configuration["Gmail:Username"], result.SenderEmail, subject, body)) {
                ViewBag.Message = "Mail successfully sent to " + result.SenderEmail;
                ViewBag.Body = body;
            }
            else {
                ViewBag.Message = "Sent Mail Failed";
                ViewBag.Body = "";
            }
            return View(result);
        }

    }
}
