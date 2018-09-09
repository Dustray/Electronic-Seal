using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Seal
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        Seal seal;
        public Form1()
        {
            InitializeComponent();

            Draws();


        }
        public void Draws()
        {
            bitmap = new Bitmap(Convert.ToInt32(inputBitmapSizeX.Text.ToString()), Convert.ToInt32(inputBitmapSizeY.Text.ToString()));
            seal = new Seal(bitmap);
            Graphics g = Graphics.FromImage(bitmap);
            seal.CreateFrame(Convert.ToInt32(inputMframeSizeX.Text.ToString()), Convert.ToInt32(inputMframeSizeY.Text.ToString()), Convert.ToInt32(frameSizeTrack.Value.ToString()));
            seal.CreateText(inputText.Text.ToString(), Convert.ToInt32(textSizeTrack.Value.ToString()));
            seal.DrawImpurity();

            showPictureBox.Image = bitmap;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Draws();

        }

        private void textSizeTrack_Scroll(object sender, EventArgs e)
        {
            textSizeText.Text = textSizeTrack.Value.ToString();


            Draws();

        }

        private void frameSizeTrack_Scroll(object sender, EventArgs e)
        {
            frameSizeText.Text = frameSizeTrack.Value.ToString();

            Draws();
        }
    }
}
