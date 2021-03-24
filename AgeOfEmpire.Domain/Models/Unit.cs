using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfEmpire.Domain.Models
{
    public class Unit
    {
        public Unit()
        {
        }

        public Unit(int id, string name, int hitpoints, int attack)
        {
            Id = id;
            Name = name;
            HitPoints = hitpoints;
            Attack = attack;
        }
        public int Id { get;}
        public string Name { get;}
        public int HitPoints { get;}
        public int Attack { get;}
    }
}
