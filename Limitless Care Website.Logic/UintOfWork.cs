using Limitless_Care_Website.Logic;
using Limitless_Care_Website.Logic.DataAcess;
//using Limitless_Care_Website.Logic.DataAcess;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Data;

namespace Unit.Logic
{
    public class UintOfWork : IUnitOfWork
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
        #region DigitalizationDetailsReposatory
        Section5_DetailsReposatory digitalization;
        public Section5_DetailsReposatory Digitalization => digitalization ?? (digitalization = new Section5_DetailsReposatory(dbcontext));
        #endregion
        #region DigitalizationReposatory
        Section5_Reposatory digitalizations;
        public Section5_Reposatory Digitalizations => digitalizations ?? (digitalizations = new Section5_Reposatory(dbcontext));
        #endregion
        #region RequestReposatoriy
        RequestReposatoriy request;
        public RequestReposatoriy requests => request ?? (request = new RequestReposatoriy(dbcontext));
        #endregion
        #region UpdatesRepository
        UpdateRepository updates;
        public UpdateRepository updatess => updates ?? (updates = new UpdateRepository(dbcontext));
        #endregion
        #region PeopleRepository
        PeopleRepository people;
        public PeopleRepository peoples => people ?? (people = new PeopleRepository(dbcontext));

        //CartRepository IUnitOfWork.cart => throw new NotImplementedException();
        #endregion



    }
}
