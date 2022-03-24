using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140009_Tugas2_B
{
    class Program
    {
        public SqlDataReader dataread;

        public void CreatTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ANGGIMUNTHE;database=Anggi;Integrated Security =TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("Creat table Pegawai(ID_pegawai char (10) not null primary key ,Nama varchar (30) not null,Alamat Varchar (50),Kota Varchar (50),Status Varchar (15),Nomor_Hp char (12))"
                    + "Creat table Obat(ID_Obat char (10) not null primary key ,Nama_Obat Varchar (20),Jenis Varchar (20),Harga Varchar  (15),Stock varchar (10),ID_Supplier Char (10))"
                    + "Create table Pelanggan(ID_Pelanggan char (10) not null primary key,Nama varchar (30),Alamat Varchar (50),Jenis_Kelamin char (10),Pekerjaan Varchar(15))"
                    + "Create table Supplier(ID_Supplier cahr (10) not null primary key,Nama varchar (30),Alamat varchar (50),Kota Varchar (50),Nomor_Hp char (12))"
                    + "Create table Faktur Penjualan(Nomor char (15) not null Primary key,Tanggal Date,ID_Pelanggan char (10) not null Foreign,ID_Pegawai char (10) not null Foreign,ID_Obat char (10) not null Foreign key,jumlah Obat Varchar (15),total Varchar (15),pajak Varchar (20),Total_Bayar Varchar (20))"
                    + "Create table Faktur Supply (Nomor char (15) not null Primary key,Tanggal Varchar (15),ID_Pegawai char(10) not null foreign ,ID_Supplier char(10_ not null foreign,ID_Obat Char(10) not null foreign,Jumlah Obat  Varchar (15),Total_Pajak Varchar (15),Total_Bayar Varchar (15))", con);
                    cm.ExecuteNonQuery();

                Console.WriteLine("Tabel Sukse dibuat");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine("sepertinya tabel kamu gagal : (" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }


            

            
            


        }

        static void Main(string[] args)
        {


        }
    }
}

