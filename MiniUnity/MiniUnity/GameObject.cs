using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUnity
{
    public class GameObject
    {
        private List<Component> components;

        public void AddComponent(Component c)
        {
            components.Add(c);
        }
        public void Start()
        {
            components = new List<Component>();

            foreach (Component c in components)
            {
                c.Start();
            }
        }

        public void Update()
        {
            foreach (Component c in components)
            {
                c.Update();
            }
        }
    }
}
