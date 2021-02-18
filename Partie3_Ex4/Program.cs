﻿using System;

namespace Partie3_Ex4
{
    class Program
    {
        static void Main(string[] args)

        {

            // generateur de nombre aléatoire 
            Random random = new Random();

            //retourne un nombre aléatoire entier non négatif.
            int returnvalue = random.Next(1, 51);


            Console.WriteLine(" Devine un nombre entre 1 et 50 ");
            int response = Convert.ToInt32(Console.ReadLine());

            //tant que la valeur écrite est différente de returnvalue 

            while (response > returnvalue)
            {
                Console.WriteLine($"Non le chiffre est plus petit que {response} retente ta chance !");
                response = Convert.ToInt32(Console.ReadLine());
            }

            while (response < returnvalue)
            {
                Console.WriteLine($"Non, le chiffre est plus grand que {response} retente ta chance !");
                response = Convert.ToInt32(Console.ReadLine());
            }

            while (response != returnvalue)
            {
                Console.WriteLine($"mauvaise réponse {response} n'est pas le bon chiffre retente ta chance !");
                response = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Tres bien la valeur était de {returnvalue}");

            /* Code qui fonctionne 

                  Random random = new Random();
                  int tries = 0;
                  int nb = random.Next(1, 51);
                  Console.WriteLine("devinez le nombre entre 1 et 50 !");
                  int nbUser = Convert.ToInt32(Console.ReadLine());
                  tries++;


                  while (nbUser > nb)
                  {
                      Console.WriteLine($"c'est plus petit que {nbUser}, vous avez fait {tries} tentatives ! Devinez à nouveau");
                      nbUser = Convert.ToInt32(Console.ReadLine());
                      tries++;

                  }

                  while (nbUser < nb)
                  {
                      Console.WriteLine($"c'est plus grand que {nbUser}, vous avez fait {tries} tentatives ! Devinez à nouveau !");
                      nbUser = Convert.ToInt32(Console.ReadLine());
                      tries++;



                  }

                  while (nbUser != nb)
                  {
                      Console.WriteLine($"encore raté :/ ce n'est pas {nbUser} , vous avez fait {tries} tentatives devinez à nouveau");
                      nbUser = Convert.ToInt32(Console.ReadLine());
                      tries++;

                  }

                  Console.WriteLine($"C'est pas trop tot ! vous avez trouvé en {tries} tentatives,  Félicitation !");*/
        }
        }
    }



