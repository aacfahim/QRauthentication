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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ID_CARD_GENERATOR_AND_AUTHENTICATION_SYSTEM
{
    public partial class Card : MaterialSkin.Controls.MaterialForm
    {
        public Card()
        {
            InitializeComponent();
        }


        private void ExportToPDF()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { FileName = label3.Text + ".pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Rectangle idCard = new iTextSharp.text.Rectangle(255.118f, 141.732f);
                    Document doc = new Document();
                    doc.SetMargins(13.3f, 0, 8f, 0);
                    doc.SetPageSize(idCard);

                    iTextSharp.text.Font font_01 = FontFactory.GetFont("C\\Windows\\Fonts\\SEGOE UI__.ttf", 14, BaseColor.BLACK);
                    iTextSharp.text.Font font_02 = FontFactory.GetFont("C\\Windows\\Fonts\\SEGOE UI__.ttf", 8, BaseColor.BLACK);

                    Chunk c01 = new Chunk(label1.Text, font_01);
                    Chunk c02 = new Chunk(label2.Text, font_02);
                    Chunk c03 = new Chunk(label3.Text, font_01);
                    Chunk c04 = new Chunk(label4.Text, font_02);

                    Chunk c05 = new Chunk(label5.Text, font_01);
                    Chunk c06 = new Chunk(label6.Text, font_02);


                    Paragraph p01 = new Paragraph();
                    p01.Add(c01);
                    p01.IndentationLeft = 120;

                    Paragraph p02 = new Paragraph();
                    p02.Add(c02);
                    p02.IndentationRight = 120;

                   
                    iTextSharp.text.Image bg = iTextSharp.text.Image.GetInstance("Background.png");
                    bg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    bg.ScaleAbsolute(255.118f, 141.732f);
                    bg.SetAbsolutePosition(0, 0);

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                        doc.Open();
                        doc.Add(bg);
                        doc.Add(p01);
                        //doc.Add(p02);
                        //doc.Add(p03);
                        //doc.Add(p04);
                        //doc.Add(p05);
                        //doc.Add(p06);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        doc.Close();
                    }



                }
            }

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

           

            // Create a new image
            //Image img = new Bitmap(300, 100);
            //Graphics g = Graphics.FromImage(img);

            //// Place a.gif
            //g.DrawImage(pictureBox1.Image, new Point(10, 10));

            //// Place b.jpg
            //g.DrawImage(pictureBox2.Image, new Point(70, 10));

            //// Place c.jpg
            //g.DrawImage(pictureBox3.Image, new Point(130, 10));


            //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //        pictureBox1.Image = Image.FromFile(ofd.FileName);
            //}

            //Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            //pictureBox2.DrawToBitmap(bmp, new Rectangle(pictureBox2.Location.X - pictureBox1.Location.X, pictureBox2.Location.Y - pictureBox1.Location.Y, pictureBox2.Width, pictureBox2.Height));
            //pictureBox3.DrawToBitmap(bmp, new Rectangle(pictureBox3.Location.X - pictureBox1.Location.X, pictureBox3.Location.Y - pictureBox1.Location.Y, pictureBox3.Width, pictureBox3.Height));


            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print image
            //Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            //e.Graphics.DrawImage(bm, 0, 0);
            //bm.Dispose();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            // Create a new image
            //Image img = new Bitmap(300, 100);
            //Graphics g = Graphics.FromImage(img);

            //// Place a.gif
            //g.DrawImage(pictureBox1.Image, new Point(10, 10));

            //// Place b.jpg
            //g.DrawImage(pictureBox2.Image, new Point(70, 10));

            //// Place c.jpg
            //g.DrawImage(pictureBox3.Image, new Point(130, 10));

            //// Save changes as output.jpg
            //img.Save("output.jpg", ImageFormat.Jpeg);



            //ExportToPDF();


        }
    }
}
