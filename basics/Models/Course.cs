using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Course
    {
        /*
        prop+enter --> public int MyProperty { get; set; }
        */
        public int Id { get; set; }
 
        public string? Title { get; set; }//string? ? koymamın nedeni string boş girilme durumu için
    }
}