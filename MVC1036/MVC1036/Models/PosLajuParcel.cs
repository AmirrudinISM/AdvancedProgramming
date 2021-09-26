using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC1036.Models {
    public class PosLajuParcel {
        public DateTime ParcelDateTime {
            get {
                return DateTime.Now;
            }

            set {

            }
        }

        public string ParcelId {
            get {
                string hexTicks = DateTime.Now.Ticks.ToString("X");
                return hexTicks.Substring(hexTicks.Length - 10, 10);
            }

            set {

            }
        }
        
        [Required]
        public string SenderName { 
            get; 
            set; 
        }
        [Required]
        public string SenderAddress {
            get;
            set;
        }
        [Required]
        public string SenderPhone {
            get;
            set;
        }
        public string SenderEmail {
            get;
            set;
        }
        [Required]
        public string ReceiverName {
            get;
            set;
        }
        [Required]
        public string ReceiverAddress {
            get;
            set;
        }
        [Required]
        public string ReceiverPhone {
            get;
            set;
        }
        public string ReceiverEmail {
            get;
            set;
        }

        [Required]
        public int IndexWeight {
            get;
            set;
        }
        [Required]
        public int IndexZone {
            get;
            set;
        }
        [DisplayFormat(DataFormatString ="{0:n2}")]
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
