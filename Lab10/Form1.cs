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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gvPrinter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPrinter.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "printerName";
            column.Name = "Назва принтеру";
            gvPrinter.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DPI";
            column.Name = "Максимальний dpi";
            gvPrinter.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PaperSize";
            column.Name = "Підтримуемий формат бумаги";
            gvPrinter.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "paperSize";
            column.Name = "Швидкысть друку принтера";
            gvPrinter.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TexWrite";
            column.Name = "Формат печат";
            gvPrinter.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "printerLife";
            column.Name = "Строк предатності";
            gvPrinter.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WiFi";
            column.Name = "Підтримка WiFi";
            column.Width = 60;
            gvPrinter.Columns.Add(column);

            bindSrcPrinter.Add(new Printer("", 0.0, "", 0.0, false, Printer.TextWriteState.Inkjet, 0.0));

            EventArgs args = new EventArgs();
            OnResize(args);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer("", 0.0, "", 0.0, false, Printer.TextWriteState.Inkjet, 0.0);
            PrinterForm pf = new PrinterForm(printer);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                bindSrcPrinter.Add(printer);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Printer printer = (Printer)bindSrcPrinter.List[bindSrcPrinter.Position];
            PrinterForm pf = new PrinterForm(printer);
            if (pf.ShowDialog() == DialogResult.OK)
            {
                bindSrcPrinter.List[bindSrcPrinter.Position] = printer;
            }
        }

                private void btnDel_Click(object sender, EventArgs e)
                {
                    if (MessageBox.Show("Видалити поточний запис?",
        "Видалення запису", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        bindSrcPrinter.RemoveCurrent();
                    }
                }

        private void btnClear_Click(object sender, EventArgs e)
        {
                        if (MessageBox.Show(
             "Очистити таблицю?\n\nВсі дані будуть втрачені",
             "Очищення даних", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            bindSrcPrinter.Clear();
                        }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                        if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
             MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Application.Exit();
                        }
        }
    }
}
