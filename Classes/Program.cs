using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static bool upgrade;
        static void Main(string[] args)
        {
            upgrade = true;

            //everything in a class is called a member

            //single piece of data
            int lives; //declaration
                       //no instantiation
            lives = 3; //initialization


            int[] ammo;
            ammo = new int[3]; //instatiation
            ammo[0] = 12;
            ammo[1] = 20;
            ammo[2] = 6;


            //Player player = new Player();

            Player player; //declaration
            
            player = new Player(); //instantiation

            player.health = 10; //cannot acces "health" from another class unless "health" is made public


            Enemy enemySmall = new Enemy();
            Enemy enemyMedium = new Enemy();
            Enemy enemyLarge = new Enemy();

        }
    }
}
