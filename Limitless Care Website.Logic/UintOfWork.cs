using Limitless_Care_Website.Logic.DataAcess;
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

        #region Cart
        CartRepository  cart;
        public CartRepository Cart => cart ?? (cart = new CartRepository(dbcontext));
        #endregion

    }
}
