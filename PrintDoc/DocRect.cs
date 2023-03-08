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
        private int[] MyCoulums_Width = { 48, 48, 31, 151 };
        private StringAlignment[] Vertical_Ali = { StringAlignment.Center, StringAlignment.Center, StringAlignment.Center, StringAlignment.Center };
        private StringAlignment[] Horezontal_Ali = { StringAlignment.Center, StringAlignment.Center, StringAlignment.Center, StringAlignment.Far };
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 001");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 002");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 003");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 004");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 005");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 006");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 007");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 008");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 009");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 010");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 011");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 012");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 013");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 014");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 015");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 016");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 017");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 018");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 019");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 020");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 021");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 022");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 023");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 024");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 025");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 026");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 027");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 028");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 029");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 030");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 031");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 032");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 033");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 034");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 035");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 036");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 037");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 038");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 039");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 040");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 041");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 042");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 043");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 044");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 045");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 046");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 047");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 048");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 049");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 050");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 051");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 052");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 053");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 054");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 055");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 056");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 057");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 058");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 059");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 060");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 061");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 062");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 063");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 064");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 065");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 066");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 067");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 068");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 069");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 070");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 071");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 072");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 073");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 074");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 075");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 076");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 077");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 078");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 079");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 080");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 081");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 082");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 083");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 084");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 085");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 086");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 087");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 088");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 089");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 090");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 091");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 092");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 093");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 094");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 095");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 096");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 097");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 098");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 099");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 100");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 101");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 102");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 103");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 104");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 105");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 106");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 107");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 108");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 109");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 110");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 111");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 112");
            dataGridView1.Rows.Add("7500", "2500", "3", "Produto 113");

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
        string Auther = "By: Trolles Maiado";
        int niopp = 0;
        int numm = 0;
        string cashier = "Caixa: ";
        string bill = "Conta: ";
        string datee = "Data: ";
        DateTime dat = new DateTime();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;
            Font MyFont0 = new Font("Arial", 12, FontStyle.Bold);
            int My_newline = 0;
            var g = e.Graphics;
            SolidBrush My_Color = new SolidBrush(Color.Black);

            //----------------------------------------------myDataGrid------------------------------------
            StringFormat MyStringFormat = new StringFormat();
            Font MyFont1 = new Font("Rudaw", 7);
            const int Side_margin = 4;
            int y = My_newline;
            for (int j = numm; j < dataGridView1.Rows.Count; j++)
            {
                int MyMax_height = 0;
                niopp++;

                if (niopp <= 55)
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
            printDocument1.PrinterSettings.Copies = (short)numericUpDown1.Value;
            PrintController pc = new StandardPrintController();
            printDocument1.PrintController = pc;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }
    }
}
