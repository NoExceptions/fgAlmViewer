namespace fgAlmViewer
{
    partial class almGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpComments = new System.Windows.Forms.GroupBox();
            this.edtComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdTipo = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.edtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtTagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.timeInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.grpCols = new System.Windows.Forms.GroupBox();
            this.spinFrom = new System.Windows.Forms.NumericUpDown();
            this.spinTo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.edtNode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtGrupo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpComments.SuspendLayout();
            this.grdTipo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpCols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grpComments);
            this.groupBox1.Controls.Add(this.grdTipo);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.grpCols);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // grpComments
            // 
            this.grpComments.Controls.Add(this.edtGrupo);
            this.grpComments.Controls.Add(this.label9);
            this.grpComments.Controls.Add(this.edtNode);
            this.grpComments.Controls.Add(this.label8);
            this.grpComments.Controls.Add(this.edtComment);
            this.grpComments.Controls.Add(this.label6);
            this.grpComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpComments.Location = new System.Drawing.Point(6, 112);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(725, 44);
            this.grpComments.TabIndex = 4;
            this.grpComments.TabStop = false;
            this.grpComments.Text = "Filtrar:";
            // 
            // edtComment
            // 
            this.edtComment.BackColor = System.Drawing.Color.White;
            this.edtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edtComment.Location = new System.Drawing.Point(542, 15);
            this.edtComment.Name = "edtComment";
            this.edtComment.Size = new System.Drawing.Size(177, 23);
            this.edtComment.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(452, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comentário:";
            // 
            // grdTipo
            // 
            this.grdTipo.Controls.Add(this.radioButton3);
            this.grdTipo.Controls.Add(this.radioButton2);
            this.grdTipo.Controls.Add(this.radioButton1);
            this.grdTipo.Location = new System.Drawing.Point(737, 14);
            this.grdTipo.Name = "grdTipo";
            this.grdTipo.Size = new System.Drawing.Size(116, 142);
            this.grdTipo.TabIndex = 5;
            this.grdTipo.TabStop = false;
            this.grdTipo.Text = "Tipo:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "AE";
            this.radioButton3.Text = "Ambos";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "E";
            this.radioButton2.Text = "Eventos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "A";
            this.radioButton1.Text = "Alarmes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(859, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 134);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.edtUser);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.edtTagName);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.Location = new System.Drawing.Point(207, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 44);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar:";
            // 
            // edtUser
            // 
            this.edtUser.BackColor = System.Drawing.Color.White;
            this.edtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edtUser.Location = new System.Drawing.Point(341, 17);
            this.edtUser.Name = "edtUser";
            this.edtUser.Size = new System.Drawing.Size(177, 23);
            this.edtUser.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(274, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuário:";
            // 
            // edtTagName
            // 
            this.edtTagName.BackColor = System.Drawing.Color.White;
            this.edtTagName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtTagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edtTagName.Location = new System.Drawing.Point(84, 17);
            this.edtTagName.Name = "edtTagName";
            this.edtTagName.Size = new System.Drawing.Size(165, 23);
            this.edtTagName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tagname:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeFinal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dateFinal);
            this.groupBox3.Controls.Add(this.timeInicial);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateInicial);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(207, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intervalo";
            // 
            // timeFinal
            // 
            this.timeFinal.CustomFormat = "";
            this.timeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.timeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFinal.Location = new System.Drawing.Point(425, 19);
            this.timeFinal.Name = "timeFinal";
            this.timeFinal.ShowUpDown = true;
            this.timeFinal.Size = new System.Drawing.Size(93, 23);
            this.timeFinal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(274, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Final:";
            // 
            // dateFinal
            // 
            this.dateFinal.CustomFormat = "";
            this.dateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.Location = new System.Drawing.Point(317, 19);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(102, 23);
            this.dateFinal.TabIndex = 3;
            // 
            // timeInicial
            // 
            this.timeInicial.CustomFormat = "";
            this.timeInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.timeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeInicial.Location = new System.Drawing.Point(169, 19);
            this.timeInicial.Name = "timeInicial";
            this.timeInicial.ShowUpDown = true;
            this.timeInicial.Size = new System.Drawing.Size(80, 23);
            this.timeInicial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicial:";
            // 
            // dateInicial
            // 
            this.dateInicial.CustomFormat = "";
            this.dateInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.Location = new System.Drawing.Point(61, 19);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(102, 23);
            this.dateInicial.TabIndex = 0;
            // 
            // grpCols
            // 
            this.grpCols.Controls.Add(this.spinFrom);
            this.grpCols.Controls.Add(this.spinTo);
            this.grpCols.Controls.Add(this.label7);
            this.grpCols.Controls.Add(this.label5);
            this.grpCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpCols.Location = new System.Drawing.Point(6, 14);
            this.grpCols.Name = "grpCols";
            this.grpCols.Size = new System.Drawing.Size(194, 96);
            this.grpCols.TabIndex = 0;
            this.grpCols.TabStop = false;
            this.grpCols.Text = "Prioridade:";
            // 
            // spinFrom
            // 
            this.spinFrom.Location = new System.Drawing.Point(68, 26);
            this.spinFrom.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.spinFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinFrom.Name = "spinFrom";
            this.spinFrom.Size = new System.Drawing.Size(120, 23);
            this.spinFrom.TabIndex = 4;
            this.spinFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spinTo
            // 
            this.spinTo.Location = new System.Drawing.Point(68, 52);
            this.spinTo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.spinTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinTo.Name = "spinTo";
            this.spinTo.Size = new System.Drawing.Size(120, 23);
            this.spinTo.TabIndex = 3;
            this.spinTo.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Até:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "De:";
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdData.Location = new System.Drawing.Point(3, 169);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(990, 330);
            this.grdData.TabIndex = 1;
            // 
            // edtNode
            // 
            this.edtNode.BackColor = System.Drawing.Color.White;
            this.edtNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edtNode.Location = new System.Drawing.Point(48, 15);
            this.edtNode.Name = "edtNode";
            this.edtNode.Size = new System.Drawing.Size(146, 23);
            this.edtNode.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nó:";
            // 
            // edtGrupo
            // 
            this.edtGrupo.BackColor = System.Drawing.Color.White;
            this.edtGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edtGrupo.Location = new System.Drawing.Point(285, 15);
            this.edtGrupo.Name = "edtGrupo";
            this.edtGrupo.Size = new System.Drawing.Size(165, 23);
            this.edtGrupo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(209, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Grupo:";
            // 
            // almGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.groupBox1);
            this.Name = "almGrid";
            this.Size = new System.Drawing.Size(1000, 502);
            this.groupBox1.ResumeLayout(false);
            this.grpComments.ResumeLayout(false);
            this.grpComments.PerformLayout();
            this.grdTipo.ResumeLayout(false);
            this.grdTipo.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpCols.ResumeLayout(false);
            this.grpCols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker timeFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.DateTimePicker timeInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.TextBox edtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtTagName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.GroupBox grdTipo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.TextBox edtComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCols;
        private System.Windows.Forms.NumericUpDown spinFrom;
        private System.Windows.Forms.NumericUpDown spinTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtNode;
        private System.Windows.Forms.Label label8;
    }
}
