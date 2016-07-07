using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintinfoDAL.Configuration;
using System.Data.Entity;


namespace CreationBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MaintinfoInitializer());
            using (var context = new MaintinfoContext())
            {
                context.Database.Initialize(false);
            }

        }
    }
}
