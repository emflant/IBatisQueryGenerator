using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication01
{
    class CombineSelectQuery : CombineQuery
    {
        private MakeQuery makeQuery;
        private DataTable dataTable;
        private string strTableEng;
        private string strTableKor;

        public CombineSelectQuery(MakeQuery makeQuery, DataTable dataTable, string strTableEng, string strTableKor)
        {
            this.makeQuery = makeQuery;
            this.dataTable = dataTable;
            this.strTableEng = strTableEng;
            this.strTableKor = strTableKor;
        }

        public string combine()
        {
            string strResult = combineSelectQuery();
            strResult += combineFromQuery();
            strResult += combineWhereQuery();
            return strResult;
        }

        private string combineSelectQuery()
        {

            String strResult = "SELECT \n";

            int i = 0;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                DataColumn dataColumn1 = dataTable.Columns[0];
                DataColumn dataColumn2 = dataTable.Columns[1];
                DataColumn dataColumn3 = dataTable.Columns[2];

                if (dataRow[dataColumn1].ToString() == null)
                {
                    //Console.WriteLine(dataRow[dataColumn1].ToString().Value);
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

            int nWhere = 0;


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

                if (dataRow[dataColumn3].ToString() == null)
                {
                    continue;
                }



                //MessageBox.Show(grid[2, i].Value.ToString());

                if (!dataRow[dataColumn3].ToString().Equals("True"))
                {
                    continue;
                }

                nWhere++;

                string strAdd = " WHERE  ";

                if (nWhere > 1)
                {
                    strAdd = "   AND  ";
                }

                strResult += strAdd + makeQuery.makeWhereQuery(dataRow[dataColumn1].ToString()
                    , dataRow[dataColumn2].ToString());

                strResult += "\n";
            }
            
            return strResult;
        }
    }
}
