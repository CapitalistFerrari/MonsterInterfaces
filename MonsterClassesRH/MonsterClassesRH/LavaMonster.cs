using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesRH
{
    class LavaMonster : Monster, IBattle
    {
        private bool _hasfury;
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public bool HasFury
        {
            get { return _hasfury; }
            set { _hasfury = value; }
        }

        public override string Greeting()
        {
            return $"I am a Lava Monster, and my name is {Name}!";
        }

        public override bool IsHappy()
        { 
            return _hasfury ? true : false;
        }

        public override string Farewell()
        {
            return "I must return to Mt. St. Helens.";
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
