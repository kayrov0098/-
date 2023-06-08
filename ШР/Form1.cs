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
       

        
        private void button1_Click(object sender, EventArgs e)
        {
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

            swApp.OpenDoc6(address+"шр.SLDASM", 2, 0, null, err, war);
            swModel = swApp.IActiveDoc2;
            swAssy = (AssemblyDoc)swModel;

            // Редактирование левой панели

            swModel.Extension.SelectByID2("Панель внутр.-3@шр", "COMPONENT", 0, 0, 0, false, 0, null, 0);
            swAssy.EditPart2(true,true,3);




           // swApp.NewPart();


            //swModel = swApp.IActivateDoc2;



            // Редакция панели


            // Редакция крыши

            // редакция порога

            //

            // Открытие сборки



        }
    }
}