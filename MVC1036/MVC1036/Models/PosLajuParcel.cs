﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC1036.Models {
    public class PosLajuParcel {
        [Display(Name = "Date & Time")]
        public DateTime ParcelDateTime {
            get {
                return DateTime.Now;
            }

            set {

            }
        }

        [Display(Name = "Date & Time")]
        public DateTime ViewDateTime {
            get;
            set;
        }

        [Display(Name = "Parcel ID")]
        public string ParcelId {
            get {
                string hexTicks = DateTime.Now.Ticks.ToString("X");
                return hexTicks.Substring(hexTicks.Length - 10, 10);
            }

            set {

            }
        }

        [Display(Name = "Parcel ID")]
        public string ViewId {
            get;
            set;
        }
        
        [Required]
        [Display(Name = "Sender Name")]
        public string SenderName { 
            get; 
            set; 
        }

        [Required]
        [Display(Name = "Sender Address")]
        public string SenderAddress {
            get;
            set;
        }

        [Required]
        [Display(Name = "Sender Phone")]
        public string SenderPhone {
            get;
            set;
        }

        [Display(Name = "Sender Email")]
        public string SenderEmail {
            get;
            set;
        }
        [Required]
        [Display(Name = "Receiver Name")]
        public string ReceiverName {
            get;
            set;
        }

        [Required]
        [Display(Name = "Receiver Address")]
        public string ReceiverAddress {
            get;
            set;
        }

        [Required]
        [Display(Name = "Receiver Phone")]
        public string ReceiverPhone {
            get;
            set;
        }

        [Display(Name = "Receiver Email")]
        public string ReceiverEmail {
            get;
            set;
        }

        [Required]
        [Display(Name = "Weight")]
        public int IndexWeight {
            get;
            set;
        }

        [Required]
        [Display(Name = "Zone")]
        public int IndexZone {
            get;
            set;
        }

        [DisplayFormat(DataFormatString ="{0:c2}")]
        [Display(Name = "Paid Amount")]
        public double Amount {
            get {
                return rates[IndexWeight, IndexZone];
            }

            set {

            }
        }

        public IDictionary<int, string> DictWeight {
            get {
                return new Dictionary<int, string>() {
                    {0, "< 0.50 kg"},
                    {1, "< 0.75 kg"},
                    {2, "< 1.00 kg"},
                    {3, "< 1.25 kg"},
                    {4, "< 1.50 kg"},
                    {5, "< 1.75 kg"},
                    {6, "< 2.00 kg"},
                    {7, "< 2.50 kg"},
                    {8, "< 3.00 kg"}
                };
            }

            set {

            }
        }
        [Display(Name = "Zone")]
        public IDictionary<int, string> DictZone {
            get {
                return new Dictionary<int, string>() {
                    {0, "West Malaysia" },
                    {1, "Sabah" },
                    {2, "Sarawak" }
                };
            }
        }

        static double[,] rates = {
            {6.00, 8.50, 9.00 },
            {7.00, 10.50, 12.00 },
            {8.50, 12.50, 14.50 },
            {10.00, 14.50, 17.00 },
            {11.00, 16.50, 20.00 },
            {12.50, 18.50, 22.50 },
            {14.00, 20.50, 25.00 },
            {21.00, 34.50, 41.00 },
            {24.00, 39.00, 46.00 }
        };

    }
}
