using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipASP.NET
{
    interface ICURD<T>
    {
        StringReader Recipt(T a);
    }
}
