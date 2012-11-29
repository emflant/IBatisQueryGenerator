using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication01
{
    interface MakeQuery
    {
        string makeSelectQuery(string strColEng, string strColKor);
        string makeFromQuery(string strTableEng, string strTableKor);
        string makeWhereQuery(string strColEng, string strColKor);
    }
}
