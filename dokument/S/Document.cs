using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokument.S
{
    class Document
    {
        public DocumentContent Content { get; set; }
        public Print Print { get; set; }
        public FileOptions FileOptions { get; set; }
    }
}
