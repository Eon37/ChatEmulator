using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class User
    {
        public User(string n, Color c, byte s)
        {
            name = n;
            color = c;
            speed = s;
            continueThread = true;
        }
        public bool continueThread;
        public string name;
        public Color color;
        public byte speed;
    }
}
