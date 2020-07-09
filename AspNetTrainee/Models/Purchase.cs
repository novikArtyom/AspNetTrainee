using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTrainee.Models
{
    public class Purchase
    {

        private int PurchaseId { get; set; }

        private string BuyerName { get; set; }

        private string BuyerPhone { get; set; }

        private string BuyerMail { get; set; }

        public int PhoneId { get; set; }
    }
}