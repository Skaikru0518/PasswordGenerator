using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class GenerateConfig
    {
        public int Lenght { get; set; }
        public bool IsLower { get; set; }
        public bool IsUpper { get; set; }
        public bool IsDigit { get; set; }
        public bool IsSymbol { get; set; }
    }
}
