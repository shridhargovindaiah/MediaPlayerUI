using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customiseDesign();
        }

        private void customiseDesign()
        {
            panelMediaSideMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSideMenu.Visible == true)
                panelMediaSideMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSideMenu);
        }
        #region Media Sub Menu

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }
#endregion
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
        #region Playlist Sub Menu
        private void button9_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }
#endregion
        private void btnEquilizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //
            //Your code
            //
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region Tools Sub Menu
        private void button15_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childFrom);
            panelChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
    }
}
