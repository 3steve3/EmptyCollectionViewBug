using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyCollectionViewBug
{
    public class ViewModel
    {
        //If text is not null, then the header will show with the items
        /*string[] text = new string[3]
        {
            "one",
            "two",
            "three"
        };*/
        string[] text = null;
        public string[] Text => text;
        public ViewModel()
        {
            
        }

    }
}
