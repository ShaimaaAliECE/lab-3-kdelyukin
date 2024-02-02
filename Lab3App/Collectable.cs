using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        public abstract void AddMe(List<Collectable> collected);
        public abstract void Display();
    }
}

