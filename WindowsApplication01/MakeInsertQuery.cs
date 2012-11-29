using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication01
{
    class MakeInsertQuery : MakeQuery
    {
        private int nMaxColEngLength;
        private int nMaxColKorLength;
        private bool checkedComment;

        public MakeInsertQuery(int nMaxColEngLength, int nMaxColKorLength, bool checkedComment)
        {
            this.nMaxColEngLength = nMaxColEngLength;
            this.nMaxColKorLength = nMaxColKorLength;
            this.checkedComment = checkedComment;
        }

        public string makeSelectQuery(string strColEng, string strColKor)
        {
            return makeQuery(strColEng, strColKor, "");
        }

        public string makeFromQuery(string strTableEng, string strTableKor)
        {
            return "INSERT  INTO  " + strTableEng + " ( \n";
        }

        public string makeWhereQuery(string strColEng, string strColKor)
        {
            return makeQuery(strColEng, strColKor, "#");
        }


        private string makeQuery(string strColEng, string strColKor, string strParam)
        {
            if (strColEng.Length >= nMaxColEngLength)
            {
                throw new MyException("컬럼길이(" + strColEng.Length + ")보다 입력넓이가 작거나 같습니다.");
            }

            String str1 = strParam + strColEng + strParam;

            if (checkedComment)
            {
                return str1;
            }

            else
            {
                return makeComment(strColKor, str1);
            }
        }


        public string makeComment(string strColKor, string str1)
        {
            String str2 = (str1).PadRight(nMaxColEngLength) + "<!-- " + strColKor;

            CalculateByteLength calculateByteLength = new CalculateByteLength();
            int nTotal = calculateByteLength.calculate(strColKor);

            String str3 = str2.PadRight(nMaxColEngLength + nMaxColKorLength - nTotal) + " -->";

            return str3;
        }

    }
}
