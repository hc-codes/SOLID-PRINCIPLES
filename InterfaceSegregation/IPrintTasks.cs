using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    //public interface IPrintTasks
    //{
    //    bool PrintContent(string content);
    //    bool ScanContent(string content);
    //    bool FaxContent(string content);
    //    bool PhotoCopyContent(string content);
    //    bool PrintDuplexContent(string content);
    //}
    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
