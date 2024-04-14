using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lesClasses
{
    internal class Character
    {
        public string Nom{  get; set; }
        public int PointDeVie { get; set; }
        public int ForceAttaque {  get; set; }
        public int ForceDefense {  get; set; }
       
        
        public Character(string nom,int pv,int foratta,int forDef)
        { 
            Nom = nom;
            PointDeVie = pv;
            ForceAttaque = foratta;
            ForceDefense = forDef;
        }
        public bool IsAlive()
        {
            bool vivant = true;
            bool mort = false;

            if (PointDeVie > 0)
            {
                return vivant;
            }
            else
            {
                return mort;
            }

        }
        public void Attack(Character attaque)
        {
            if (PointDeVie > 0)
            {
                attaque.PointDeVie = attaque.PointDeVie - Math.Abs(ForceAttaque - attaque.ForceDefense);
            } 
        }
    }
}
