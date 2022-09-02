using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
   public class PredicatDelegate
    {
        public  bool IsApple(string modelName)
        {
            if (modelName == "I Phone X")
                return true;
            else
                return false;
        }
    }
}
