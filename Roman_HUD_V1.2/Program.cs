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
        static string studioName = "Team Void";
        static string gameName = "Doomies 64";
        
        static void Main()
        {
            Console.WriteLine("{0,30}", studioName);
            Console.WriteLine("{0,30}", gameName);
            ChangeWeapon(2);
            ShowHUD();
            ChangeWeapon(1);
            ShowHUD();
            Heal(60);
            ShowHUD();
            ChangeWeapon(4);
            ShowHUD();
            ChangeWeapon(5);
            ShowHUD();
            ChangeWeapon(3);
            ShowHUD();

        }

        static void ChangeWeapon(int weaponPickedUp)
        {
            if(weaponPickedUp == 0) //fists
            {
                damage = 5;
                currWeapon = "Fists";
                Console.WriteLine($"You picked up {currWeapon}.");
            }
            else if (weaponPickedUp == 1) //pistol
            {
                damage = 10;
                currWeapon = "Pistol";
                Console.WriteLine($"You picked up {currWeapon}.");
            }
            else if (weaponPickedUp == 2) //shotgun
            {
                damage = 40;
                currWeapon = "Shotgun";
                Console.WriteLine($"You picked up {currWeapon}.");
            }
            else if (weaponPickedUp == 3) //machine gun
            {
                damage = 60;
                currWeapon = "Machine Gun";
                Console.WriteLine($"You picked up {currWeapon}.");
            }
            else if (weaponPickedUp == 4) //flamethrower
            {
                damage = 30;
                fireEffect = 2;
                currWeapon = "Flamethrower";
                Console.WriteLine($"You picked up {currWeapon}.");
            }
            else if (weaponPickedUp == 5) //rocketlauncher
            {
                damage = 80;
                currWeapon = "Rocket Launcher";
                Console.WriteLine($"You picked up {currWeapon}.");
            }
            else
            {
                Console.WriteLine("You didn't pick up any weapon.");
                weaponPickedUp = 0;
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
            Console.WriteLine($"Enemy healed for {hp} health.");
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
                hpStatus = "Enemy is defeated!";
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
                Console.WriteLine();
                Console.WriteLine("Enemy is burning! He took 10 damage.");
            }
        }

        static string WeaponUsed() //Shows your weapon
        {
            string result = "";
            result += "Your current weapon: " + currWeapon;
            return result;
        }
        
        static void ShowHUD()
        {
            HealthCheck();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enemy HP: " + health);
            Console.WriteLine("His health status is: " + hpStatus);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(WeaponUsed());
            Console.ReadKey();
            Console.Clear();
            DealDamage(damage);
            HealthCheck();
            Console.WriteLine($"You dealt {damage} damage!");
            FireCheck();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enemy HP is now: " + health);
            Console.WriteLine("His health status is: " + hpStatus);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(WeaponUsed());
            Console.ReadKey();
            Console.Clear();
            
        }




    }
}
