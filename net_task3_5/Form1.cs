using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_task3_5
{
    public partial class Form1 : Form
    {
        private string continentName;
        private Planet ourPlanet;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string planetName = textBox1.Text;
            string[] continentNames = textBox2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] oceanNames = textBox3.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] islandNames = textBox4.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            ourPlanet = new Planet(planetName, continentNames, oceanNames, islandNames);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = ourPlanet.GetPlanetName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = ourPlanet.GetContinentCount().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = ourPlanet.GetOceanCount().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = ourPlanet.GetIslandCount().ToString();
        }

    }
}
