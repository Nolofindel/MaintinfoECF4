using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MaintinfoDalEntity.Configuration;


namespace CreationBDD
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
