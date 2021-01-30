using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SpellingGame.Classes;

namespace SpellingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader file=File.OpenText(@"C:\Users\özgür\source\repos\SpellingGame\SpellingGame\Json\History.json"))
            {
                Random random = new Random();
                JsonSerializer serializer = new JsonSerializer();
                List<World> worlds = new List<World>();
                Root root = (Root)serializer.Deserialize(file, typeof(Root));
                for (int i = 0; i < 5; i++)
                {
                    int index = random.Next(root.worlds.Count);
                    worlds.Add(root.worlds[index]);
                    root.worlds.Remove(root.worlds.ElementAt(index));
                }
                GameForm gameForm = new GameForm(worlds);
                gameForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
