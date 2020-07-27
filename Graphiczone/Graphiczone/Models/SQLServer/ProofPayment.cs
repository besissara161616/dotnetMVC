﻿using System;
using System.Collections.Generic;

namespace Graphiczone.Models.SQLServer
{
    public partial class ProofPayment
    {
        public string OrPrintId { get; set; }
        public string PrfPayId { get; set; }
        public string PrfPayBank { get; set; }
        public DateTime? PrfPayDate { get; set; }
        public string PrfPayTime { get; set; }
        public string PrfPayFile { get; set; }
        public string PrfPayDetail { get; set; }

        public virtual OrderPrint OrderPrint { get; set; }
    }
}
