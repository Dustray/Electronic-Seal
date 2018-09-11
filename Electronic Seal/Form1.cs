using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Seal
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        Seal seal;
        bool isSlide = true;
        public Form1()
        {
            InitializeComponent();
            frameWidthTrackBar.Maximum = Convert.ToInt32(inputBitmapSizeX.Text.ToString());
            frameHeightTrackBar.Maximum = Convert.ToInt32(inputBitmapSizeY.Text.ToString());
            Draws();
            //Color c = Color.Green;
            //float light = c.GetBrightness();
            //MessageBox.Show("" + light);


        }
        public void Draws()
        {
            bitmap = new Bitmap(Convert.ToInt32(inputBitmapSizeX.Text.ToString()), Convert.ToInt32(inputBitmapSizeY.Text.ToString()));
            seal = new Seal(bitmap);
            Graphics g = Graphics.FromImage(bitmap);
            seal.CreateFrame(Convert.ToInt32(inputMframeSizeX.Text.ToString()), Convert.ToInt32(inputMframeSizeY.Text.ToString()), Convert.ToInt32(frameSizeTrack.Value.ToString()));
            seal.CreateText(inputText.Text.ToString(), Convert.ToInt32(textSizeTrack.Value.ToString()));
            seal.DrawImpurity(isSlide);

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

        private void textSizeTrack_MouseDown(object sender, MouseEventArgs e)
        {
            isSlide = false;
        }

        private void textSizeTrack_MouseUp(object sender, MouseEventArgs e)
        {
            isSlide = true;
            Draws();
        }

        private void frameSizeTrack_Scroll(object sender, EventArgs e)
        {
            frameSizeText.Text = frameSizeTrack.Value.ToString();

            Draws();
        }

        private void frameSizeTrack_MouseDown(object sender, MouseEventArgs e)
        {
            isSlide = false;
        }

        private void frameSizeTrack_MouseUp(object sender, MouseEventArgs e)
        {
            isSlide = true;
            Draws();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveImageDialog.Filter = "图片(*.jpg)|*.jpg|图片(*.png)|*.png|所有文件|*.*";//设置文件类型
            saveImageDialog.FileName = "水印";
            saveImageDialog.DefaultExt = "jpg";//默认格式
            saveImageDialog.AddExtension = true;//设置自动在文件名中添加扩展名

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveImageDialog.FilterIndex)
                {
                    case 1: bitmap.Save(saveImageDialog.FileName, ImageFormat.Jpeg); break;
                    case 2:
                        seal.changePixcl();
                        //bitmap.MakeTransparent(Color.White);
                        bitmap.Save(saveImageDialog.FileName, ImageFormat.Png);
                        break;
                }
            }
        }
        //frameWidthTrackBar EVENTs
        private void frameWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            inputMframeSizeX.Text = frameWidthTrackBar.Value.ToString();
            Draws();
        }

        private void frameWidthTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            isSlide = false;
        }

        private void frameWidthTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            isSlide = true;
            Draws();
        }
        //frameHeightTrackBar EVENTs
        private void frameHeightTrackBar_Scroll(object sender, EventArgs e)
        {
            inputMframeSizeY.Text = frameHeightTrackBar.Value.ToString();
            Draws();
        }



        private void frameHeightTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            isSlide = false;
        }

        private void frameHeightTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            isSlide = true;
            Draws();
        }


        public bool isIntNumber(string str)
        {
            return Regex.IsMatch(str, @"^[+-]?\d*$");
        }
        private void inputBitmapSizeX_TextChanged(object sender, EventArgs e)
        {
            string temp = inputBitmapSizeX.Text.ToString();
            //改变frame最大宽度
            if (isIntNumber(temp))
            {
                frameWidthTrackBar.Maximum = Convert.ToInt32(temp);
            }
        }
        private void inputBitmapSizeY_TextChanged(object sender, EventArgs e)
        {
            string temp = inputBitmapSizeY.Text.ToString();
            //改变frame最大高度       
            if (isIntNumber(temp))
            {
                frameHeightTrackBar.Maximum = Convert.ToInt32(temp);

            }
        }

        private void inputMframeSizeX_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputMframeSizeY_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
