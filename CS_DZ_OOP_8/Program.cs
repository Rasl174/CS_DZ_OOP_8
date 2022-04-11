using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_OOP_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = {new Fighter("Иван Амбал", 500, 20, 80), new Fighter("Человек Торнадо", 400, 0, 60), new Fighter("Леха Каратист", 350, 0, 100),
                                  new Fighter("Полковник Грач", 450, 30, 70), new Fighter("Железный человек", 400, 40, 80)};

            int firstFighterNumber;
            int secondFighterNumber;

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write((i + 1) + " ");
                fighters[i].ShowStats();
            }

            Console.Write("Выберите первого бойца: ");
            firstFighterNumber = Convert.ToInt32(Console.ReadLine());
            Fighter firstFighter = fighters[firstFighterNumber - 1];
            Console.Write("Выберите второго бойца: ");
            secondFighterNumber = Convert.ToInt32(Console.ReadLine());
            Fighter secondFighter = fighters[secondFighterNumber - 1];

            while(firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowStats();
                secondFighter.ShowStats();

                if(firstFighter.Health <= 0 && secondFighter.Health <= 0)
                {
                    Console.WriteLine("Оба умерли!");
                }
                else if(firstFighter.Health <= 0)
                {
                    Console.WriteLine(firstFighter.Name + " погиб.");
                    Console.WriteLine(secondFighter.Name + " выиграл!");
                }
                else if(secondFighter.Health <= 0)
                {
                    Console.WriteLine(secondFighter.Name + " погиб.");
                    Console.WriteLine(firstFighter.Name + " выиграл!");
                }
            }
        }
    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _armor;
        private int _damage;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
        }

        public Fighter(string name, int health, int armor, int damage)
        {
            _name = name;
            _health = health;
            _armor = armor;
            _damage = damage;
        }

        public void ShowStats()
        {
            Console.WriteLine(_name + " Жизни - " + _health + " Броня - " + _armor + " Урон - " + _damage);
        }

        public void TakeDamage(int damage)
        {
            _health = _health - (damage - _armor);
        }
    }
}
