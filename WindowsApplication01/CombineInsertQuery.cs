using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication01
{
    class CombineInsertQuery : CombineQuery
    {
        private MakeQuery makeQuery;
        private DataTable dataTable;
        private string strTableEng;
        private string strTableKor;

        public CombineInsertQuery(MakeQuery makeQuery, DataTable dataTable, string strTableEng, string strTableKor)
        {
            this.makeQuery = makeQuery;
            this.dataTable = dataTable;
            this.strTableEng = strTableEng;
            this.strTableKor = strTableKor;
        }

        public string combine()
        {
            string strResult = combineFromQuery();
            strResult += combineSelectQuery();
            strResult += ")  VALUES  (\n";
            strResult += combineWhereQuery();
            strResult += ")\n";
            return strResult;
        }

        private string combineSelectQuery()
        {
            String strResult = null;

            int i = 0;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                DataColumn dataColumn1 = dataTable.Columns[0];
                DataColumn dataColumn2 = dataTable.Columns[1];
                DataColumn dataColumn3 = dataTable.Columns[2];


                if (dataRow[dataColumn1].ToString() == null)
                {
                    continue;
                }

                if (dataRow[dataColumn2].ToString() == null)
                {
                    dataRow[dataColumn2] = "";
                }

                string strAdd = "        ";

                if (i != 0)
                {
                    strAdd = "     ,  ";
                }

                strResult += strAdd + makeQuery.makeSelectQuery(
                    dataRow[dataColumn1].ToString(), dataRow[dataColumn2].ToString());

                strResult += "\n";
                i++;
            }
            
            return strResult;
        }

        private string combineFromQuery()
        {
            return makeQuery.makeFromQuery(strTableEng, strTableKor);
        }

        private string combineWhereQuery()
        {
            String strResult = null;

            int i = 0;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                DataColumn dataColumn1 = dataTable.Columns[0];
                DataColumn dataColumn2 = dataTable.Columns[1];
                DataColumn dataColumn3 = dataTable.Columns[2];


                if (dataRow[dataColumn1].ToString() == null)
                {
                    continue;
                }

                if (dataRow[dataColumn2].ToString() == null)
                {
                    dataRow[dataColumn2] = "";
                }

                string strAdd = "        ";

                if (i != 0)
                {
                    strAdd = "     ,  ";
                }

                strResult += strAdd + makeQuery.makeWhereQuery(
                    dataRow[dataColumn1].ToString(), dataRow[dataColumn2].ToString());

                strResult += "\n";
                i++;
            }
            
            return strResult;
        }
    }
}
