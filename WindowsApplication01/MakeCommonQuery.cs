using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication01
{
    class MakeCommonQuery
    {

        private int nMaxColEngLength;
        private int nMaxColKorLength;
        private string strTableAlias;

        public MakeCommonQuery(string strTableAlias, int nMaxColEngLength, int nMaxColKorLength)
        {
            this.strTableAlias = strTableAlias;
            this.nMaxColEngLength = nMaxColEngLength;
            this.nMaxColKorLength = nMaxColKorLength;
        }

        //type1 = select 절
        //type2 = where  절
        public string makeQuery(string strColEng, string strColKor, string type, bool checkedComment)
        {
            string strParam1 = null;
            string strParam2 = null;

            if (type == "type1")
            {
                strParam1 = "AS";
                strParam2 = "\"";
            }

            else if (type == "type2")
            {
                strParam1 = " =";
                strParam2 = "#";
            }

            if (strColEng.Length >= nMaxColEngLength)
            {
                throw new MyException("컬럼길이(" + strColEng.Length + ")보다 입력넓이가 작거나 같습니다.");
            }

            String strQuery = null;

            if (strTableAlias != null && strTableAlias.Length != 0)
            {
                strQuery += strTableAlias + ".";
            }

            String str1 = (strQuery + strColEng).PadRight(nMaxColEngLength) + strParam1 + " " + strParam2 + strColEng + strParam2;


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
            String str2 = str1.PadRight(nMaxColEngLength * 2 + 3) + "<!-- " + strColKor;

            CalculateByteLength calculateByteLength = new CalculateByteLength();
            int nTotal = calculateByteLength.calculate(strColKor);

            String str3 = str2.PadRight(nMaxColEngLength * 2 + 3 + nMaxColKorLength - nTotal) + " -->";
            return str3;
        }
    }
}
