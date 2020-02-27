using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstTask.Models
{
    
    public static class Functions
    {
        public static int Result(FormCollection answers)
        {
            int score = 0;
            if (answers["Radio"] == "One")
                score++;
            if (answers["Text"].ToUpper() == "BALL")
                score++;
            if (Convert.ToBoolean(answers["Check1"].Split(',')[0]) == true &&
                Convert.ToBoolean(answers["Check2"].Split(',')[0]) == true &&
                Convert.ToBoolean(answers["Check3"].Split(',')[0]) == false)
                score++;
            return score;
        }
    }
}