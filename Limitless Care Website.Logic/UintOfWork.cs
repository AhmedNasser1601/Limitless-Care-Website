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
        #region DigitalizationDetailsReposatory
        DigitalizationDetailsReposatory digitalization;
        public DigitalizationDetailsReposatory Digitalization => digitalization ?? (digitalization = new DigitalizationDetailsReposatory(dbcontext));
        #endregion
        #region DigitalizationReposatory
        DigitalizationReposatory digitalizations;
        public DigitalizationReposatory Digitalizations => digitalizations ?? (digitalizations = new DigitalizationReposatory(dbcontext));
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
        #endregion



    }
}
