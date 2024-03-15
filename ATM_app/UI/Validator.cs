using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app.UI
{
    internal class Validator
    {
        public static T Convert<T>( String prompet)
        {
            bool valid  = false;
            String userInput;

            while (!valid)
            {
                userInput = Utilites.GetUserInput(prompet);
               var converter = TypeDescriptor.GetConverter(typeof(T));

                try{
                    if(converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    
                    
                }
                catch
                {
                    Utilites.PrintMsg("Invalid input ! Try again.", false);
           
                }

          
            }
            return default;

        }
    }
}
