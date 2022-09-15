using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Limitless.Services.Services.CartServices
{
    public interface ICartServices
    {
        public ResultViewModel GetMainCart(); // Get All Carts For Home Page 
        public ResultViewModel GetDetailsOfCartSec1(int CartId); // Get Details For First Section in Cart View 
        public ResultViewModel GetDetailsOfCartSec2(int CartId); // Get Details For The Sections In a Specific Cart 
        public ResultViewModel GetBenefitsOfCart(int CartId); // Get Beneifts Of The Cart 
        public ResultViewModel GetSectionsName(int CartId); // Get The Sections Name for Specific Cart 
       
        // Get All Data Like Above but in Arabic 
        public ResultViewModel GetMainCart_Ar();
        public ResultViewModel GetDetailsOfCartSec1_Ar(int CartId);
        public ResultViewModel GetDetailsOfCartSec2_Ar(int CartId);
        public ResultViewModel GetBenefitsOfCart_Ar(int CartId);
        public ResultViewModel GetSectionsName_Ar(int CartId);
        // Requeest
        public ResultViewModel AddRequest(RequestViewModel model); // Add A request 
        public ResultViewModel GetRequests(); // get All Requests 

        // Addmin Tool 
        public ResultViewModel AddCart(CartViewModel model); // Add Anew Card
        public ResultViewModel EditMain(CartViewModel model);
        //public ResultViewModel EditSections(CartViewModel model,int id);
        public ResultViewModel DeleteCart(int id);

    }
}
