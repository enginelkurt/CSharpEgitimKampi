using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud

            Console.WriteLine("****** Menü Sipari İslem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------");
            #region Kategori Ekleme İslemleri

            //Console.Write("Eklemek istediginiz Kategori Adı : ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-747RGEQD\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori basariyla eklendi");
            #endregion


            #region Urun Ekleme İslemleri

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Urün adi:  ");
            //productName= Console.ReadLine();
            //Console.Write("Urün fiyati:  ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-747RGEQD\\SQLEXPRESS;initial catalog = EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus)values(@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Urun eklemesi basarali");

            #endregion

            #region Urun Listeleme İslemi


            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-747RGEQD\\SQLEXPRESS;initial catalog = EgitimKampiDb;integrated security=true");
            //connection.Open();


            //SqlCommand command =new SqlCommand ("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+ " ");
            //    }
            //    Console.WriteLine() ;   







            //connection.Close();


            #endregion


            #region Urun Silme İslemi

            //Console.Write("Silinecek Urun Id: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-747RGEQD\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();









            //connection.Close();


            //Console.WriteLine("Silme islemi yapildi");

            #endregion

            #region Urun Guncelleme İslemleri

            //Console.Write("Guncellenecek Id: ");
            //int productId =int.Parse(Console.ReadLine());
            //Console.Write("Guncellenecek Urun Adi: ");
            //string productName = Console.ReadLine();
            //Console.Write("Guncellenecce Urun Fiyati: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = LAPTOP-747RGEQD\\SQLEXPRESS;initial catalog = EgitimKampiDb;integrated security=true");
            //connection.Open(); 
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice,where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close ();

            //Console.WriteLine("Guncelleme Basarili");
            #endregion

            Console.Read();
        }
    }
}

