using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkingWithFroalaEditor.DAL;
using WorkingWithFroalaEditor.Model;

namespace WorkingWithFroalaEditor.BLL
{
    public class Manager
    {
        Gateway gateway = new Gateway();

        public string Save(Article aArticle)
        {
            if(gateway.Save(aArticle)>0)
            {
                return "Save Succesfully!";

            }
            else
            {
                return "Save Failed!";
            }

        }
    }
}