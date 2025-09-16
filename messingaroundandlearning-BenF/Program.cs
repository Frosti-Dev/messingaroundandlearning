using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messingaroundandlearning_BenF
{
    internal class Program
    {
        static int health = 100;
        static int weapon = 2;
        static int enemyHealth = 100;

        //static WeaponType = weapon;

        static void Main(string[] args)
        {
            /*
            string characterName = "Alexa";
            int health = 80;
            int speed = 5;
            int attack = 500;


            //string interpolation

            //Console.WriteLine($"My character's name is {characterName}. I have {health} health.");

            
            Console.WriteLine("{0,0}{1,10}{2,10}", characterName, health, speed);
            Console.WriteLine("{0,0}{1,10}{2,12}", characterName, health, speed);
            Console.WriteLine("{0,0}{1,10}{2,14}", characterName, health, speed);
            Console.WriteLine("{0,0}{1,10}{2,16}", characterName, health, speed);
            Console.WriteLine("{0,0}{1,10}{2,18}", characterName, health, speed);
            */

            /*
            //methods
            string name = "Megensitica";



            int result = equationMethod(600,500);

            Console.WriteLine(result);

            randomMethod();
           
         

        }

        static void randomMethod()
        {
            Console.WriteLine("Wow im using a method rn!!!");
        }

        static int equationMethod(int x, int y)
        {
            x += y + 2;
            y += x * 27;
            return x + y;
        }
            */


            //Conditionals "if"

            /*
            if(isAlive()) // WE ARE ALIVE
            {
                Console.WriteLine($"Our health is: {health}. We are alive");
            }
            else //ded
            {
                Console.WriteLine($"Our health is: {health}. We are dead");
            }
            Console.ReadKey();

            static bool isAlive()
            {
                if (health > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            

            Console.WriteLine("The current weapon is: " + weapon);

            if (weapon == 0)
            {
                //deals fist damage
                DealDamageToEnemy(5);
            }
            else if (weapon == 1)
            {
                //pistol damage
                DealDamageToEnemy(20);
            }
            else if (weapon == 2)
            {
                //rocket launcher damage
                DealDamageToEnemy(100);
                weapon = 0;
            }
            else if (weapon == 3)
            {
                //sniper damage
                DealDamageToEnemy(100);
            }
            else
            {

                Console.WriteLine("The equipped weapon is not valid");
            }

            Console.WriteLine("The current weapon is: " + weapon);

            static void DealDamageToEnemy(int amount) //move outside of main method for use...
            {
                Console.WriteLine($"The enemy health is at {enemyHealth}. We deal {amount}.");

                enemyHealth -= amount;

                Console.WriteLine($"The enemy now has {enemyHealth} health.");
            }
            */


            /*
            //switch statement

            WeaponType weapon = Weapontype.fist
            Console.WriteLine("The current weapon is: " + weapon);
            switch (weapon)
            {
                case WeaponType.fist:
                    //fist attack
                    DealDamageToEnemy(5);
                    break;
                case 1:
                    //pistol attack
                    DealDamageToEnemy(20);
                    break;
                case 2:
                    //rocket launcher attack
                    DealDamageToEnemy(100);
                    weapon = 0;
                    break;
                case 3:
                    //sniper attack
                    DealDamageToEnemy(80);
                    break;
                default:
                    Console.WriteLine("The equipped weapon is not valid");
                    break;

            }
            Console.WriteLine("The current weapon is: " + weapon);
            

            
        }

        //enum
        enum WeaponType
        {
            fist,
            pistol,
            rockelauncher,
            sniperRifle
        }

        static void DealDamageToEnemy(int amount)
        {
            Console.WriteLine($"The enemy health is at {enemyHealth}. We deal {amount}.");

            enemyHealth -= amount;

            Console.WriteLine($"The enemy now has {enemyHealth} health.");
        }


        */
            //key info
            /*
            ConsoleKeyInfo keyinfo = Console.ReadKey();

            switch (keyinfo.Key)
            {
                case ConsoleKey.Spacebar:
                    Console.WriteLine("Spacebar");
                    break;

                case ConsoleKey.Enter:
                    Console.WriteLine("Enter");
                    break;
                       
            }
            */

            //true or false returns

            //static bool IsEven(int numtoCheck)
            //{
            //    if (numtoCheck % 2 == 0)
            //    {
            //        return true;
            //    }

            //    return false;
            //}



        }


    }
}
