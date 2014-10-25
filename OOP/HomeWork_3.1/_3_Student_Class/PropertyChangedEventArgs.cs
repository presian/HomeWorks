using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Student_Class
{
    public class PropertyChangedEventArgs:EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string OldName { get; set; }
        public int OldAge { get; set; }
        public string ChangeProperty { get; set; }

    }
}
