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
                    + "Creat table Obat(ID_Obat char (10) not null primary key ,ID_Pelanggan char (10) not null foreign key,Nama_Obat Varchar (20),Jenis Varchar (20),Harga Varchar  (15),Stock varchar (10),ID_Supplier Char (10))"
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
        public void InsertData()
        {
            SqlConnection conc = null;
            try
            {
                conc = new SqlConnection("data source=ANGGIMUNTHE;database=Anggi;Integrated Security =TRUE");
                conc.Open();

                SqlCommand cm = new SqlCommand("insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Anggi Hasian','Medan','Rantauprapat','Mahasiswa','0813966222306')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Nugraha','Pancing','Labura','Pelajar','0858966222306')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','joko','Jateng','Magelang','Buru tani','0913966222306')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Widodo','Jatim','surabaya','pelayan ','07813966222306')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Prabowo','Sumsel','Palembang ','Pns ',0913966222306')"
                    + "insert into Obat (ID_Obat ,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Acarbose','Tablet','Rp.15.000','12 kotak','21567')"
                    + "insert into Obat (ID_Obat ,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Albumin'','sirup','Rp.20.000','15 kotak','21567')"
                    + "insert into Obat(ID_Obat, ID_Pegawai, Nama_Obat, Jenis, Harga, Stock, ID_Supplier)values('005678', '234567', 'Penicilin ', 'Obat Cair', 'Rp.10.000', '10 kotak', '21567')"
                    + "insert into Obat (ID_Obat ,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Trisulfa','obat oles','Rp.12.000','5 kotak','21567')"
                    + "insert into Obat (ID_Obat ,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Vit.k','obat encer','Rp.17.000','8 kotak','21567')"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567',Aldy Ahmad','NegeriLama','Laki-Laki','Pegawai Negri')"
                    + "+insert into Pelanggan(ID_Pelanggan, Nama, Alamat, Jenis_Kelamin, Pekerjaan)values('20567', Muid','Indramayu','Laki - Laki','Guru Madrasah ',)"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567',Amina','NegeriLama Perempuan','Pedagang',)"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567',Ruqiyah','Ajamu','Perempuan','Buru Tani ',)"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567',Sarno','Sidomakmur','Laki-Laki','Guru Ngaji',)"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','Alam',concat,'088776543',)"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','dodi',Bantul,'01234567',)"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','Mayang ',Tamantirto,'055776543',)"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','puput',kalimantan,'089996543',)"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','tiah',sidomulyo,'088776599',)"
                    + "insert into Faktur Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('050','05 okktober 2022','20567',234567','00567,'10 tablet,'10 kotak','Rp.1000,'Rp.100.0000',)"
                    + "insert into Faktur Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('050','10 okktober 2022','20567',234567','00567,'15 tablet,'11 kotak','Rp.1000,'Rp.200.0000',)"
                    + "insert into Faktur Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('050','05 November  2022','20567',234567','00567,'10 tablet,'20 kotak','Rp.1000,'Rp.150.0000',)"
                    + "insert into Faktur Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('050','06 November 2022','20567',234567','00567,'10 tablet,'5 kotak','Rp.1000,'Rp.120.0000',)"
                    + "insert into Faktur Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('050','07 okktober 2022','20567',234567','00567,'10 tablet,'7 kotak','Rp.1000,'Rp.50.0000',)"
                    + "insert into Faktur Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055,'20 januari 2022',234567','21567','00567','6 Dus','Rp.1000','Rp.100.000',) "
                    + "insert into Faktur Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055,'23 januari 2022',234567','21567','00567','15 Dus','Rp.1000','Rp.120.000',) "
                    + "insert into Faktur Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055,'20 Maret 2022',234567','21567','00567','10 Dus','Rp.1000','Rp.500.000',) "
                    + "insert into Faktur Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055,'5 juli 2022',234567','21567','00567','6 Dus','Rp.1000','Rp.50.000',) "
                    + "insert into Faktur Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055,'4 januari 2022',234567','21567','00567','20 Dus','Rp.1000','Rp.200.000',))", conc);
                cm.ExecuteNonQuery();

                Console.WriteLine("sukses menambahkan data");
                Console.ReadKey();





            }
            catch (Exception e)
            {
                Console.WriteLine("sepertinya tabel kamu gagal : (" + e);
                Console.ReadKey();
            }
            finally
            {
                conc.Close();
            }
        }

    

        static void Main(string[] args)
        {


        }
    }
}

