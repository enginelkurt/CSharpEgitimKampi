using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            Console.WriteLine("****** C# Veri Tabanlı Urun-Kategori Bilgi Sistemi ******");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;



            Console.WriteLine("------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Urünler");
            Console.WriteLine("3-Siparisler");
            Console.WriteLine("4-Cikis Yap");

            Console.Write("Lütfen getirmek istediginiz tablo numarasini giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-747RGEQD\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory" , connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());

                }
                Console.WriteLine();            }





            Console.Read();
        }
    }
}
