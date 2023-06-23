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
        string address = "C:\\SolidAPI\\ШР\\";
        int err;
        int war;
        int d = 1000;
        double widthPanelIx;
        double heightPanelEx;
        



        private void button1_Click(object sender, EventArgs e)
        {
            var widthCabinet = (double)width.Value;
            var heightCabinet = (double)heigth.Value;




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
            
            // Редактирование ширины

            swModel.Extension.SelectByID2("Ребро-кромка4@Панель внутр.-3@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swModel.IParameter("D7@Ребро-кромка4@Панель внутр.-3.Part").SetValue3(widthPanelIx, 3, "Левая");
            
            // Редактирование высоты
           
            swModel.Extension.SelectByID2("D2@Эскиз1@Панель внутр.-3@шр", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swModel.IParameter("D2@Эскиз1@Панель внутр..Part").SetValue3(heightCabinet, 3, "Левая");
            
            // Выход в сборку

            swAssy.EditAssembly();



            // Редактирование правой панели  

            // Редакция ширины

            swModel.Extension.SelectByID2("Ребро-кромка10@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swModel.IParameter("D7@Ребро-кромка10@Панель внутр.-4.Part").SetValue3(widthPanelIx, 3, "Правая");

            // Редакция гибов замка

            if (widthCabinet < 1500)
            {
                swModel.Extension.SelectByID2("Ребро-кромка11@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.IParameter("D7@Ребро-кромка11@Панель внутр.-4.Part").SetValue3(23, 3, "Правая");
                swModel.Extension.SelectByID2("Ребро-кромка13@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.EditSuppress2();
                swModel.Extension.SelectByID2("Ребро-Кромка12@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.EditUnsuppress2();
                swAssy.EditAssembly();
            }
            else
            {
                swModel.Extension.SelectByID2("Ребро-кромка11@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.IParameter("D7@Ребро-кромка11@Панель внутр.-4.Part").SetValue3(25, 3, "Правая");
                swModel.Extension.SelectByID2("Ребро-кромка12@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.EditSuppress2();
                swModel.Extension.SelectByID2("Ребро-Кромка13@Панель внутр.-4@шр", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
                swModel.EditUnsuppress2();
                swAssy.EditAssembly();
            }

            // Редакция высоты

            swModel.Extension.SelectByID2("D2@Эскиз1@Панель внутр.-4@шр", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swModel.IParameter("D2@Эскиз1@Панель внутр.-4.Part").SetValue3(heightCabinet, 3, "Правая");

            // Редакция крыши

            // редакция порога

            //

            // Редакция сборки сборки
            if (widthCabinet>1500)
            {
                swModel.Extension.SelectByID2("Совпадение49", "MATE", 0, 0, 0, false, 0, null, 0);
                swModel.EditSuppress2();
                swModel.Extension.SelectByID2("Вставка-1@шр", "COMPONENT", 0, 0, 0, false, 0, null, 0);
                swModel.EditUnsuppress2();
            }
            



            swModel.EditRebuild3();
            
        }
        
    }
}