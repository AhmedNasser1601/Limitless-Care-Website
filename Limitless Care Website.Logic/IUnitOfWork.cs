using Limitless_Care_Website.Logic.DataAcess;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.Logic.Models;

namespace Limitless_Care_Website.Logic
{
    public interface IUnitOfWork
    {
        public void Commit();
        public CartRepository Cart { get; }
        public DigitalizationDetailsReposatory Digitalization { get; }
        public DigitalizationReposatory Digitalizations { get; }
        public RequestReposatoriy requests { get; }
        public UpdateRepository updatess { get; }
        public PeopleRepository peoples { get; }



    }
}
