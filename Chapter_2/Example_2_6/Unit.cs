using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_6
{
    class Unit : ILifeForm, IAttack
    {
        public void HitEnemy()
        {
            throw new NotImplementedException();
        }

        void ILifeForm.IsAlive()
        {
            throw new NotImplementedException();
        }

        void ILifeForm.RemoveLives()
        {
            throw new NotImplementedException();
        }
    }
}
