using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesRH
{
    class SeaMonster : Monster, IBattle
    {
        private bool _hasgills;
        private string _seaname;


        public string SeaName
        {
            get { return _seaname; }
            set { _seaname = value; }
        }

        public bool HasGills
        {
            get { return _hasgills; }
            set { _hasgills = value; }
        }
        public override bool IsHungry()
        {
            return true;
        }

        public override bool IsHappy()
        {
            return true;
        }

        public override string Greeting()
        {
            return $"Hello I am a SeaMonster, and my name is {Name}";
        }

        public override string Farewell()
        {
            return "Goodbye traveler.";
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
    }
}
