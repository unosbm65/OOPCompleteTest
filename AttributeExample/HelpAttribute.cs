using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{

    //[AttributeUsage(AttributeTargets.Class) ]
    public class HelpAttribute : Attribute
    {

        public HelpAttribute(String Descrition_in)
        {
            this.description = Descrition_in;
        }
        protected String description;
        public String Description
        {
            get
            {
                return this.description;

            }
        }    


    }
}
