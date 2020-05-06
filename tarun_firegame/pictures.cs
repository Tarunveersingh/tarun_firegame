using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarun_firegame
{
    // sending pictures to form 1 from this class 
    public class pictures {
        public void ongame(PictureBox tr) {
            tr.Image = tarun_firegame.Properties.Resources.start_Game;
        }
        public void loadgame(PictureBox tr) {
            tr.Image = tarun_firegame.Properties.Resources.load_game; 
        }
        public void spingame(PictureBox tr) {
            tr.Image = tarun_firegame.Properties.Resources.spin;
        }
        public void shootgame(PictureBox tr) {
            tr.Image = tarun_firegame.Properties.Resources.shoot_game;
        }
        public void shootawaygame(PictureBox tr) {
            tr.Image = tarun_firegame.Properties.Resources.shoot_away;
        }
    }    
}
