using Kompas6API5;
using Kompas6Constants;
using KompasAPI7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{

    public class GetVariables
    {
        public static ksPart transfer;
        public static VariableCollection a;

        //string path = Environment.CurrentDirectory;
        readonly string path = @"D:\PROJECTS\Kompas C#\Variables";

        public void variables(string detailPath)
        {
            MainForm form1 = new MainForm();
            string progId = "KOMPAS.Application.5";
            KompasObject kompas = (KompasObject)Marshal.GetActiveObject(progId);
            _Application My7Komp = (_Application)kompas.ksGetApplication7();

            //Пропустить сообщения
            My7Komp.HideMessage = ksHideMessageEnum.ksHideMessageNo;

            //IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open(@"D:\PROJECTS\Kompas C#\Variables\Швеллер\Швеллер.m3d", true, true);
            IKompasDocument3D docOpen = (IKompasDocument3D)My7Komp.Documents.Open($@"{path}{detailPath}", true, false);

            IPart7 part7 = docOpen.TopPart;

            transfer = kompas.TransferInterface(part7, 1, 0);

            //Получаем коллекцию внешних переменных
            a = transfer.VariableCollection();

            //обновляем коллекцию внешних переменных
            a.refresh();
        }
    }
}
