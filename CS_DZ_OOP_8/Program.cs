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
            List<Fighter> fighters = new List<Fighter>();
            Fighter firstFighter = null;
            Fighter secondFighter = null;
            BigHuman bigBoy = new BigHuman(1, "Амбал", 500, 0, "Берсерк + 10 к урону каждую атаку", 10, 10);
            Fighter monster = new Fighter(2, "Вурдалак", 200, 5, "Каждую атаку пополняет здоровье на 10", 20);
            Fighter smallBoy = new Fighter(3, "Жилистый", 300, 0, "Тройной удар", 30);
            Fighter general = new Fighter(4 ,"Господин", 400, 15, "Двойной удар", 20);
            Fighter elf = new Fighter(5, "Селена", 300, 10, "Шанс вызова ночного волка с уроном 100", 30);

            bigBoy.Showinfo(); monster.Showinfo(); smallBoy.Showinfo(); general.Showinfo(); elf.Showinfo();
            fighters.Add(bigBoy); fighters.Add(monster); fighters.Add(smallBoy); fighters.Add(general); fighters.Add(elf);

            Console.Write("Выберите первого бойца: ");
            int firstIndex = Convert.ToInt32(Console.ReadLine());
            foreach (var fighter in fighters)
            {
                if(firstIndex == fighter.Index)
                {
                    firstFighter = fighter;
                    Console.WriteLine("Выбран боец - ");
                    firstFighter.Showinfo();
                }
            }

            Console.WriteLine("Выберите второго бойца! Нельзя выбирать такого же!");
            bool correctInput = false;
            while(correctInput == false)
            {
                int secondIndex = Convert.ToInt32(Console.ReadLine());
                if(firstIndex == secondIndex)
                {
                    Console.WriteLine("Ошибка повторите попытку!");
                }
                else
                {
                    correctInput = true;
                    foreach (var fighter in fighters)
                    {
                        if(secondIndex == fighter.Index)
                        {
                            secondFighter = fighter;
                            Console.WriteLine("Выбран боец - ");
                            secondFighter.Showinfo();
                        }
                    }
                }
            }

            while (firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                Console.WriteLine("У бойца - " + firstFighter.Name + " осталось " + firstFighter.Health);
                Console.WriteLine("У бойца - " + secondFighter.Name + " осталось " + secondFighter.Health);
            }
        }
    }

    class Fighter
    {
        public int Index { get; private set; }

        public string Name { get; private set; }

        public int Health { get; private set; }

        protected int Armor;

        protected string SpecialHit;

        public int Damage { get; private set; }

        public Fighter(int index, string name, int health, int armor, string specialHit, int damage)
        {
            Index = index;
            Name = name;
            Health = health;
            Armor = armor;
            SpecialHit = specialHit;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void Showinfo()
        {
            Console.WriteLine(Index + " " + Name + " его жизни - " + Health + " его броня - " + Armor + " " + SpecialHit + " его урон - " + Damage);
        }
    }

    class BigHuman : Fighter
    {
        public BigHuman(int index, string name, int health, int armor, string specialHit, int damage, int specialAttack) : base(index, name, health, armor, specialHit, damage += specialAttack)
        {

        }
    }

    class Monster : Fighter
    {
        public Monster(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage)
        {

        }
    }

    class SmallHuman : Fighter
    {
        public SmallHuman(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage)
        { 

        }
    }

    class General : Fighter
    {
        public General(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage)
        {

        }
    }

    class Elf : Fighter
    {
        public Elf(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage)
        {

        }
    }
}
