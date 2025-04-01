using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUnity
{
    public abstract class Component // "Monobehaviour"
    {
        public virtual void Start()
        {

        }
        public abstract void Update();
    }
}
