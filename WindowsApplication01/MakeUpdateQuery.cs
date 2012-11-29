using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication01
{
    class MakeUpdateQuery : MakeQuery
    {
        private int nMaxColEngLength;
        private int nMaxColKorLength;
        private bool checkedComment;

        public MakeUpdateQuery(int nMaxColEngLength, int nMaxColKorLength, bool checkedComment)
        {
            this.nMaxColEngLength = nMaxColEngLength;
            this.nMaxColKorLength = nMaxColKorLength;
            this.checkedComment = checkedComment;
        }

        public string makeSelectQuery(string strColEng, string strColKor)
        {
            return makeQuery(strColEng, strColKor);
        }

        public string makeFromQuery(string strTableEng, string strTableKor)
        {
            string strQuery = "UPDATE  " + strTableEng + "\n";
            return strQuery;
        }

        public string makeWhereQuery(string strColEng, string strColKor)
        {
            return makeQuery(strColEng, strColKor);
        }



        public string makeQuery(string strColEng, string strColKor)
        {
            MakeCommonQuery comm = new MakeCommonQuery("", nMaxColEngLength, nMaxColKorLength);
            return comm.makeQuery(strColEng, strColKor, "type2", checkedComment);
        }

    }
}
