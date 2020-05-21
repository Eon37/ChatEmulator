using System.Drawing;

namespace MultiThreading
{
    public class User
    {
        public bool continueThread { get; set; }
        public string name { get; }
        public Color color { get; }
        public byte speed { get; }

        public User(string name, Color color, byte speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            continueThread = true;
        }
    }
}
