using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_DungeonsAndDragons
{
    class GameRound
    {
        int numberOfSides;
        int value;
        bool isCriticalHit;
        bool isCriticalMiss;
        // int EnemyArmorClass;

        Random random = new Random();

        public GameRound()
        {
            this.value = value;
        }

        public int RollGameDie()
        {
            int value = random.Next(1, 20);
            Console.WriteLine(value);
            return value;
        }
        // xdy
        // string 2d6
        // string 3d4

        public bool IsCriticalHit(int value)
        {
            if (value == 20)
            {
                isCriticalHit = true;
            }
            else
            {
                isCriticalHit = false;
            }
            return isCriticalHit;
        }

        public bool IsCriticalMiss(int value)
        {
            if (value == 1)
            {
                isCriticalMiss = true;
                Console.WriteLine(isCriticalMiss);
            }
            else
            {
                isCriticalMiss = false;
                Console.WriteLine(isCriticalMiss);
            }

            return isCriticalMiss;           
        }

        public int EnterModifier(int value)
        {
            Console.WriteLine("Enter a modifier, game master: ");
            int modifier = Convert.ToInt32(Console.ReadLine());
            return modifier;
        }

        public int AddModifierToRoll(int value, int modifier)
        {
            int attack = value + modifier;
            return attack;
        }       

        public int getEnemyArmorClass()
        {
            int armorClass = random.Next(1, 20);
            return armorClass;
        }

        public bool IsHit(int attack, int armorClass)
        {
            if (attack >= armorClass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string WeaponDamage()
        {
            Console.WriteLine("Weapon damage (xdy): ");
            string input = Console.ReadLine();

            string[] damage = input.Split(',');
            string damageX = damage[0];
            string damageY = damage[2];


            
        }
    }
}
