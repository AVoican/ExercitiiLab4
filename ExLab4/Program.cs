using System;

namespace ExLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            Ex7();
        }

        //Scrieti un progra care va citi un vector de intregi de dimensiune n de la tastatura. Scrieti o functie care
        //va inversa elementele vectorului, apelati-o si afisati-i rezultatul.
        static void Ex1()
        {
            Console.WriteLine("Introduceti lungimea vectorului ");
            int n = int.Parse(Console.ReadLine());

            int[] vectorIntregi = new int[n];

            Console.WriteLine("Introduceti valorile vectorului ");

            for (int i = 0; i < n; i++)
            {
                vectorIntregi[i] = int.Parse(Console.ReadLine());
            }

            vectorIntregi=InversareValoriDinVector(n, vectorIntregi);
            for(int i = 0; i < n; i++)
            {
                Console.Write(vectorIntregi[i] + " ");
            }
        }

        static int[] InversareValoriDinVector(int n, int[] v)
        {
            int a = 0;
            int b = n-1;
            int aux;

            while (a <= b)
            {
                aux = v[a];
                v[a] = v[b];
                v[b] = aux;

                a++;
                b--;
            }
            return v;
        }

        //Cititi de la tastatura continului unei matrici de intregi cu 3 dimensiuni avand lungimile n, m, k.
        //Lungimile celor trei dimensiuni vor fi citite de la tastatura
        static void Ex2()
        {
            Console.WriteLine("Introduceti lungimea matricii tridimensionale  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea matricii tridimensionale  ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti adancimea matricii tridimensionale  ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti valorile din matrice ");
            int[,,] matrix3D = new int[n, m, k];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int h = 0; h < k; h++)
                    {
                        matrix3D[i, j, h] = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("Suma elementelor din matrice este " + SumaElementelorDinMatrice(n, m, k, matrix3D));

            Console.WriteLine("Valoarea maxima din matrice este " + ELementulMaximDinMatrice(n, m, k, matrix3D));
        }

        //Scrieti o functie care va calcula suma elementelor unei astfel de matrici, apelati-o si afisati-i rezultatul
        static int SumaElementelorDinMatrice(int lungime, int latime, int adancime, int[,,] matrice)
        {
            int s = 0;

            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < latime; j++)
                {
                    for (int h = 0; h < adancime; h++)
                    {
                        s += matrice[i, j, h];
                    }
                }
            }
            return s;
        }

        //SCrieti o functie care va determina elementul cu valoare maxima din matrice, apelati-o si afiti-i rezultatul
        static int ELementulMaximDinMatrice(int lungime, int latime, int adancime, int[,,] matrice)
        {
            int max=matrice[0,0,0];
            int aux;

            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < latime; j++)
                {
                    for (int h = 1; h < adancime; h++)
                    {
                        aux = matrice[i, j, h];

                        if (max < aux)
                        {
                            max = aux;
                        }
                    }
                }
            }
            return max;
        }

        static void Ex3()
        {
            Console.WriteLine("Introduceti lungimea matricilor  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea matricilor  ");
            int m = int.Parse(Console.ReadLine());

            int[,] matricea1 = new int[n, m];
            int[,] matricea2 = new int[n, m];

            Console.WriteLine("introduceti valorile primei matrice ");

            for (int i = 0; i < n; i++)
            {
                for(int j =0; j < m; j++)
                {
                    matricea1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("introduceti valorile celei de a doua matrice ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matricea2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] matriceRezultantaDupaInmultire = InmultireaCelorDouaMatrici(n, m, matricea1, matricea2);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine(matriceRezultantaDupaInmultire[i, j]+" ");
                    }
                    else
                    {
                        Console.Write(matriceRezultantaDupaInmultire[i, j]+" ");
                    }
                }
            }
        }

        static int[,] InmultireaCelorDouaMatrici(int lungime, int latime, int[,] matrix1, int[,] matrix2)
        {
            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < latime; j++)
                {
                    matrix1[i, j] *= matrix2[i, j];
                }
            }

            return matrix1;
        }

        //Scrieti o functie recursiva care va calcula in ordine elementele unui vector de intregi
        static void Ex4()
        {

        }

        //scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati-o si afisati-i rezultatul.
        static void Ex5()
        {
            Console.WriteLine("Introduceti valoarea lui n ");
            int n = int.Parse(Console.ReadLine());
            int aux = 0;

            int sumaNumerelor = AdunareaNumerelor(n, aux);

            Console.WriteLine("Suma primelor n numere este " + sumaNumerelor);
        }

        static int AdunareaNumerelor(int n, int suma)
        {
            if (n == 0)
            {
                return suma;
            }

            suma += n;
            return AdunareaNumerelor(n - 1, suma);

        }

        //Scrieti o functie recursiva care va calcula al n-lea element din sirul lui Fibonacci, n fiind citit de la tastatura.
        static void Ex6()
        {

            Console.WriteLine("Introduceti valoarea lui n ");
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;
            int aux = 3;

            Console.WriteLine("Al " + n + "-lea element din Sirul lui Fibonacci este "+ CalculareaElementuluiNDinFIBonacci(n, aux, a, b));
        }

        static int CalculareaElementuluiNDinFIBonacci(int elementulNumarulN,int aux,int a,int b)
        {
            
            if (aux == elementulNumarulN)
            {
                return b;
            }
            aux++;
            int x = a;
            a = b;
            b += x;

            return CalculareaElementuluiNDinFIBonacci(elementulNumarulN, aux, a, b);
        }

        //Scrieti o functie recursiva care pentru un numar "n" primit ca parametru, va afisa urmatoarea piramida a numerelor:
        //1
        //2 2
        //3 3 3 
        static void Ex7()
        {
            Console.WriteLine("Introduceti valoarea lui n ");
            int n = int.Parse(Console.ReadLine());

            int aux = 1;

            if (n > 0)
            {
                CrearePiramida(n, aux);
            }
            else
            {
                Console.WriteLine("Ati introdus o valoare invalida!");
            }
        }

        static void CrearePiramida(int n, int aux)
        {
            if (aux>n)
            {
                return;
            }

            for(int i=1; i <aux;i++)
            {
                Console.Write(aux + " ");
            }

            Console.WriteLine(aux + " ");
            aux++;

            CrearePiramida(n, aux);
        }
    }
}
