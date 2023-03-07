using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;
using System.Drawing.Printing;

namespace RioSOft_PrintDoc
{
    public partial class DocRect : Form
    {
        public DocRect()
        {
            InitializeComponent();
        }
        /* 
        * ***************************************************
        *              Receipt Datagridvew                  *
        *                                                   *
        *           Written by: Ibrahim Sherwani            *
        *                   Date: 2021                      *
        *                   (RIO SOFT)                      *
        *                                                   *
        *  Print a DataGridView on the thermal printer      *
        *               using PrintDocument                 *
        *                                                   *
        * ***************************************************
        */
        private int[] MyCoulums_Width = { 48, 48, 31, 151};
        private StringAlignment[] Vertical_Ali = { StringAlignment.Center, StringAlignment.Center, StringAlignment.Center, StringAlignment.Center};
        private StringAlignment[] Horezontal_Ali = { StringAlignment.Center, StringAlignment.Center,StringAlignment.Center, StringAlignment.Far};
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("7500", "2500", "3","Produto 001");
            dataGridView1.Rows.Add( "3000", "1000", "3","Produto 002");
            dataGridView1.Rows.Add("5000", "500", "10","Produto 003");
            dataGridView1.Rows.Add( "500", "500", "1","Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add( "1500", "1500", "1","Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add( "6000", "2000", "3","Produto 006");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 001");
            dataGridView1.Rows.Add("3000", "1000", "3", "Produto 002");
            dataGridView1.Rows.Add("5000", "500", "10", "Produto 003");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 001");
            dataGridView1.Rows.Add("3000", "1000", "3", "Produto 002");
            dataGridView1.Rows.Add("5000", "500", "10", "Produto 003");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("6000", "2000", "3", "Produto 006");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 001");
            dataGridView1.Rows.Add("3000", "1000", "3", "Produto 002");
            dataGridView1.Rows.Add("5000", "500", "10", "Produto 003");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 001");
            dataGridView1.Rows.Add("3000", "1000", "3", "Produto 002");
            dataGridView1.Rows.Add("5000", "500", "10", "Produto 003");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("1500", "1500", "1", "Produto 005");
            dataGridView1.Rows.Add("6000", "2000", "3", "Produto 006");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 001");
            dataGridView1.Rows.Add("3000", "1000", "3", "Produto 002");
            dataGridView1.Rows.Add("5000", "500", "10", "Produto 003");
            dataGridView1.Rows.Add("500", "500", "1", "Produto 004");
            Printer();
            comboBox1.Text = Properties.Settings.Default.Printer;
        }

        void Printer()
        {
            comboBox1.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(printer);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        SizeF Size_MyColums;
        Rectangle MyBox_Rectangle;
        Rectangle MyTest_Rectangle;
        string Auther = "By:Ibrahim Sherwani (RIOSOFT)";
        int niopp = 0;
        int numm = 0;
        string cashier = "Caixa";
        string bill = "Conta";
        string datee = "Data";
        DateTime dat = new DateTime();
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;
            Font MyFont0 = new Font("Arial", 12, FontStyle.Bold);
            String MyLine = "____________________________________";
            int Horezontal_X = 0;
            int vertical_Y = 0;
            int My_newline = 0;
            My_newline += 0;
            My_newline = My_newline + 20;
            var g = e.Graphics;
            My_newline = My_newline + 60;
            SolidBrush My_Color = new SolidBrush(Color.Black);
            var MyStringFormat2 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            MyGraphics.DrawString(label1.Text.ToUpper(), new Font("Arial", 23, FontStyle.Bold), My_Color, 15, vertical_Y + 12);
            My_newline = My_newline + 60;
            MyGraphics.DrawString(cashier + textBox1.Text, MyFont0, My_Color, 205, vertical_Y + My_newline, MyStringFormat2);
            My_newline = My_newline + 25;
            MyGraphics.DrawString(bill + textBox2.Text, MyFont0, My_Color, 85, vertical_Y + My_newline);
            My_newline = My_newline + 25;
            g.DrawString(datee + DateTime.Now.ToShortDateString(), MyFont0, My_Color, 75, vertical_Y + My_newline);
            My_newline = My_newline + 10;
            MyGraphics.DrawString(MyLine, new Font("Arial", 10, FontStyle.Bold), My_Color, 0, vertical_Y + My_newline);
            My_newline = My_newline + 25;
            MyGraphics.DrawString("Descrição", new Font("Rudaw", 10, FontStyle.Bold), My_Color, 280, vertical_Y + My_newline,MyStringFormat2);
            MyGraphics.DrawString("Qtde‌", new Font("Rudaw", 8, FontStyle.Bold), My_Color, Horezontal_X + 90, vertical_Y + My_newline);
            MyGraphics.DrawString("Preço", new Font("Rudaw", 8, FontStyle.Bold), My_Color, Horezontal_X + 58, vertical_Y + My_newline);
            MyGraphics.DrawString("Total", new Font("Rudaw", 8, FontStyle.Bold), My_Color, Horezontal_X + 2, vertical_Y + My_newline);
            My_newline = My_newline + 20;


            //----------------------------------------------myDataGrid------------------------------------
            StringFormat MyStringFormat = new StringFormat();
            Font MyFont1 = new Font("Rudaw", 7);
            const int Side_margin = 4;
            int y = My_newline;
            for (int j = numm; j < dataGridView1.Rows.Count ; j++)
            {
                int MyMax_height = 0;
                niopp++;

                if (niopp <= 26)
                {
                    numm++;
                    if (numm <= dataGridView1.Rows.Count)
                    {

                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            Size_MyColums = e.Graphics.MeasureString(Convert.ToString(dataGridView1.Rows[j].Cells[i].Value), MyFont1, MyCoulums_Width[i] - 1 * Side_margin);
                            int MyNew_height = (int)Math.Ceiling(Size_MyColums.Height);
                            if (MyMax_height < MyNew_height)
                            {
                                MyMax_height = MyNew_height;
                            }
                        }
                        MyMax_height += 2 * Side_margin;

                        int x = Side_margin;
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            MyBox_Rectangle = new Rectangle(x, y, MyCoulums_Width[i], MyMax_height);
                            MyTest_Rectangle = MyBox_Rectangle;
                            MyTest_Rectangle.Inflate(-Side_margin, -Side_margin);
                            MyStringFormat.Alignment = Horezontal_Ali[i];
                            MyStringFormat.LineAlignment = Vertical_Ali[i];
                            e.Graphics.DrawString(Convert.ToString(dataGridView1.Rows[j].Cells[i].Value), MyFont1, My_Color, MyTest_Rectangle, MyStringFormat);
                            e.Graphics.DrawRectangle(Pens.Black, MyBox_Rectangle);
                            x += MyCoulums_Width[i];
                        }
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    niopp = 0;
                    e.HasMorePages = true;
                    return;
                }
                y += MyMax_height;
            }
            //----------------------------------------------myDataGrid------------------------------------
            My_newline = y + 10;
            textBox5.Text = String.Format("{0:n0}", double.Parse(textBox5.Text));
            textBox6.Text = String.Format("{0:n0}", double.Parse(textBox6.Text));
            MyGraphics.DrawString(textBox5.Text, MyFont0, My_Color, 0, vertical_Y + My_newline);
            MyGraphics.DrawString("كۆی گشتی:", MyFont0, My_Color, 280, vertical_Y + My_newline, MyStringFormat2);
            My_newline = My_newline + 18;
            MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, vertical_Y + My_newline);
            My_newline = My_newline + 20;
            MyGraphics.DrawString(textBox6.Text, MyFont0, My_Color, 2, vertical_Y + My_newline);
            MyGraphics.DrawString("داشكاندن:", MyFont0, My_Color, 280, vertical_Y + My_newline, MyStringFormat2);
            My_newline = My_newline + 18;
            MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, vertical_Y + My_newline);
            My_newline = My_newline + 30;
            MyGraphics.DrawString("*" + textBox2.Text + "*", new Font("C39P24DlTt", 25), My_Color, 35, vertical_Y + My_newline);
            My_newline = My_newline + 35;
            MyGraphics.DrawString(textBox2.Text, new Font("Arial", 8), My_Color, 115, vertical_Y + My_newline);
            My_newline = My_newline + 40;
            MyGraphics.DrawString(textBox4.Text, MyFont0, My_Color, 40, vertical_Y + My_newline);
            My_newline = My_newline + 20;
            MyGraphics.DrawString(Auther, MyFont0, My_Color, 10, vertical_Y + My_newline);

            niopp = 0;
            numm = 0;
        }

        private void DocRect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Printer = comboBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = Properties.Settings.Default.Printer;
            printDocument1.PrinterSettings.Copies = (short)numericUpDown1.Value ;
            PrintController pc = new StandardPrintController();
            printDocument1.PrintController = pc;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }
    }
}
