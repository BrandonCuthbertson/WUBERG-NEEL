using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Author: Sarah Hanson
 *  Holds data for the Products_Suppliers table
 */
namespace Workshop2_TravelExperts {
    public class Products_Suppliers {
        public int ProductSupplierId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
    }
}
