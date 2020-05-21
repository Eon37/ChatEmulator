using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading
{
    public partial class ChatWindow : Form
    {
        List<User> users;
        List<Thread> thrd;
        Random rnd = new Random();
        byte numOfUsers;
        string[] speeds;

        public ChatWindow()
        {
            InitializeComponent();
            users = new List<User>();
            thrd = new List<Thread>();
            speeds = new string[] { "5" };
        }

        private void aplBtn_Click(object sender, EventArgs e)
        {
            if(!checkInput()) return;
            
            for(byte i = 0; i < users.Count(); i++)
            {
                users[i].continueThread = false;
            }
            users.Clear();

            numOfUsers = Byte.Parse(amountBox.Text);
            for (byte i = 0; i < numOfUsers; i++)
            {
                users.Add(new User(StringPool.names[rnd.Next(StringPool.names.Length)], 
                                    Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)),
                                    speeds.Length == 1 ? Byte.Parse(speeds[0]) : Byte.Parse(speeds[i])));
            }
            

            foreach (User u in users)
            {
                ThreadPool.QueueUserWorkItem(chat, u);
            }
            
        }

        private bool checkInput()
        {
            speeds = speedBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            numOfUsers = Byte.Parse(amountBox.Text);
            foreach (string s in speeds)
            {
                if (speeds.Length == 1) return true;
                if (speeds.Length != numOfUsers || !System.Text.RegularExpressions.Regex.IsMatch(s, "^\\d{1,2}$")
                    || amountBox.Text == "0")
                {
                    MessageBox.Show("Incorrect speed input");
                    return false;
                }
            }
            return true;
        }

        private string says()
        {
            byte numOfWords = (byte)rnd.Next(1,15);
            byte numOfLetters;
            char[] word;
            List<string> words = new List<string>();
            string say;

            for(byte i = 0; i< numOfWords; i++)
            {
                numOfLetters = (byte)rnd.Next(1,14);
                word = new char[numOfLetters];
                for (byte j = 0; j < numOfLetters; j++)
                {
                    word[j] = (char)rnd.Next('a', 'z');
                }
                words.Add(new string(word));
            }

            words[0] = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[0]);

            say = words.Aggregate((i, j) => i + " " + j);

            return say + StringPool.endOfSentence[rnd.Next(0, 3)];
        }
        

        private void chat(object u)
        {
            while (((User)u).continueThread)
            {
                ChatWindow.marginalies.Invoke((MethodInvoker)delegate
                {
                    ChatWindow.marginalies.SelectionColor = Color.Gray;
                    ChatWindow.marginalies.SelectedText = Environment.NewLine + new string('-', 58);
                    ChatWindow.marginalies.SelectionColor = ((User)u).color;
                    ChatWindow.marginalies.SelectedText = Environment.NewLine + ((User)u).name + ": " + 
                                                            says();

                    ChatWindow.marginalies.ScrollToCaret();
                });
                Thread.Sleep(((User)u).speed * 1000);
            }

            
        }
    }
}
