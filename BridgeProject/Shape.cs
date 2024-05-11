using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public delegate void Action(int value);
    public abstract class Shape
    {
        public void SetParameters(string parameters, params Action[] actions)
        {
            string[] par=parameters.Split(" \t;".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            if (par.Length != actions.Length)
                throw new ArgumentException("Wrong parameters count");

            for (int i = 0; i < actions.Length; ++i)
            {
                actions[i](int.Parse(par[i]));
            }
        }

        public abstract void Draw(Graphics g);
        public abstract string toXml();

    }
}
