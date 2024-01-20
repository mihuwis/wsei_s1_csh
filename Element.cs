using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject02
{
    internal class Element
    {
        public Element previousElem;
        public Element nextElem; 
        
        public void addElement(Element elem)
        {
            if(this.nextElem == null)
            {
                nextElem = elem;
                elem.previousElem = this;
            }
            else
            {
                elem.nextElem = this.nextElem;
                elem.previousElem = this;
                this.nextElem = elem;
                elem.nextElem.previousElem = elem;
            }

        }

        public void removeNext()
        {
            this.nextElem.nextElem.previousElem = this;
            this.nextElem = this.nextElem.nextElem;
        }
    }
}
