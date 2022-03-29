using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postava
{
    public class Character
    {
        private int shield;
        private int health;
        private int damage;

        public string Name { get; }
        public int Health { get => health; }
        public int Shield { get => shield; }
        public int Damage { get => damage; }

        public Character(string name)
        {
            Name = name;
            health = 100;
            shield = 50;
            damage = 20;
        }

        public void GetHit(int damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                health += shield;
                shield = 0;
            }
        }

        public Character(string name, int health, int shield, int damage)
        {
            Name = name;
            damage = Damage;
            health = Health;
            shield = Shield;
            damage = Damage;
        }

        public void Heal()
        {
            health += 15;
        }

        public override string ToString()
        {
            string text = "Name: " + Name + "\r\n";
            text += "Health: " + health + "\r\n";
            text += "Shield: " + shield + "\r\n";
            text += "Damage: " + damage + "\r\n";
            return text;
        }
    }
}
