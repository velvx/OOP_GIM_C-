using System;
using System.Collections.Generic;
using System.Dynamic;

namespace KerangkaGame
{
    class Karakter
    {
        public int totalSenjata, kekuatan;

        public string nama{get; private set;}
        public int kesehatan{get; private set;}
        public string senjata{get; private set;}

        public Karakter(string nama, string kesehatan, string senjata)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }
        /**public void setData(string namaBaru, string kesehatanBaru, string senjataBaru, int jumlahSenjata, int jumlahKekuatan)
        {
            this.nama = namaBaru;
            this.kesehatan = kesehatanBaru;
            this.senjata = senjataBaru;
            this.totalSenjata = jumlahSenjata;
            this.kekuatan = jumlahKekuatan;
        }**/

        /**public void getData()
        {
            Console.WriteLine(nama);
            Console.WriteLine(kesehatan);
            Console.WriteLine(senjata);
            Console.WriteLine(totalSenjata);
            Console.WriteLine(kekuatan);
        }**/

        public void getData()
        {
            Console.WriteLine($"Karakter {nama}");
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {

            Karakter player1 = new Karakter("Asep", "Sehat", "M4");
            player1.getData();
    



            /**Console.WriteLine("PLAYER================");

            Karakter player = new Karakter();
            player.setData("Archer", "critical!!!!", "Bow", 5, 30);
            player.getData();

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Karakter player1 = new Karakter();
            player1.setData("Beggar", "content", "Stone", 10, 15);
            player1.getData();

            //musuh hitam

            Console.WriteLine();
            Console.WriteLine("ENEMY================");
            Console.WriteLine();

            Karakter enemy = new Karakter();
            enemy.setData("PSHT", "content", "celurit", 5, 10);
            enemy.getData();

            List<Karakter> daftarHero = new List<Karakter>();
            daftarHero.Add(player);
            daftarHero.Add(player1);

            Console.WriteLine();
            Console.WriteLine("DAFTAR HERO================");

            foreach (Karakter hero in daftarHero)
            {
                hero.getData();
                Console.WriteLine();
            } **/
        }
    }
}