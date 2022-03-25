using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercisePABD
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=NIAAUDITA; database=TokoKuePABD;User ID=sa;Password=Binamarga85");
                con.Open();

                SqlCommand cm = new SqlCommand(
                    "insert into JenisKue (id_JenisKue, Jenis_Kue) values ('JK1','Roti Gandum')" +
                    "insert into JenisKue (id_JenisKue, Jenis_Kue) values ('JK2','Roti Tawar')" +
                    "insert into JenisKue (id_JenisKue, Jenis_Kue) values ('JK3','Roti Selai Nanas')" +
                    "insert into JenisKue (id_JenisKue, Jenis_Kue) values ('JK4','Roti Keju')" +
                    "insert into JenisKue (id_JenisKue, Jenis_Kue) values ('JK5','Roti Kismis')" +
                    "insert into Kue (id_Kue, id_JenisKue, nama_kue,harga) values ('K1','JK1','Gandum Murni','15000')"+
                    "insert into Kue (id_Kue, id_JenisKue, nama_kue,harga) values ('K2','JK2','Tawar Tanpa Tepi','18000')" +
                    "insert into Kue (id_Kue, id_JenisKue, nama_kue,harga) values ('K3','JK3','Nanas Juara','10000')" +
                    "insert into Kue (id_Kue, id_JenisKue, nama_kue,harga) values ('K4','JK4','Keju Parut','25000')" +
                    "insert into Kue (id_Kue, id_JenisKue, nama_kue,harga) values ('K5','JK5','Kismis Manis','35000')" +
                    "insert into Pembeli (id_Pembeli, id_Kue, jumlah_beli) values ('P1','K1','1')" +
                    "insert into Pembeli (id_Pembeli, id_Kue, jumlah_beli) values ('P2','K2','5')" +
                    "insert into Pembeli (id_Pembeli, id_Kue, jumlah_beli) values ('P3','K3','3')" +
                    "insert into Pembeli (id_Pembeli, id_Kue, jumlah_beli) values ('P4','K4','2')" +
                    "insert into Pembeli (id_Pembeli, id_Kue, jumlah_beli) values ('P5','K5','1')" +
                    "insert into Kasir (id_Kasir, Nama_Kasir) values ('KSR1','Tiara')" +
                    "insert into Kasir (id_Kasir, Nama_Kasir) values ('KSR2','Defina')" +
                    "insert into Kasir (id_Kasir, Nama_Kasir) values ('KSR3','Nurwinda')" +
                    "insert into Kasir (id_Kasir, Nama_Kasir) values ('KSR4','Niaaudita')" +
                    "insert into Kasir (id_Kasir, Nama_Kasir) values ('KSR5','DindaAnisa')" +
                    "insert into Transaksi (id_Transaksi, id_Pembeli, id_Kasir, Tgl_Transaksi,Uang_Bayar, Uang_Kembali, Total_Harga) values ('TR1','P1','KSR1','01-03-2021','30000','13000',17000)" +
                    "insert into Transaksi (id_Transaksi, id_Pembeli, id_Kasir, Tgl_Transaksi,Uang_Bayar, Uang_Kembali, Total_Harga) values ('TR2','P2','KSR2','07-09-2021','50000','8000',42000)" +
                    "insert into Transaksi (id_Transaksi, id_Pembeli, id_Kasir, Tgl_Transaksi,Uang_Bayar, Uang_Kembali, Total_Harga) values ('TR3','P3','KSR3','02-12-2021','45000','19000',26000)" +
                    "insert into Transaksi (id_Transaksi, id_Pembeli, id_Kasir, Tgl_Transaksi,Uang_Bayar, Uang_Kembali, Total_Harga) values ('TR4','P4','KSR4','04-08-2021','89000','72000',17000)" +
                    "insert into Transaksi (id_Transaksi, id_Pembeli, id_Kasir, Tgl_Transaksi,Uang_Bayar, Uang_Kembali, Total_Harga) values ('TR5','P5','KSR5','03-01-2021','36000','20000',16000)" 
                    , con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Data Berhasil dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOoopss, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
