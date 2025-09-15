using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_HUD_V1._2
{
    internal class Program
    {

        static int weapon = 0;
        static int health = 100;
        static int damage = 5;
        static string currWeapon = "";
        static string hpStatus = "";
        static int fireEffect = 0;
        
        static void Main()
        {
            
        }

        static void ChangeWeapon(int weaponPickedUp)
        {
            if(weaponPickedUp == 0) //fists
            {
                damage = 5;
                currWeapon = "Fists";
            }
            else if (weaponPickedUp == 1) //pistol
            {
                damage = 10;
                currWeapon = "Pistol";
            }
            else if (weaponPickedUp == 2) //shotgun
            {
                damage = 40;
                currWeapon = "Shotgun";
            }
            else if (weaponPickedUp == 3) //machine gun
            {
                damage = 60;
                currWeapon = "Machine Gun";
            }
            else if (weaponPickedUp == 4) //flamethrower
            {
                damage = 30;
                fireEffect = 2;
                currWeapon = "Flamethrower";
            }
            else //rocketlauncher
            {
                damage = 80;
                currWeapon = "Rocket Launcher";
            }

        }

        static int DealDamage(int damage)
        {
            health -= damage;
            if(health < 0)
            {
                health = 0;
            }
            return health;
        }

        static int Heal(int hp)
        {
            health += hp;
            if(health > 100)
            {
                health = 100;
            }
            return health;
        }

        static void HealthCheck()
        {
            if(health == 0)
            {
                Console.WriteLine("Enemy is defeated!");
            }
            else if(health <= 10)
            {
                hpStatus = "Imminent Danger";
            }
            else if(health <= 50)
            {
                hpStatus = "Badly Hurt";
            }
            else if(health <= 75)
            {
                hpStatus = "Hurt";
            }
            else if(health < 100)
            {
                hpStatus = "Healthy";
            }
            else
            {
                hpStatus = "Perfect Health";
            }
        }
        
        static void FireCheck() //Checks if there burning status on enemy, if there is, deals damage
        {
            if(fireEffect > 0)
            {
                health -= 10;
                fireEffect--;
                Console.WriteLine("Enemy is burning! He took 10 damage.");
            }
        }

        static void WeaponUsed() //Shows your weapon
        {
            Console.WriteLine("Your current weapon: " + currWeapon);
        }
        
        static void ShowHUD()
        {

        }


    }
}
