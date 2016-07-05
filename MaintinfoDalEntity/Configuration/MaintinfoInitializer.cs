using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MaintinfoDalEntity.Configuration
{
    public class MaintinfoInitializer:DropCreateDatabaseAlways<MaintinfoContext>
    {
        protected override void Seed(MaintinfoContext context)
        {
            base.Seed(context);
        }
    }
}
