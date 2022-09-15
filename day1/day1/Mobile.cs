using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training
{
    public abstract class Mobile
    {
        private int IMEINo;

        public String Model { get; set; }

        public int Year { get; set; }

    }

    public class Nokia:Mobile
    {
        public void NokiaConfig() { }
    }

    public class Samsung:Mobile
    {
        public void SamsungConfig() { }
    }

}
