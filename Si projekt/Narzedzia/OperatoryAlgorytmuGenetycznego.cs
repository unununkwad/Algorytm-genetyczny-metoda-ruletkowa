﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Si_projekt
{
    class OperatoryAlgorytmuGenetycznego 
    {
        public static string mutacje(string osobnik)
        {
			string pomocniczyOsobnik = "";
			for (int i = 0; i < osobnik.Length; i++)
			{
					if (osobnik[i] == '0')
						pomocniczyOsobnik += "1";
					else
						pomocniczyOsobnik += "0";
				
			}
            return pomocniczyOsobnik;
        }
        
        public static Dzieci krzyzowanie(string osobnik1,string osobnik2, int pktPrzeciecia)
        {
            Dzieci potomkowie = new Dzieci();

            string czesciOsobnika1 = "";
            //string czesciOsobnika2 = "";
            string czesciOsobnika3 = "";
            //string czesciOsobnika4 = "";
			//we jeszcze jeden if length <=
            if (osobnik1.Length < osobnik2.Length)
            {
                
                for (int i = 0; i < osobnik1.Length; i++)
                {
                    czesciOsobnika1 += osobnik1[i];
                    czesciOsobnika3 += osobnik2[i];
                }
               
            }
            else
            {
                for (int i = 0; i < osobnik2.Length; i++)
                {
                    czesciOsobnika1 += osobnik1[i];
                    czesciOsobnika3 += osobnik2[i];
                }
                
            }
                    
            
           
            string koncowyOsobnik1 = czesciOsobnika3;
            string koncowyOsobnik2 = czesciOsobnika1;
            potomkowie.dziecko1 = koncowyOsobnik1;
            potomkowie.dziecko2 = koncowyOsobnik2;
            potomkowie.punktPrzeciecia = pktPrzeciecia;

            return potomkowie;
        }

    }
}
