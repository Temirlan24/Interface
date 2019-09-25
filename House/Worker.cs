using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public class Worker: IWorker
    {
        public bool ConstructionCheck(IPart part)
        {
            if (part.IsBuilt)
            {
                return true;
            }
            return false;
        }
        public void CheckBuild(IPart part)
        {
            Window window = new Window();
            Wall walls = new Wall();
            if (!part.IsBuilt)
            {
                Part(part);
            }
        }   
        public void Part(IPart part)
        {
            part.IsBuilt = true;
        }
    }
}
