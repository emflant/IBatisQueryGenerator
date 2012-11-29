using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication01
{
    class CombineDeleteQuery : CombineQuery
    {
        private MakeQuery makeQuery;
        private DataTable dataTable;
        private string strTableEng;
        private string strTableKor;

        public CombineDeleteQuery(MakeQuery makeQuery, DataTable dataTable, string strTableEng, string strTableKor)
        {
            this.makeQuery = makeQuery;
            this.dataTable = dataTable;
            this.strTableEng = strTableEng;
            this.strTableKor = strTableKor;
        }

        public string combine()
        {
            string strResult = combineFromQuery();
            strResult += combineWhereQuery();
            return strResult;
        }

        private string combineSelectQuery()
        {
            return null;
        }

        private string combineFromQuery()
        {
            return makeQuery.makeFromQuery(strTableEng, strTableKor);
        }

        private string combineWhereQuery()
        {
            String strResult = null;
            int nRow = dataTable.Rows.Count;

            int nWhere = 0;

            foreach (DataRow dataRow in dataTable.Rows)
            {
                DataColumn dataColumn1 = dataTable.Columns[0];
                DataColumn dataColumn2 = dataTable.Columns[1];
                DataColumn dataColumn3 = dataTable.Columns[2];

                Console.WriteLine("====================================");
                Console.WriteLine(dataRow[dataColumn1].ToString());
                Console.WriteLine(dataRow[dataColumn2].ToString());
                Console.WriteLine(dataRow[dataColumn3].ToString());

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

        /*****
        private string combineWhereQuery2()
        {
            String strResult = null;
            int nRow = dataTable.Rows.Count;

            int nWhere = 0;

            for (int i = 0; i < nRow; i++)
            {
                if (dataTable[0, i].Value == null)
                {
                    continue;
                }

                if (dataTable[1, i].Value == null)
                {
                    dataTable[1, i].Value = "";

                }

                if (dataTable[2, i].Value == null)
                {
                    continue;
                }



                //MessageBox.Show(grid[2, i].Value.ToString());

                if (!dataTable[2, i].Value.ToString().Equals("True"))
                {
                    continue;
                }

                nWhere++;

                string strAdd = " WHERE  ";

                if (nWhere > 1)
                {
                    strAdd = "   AND  ";
                }

                strResult += strAdd + makeQuery.makeWhereQuery(dataTable[0, i].Value.ToString()
                    , dataTable[1, i].Value.ToString());

                strResult += "\n";
            }

            return strResult;
        }
        ******/

    }
}
