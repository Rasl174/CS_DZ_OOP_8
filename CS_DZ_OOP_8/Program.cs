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
            BigHuman bigBoy = new BigHuman(1, "Амбал", 600, 0, "Берсерк + 20 к урону", 5);
            Monster monster = new Monster(2, "Вурдалак", 200, 10, "Быстрая атака", 10);
            SmallHuman smallBoy = new SmallHuman(3, "Жилистый", 300, 0, "Тройной удар", 10);
            General general = new General(4 ,"Господин", 400, 10, "Двойной удар", 10);
            Elf elf = new Elf(5, "Селена", 300, 10, "Ночной волк с уроном 20", 10);

            bigBoy.Showinfo(); monster.Showinfo(); smallBoy.Showinfo(); general.Showinfo(); elf.Showinfo();
            fighters.Add(bigBoy); fighters.Add(monster); fighters.Add(smallBoy); fighters.Add(general); fighters.Add(elf);

            Console.Write("Выберите первого бойца: ");
            int firstIndex = Convert.ToInt32(Console.ReadLine());
            foreach (var fighter in fighters)
            {
                if(firstIndex == fighter.Index)
                {
                    firstFighter = fighter;
                    Console.Write("Выбран боец - ");
                    firstFighter.Showinfo();
                }
            }

            Console.Write("Выберите второго бойца. Нельзя выбирать такого же: ");
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
                            Console.Write("Выбран боец - ");
                            secondFighter.Showinfo();
                        }
                    }
                }
            }

            while (firstFighter.Health >= 0 && secondFighter.Health >= 0)
            {
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                Console.WriteLine("У бойца - " + firstFighter.Name + " осталось " + firstFighter.Health);
                Console.WriteLine("У бойца - " + secondFighter.Name + " осталось " + secondFighter.Health);

                if(firstFighter.Health < 0)
                {
                    Console.WriteLine(firstFighter.Name + " умер");
                    Console.WriteLine(secondFighter.Name + " победил");
                }
                else if(secondFighter.Health < 0)
                {
                    Console.WriteLine(secondFighter.Name + " умер");
                    Console.WriteLine(firstFighter.Name + " победил");
                }
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
        public BigHuman(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage + 20) { }

    }

    class Monster : Fighter
    {
        public Monster(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage * 6) { }

    }

    class SmallHuman : Fighter
    {
        public SmallHuman(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage * 3) { }
    }

    class General : Fighter
    {
        public General(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage * 2) { }
    }

    class Elf : Fighter
    {
        public Elf(int index, string name, int health, int armor, string specialHit, int damage) : base(index, name, health, armor, specialHit, damage + 30) { }
    }
}
