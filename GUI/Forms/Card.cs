using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;

namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    public partial class Card : MaterialSkin.Controls.MaterialForm
    {

        Bitmap bitmap;

        public Card()
        {
            InitializeComponent();
        }



        private void Card_Load(object sender, EventArgs e)
        {
            label1.Text = NewID.SetValueForText1;
            label2.Text = NewID.SetValueForText2;
            label3.Text = NewID.SetValueForText3;
            label4.Text = NewID.SetValueForText4;
            label5.Text = NewID.SetValueForText5;
            label3.Text = NewID.SetValueForText6; // for id
            label6.Text = NewID.SetValueForText7;
            pictureBox2.Image = NewID.photo;
            pictureBox3.Image = NewID.QRCode;

        }




        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 1, 0, s);
        }

        //private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    //Print image
        //    Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        //    pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        //    e.Graphics.DrawImage(bm, 0, 0);
        //    bm.Dispose();
        //}

       

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
                    }

        private void printPreviewControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
