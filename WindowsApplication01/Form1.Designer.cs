namespace WindowsApplication01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_eng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_kor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxQueryKindCd = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNColEng = new System.Windows.Forms.TextBox();
            this.txtNColKor = new System.Windows.Forms.TextBox();
            this.txtTableAlias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.cboSchema = new System.Windows.Forms.ComboBox();
            this.chkComment = new System.Windows.Forms.CheckBox();
            this.chkUpperYn = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_eng,
            this.col_kor,
            this.key});
            this.dataGridView1.Location = new System.Drawing.Point(25, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(322, 266);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // col_eng
            // 
            this.col_eng.DataPropertyName = "col_eng";
            this.col_eng.HeaderText = "컬럼영문명";
            this.col_eng.Name = "col_eng";
            this.col_eng.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_kor
            // 
            this.col_kor.DataPropertyName = "col_kor";
            this.col_kor.HeaderText = "컬럼한글명";
            this.col_kor.Name = "col_kor";
            // 
            // key
            // 
            this.key.DataPropertyName = "pk";
            this.key.HeaderText = "WHERE";
            this.key.Name = "key";
            this.key.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.key.Width = 50;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(394, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 266);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "▷ 쿼리전환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxQueryKindCd
            // 
            this.listBoxQueryKindCd.FormattingEnabled = true;
            this.listBoxQueryKindCd.ItemHeight = 12;
            this.listBoxQueryKindCd.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.listBoxQueryKindCd.Location = new System.Drawing.Point(94, 317);
            this.listBoxQueryKindCd.Name = "listBoxQueryKindCd";
            this.listBoxQueryKindCd.Size = new System.Drawing.Size(85, 52);
            this.listBoxQueryKindCd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "컬럼영문명최대길이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "컬럼한글명최대길이";
            // 
            // txtNColEng
            // 
            this.txtNColEng.Location = new System.Drawing.Point(511, 324);
            this.txtNColEng.MaxLength = 2;
            this.txtNColEng.Name = "txtNColEng";
            this.txtNColEng.Size = new System.Drawing.Size(46, 21);
            this.txtNColEng.TabIndex = 8;
            this.txtNColEng.Text = "30";
            // 
            // txtNColKor
            // 
            this.txtNColKor.Location = new System.Drawing.Point(511, 353);
            this.txtNColKor.MaxLength = 2;
            this.txtNColKor.Name = "txtNColKor";
            this.txtNColKor.Size = new System.Drawing.Size(46, 21);
            this.txtNColKor.TabIndex = 9;
            this.txtNColKor.Text = "30";
            // 
            // txtTableAlias
            // 
            this.txtTableAlias.Location = new System.Drawing.Point(326, 11);
            this.txtTableAlias.MaxLength = 5;
            this.txtTableAlias.Name = "txtTableAlias";
            this.txtTableAlias.Size = new System.Drawing.Size(22, 21);
            this.txtTableAlias.TabIndex = 10;
            this.txtTableAlias.Text = "T";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "쿼리구분";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(394, 10);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(85, 21);
            this.txtIp.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(485, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 21);
            this.txtId.TabIndex = 15;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(573, 10);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(64, 21);
            this.txtPw.TabIndex = 16;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.ItemHeight = 12;
            this.cboTable.Location = new System.Drawing.Point(154, 11);
            this.cboTable.MaxDropDownItems = 30;
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(166, 20);
            this.cboTable.TabIndex = 17;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // cboSchema
            // 
            this.cboSchema.FormattingEnabled = true;
            this.cboSchema.Location = new System.Drawing.Point(27, 11);
            this.cboSchema.Name = "cboSchema";
            this.cboSchema.Size = new System.Drawing.Size(121, 20);
            this.cboSchema.TabIndex = 18;
            this.cboSchema.SelectedIndexChanged += new System.EventHandler(this.cboSchema_SelectedIndexChanged);
            // 
            // chkComment
            // 
            this.chkComment.AutoSize = true;
            this.chkComment.Location = new System.Drawing.Point(590, 326);
            this.chkComment.Name = "chkComment";
            this.chkComment.Size = new System.Drawing.Size(72, 16);
            this.chkComment.TabIndex = 19;
            this.chkComment.Text = "주석제거";
            this.chkComment.UseVisualStyleBackColor = true;
            this.chkComment.CheckedChanged += new System.EventHandler(this.chkComment_CheckedChanged);
            // 
            // chkUpperYn
            // 
            this.chkUpperYn.AutoSize = true;
            this.chkUpperYn.Location = new System.Drawing.Point(590, 353);
            this.chkUpperYn.Name = "chkUpperYn";
            this.chkUpperYn.Size = new System.Drawing.Size(100, 16);
            this.chkUpperYn.TabIndex = 20;
            this.chkUpperYn.Text = "대문자로 출력";
            this.chkUpperYn.UseVisualStyleBackColor = true;
            this.chkUpperYn.Visible = false;
            this.chkUpperYn.CheckedChanged += new System.EventHandler(this.chkUpperYn_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(670, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkUpperYn);
            this.Controls.Add(this.chkComment);
            this.Controls.Add(this.cboSchema);
            this.Controls.Add(this.cboTable);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTableAlias);
            this.Controls.Add(this.txtNColKor);
            this.Controls.Add(this.txtNColEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxQueryKindCd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "IBatisQueryGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxQueryKindCd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNColEng;
        private System.Windows.Forms.TextBox txtNColKor;
        private System.Windows.Forms.TextBox txtTableAlias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.ComboBox cboSchema;
        private System.Windows.Forms.CheckBox chkComment;
        private System.Windows.Forms.CheckBox chkUpperYn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_kor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn key;
        private System.Windows.Forms.Button btnConnect;
    }
}

