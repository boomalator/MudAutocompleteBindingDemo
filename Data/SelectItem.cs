using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultBlazor
{
    public class SelectItemInt
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Text}".Trim();
        }
    }

}
