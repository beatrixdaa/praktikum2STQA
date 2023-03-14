using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum2STQA
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks> class data dapat mencari data siswa </remarks>

    public class AplikasiData
    {
        /// <summary>
        /// aplikasi pencari data siswa yang terdiri dari nama,nim,jeniskelamin,alamat,kelas,dan walikelas
        /// </summary>
        //string namaSi, nisSi, jkSi, alSi, kelSi, kelas ,walas, ;
        public void InputData()
        {
            //berfungsi untuk menginput data nama,nim,alamat,kelas,dan wali kelas dari siswa
            string[] namaSi = new string[35];
            int[] nisSi = new int[35];
            string[] jkSis = new string[35];
            string[] alSi = new string[35];
            string[] kelas = new string[35];
            string[] walas = new string[35];

            //berfungsi untuk menampilkan menu selamat datang 
            Console.WriteLine("Selamat Datang!");
            Console.WriteLine();
            int i, n = 0;
            //berfungsi untuk menginput data
            Console.Write("Berapa kali anda ingin menginput data : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                //berfungsi untuk memasukkan nama,nis,jeniskelamin,alamat,kelas,dan wali kelas siswa
                Console.Write("Masukan Nama Siswa/i     : ");
                namaSi[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Masukan NIS Siswa/i      : ");
                nisSi[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Jenis Kelamin    : ");
                jkSis[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Masukan Alamat           : ");
                alSi[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Kelas                    : ");
                kelas[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Nama Wali Kelas          : ");
                walas[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("             Data Siswa          ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nama Siswa \t NIS \t JK \t Alamat \t Kelas \t Wali Kelas");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"{namaSi[i]} \t \t {nisSi[i]} \t {jkSis[i]} \t {alSi[i]} \t {kelas[i]} \t {walas[i]}");
            }
        }
    }
    class Program
    {
        /// <summary>
        /// class data dapat menginput data siswa yang terdiri dari menu utama dan selamat datang
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AplikasiData AD = new AplikasiData();
            int pilihan;
            string jawaban;
            
            //menampilkan menu utama
            // menampilkan menu selamat datang
            //menampilkan seberapa banyak data yang akan diinput 
            Console.WriteLine("Menu Utama");
            Console.WriteLine("============================================");
            Console.WriteLine("Selamat Datang!");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Apakah anda ingin menginput Data Siswa?");
            Console.WriteLine("1. Iya");
            Console.WriteLine("2. Tidak");
            Console.WriteLine();
            Console.Write("Jawaban : ");
            pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (pilihan)
            {
                //menampilkan menu exit
                case 1:
                    Console.Clear();
                    AD.InputData();
                    Console.WriteLine("Apakah anda akan kembali ke menu utama? (Y/N)");
                    jawaban = Console.ReadLine();
                    if (jawaban.Equals("y") || jawaban.Equals("Y"))
                    {
                        Console.Clear();
                        Main(args);
                    }
                    break;
                default:
                    //menampilkan menu pilihan salah
                    Console.WriteLine("Pilihan Salah!");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
