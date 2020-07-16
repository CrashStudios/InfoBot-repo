using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InfoBotWeb.Models;
using InfoBotLibrary;

namespace InfoBotWeb
{
    public class UserInputModel : PageModel
    {
        [BindProperty]
        public UserInfoModel NameProperty { get; set; }
       
        
        
        public IActionResult OnGet()
        {
            if (NameProperty == null)
            {
                NameProperty = new UserInfoModel();
                
                
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            UserLookup lookup = new UserLookup();
            UserInfo info = new UserInfo();
            if (ModelState.IsValid == true)
            {
                
                info = lookup.GetUserInfo(NameProperty.Name);
                NameProperty.District = info.District;
                NameProperty.Fact = info.Fact;
                NameProperty.ErrorMessage = info.ErrorMessage;
                return Page();//new RedirectToPageResult("/Input/UserInput");
                        
            }
           else
            {

                //NameProperty.ErrorMessage = info.ErrorMessage;
                return Page();
            }
            

           

           // if (ModelState.IsValid == true)
          //  {
                //return Model
          //  }
           // if ()
        }
    }
}