using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>  //  Create generic Employee class
    {
        //  Creatie property called Things with generic List matching the class
        public List<T> Things { get; set; }
    }
}
