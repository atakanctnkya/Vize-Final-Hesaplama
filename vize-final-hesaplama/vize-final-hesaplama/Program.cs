using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeOdev
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int mevcut;
            Console.Write("Lütfen sınıf mevcudunu giriniz = ");
            mevcut = int.Parse(Console.ReadLine());
            string[] ad = new string[mevcut];
            string[] soyad = new string[mevcut];
            int[] ogrNo = new int[mevcut];
            double[] vize = new double[mevcut];
            double[] final = new double[mevcut];
            double[] ort = new double[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.WriteLine("\n{0}. Öğrencinin", i + 1);
                Console.Write("Adı : ");
                ad[i] = Console.ReadLine();
                Console.Write("Soyadı : ");
                soyad[i] = Console.ReadLine();
                Console.Write("Öğrenci Numarası : ");
                ogrNo[i] = int.Parse(Console.ReadLine());
                Console.Write("Vize : ");
                vize[i] = double.Parse(Console.ReadLine());
                

                if (vize[i] >= 0 && vize[i] <= 100 )
                {
                    Console.Write("Final : ");
                    final[i] = double.Parse(Console.ReadLine());

                    if(final[i] >=0 && final[i] <= 100)
                    {
                        ort[i] = vize[i] * 40 / 100 + final[i] * 60 / 100;
                        Console.WriteLine("Ortalama : " + ort[i]);

                        if (ort[i] > 90 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : AA");
                        }
                        else if (ort[i] > 80 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : BA");
                        }
                        else if (ort[i] > 70 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : BB");
                        }
                        else if (ort[i] > 60 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : CB");
                        }
                        else if (ort[i] > 50 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : CC");
                        }
                        else if (ort[i] > 40 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : DC");
                        }
                        else if (ort[i] > 35 && final[i] >= 50)
                        {
                            Console.WriteLine("Harf Notu : DD");
                        }
                        else if (ort[i] > 1 && final[i] < 50)
                        {
                            Console.WriteLine("Harf Notu : FD");
                        }
                        else
                        {
                            Console.WriteLine("Harf Notu : FF");
                        }

                        if (ort[i] > 50 && final[i] >= 50)
                        {
                            Console.WriteLine("Durum : Geçti");
                        }
                        else if (ort[i] > 35 && final[i] >= 50)
                        {
                            Console.WriteLine("Durum : Sorumlu Geçti");
                        }
                        else if (ort[i] >= 0 && final[i] < 50)
                        {
                            Console.WriteLine("Durum : Kaldı");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız !");
                    }
                    

                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız !");
                }
            }
                
            
           
            Console.ReadKey();


        }
    }
}
