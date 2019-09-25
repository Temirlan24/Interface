using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public interface IWorker
    {
        void Part(IPart part);

        bool ConstructionCheck(IPart part);
    }
}
