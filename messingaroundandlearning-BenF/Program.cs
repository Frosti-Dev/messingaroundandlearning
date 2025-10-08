using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            //Arrays

            //static string[] partyNames = { "Alexia", "Scissor", "Phil", "Angel" };
            //static int[] partyLevels = new int[4];

            //static void LevelUpPartyMember(string memberName)
            //{
            //    int indexOfPartyMember = Array.IndexOf(partyNames, memberName);
            //    //Alexia = 0 in this case -----------------^

            //    partyLevels[indexOfPartyMember] += 1;
            //}

            //Array.Sort(partyNames);

            //Console.WriteLine(partyNames[0]);
            //Console.WriteLine(partyNames[1]);
            //Console.WriteLine(partyNames[2]);
            //Console.WriteLine(partyNames[3]);

            //partyLevels[0] = 1;
            //partyLevels[1] = 1;
            //partyLevels[2] = 1;
            //partyLevels[3] = 1;

            //LevelUpPartyMember("Alexia");
            //LevelUpPartyMember("Alexia");
            //LevelUpPartyMember("Alexia");
            //LevelUpPartyMember("Alexia");
            //LevelUpPartyMember("Angel");
            //LevelUpPartyMember("Scissor");

            //Console.WriteLine(partyLevels[0]);
            //Console.WriteLine(partyLevels[1]);
            //Console.WriteLine(partyLevels[2]);
            //Console.WriteLine(partyLevels[3]);

            ////highest level in party
            //int maxValue = partyLevels.Max();
            //int minValue = partyLevels.Min();
            //int totalValue = partyLevels.Sum();
            //Console.WriteLine("Highest Level: " + maxValue);
            //Console.WriteLine("Lowest Level: " + minValue);
            //Console.WriteLine("Total Level: " + totalValue);

            ////Console.WriteLine(partyNames[0]);
            //Console.ReadKey();

            //loops

            //while loops

            //int PlayerHP = 100;
            //while (PlayerHP > 0)
            //{
            //    //will repeat until hp hits 0

            //    PlayerHP -= 20;
            //    Console.WriteLine("Player Health: " + PlayerHP);
            //    Console.ReadKey();
            //    Console.Clear();
            //}

            //Console.WriteLine("ded");

            //int amountofloops = 0;
            //while (true)
            //{
            //    Console.WriteLine(amountofloops);
            //    amountofloops++;

            //    Console.ReadKey(true);
            //}

            //int PlayerHP = 100;

            //ConsoleKeyInfo lastSelection = new ConsoleKeyInfo();
            //while (PlayerHP > 0)
            //{
            //    //will repeat until hp hits 0

            //    Console.WriteLine("Player Health: " + PlayerHP);
            //    lastSelection = Console.ReadKey(true);


            //    if (lastSelection.Key == ConsoleKey.X)
            //    {
            //        break;
            //    }

            //    PlayerHP -= 10;
            //}

            //for loops

            //string[] studentNames = { "Chris", "Aiden", "Charlie", "Georgia", "Micah" };

            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.WriteLine(studentNames[i] + " " + i);
            //    Console.ReadKey(true);
            //}

            ////random number
            //Random random = new Random();


            //while (true) 
            //{
            //    //int randomNumber = random.Next(-100, 100);
            //    //Console.WriteLine(randomNumber);

            //    string MyUserInput = Console.ReadLine();

            //    Console.WriteLine($"Your input was: {MyUserInput}");

            //    int ValueasInt = int.Parse(MyUserInput);

            //    Console.WriteLine(ValueasInt);

            //    //Console.ReadKey();
            //    Console.ReadKey(true); //will not show keys pressed
            //}

            //Console.WriteLine("We are out of the loop");



            //value types + reference types

            //value types; points to data directly. Only copies the value.

            //int a = 5;

            ////int b = a;
            //ref int b = ref a;


            //b = 10;

            //Console.WriteLine(a);

            //int health = 80;
            //int level = 5;

            //    IncreaseNumber(ref level);

            //    Console.WriteLine(level);

            //}

            //static int IncreaseNumber(int numToIncrease)
            //{
            //    return numToIncrease += 1;
            //}

            //string[] someNames = { "Peter", "Alfred", "Jeremy" };

            //string[] anotherArray = someNames;

            //anotherArray[0] = "Britney Spears";

            //Console.WriteLine(someNames[0]);


            //addTwoNumbers(health, level);

            //    string[] players = { "Destroyer348654", "SamIAm", "TortoisGuy" };

            //    ChangeUsername(players, 0, "NewUsername");

            //}

            //static void ChangeUsername(string[] playersInLobby, int index, string newname)
            //{
            //    playersInLobby[index] = newname;
            //}



            //static int addTwoNumbers(int a, int b)
            //{
            //    a = 10; //a does not know about health

            //    return a + b;
            //}

            //2 dimentional arrays

            //char[,] xoBoard = {
            //    { 'X', '0', ' ' }, //row 0
            //    { ' ', 'X', ' ' }, //row 1
            //    { ' ', ' ', 'X' } //row 2

            //};

            //Console.WriteLine(xoBoard[0, 1]); //row, column

            //outer loop
            //for (int i = 0; i < boardColors.GetLength(0); i++)
            //{
            //    for(int j = 0; j <boardColors.GetLength(1); j++)
            //    {
            //        Console.BackgroundColor = boardColors[i, j];
            //        Console.Write(" ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadKey(true)


            //Scope
            //a region of code where identifiers are accessable

            //ExampleMethod();

            //myInteger does not exist here

            //for(int i = 0; i< 10; i++)
            //{
            //    int myIntForLoop = 5;

            //    ExampleMethod();
            //}

            //}

            //static void ExampleMethod()
            //{
            //    int myInteger = 10;
            //}

            //foreach loop
            //interate over collection elements

            //int[] GunAmmos = { 6, 25, 30, 1 };

            //foreach(int GunAmmo in GunAmmos)
            //{
            //    //GunAmmo is equal to 6 the first interation then will change to 25 etc.
            //    Console.WriteLine($"Gun Ammo: {GunAmmo}");
            //}

            ////list -> dynamicallly sizable
            //List<string> classPeoplez = new List<string>();

            //add, remove, clear, contains
            //classPeoplez.Add("Simon");
            //classPeoplez.Add("Charile");
            //classPeoplez.Add("Ben");

            //classPeoplez.Reverse();

            //classPeoplez.Remove("Simon");

            //Console.WriteLine(classPeoplez.Max<string>());

            //for (int i = 0, i <classPeoplez.Count; i++)
            //{

            //}

            //foreach(string name in classPeoplez)
            //{
            //    Console.WriteLine(name);
            //}

            //List<string> Inventory = new List<string>();

            //Inventory.Add("Helm");
            //Inventory.Add("Chest");
            //Inventory.Add("Leggings");
            //Inventory.Add("Frosty Boots");
            //Inventory.Add("Sword");

            //Inventory.Remove(3);
            //Inventory.RemoveAt(3);

            //Inventory.Contains("Sword");

            //Console.WriteLine("Inventory");

            //foreach (string item in Inventory)
            //{ 
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();



        }
    }
}
