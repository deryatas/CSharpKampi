﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Menü Sipariş İşlemi Paneli *********");
            Console.WriteLine();
            #region Kategori Ekleme İşlemi

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Eklemek istedğiniz kategorinin adı");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A03UPTU\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Başarıyla eklendi.");
            #endregion
            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A03UPTU\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Ekleme Başarıyla Eklendi. ");
            #endregion
            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A03UPTU\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion
            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A03UPTU\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi yapıldı.");
            #endregion
            #region Ürün Güncelleme İşlemi
            //Console.WriteLine("Güncellenecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.WriteLine("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.WriteLine("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A03UPTU\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("productId", productId);
            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme İşlemi yapıldı.");
            #endregion
            Console.Read();
        }
    }
}
