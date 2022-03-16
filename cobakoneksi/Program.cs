using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cobakoneksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
            using(
                SqlConnection con = new SqlConnection("data source = INAYAHMUFIDAH\\PIYOMARU842;database = ProdiTI;" +
                "user ID = sa; Password = Piyo248C")

                //data source isinya di ambil dari server name nya di sql server
                //password sesuain dengan password yang kalian bikin sebelumnya
            )
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
                Console.Read();
            }
        }
    }
}
