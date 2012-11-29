using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication01
{
    public partial class Form1 : Form
    {
        private GridClass gridClazz;
        private EntConnection conn;

        public Form1()
        {
            InitializeComponent();
            gridClazz = new GridClass();
            listBoxQueryKindCd.SelectedItem = "SELECT";
        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //MessageBox.Show("" + Keys.Delete + "," +e.KeyCode);

                //delete Ű �Է½�
                if (e.KeyCode == Keys.Delete)
                {
                    //�Ѽ��� ���� �����Ҷ�
                    //dataGridView1.CurrentCell.Value = null;

                    //������ ���� ���ﶧ
                    //dataGridView1.SelectedCells[0].ColumnIndex;
                    //dataGridView1.SelectedCells[0].RowIndex;
                    //dataGridView1.SelectedCells[0].Value = null;

                    gridClazz.setSelectedCellsValue(dataGridView1, null);
                }

                
                //ctrl+v Ű �Է½�
                if (e.Control && e.KeyCode == Keys.V)
                {
                    gridClazz.setGridMultyRow(dataGridView1, Clipboard.GetText());
                }

            }
            catch (MyException my)
            {
                my.showMessage();
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
        }

        //���̺��� ����������
        private void cboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cboTable.SelectedItem.ToString());
            dataGridView1.DataSource = conn.getColumnList(cboTable.SelectedItem.ToString(), chkUpperYn.Checked);
        }

        //��Ű���� ����������
        private void cboSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTable.DataSource = conn.getTableList(cboSchema.SelectedItem.ToString());
        }

        private void chkComment_CheckedChanged(object sender, EventArgs e)
        {
            getQuery();
        }

        private void chkUpperYn_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.getColumnList(cboTable.SelectedItem.ToString(), chkUpperYn.Checked);
        }

        private void getQuery()
        {

            try
            {
                String result = gridClazz.getQueryText(
                    (DataTable)dataGridView1.DataSource,
                    cboSchema.SelectedItem.ToString() + ".." + cboTable.SelectedItem.ToString(),
                    txtTableAlias.Text,
                    int.Parse(txtNColEng.Text),
                    int.Parse(txtNColKor.Text),
                    listBoxQueryKindCd.SelectedItem.ToString(),
                    chkComment.Checked);

                richTextBox1.Text = result;
            }

            catch (MyException my)
            {
                my.showMessage();
            }


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (conn != null)
            {
                conn.close();
            }

            //this.conn = new EntConnection(new ConnectionMSSQL2000(txtIp.Text, txtId.Text, txtPw.Text));   // MS-SQL 2000
            this.conn = new EntConnection(new ConnectionMSSQL2008(txtIp.Text, txtId.Text, txtPw.Text));     // MS-SQL 2008
            cboSchema.DataSource = conn.getSchemaList();
            //cboTable.DataSource = conn.getTableList(cboSchema.SelectedItem.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null)
            {
                conn.close();
            }
            
        }



    }
}