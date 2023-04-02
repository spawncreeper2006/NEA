using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music_nea.Forms
{


    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
        }

        private void Playlist_Load(object sender, EventArgs e)
        {
            displayPanel x1 = new displayPanel();
            x1.showPanel();
            
        }

        public static class Globals
        {
            public static int counter = 0;
            public static int displayPanelHeight = 300;
            public static int[] color = new int[] { 20, 20, 20 };
        }


        public class displayPanel
        {

            int count;

            public void showPanel()
            {
                var panel = new Panel();
                panel.Height = Globals.displayPanelHeight;
                panel.BackColor = Color.FromArgb(Globals.color[0], Globals.color[1], Globals.color[2]);
                //panel.Dock = DockStyle.Top;
                panel.Show();
                Console.WriteLine(panel.Width);
                Console.WriteLine(panel.Height);
                
                
            }
            public displayPanel()
            {

                count = Globals.counter;
                Globals.counter += 1;



            }




        }
    }
}
