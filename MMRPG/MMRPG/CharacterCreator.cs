using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRPG
{
    public abstract class CharacterCreator
    {
        public abstract Character CreateCharacter(string name);
    }
}
