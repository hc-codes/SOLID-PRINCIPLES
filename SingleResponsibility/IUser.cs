using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// Here we have assigned only single responsiblity to each interfaces.
    /// </summary>
    public interface IUser
    {
        bool Register(string name, string email, string password);
        bool Login(string email, string password);
        //bool SendMail(string content);
        //void Error(string errror);
    }
    public interface ILogError
    {
        void Error(string errror);
    }
    public interface ISendMail
    {
        bool SendMail(string content);
    }
}
