using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInversion
{
    /// <summary>
    /// BLL is directly dependent on the low level Data Access Layer 
    /// and it’s hard to perform any unit tests on this code as both are coupled.
    /// </summary>
    //public class BusinessLogicLayer
    //{
    //    private readonly DataAccessLayer DAL;

    //    public BusinessLogicLayer()
    //    {
    //        DAL = new DataAccessLayer();
    //    }

    //    public void Save(Object details)
    //    {
    //        DAL.Save(details);
    //    }
    //}

    //public class DataAccessLayer
    //{
    //    public void Save(Object details)
    //    {
    //        //perform save
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer DAL;

        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
}
