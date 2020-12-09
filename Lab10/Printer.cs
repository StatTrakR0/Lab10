using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Printer
    {
        public enum TextWriteState { Laser, LED, Inkjet } 
        public string printerName { get; set; }
        public double pDPI { get; set; }
        public string pPaperSize { get; set; }
        public double pSpeedWrite { get; set; }
        public bool pWiFi { get; set; }
        public TextWriteState pTexWrite { get; set; }
        public double printerLife { get; set; }
        public double brokenPrinter() => (printerLife / pSpeedWrite) * 10;

        public void outPrinter()
        {

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва принтеру:" + printerName);
            Console.WriteLine("Максимальний dpi:" + pDPI);
            Console.WriteLine("Підтримуемий формат бумаги:" + pPaperSize);
            Console.WriteLine("Швидкысть друку принтера:" + pPaperSize + "листів в секунду");
            Console.WriteLine("Підтримка WiFi:" + pWiFi);
            Console.WriteLine("Формат печаті:" + pTexWrite);
            Console.WriteLine("Формат печаті:" + printerLife);
            Console.WriteLine("Ваш принтер працюватиме:" + (printerLife / pSpeedWrite) * 10 + "р");

            new Printer(printerName, pDPI, pPaperSize, pSpeedWrite, pWiFi, pTexWrite, printerLife);
        }

        public Printer(string printerName, double pDpi, string pPaperSize, double pSpeedWrite,
            bool pWiFi, TextWriteState pTexWrite, double printerLife)
        {
            this.printerName = printerName;
            this.pDPI = pDpi;
            this.pPaperSize = pPaperSize;
            this.pSpeedWrite = pSpeedWrite;
            this.pWiFi = pWiFi;
            this.pTexWrite = pTexWrite;
            this.printerLife = printerLife;
        }

    }

    public static class PrinterPropertis
    {
        public static Printer PrinterInit()
        {
            Console.Write("Введіть назву принтеру:");
            string printerName = Console.ReadLine();
            Console.Write("Введіть максимальний dpi:");
            double pDPI = double.Parse(Console.ReadLine());
            Console.Write("Введіть підтримуемий формат бумаги:");
            string pPaperSize = Console.ReadLine();
            Console.Write("Введіть швидкість друку:");
            double pSpeedWrite = double.Parse(Console.ReadLine());
            Console.Write("Чи підтримуе друк по WiFi:");
            Console.WriteLine("(Y - Так /else - Ні)");
            ConsoleKeyInfo keyWiFi = Console.ReadKey();
            bool pWiFi = keyWiFi.Key == ConsoleKey.Y;
            Console.WriteLine("Оберіть технологію печаті:");
            Console.WriteLine("1. Лазерна:");
            Console.WriteLine("2. Світодіона:");
            Console.WriteLine("3. Струйна:");
            Printer.TextWriteState pTexWrite = Printer.TextWriteState.Inkjet;
            if (int.TryParse(Console.ReadLine(), out int switch_menu))
            {
                switch (switch_menu)
                {
                    case 1:
                        pTexWrite = Printer.TextWriteState.Laser;
                        break;
                    case 2:
                        pTexWrite = Printer.TextWriteState.LED;
                        break;
                    case 3:
                        pTexWrite = Printer.TextWriteState.Inkjet;
                        break;
                }
            }
            Console.Write("Введіть строк предатності принтеру:");
            double printerLife = double.Parse(Console.ReadLine());
            return new Printer(printerName, pDPI, pPaperSize, pSpeedWrite, pWiFi, pTexWrite, printerLife);
        }
    }
}
