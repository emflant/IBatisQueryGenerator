using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication01
{
    class MakeSelectQuery : MakeQuery
    {
        private int nMaxColEngLength;
        private int nMaxColKorLength;
        private string strTableAlias;
        private bool checkedComment;

        public MakeSelectQuery(string strTableAlias, int nMaxColEngLength, int nMaxColKorLength, bool checkedComment)
        {
            this.strTableAlias = strTableAlias;
            this.nMaxColEngLength = nMaxColEngLength;
            this.nMaxColKorLength = nMaxColKorLength;
            this.checkedComment = checkedComment;
        }

        public string makeSelectQuery(string strColEng, string strColKor)
        {
            return makeQuery(strColEng, strColKor, "type1");
        }

        public string makeFromQuery(string strTableEng, string strTableKor)
        {
            return "  FROM  " + strTableEng + "  " + strTableAlias + "\n";
        }

        public string makeWhereQuery(string strColEng, string strColKor)
        {
            return makeQuery(strColEng, strColKor, "type2");
        }


        //str1 = 'AS' or ' ='  
        //str2 = '\"'  or '#'
        private string makeQuery(string strColEng, string strColKor, string type)
        {
            MakeCommonQuery comm = new MakeCommonQuery(strTableAlias, nMaxColEngLength, nMaxColKorLength);
            return comm.makeQuery(strColEng, strColKor, type, checkedComment);
        }

    }


}
