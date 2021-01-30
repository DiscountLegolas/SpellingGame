using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using SpellingGame.Classes;

namespace SpellingGame
{
    public partial class GameForm : Form
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        private int CurrentWorldındex { get; set; }
        private List<World> Worlds { get; set; }
        public GameForm(List<World> worlds)
        {
            this.Worlds = worlds;
            this.CurrentWorldındex = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            World world = Worlds[CurrentWorldındex];
            speechSynthesizer.SetOutputToDefaultAudioDevice();
            speechSynthesizer.Speak(world.word);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()==Worlds[CurrentWorldındex].word.Trim())
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {

            }

        }
    }
}
