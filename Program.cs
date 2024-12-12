using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baslatApp();
            Console.ReadKey();
        }

        static void baslatApp()
        {
            // TR = 1 - ENG = 2
            Console.Title = "Dil Seçimi/Language Selection - TR/ENG";
            int dilSecim = 0;
            bool dilSecimDogruMu=false;
            while (!dilSecimDogruMu)
            {
                Console.Write("Lütfen bir dil seçiniz. / Please select a language.\n1. Türkçe\n2. English\n\nSeçiminiz / Your Choice: ");
                try
                {
                    dilSecim = Convert.ToInt16(Console.ReadLine());
                    if (dilSecim == 1)
                    {
                        dilSecimDogruMu = true; 
                        Console.Clear();
                        appTR();
                    }
                    else if (dilSecim == 2)
                    {
                        dilSecimDogruMu = true;
                        Console.Clear();
                        appEN();
                    }
                    else
                    {
                        dilSecimDogruMu = false;
                        Console.WriteLine("(TR)  Geçersiz sayı. Lütfen 1 ila 2 arasında bir sayı giriniz.");
                        Console.WriteLine("(ENG) Invalid selection. Please select a number in the range 1 to 2.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    dilSecimDogruMu = false;
                    Console.WriteLine("(TR)  Geçersiz giriş. Lütfen bir sayı giriniz.");
                    Console.WriteLine("(ENG) Invalid input. Please enter a number.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
        }
        
        
        
        
        
        
        static void appTR()
        {
            Console.Title = "Sayı Tahmin Oyunu";
            bool tekrarDene = true;
            while (tekrarDene)
            {
                bool girisDogruMuALT = false, girisDogruMuUST = false, girisDogruMuTAHMIN = false;
                Console.Clear();
                Random random = new Random();
                int altSinir = 0, ustSinir = 100, tahminSayi = 0;
                Console.Write("Sayı Tahmin Oyunu - github.com/ebakc\n\n");

                while (!girisDogruMuALT)
                {
                    try
                    {
                        Console.Write("Alt Sınır Seçiniz: ");
                        altSinir = Convert.ToInt32(Console.ReadLine());
                        girisDogruMuALT = true;
                    }
                    catch
                    {
                        Console.WriteLine("Geçersiz Giriş. Lütfen Bir Sayı Giriniz.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Sayı Tahmin Oyunu - github.com/ebakc\n\n");
                    }
                }

                while (!girisDogruMuUST)
                {
                    try
                    {
                        Console.Write("Üst Sınır Seçiniz: ");
                        ustSinir = Convert.ToInt32(Console.ReadLine());
                        if (ustSinir > altSinir)
                        {
                            girisDogruMuUST = true;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Alt Sınırı Üst Sınırdan Küçük Seçin.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write($"Sayı Tahmin Oyunu - github.com/ebakc\n\nAlt Sınır Seçiniz: {altSinir}\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Geçersiz Giriş. Lütfen Bir Sayı Giriniz.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write($"Sayı Tahmin Oyunu - github.com/ebakc\n\nAlt Sınır Seçiniz: {altSinir}\n");
                    }
                }

                Console.Clear();
                Console.Write($"Sayı Tahmin Oyunu - github.com/ebakc\n\nAralık [{altSinir},{ustSinir}]\n");

                while (!girisDogruMuTAHMIN)
                {
                    try
                    {
                        Console.Write("Tahmin Ettiğiniz Sayıyı Giriniz: ");
                        tahminSayi = Convert.ToInt32(Console.ReadLine());
                        if (tahminSayi >= altSinir && tahminSayi <= ustSinir)
                        {
                            girisDogruMuTAHMIN = true;
                        }
                        else
                        {
                            Console.WriteLine("Tahmininiz Alt Sınır ile Üst Sınır Arasında Olmalı.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write($"Sayı Tahmin Oyunu - github.com/ebakc\n\nAralık [{altSinir},{ustSinir}]\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Geçersiz Giriş. Lütfen Bir Sayı Giriniz.");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
                Console.Write($"Sayı Tahmin Oyunu - github.com/ebakc\n\nAralık [{altSinir},{ustSinir}]\nTahmininiz: {tahminSayi}\n\n");
                int randomSayi = random.Next(altSinir, ustSinir + 1);

                if (randomSayi == tahminSayi)
                {
                    Console.Write($"Tebrikler, Doğru Tahmin!\nSayı: {tahminSayi}\nTekrar Deneyin! (E/H) = ");
                }
                else
                {
                    Console.Write($"Maalesef Tahmininiz Yanlış. Doğru Sayı: {randomSayi}\nTekrar Deneyin! (E/H) = ");
                }

                string cevap = Console.ReadLine().ToUpper();
                if (cevap != "E") { tekrarDene = false; }
            }
        }
        static void appEN()
        {
            Console.Title = "Number Guessing Game";
            bool tekrarDene = true;
            while (tekrarDene)
            {
                bool girisDogruMuALT = false, girisDogruMuUST = false, girisDogruMuTAHMIN = false;
                Console.Clear();
                Random random = new Random();
                int altSinir = 0, ustSinir = 100, tahminSayi = 0;
                Console.Write("Number Guessing Game - github.com/ebakc\n\n");

                while (!girisDogruMuALT)
                {
                    try
                    {
                        Console.Write("Choose Lower Bound: ");
                        altSinir = Convert.ToInt32(Console.ReadLine());
                        girisDogruMuALT = true;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input. Please Enter a Number.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Number Guessing Game - github.com/ebakc\n\n");
                    }
                }

                while (!girisDogruMuUST)
                {
                    try
                    {
                        Console.Write("Choose Upper Bound: ");
                        ustSinir = Convert.ToInt32(Console.ReadLine());
                        if (ustSinir > altSinir)
                        {
                            girisDogruMuUST = true;
                        }
                        else
                        {
                            Console.WriteLine("Please Choose the Lower Bound Less Than the Upper Bound.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write($"Number Guessing Game - github.com/ebakc\n\nLower Bound: {altSinir}\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input. Please Enter a Number.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write($"Number Guessing Game - github.com/ebakc\n\nLower Bound: {altSinir}\n");
                    }
                }

                Console.Clear();
                Console.Write($"Number Guessing Game - github.com/ebakc\n\nRange [{altSinir},{ustSinir}]\n");

                while (!girisDogruMuTAHMIN)
                {
                    try
                    {
                        Console.Write("Enter Your Guess: ");
                        tahminSayi = Convert.ToInt32(Console.ReadLine());
                        if (tahminSayi >= altSinir && tahminSayi <= ustSinir)
                        {
                            girisDogruMuTAHMIN = true;
                        }
                        else
                        {
                            Console.WriteLine("Your Guess Must Be Within the Lower and Upper Bound.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write($"Number Guessing Game - github.com/ebakc\n\nRange [{altSinir},{ustSinir}]\n");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input. Please Enter a Number.");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
                Console.Write($"Number Guessing Game - github.com/ebakc\n\nRange [{altSinir},{ustSinir}]\nYour Guess: {tahminSayi}\n\n");
                int randomSayi = random.Next(altSinir, ustSinir + 1);

                if (randomSayi == tahminSayi)
                {
                    Console.Write($"Congratulations, Correct Guess!\nNumber: {tahminSayi}\nTry Again! (Y/N) = ");
                }
                else
                {
                    Console.Write($"Unfortunately, Your Guess Was Incorrect. The Correct Number Was: {randomSayi}\nTry Again! (Y/N) = ");
                }

                string cevap = Console.ReadLine().ToUpper();
                if (cevap != "Y") { tekrarDene = false; }
            }
        }
    }
}
