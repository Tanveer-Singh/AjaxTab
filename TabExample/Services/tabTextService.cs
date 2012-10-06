using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TabExample.Models;
using System.Collections;

namespace TabExample.Services
{
    public class tabTextService
    {
        public tabViewModel getTabViewModel()
        {
            tabViewModel model = new tabViewModel();

            model.TabText1 = getTabText1();
            model.TabText2 = getTabText2();
            model.TabText3 = getTabText3();

            return model;
        }

        private string getTabText1()
        {
            return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sed lacus. Donec auctor metus vel neque lobortis molestie. Nullam venenatis tellus. Proin commodo aliquet nisl. Quisque purus turpis, sagittis in, auctor quis, feugiat nec, nulla. Nam nec leo. Cras placerat ullamcorper elit. Fusce tempus faucibus tellus. Fusce sagittis ornare magna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Etiam in nunc. Vivamus condimentum. Mauris eu ante sit amet nulla fringilla euismod. Sed porttitor accumsan lectus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae";
        }

        private string getTabText2()
        {
            return "In iaculis, sapien sit amet sagittis vestibulum, arcu turpis pulvinar dolor, et rutrum urna erat vitae nisi. Sed fringilla quam tempor leo. Suspendisse semper porta eros. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Curabitur auctor. Aenean imperdiet tempus nulla. Donec enim ipsum, ornare sed, convallis sit amet, egestas luctus, orci. In sit amet justo. Praesent luctus ultrices ligula. Aenean vel enim id sapien congue scelerisque. In volutpat. Proin imperdiet placerat purus. Ut luctus nunc. Praesent feugiat hendrerit sem. Nulla sem risus, egestas ac, suscipit et, facilisis vel, velit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Cras molestie. Aenean consequat tellus ac leo. Nullam a dolor. Quisque arcu augue, tincidunt non, lacinia ut, scelerisque sed, sem.";
        }

        private string getTabText3()
        {
            return "Nullam non ipsum. Aenean tempus, nisi at condimentum molestie, turpis nulla hendrerit lorem, sed aliquam risus leo mattis ligula. Donec posuere. Nam semper justo nec tortor. Nulla facilisi. Sed porta ante eu arcu. Quisque ut enim. Vestibulum eu massa. Vivamus rutrum, nunc at placerat congue, velit nulla pretium neque, eget fringilla est nisl vitae urna. Phasellus nec nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla rutrum luctus neque. Vestibulum posuere iaculis sem. Donec. ";
        }
    }
}
