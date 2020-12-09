using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class PrinterForm : Form
    {
        public Printer ThePrinter;
        public PrinterForm(Printer p)
        {
            
             ThePrinter = p;
            InitializeComponent();
            
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AcceptButton = btnOk;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePrinter.printerName = tbName.Text.Trim();
            string temp = tbDPI.Text.Trim();
            ThePrinter.pDPI = double.Parse(temp);
            ThePrinter.pPaperSize = tbPaperSize.Text.Trim();
            ThePrinter.pSpeedWrite = double.Parse(tbSpeedWrite.Text.Trim());
            ThePrinter.printerLife = double.Parse(tbPrinterLife.Text.Trim());
            ThePrinter.pWiFi = chbHasWiFi.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            CancelButton = btnCancel;
            DialogResult = DialogResult.Cancel;
        }



        private void fPrinter_Load(object sender, EventArgs e)
        {
            if (ThePrinter != null)
            {
                tbName.Text = ThePrinter.printerName;
                tbDPI.Text = ThePrinter.pDPI.ToString();
                tbPaperSize.Text = ThePrinter.pPaperSize;
                tbSpeedWrite.Text = ThePrinter.pSpeedWrite.ToString();
                tbPrinterLife.Text = ThePrinter.printerLife.ToString("0.00");
                chbHasWiFi.Checked = ThePrinter.pWiFi;
            }
        }

        private void PrinterForm_Load(object sender, EventArgs e)
        {

        }
    }




}
