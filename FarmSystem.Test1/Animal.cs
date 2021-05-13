using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
   public abstract class Animal
    {
        public virtual string Name => GetType().Name;

        public virtual int NoOfLegs => 4;

        string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_id))
                {
                    _id = Guid.NewGuid().ToString();
                }

                return _id;
            }
            set => _id = value;
        }

        protected abstract string Noise { get; }

        public virtual void Talk()
        {
            Console.WriteLine(Name + " says " + Noise +"!");
        }

        public void Run()
        {
            Console.WriteLine(Name + " is running");
        }
    }
}
