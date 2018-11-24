using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Reflection;
using System.Data;
using System.IO;

namespace Add_Mod_Del_Invoice_Project.Items
{
    class clsItemsSQL
    {
        /// <summary>
        /// Connection string to the database.
        /// </summary>
        private string sConnectionString;

        /// <summary>
        /// Constructor that sets the connection string to the database
        /// </summary>
		public clsItemsSQL()
        {
            sConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data source= " + Directory.GetCurrentDirectory() + "\\CS3280GroupProject1.accdb";
        }
        private clsDataAccess db = new clsDataAccess();
        public int iReturn_Value; 

        /// <summary>
        /// Load All the Equipment
        /// </summary>
        public void getTable()
        {
            try
            {
                DataSet ds;
                string sSQL;

                sSQL = "Select * FROM EQUIPMENT";

                ds = db.ExecuteSQLStatement(sSQL, ref iReturn_Value);


            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
        
        /// <summary>
        /// Updates the SQL and return the ourput. 
        /// </summary>
        /// <param name="ssql"></param>
        public int updateItem(int ID, string Set)
        {
            try
            {
                string sSQL;

                sSQL = "Update Equipment " + Set + "Where ID ='" + ID + "'";
                
                return  db.ExecuteNonQuery(sSQL);

            
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Check for item in the invoice tables. If ok to to delete return nothing if not return invoice ID for message
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string checkDelete(int ID)
        {
            try
            {
                DataSet ds = null; 
                string sSQL;

                sSQL = "Select * FROM Invoices Where ID ='" + ID + "'";

                ds = db.ExecuteSQLStatement(sSQL, ref iReturn_Value);

                if (ds == null)
                    return "";
                else
                    return ds.Tables[0].Rows[0][0].ToString();


            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
        /// <summary>
        /// Complete the deletion of the record. Return an Int when finished.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DeleteRecord(int ID)
        {
            try
            {
                string sSQL;

                sSQL = "Delete Equipment Where ID ='" + ID + "'";

                return db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// INsert record. 
        /// </summary>
        /// <param name="sSQL"></param>
        /// <returns></returns>
        public int InertRecord(string sSQL)
        {
            try
            {


                sSQL = " INSERT Equipment values( ID, EquipmentName, EquipmentDescription, cost) INTO " + sSQL;
               return db.ExecuteNonQuery(sSQL);


            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}

