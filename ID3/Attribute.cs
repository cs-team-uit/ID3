using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3
{
    class Attribute
    {
        public Attribute() //Thêm hàm
        {
            Name = "Root";
        }
        public Attribute(string name) //Thêm hàm
        {
            Name = name;
        }
        public string Name;
        public Value LValue;
        public int[] Value;
        public string Label;
        public int Count;
    }
}
