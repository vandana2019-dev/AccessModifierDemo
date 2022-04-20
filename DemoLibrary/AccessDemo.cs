using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {

        private void Demo()
        {
            PrivateDemo();
        }

        // cannot be accessed from anywhere
        private void PrivateDemo()
        {

        }

        // Same assembly and the the inherited class
        private protected void PrivateProtectedDemo()
        {

        }

        // The code is accessible within the same class or from any class that inherits from that classs
        protected void ProtectedDemo()
        {

        }

        // Same assembly and also from where it inherits
        protected internal void ProtectedInternalDemo()
        {

        }

        // can be accessed only in that dll (assembly - class library)
        internal void InternalDemo()
        {

        }

        // access from anywhere
        public void PublicDemo()
        {

        }

    }
}
