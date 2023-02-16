using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video.Models
{
    class CustomExceptionAn : Exception
    {
        public override string Message
        {
            get
            {
                return "1880 < An <= 2020";
            }
        }
    }
}
