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
            Fighter bigBoy = new Fighter("Амбал", 500, 50, "Берсерк + 10 к урону каждую атаку", 20);
            Fighter monster = new Fighter("Вурдалак", 200, 100, "Каждую атаку пополняет здоровье на 10", 20);
            Fighter smallBoy = new Fighter("Жилистый", 300, 0, "Шанс уворота 50%", 30);
            Fighter general = new Fighter("Господин", 400, 200, "Шанс нанести двойной урон", 20);
            Fighter elf = new Fighter("Селена", 300, 50, "Шанс вызова ночного волка с уроном 100", 30);

            bigBoy.Showinfo(); monster.Showinfo(); smallBoy.Showinfo(); general.Showinfo(); elf.Showinfo();

            Console.Write("Выберите первого бойца: ");

        }
    }

    class Fighter
    {
        protected string Name;

        protected int Health;

        protected int Armor;

        protected string SpecialHit;

        protected int Damage;

        public Fighter(string name, int health, int armor, string specialHit, int damage)
        {
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
            Console.WriteLine(Name + " его жизни - " + Health + " его броня - " + Armor + " " + SpecialHit + " его урон - " + Damage);
        }
    }

    class BigHuman : Fighter
    {
        public BigHuman(string name, int health, int armor, string specialHit, int damage) : base(name, health, armor, specialHit, damage)
        {
            Berserk();
        }

        private void Berserk()
        {
            Damage += 10;
        }
    }

    class Monster : Fighter
    {
        public Monster(string name, int health, int armor, string specialHit, int damage) : base(name, health, armor, specialHit, damage)
        {

        }
    }

    class SmallHuman : Fighter
    {
        public SmallHuman(string name, int health, int armor, string specialHit, int damage) : base(name, health, armor, specialHit, damage)
        {

        }
    }

    class General : Fighter
    {
        public General(string name, int health, int armor, string specialHit, int damage) : base(name, health, armor, specialHit, damage)
        {

        }
    }

    class Elf : Fighter
    {
        public Elf(string name, int health, int armor, string specialHit, int damage) : base(name, health, armor, specialHit, damage)
        {

        }
    }
}
