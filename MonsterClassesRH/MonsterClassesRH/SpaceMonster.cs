using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesRH
{
    public class SpaceMonster : Monster, IBattle
    {
        private bool _hasspaceship;
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public bool HasSpaceShip
        {
            get { return _hasspaceship; }
            set { _hasspaceship = value; }
        }

        public override string Greeting()
        {
            return $"Hello I am a Space Monster, and my name is {Name}";
        }

        public override bool IsHappy()
        {
            /*
            if (_hasspaceship)
            {
                return true;
            }
            else
            {
                return false;
            }*/

            return _hasspaceship ? true : false;
        }

        public override string Farewell()
        {
            return "Farewell, Human.";
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();

            int actionProbability = randomNumber.Next(0, 101);

            if (actionProbability >= 20)
            {
                return MonsterAction.UnleashtheFury;
            }
            else if (actionProbability >= 80)
            {
                return MonsterAction.Retreat;
            }
            
            else
            {
                return MonsterAction.Defend;
            }
        }

        public override bool IsHungry()
        {
            return true;
        }
    }
}
