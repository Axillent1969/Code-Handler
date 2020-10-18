using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Handler
{
    [Serializable]
    public class Code
    {
        public string ID { get; set; }
        public bool OnHold { get; set; }
        public string Category { get; set; }

        public bool IsDeleted { get; set; }

    }
}
