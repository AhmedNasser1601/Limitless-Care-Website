using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;

namespace Unit.Logic
{
    public class UintOfWork
    {
        private readonly ApplicationContext dbcontext;
        public UintOfWork(ApplicationContext context)
        {
            dbcontext = context;
        }
        public void Commit()
        {
            dbcontext.SaveChanges();
        }

        //#region User
        ////UserRepository User;
        ////public UserRepository user => User ?? (User = new UserRepository(dbcontext));
        ////#endregion

    }
}
