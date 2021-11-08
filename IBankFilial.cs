using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenges
{
    public interface IBankFilial
    {
        string name{ get; set; }
        string region{ get; set; }
        void setRegion();
    }
}