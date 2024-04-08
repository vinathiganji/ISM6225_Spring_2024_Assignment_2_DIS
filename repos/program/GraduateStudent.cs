using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class GraduateStudent : Student , BestPractices
    {
        public string Study()
        {
            return "Complete all assignments ontime";
        }
        public string Rest() {
            return "Get plenty of rest";
                }
    }
}
