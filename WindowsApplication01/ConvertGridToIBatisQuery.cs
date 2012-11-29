using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication01
{
    class ConvertGridToIBatisQuery
    {

        public string getIBatisQuery(DataTable dataTable
            , string queryKinds
            , string strTableEng
            , string strTableKor
            , string strTableAlias
            , int nMaxColEngLength
            , int nMaxColKorLength
            , bool checkedComment)
        {
            string strResult = null;

            MakeQuery msq = null;
            CombineQuery csq = null;

            if(queryKinds.Equals("SELECT"))
            {
                msq = new MakeSelectQuery(strTableAlias, nMaxColEngLength, nMaxColKorLength, checkedComment);
                csq = new CombineSelectQuery(msq, dataTable, strTableEng, strTableKor);
            }

            else if(queryKinds.Equals("INSERT"))
            {
                msq = new MakeInsertQuery(nMaxColEngLength, nMaxColKorLength, checkedComment);
                csq = new CombineInsertQuery(msq, dataTable, strTableEng, strTableKor);
            }

            else if(queryKinds.Equals("UPDATE"))
            {
                msq = new MakeUpdateQuery(nMaxColEngLength, nMaxColKorLength, checkedComment);
                csq = new CombineUpdateQuery(msq, dataTable, strTableEng, strTableKor);
            }

            else if(queryKinds.Equals("DELETE"))
            {
                msq = new MakeDeleteQuery(nMaxColEngLength, nMaxColKorLength, checkedComment);
                csq = new CombineDeleteQuery(msq, dataTable, strTableEng, strTableKor);
            }

            IBatisQueryFactory factory = new IBatisQueryFactory(msq, csq);
            strResult = factory.getQuery();

            return strResult;
        }
    
    }
}
