using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public  class GroupedModel 
    {

        public string Name { get; set; }
        public string Number { get; set; }
        public string Image { get; set; }
        public GroupedModel()
        {
        }
    }

    public class GroupedContactModel : ObservableCollection<GroupedModel>
    {
        public string Letter { get; set; }
        
    }
}
