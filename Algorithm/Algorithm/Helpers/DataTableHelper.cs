using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using Algorithm.Entities;

namespace Algorithm.Helpers
{
    public static class DataTableHelper
    {

        public static DataTable UserToDataTable(IEnumerable<User> users)
        {
            try
            {
                //this line is setting the name of property to datatable
                DataTable dataTable = new DataTable(typeof(User).Name);
                PropertyInfo[] Props = typeof(User).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                //Setting column names as Property names
                dataTable.Columns.Add("Ad Soyad");
                dataTable.Columns.Add("Telefon");
                dataTable.Columns.Add("Mail");
                foreach (var user in users)
                {
                    //this line is setting to propertyes in user
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        values[i] = Props[i].GetValue(user, null);
                    }
                    //Finally add value to datatable
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}