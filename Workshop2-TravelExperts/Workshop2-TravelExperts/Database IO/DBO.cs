using SQLAdapter;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Sarah
 */
namespace Workshop2_TravelExperts {
    public static class DBO {
        public static bool AddProdToPackage(int prodID, int packageID ) {
            TravelExpertsDBCon db = new TravelExpertsDBCon();
            List<Products_Suppliers> product_supplier;
            Packages_Products_Suppliers packageProductSupplier = new Packages_Products_Suppliers();
            bool success = true;
            string query;
            // Getting the info from the db (assumes first option is correct, this is a big assumtion)
            query = "Select * from Products_Suppliers where ProductID = " + prodID;
            SQLAdapter.SQLAdapter.GetFromDB<Products_Suppliers>(out product_supplier, db, query);
            // Creating the DB object
            if (product_supplier.Count > 0) {
                packageProductSupplier.ProductSupplierID = product_supplier[0].ProductSupplierId;
                packageProductSupplier.PackageID = packageID;
            }
            else { 
                success = false;
            }
            if(!SQLAdapter.SQLAdapter.InsertToDBNOID<Packages_Products_Suppliers>(packageProductSupplier, db))
                success = false;
            return success;
        }
        public static bool AddProdToSupplier(int prodID, int supplierID) {
            Products_Suppliers pd = new Products_Suppliers();
            pd.ProductId = prodID;
            pd.SupplierId = supplierID;
            return SQLAdapter.SQLAdapter.InsertToDB<Products_Suppliers>(pd, new TravelExpertsDBCon());
        }
    }

    public class TravelExpertsDBCon : I_SQLDB {
        public SqlConnection GetConnection() {
            string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}