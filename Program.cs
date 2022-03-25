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
        

        public void CreatTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ANGGIMUNTHE;database=Exercise2;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("Create table Pegawai(ID_pegawai char(10) not null primary key, Nama varchar(30) not null, Alamat Varchar(50), Kota Varchar(50), Status Varchar(15), Nomor_Hp char(12))"
                   +" Create table Pelanggan(ID_Pelanggan char(10) not null primary key, Nama varchar(30), Alamat Varchar(50), Jenis_Kelamin char(10), Pekerjaan Varchar(15))"
                    +"Create table Obat(ID_Obat char(10) not null primary key, ID_Pelanggan char(10) not null FOREIGN KEY REFERENCES Pelanggan(ID_Pelanggan), Nama_Obat Varchar(20), Jenis Varchar(20), Harga Varchar(15), Stock varchar(10), ID_Supplier Char(10))"
                    +"Create table Supplier(ID_Supplier char(10) not null primary key, Nama varchar(30), Alamat varchar(50), Kota Varchar(50), Nomor_Hp char(12))"
                    +"Create table Faktur_Penjualan(Nomor char(15) not null Primary key, Tanggal Date, ID_Pelanggan char(10) not null FOREIGN KEY REFERENCES Pelanggan(ID_Pelanggan), ID_Pegawai char(10) not null FOREIGN KEY REFERENCES Pegawai(ID_Pegawai), ID_Obat char(10) not null FOREIGN KEY REFERENCES Obat(ID_Obat), jumlah_Obat Varchar(15), total Varchar(15), pajak Varchar(20), Total_Bayar Varchar(20))"
                   +"Create table Faktur_Supply(Nomor char(15) not null Primary key, Tanggal Varchar(15), ID_Pegawai char(10) not null FOREIGN KEY REFERENCES Pegawai(ID_Pegawai), ID_Supplier char(10) not null FOREIGN KEY REFERENCES Supplier(ID_Supplier), ID_Obat Char(10) not null FOREIGN KEY REFERENCES Obat(ID_Obat), Jumlah_Obat  Varchar(15), Total_Pajak Varchar(15), Total_Bayar Varchar(15))", con);
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
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ANGGIMUNTHE;database=Exercise2;Integrated Security =TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Anggi Hasian','Medan','Rantauprapat','Mahasiswa','0813966222306')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Nugraha','Pancing','Labura','Pelajar','085896622236')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','joko','Jateng','Magelang','Buru_tani','091396622236')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Widodo','Jatim','surabaya','pelayan ','0781396622230')"
                    + "insert into Pegawai(ID_Pegawai,Nama,Alamat,Kota,status,Nomor_Hp)values('234567','Prabowo','Sumsel','Palembang ','Pns','913966222306')"

                    + "insert into Obat (ID_Obat,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Acarbose','Tablet','Rp15.000','12_kotak','21567')"
                    + "insert into Obat (ID_Obat,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Albumin','sirup','Rp20.000','12_kotak','21567')"
                    + "insert into Obat(ID_Obat,ID_Pegawai,Nama_Obat, Jenis, Harga, Stock, ID_Supplier)values('005678', '234567', 'Penicilin', 'Obat Cair', 'Rp10.000', '10_kotak','21567')"
                    + "insert into Obat (ID_Obat,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Trisulfa','obatoles','Rp12.000','5_kotak','21567')"
                    + "insert into Obat (ID_Obat,ID_Pegawai,Nama_Obat,Jenis,Harga,Stock,ID_Supplier)values('005678','234567','Vitk','obatencer','Rp17.000','8_kotak','21567')"

                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567','ldy Ahmad','NegeriLama','Laki-Laki','Pegawai Negri')"
                    + "insert into Pelanggan(ID_Pelanggan,Nama, Alamat, Jenis_Kelamin, Pekerjaan)values('20567', 'Muid','Indramayu','Laki - Laki','Guru Madrasah')"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567','Amina','NegeriLama',' Perempuan','Pedagang')"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567','Ruqiyah','Ajamu','Perempuan','Buru_Tani ')"
                    + "insert into Pelanggan(ID_Pelanggan,Nama,Alamat,Jenis_Kelamin,Pekerjaan)values('20567','Sarno','Sidomakmur','Laki-Laki','Guru Ngaji')"

                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','Alam','concat','088776543')"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','dodi','Bantul','01234567')"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','Mayang ','Tamantirto','055776543')"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','puput','kalimantan','089996543')"
                    + "insert into Suplier (ID_Suplier,Nama,Alamat,Kota,Nomor_Hp)values('21567','tiah','sidomulyo','088776599')"

                   + "insert into Faktur_Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('050','05 okktober 2022','20567','234568','00569','10_tablet','10_kotak','Rp.1000','RP100.000')"
                   + "  insert into Faktur_Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('051','10 okktober 2022','20566','234565','00564','5_tablet','1_kotak','Rp.1000','Rp100.000')"
                    + " insert into Faktur_Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('052','05 November  2022','20569','234560','00561','8_tablet','5_kotak','Rp1000','Rp250.000')"
                    + " insert into Faktur_Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('054','06 November 2022','20562','234562','00565','9_tablet','4_kotak','Rp.1000','Rp300.000')"
                    + " insert into Faktur_Penjualan(Nomor,Tanggal,ID_Pelanggan,ID_Pegawai,ID_Obat,Total,Pajak,Total_Bayar)values('055','07 okktober 2022','20564','234566','00568','7_tablet','2_kotak','Rp50.000',Rp200.000')"

                   + " insert into Faktur_Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('0581','9 kktober 2022','20562','234567','00567','7_tablet','2_kotak','RP50.000','RP100.000')"
                    + " insert into Faktur_Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('052','07 okktober 2022','20563','234566','00567','7_tablet','2_kotak','RP50.000','RP100.000')"
                    + " insert into Faktur_Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('054','07 okktober 2022','20569','234667','00567','7_tablet','2_kotak','RP50.000','RP100.000')"
                    + "insert into Faktur_Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055','07 okktober 2022','20560','234567','00587','7_tablet','2_kotak','RP50.000','RP100.000')"
                    + "insert into Faktur_Supply (Nomor,Tanggal,ID_Pegawai,ID_Supplier,ID_Obat,Jumlah_Obat,Total,Pajak,Total_Bayar)values('055','07 okktober 2022','20560','234567','00587','7_tablet','2_kotak','RP50.000','RP100.000'))",con);


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
                con.Close();
            }
            Console.ReadKey();
        }

    

        static void Main(string[] args)
        {
           // new Program().CreatTable();
            new Program().InsertData();

        }
    }
}

