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
            SmallHuman smallHuman = new SmallHuman("Жилистый", 300, 0, "Шанс уворота 50%", 30);
            General general = new General("Господин", 400, 200, "Шанс нанести крит = 50%", 20);
            Elf elf = new Elf("Селена", 300, 50, "Шанс вызова ночного волка с уроном 100", 30);

            Console.WriteLine();

            NewFight fight = new NewFight();
            fight.Fight();
        }
    }

    class NewFight
    {
        List<NewFight> newFights;

        public void Fight()
        {
            
        }
    }

    class Fighters
    {

    }

    class BigHuman
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Armor { get; private set; }

        public string SpecialHit { get; private set; }

        public int Damage { get; private set; }

        public BigHuman()
        {
            Name = "Качок";
            Health = 600;
            Armor = 200;
            SpecialHit = "Каждый удар пополняет жизни на 20";
            Damage = 50;
        }
    }

    class Monster
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Armor { get; private set; }

        public string SpecialHit { get; private set; }

        public int Damage { get; private set; }

        public Monster()
        {
            Name = "Вурдалак";
            Health = 200;
            Armor = 100;
            SpecialHit = "Каждый удар пополняет жизни на 20";
            Damage = 20;
        }
    }

    class SmallHuman
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Armor { get; private set; }

        public string SpecialHit { get; private set; }

        public int Damage { get; private set; }

        public SmallHuman(string name, int health, int armor, string specialHit, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            SpecialHit = specialHit;
            Damage = damage;
        }
    }

    class General
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Armor { get; private set; }

        public string SpecialHit { get; private set; }

        public int Damage { get; private set; }

        public General(string name, int health, int armor, string specialHit, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            SpecialHit = specialHit;
            Damage = damage;
        }
    }

    class Elf
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Armor { get; private set; }

        public string SpecialHit { get; private set; }

        public int Damage { get; private set; }

        public Elf(string name, int health, int armor, string specialHit, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            SpecialHit = specialHit;
            Damage = damage;
        }
    }
}
