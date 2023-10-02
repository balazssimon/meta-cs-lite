using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public enum ListKind
    {
        SeparatorItem, // (, item)*
        ItemSeparator, // (item, )*
        WithFirstItem, // item (, item)*
        WithFirstItemSeparator, // item (, item)* ,
        WithLastItem, // (item, )* item
        WithLastItemSeparator, // (item, )* item ,
    }
}
