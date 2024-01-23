using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyper_16_01_2024_2.Classes
{
    internal class Teacher
    {
        public List<string> Subjects;
        public string GetSubjects()
        {
            return string.Join(", ", Subjects);
        }
    }
}
