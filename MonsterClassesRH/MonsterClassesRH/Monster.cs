using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesRH
{
    public abstract class Monster
    {
        public enum MonsterAction {UnleashtheFury, Defend, Retreat}
        private bool _isactive;
        private int _age;
        private String _name;
        private int _id;
        

        public bool IsActive
        {
            get { return _isactive; }
            set { _isactive = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Monster()
        {

        }

        public Monster(int id, string name)
        {
            _id = Id;
            _name = Name;
        }

        public virtual string Greeting()
        {
            return $"Hello my name is {_name}";
        }

        public virtual string Farewell()
        {
            return "Farewell traveler";
        }

        public abstract bool IsHappy();

        public abstract bool IsHungry();
     

    }
}
