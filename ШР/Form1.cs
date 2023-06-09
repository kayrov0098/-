using Microsoft.VisualBasic.ApplicationServices;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace ШР
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SldWorks swApp;
        IModelDoc2 swModel;
        AssemblyDoc swAssy;
        string address = "C:\\Users\\kayrov\\Documents\\ШР\\";
        int err;
        int war;
        int d = 1000;
        double widthPanelIx;
        double heightPanelEx;



        private void button1_Click(object sender, EventArgs e)
        {
            var widthCabinet = (double)width.Value;





            if (widthCabinet > 1500)
            {
                widthPanelIx = 750;
            }
            else
            {
                widthPanelIx = widthCabinet / 2;
            }
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }

            //Запуск SW
            Guid myGuid1 = new Guid("d134b411-3689-497d-b2d7-a27cb1066648");
            object processSW = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(myGuid1));

            swApp = (SldWorks)processSW;
            swApp.Visible = true;



            // Открытие сборки

            swApp.OpenDoc6(address + "шр.SLDASM", 2, 0, null, err, war);
            swModel = swApp.IActiveDoc2;
            swAssy = (AssemblyDoc)swModel;

            // Редактирование левой панели

            swModel.Extension.SelectByID2("Ребро-кромка13@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swModel.IParameter("D1@Эскиз17@Панель внутр..Part").SetValue3(widthPanelIx, 2, null);
            swAssy.EditAssembly();
            


            // Редактирование правой панели  46
            if (widthCabinet > 1500)
            {
                swModel.IParameter("D1@Эскиз17@Панель внутр..Part").SetValue3(widthPanelIx, 2, null);
                swModel.IParameter("D1@Эскиз38@Панель внутр..Part").SetValue3(23, 3, "Правая");

                swModel.IParameter("D1@Эскиз41@Панель внутр..Part").SetValue3(11, 3, "Правая");

                swModel.Extension.SelectByID2("Ребро-кромка13@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.EditUnsuppress2();
                swModel.Extension.SelectByID2("Ребро-Кромка12@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.EditSuppress2();

            }
            else
            {

            }


            // Редакция крыши

            // редакция порога

            //

            // Открытие сборки

            swModel.EditRebuild3();

        }
    }
}