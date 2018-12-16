using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EngineerTest.Models
{
    public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member>
            {
                new Member
                {
                    Name="山田　太郎",
                    Email = "example@exaple"
                }
            };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}
