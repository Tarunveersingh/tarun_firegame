using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarun_firegame
{
    public partial class Form1 : Form
    {
        Random obj = new Random();
        int lop = 0, countr = 0, countr2 = 0;
        pictures instance = new pictures();

        public Form1()
        {
            InitializeComponent();
            lop = obj.Next(1, 6);
            tarun_load.Enabled = false;
            tarun_spin.Enabled = false;
            tarun_shoot_away.Enabled = false;
            tarun_soot.Enabled = false;
        }

       // game is staring with start button 
        private void tarun_start_Click(object sender, EventArgs e)
        {
            instance.ongame(pictureBox1);
            tarun_start.Enabled = false;
            tarun_load.Enabled = true;
        }
        public void generateNo() {
                lop=obj.Next(1, 3);
        }
        // load button for loading the gun 
        private void tarun_load_Click(object sender, EventArgs e)
        {
            instance.loadgame(pictureBox1);
            tarun_load.Enabled = false;
            tarun_spin.Enabled = true;
        }
        // spin button is changing the picture and enabling and disabling the next and previous buttons
        private void tarun_spin_Click(object sender, EventArgs e)
        {
            instance.spingame(pictureBox1);
            
            tarun_spin.Enabled = false;
            tarun_soot.Enabled = true;
            tarun_shoot_away.Enabled = true;

        }
        // for shooting purpose below code is written with help of countr variable 
        private void tarun_soot_Click(object sender, EventArgs e)
        {
            instance.shootgame(pictureBox1);
            countr++;

            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(tarun_firegame.Properties.Resources.fire);
            obj.Play();
            if (lop == countr)
            {
                MessageBox.Show("Shoot Sucess");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Alive Still  ");
            }

            // after 4 times button is disabled
            if (countr == 4)
            {
                MessageBox.Show("Over Now ");
                tarun_soot.Enabled = false;
            }

            if (countr == 4 && countr2 == 2)
            {
                Application.Restart();
            }
        }

        // shoot away button giving two chances for shoot
        private void tarun_shoot_away_Click(object sender, EventArgs e)
        {
            instance.shootawaygame(pictureBox1);
            countr2++;
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(tarun_firegame.Properties.Resources.fire);
            obj.Play();
            MessageBox.Show("Shoot Awayed");

            if (countr2 == 2)
            {
               tarun_shoot_away.Enabled = false;


            }


            if (countr == 4 && countr2 == 2)
            {
                Application.Restart();
            }

        }
        //reload buton coding 
        private void tarun_reload_Click(object sender, EventArgs e)
        {
            tarun_reload.Enabled = false;
            tarun_start.Enabled = true;
        }
    }
}
