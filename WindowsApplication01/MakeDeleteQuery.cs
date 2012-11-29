using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication01
{
    class MakeDeleteQuery : MakeQuery
    {
        private int nMaxColEngLength;
        private int nMaxColKorLength;
        private bool checkedComment;

        public MakeDeleteQuery(int nMaxColEngLength, int nMaxColKorLength, bool checkedComment)
        {
            this.nMaxColEngLength = nMaxColEngLength;
            this.nMaxColKorLength = nMaxColKorLength;
            this.checkedComment = checkedComment;
        }

        public string makeSelectQuery(string strColEng, string strColKor)
        {
            return null;
        }

        public string makeFromQuery(string strTableEng, string strTableKor)
        {
            return "DELETE  FROM  " + strTableEng + "\n";
        }

        public string makeWhereQuery(string strColEng, string strColKor)
        {
            MakeCommonQuery comm = new MakeCommonQuery("", nMaxColEngLength, nMaxColKorLength);
            return comm.makeQuery(strColEng, strColKor, "type2", checkedComment);
        }

    }
}
