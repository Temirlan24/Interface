using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public interface IPart
    {
        string PartName { get; set; }
        bool IsBuilt { get; set; }
    }
}
