namespace RandomSeatUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.studentListTable = new System.Windows.Forms.ListBox();
            this.seatTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbdatawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentName = new System.Windows.Forms.TextBox();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.removeRow = new System.Windows.Forms.Button();
            this.rowNumber = new System.Windows.Forms.NumericUpDown();
            this.colNumber = new System.Windows.Forms.NumericUpDown();
            this.removeRowNumber = new System.Windows.Forms.NumericUpDown();
            this.AddRow = new System.Windows.Forms.Button();
            this.clearStudents = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.RandomEX = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cleanTable = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeRowNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListTable
            // 
            this.studentListTable.FormattingEnabled = true;
            this.studentListTable.ItemHeight = 15;
            this.studentListTable.Location = new System.Drawing.Point(13, 28);
            this.studentListTable.Name = "studentListTable";
            this.studentListTable.Size = new System.Drawing.Size(188, 349);
            this.studentListTable.TabIndex = 0;
            // 
            // seatTable
            // 
            this.seatTable.AutoScroll = true;
            this.seatTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.seatTable.ColumnCount = 1;
            this.seatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.seatTable.Location = new System.Drawing.Point(208, 28);
            this.seatTable.Name = "seatTable";
            this.seatTable.RowCount = 1;
            this.seatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.seatTable.Size = new System.Drawing.Size(580, 349);
            this.seatTable.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputConfigToolStripMenuItem,
            this.outputConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.configToolStripMenuItem.Text = "班级配置";
            // 
            // inputConfigToolStripMenuItem
            // 
            this.inputConfigToolStripMenuItem.Name = "inputConfigToolStripMenuItem";
            this.inputConfigToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.inputConfigToolStripMenuItem.Text = "导入配置";
            this.inputConfigToolStripMenuItem.Click += new System.EventHandler(this.inputConfigToolStripMenuItem_Click);
            // 
            // outputConfigToolStripMenuItem
            // 
            this.outputConfigToolStripMenuItem.Name = "outputConfigToolStripMenuItem";
            this.outputConfigToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.outputConfigToolStripMenuItem.Text = "导出配置";
            this.outputConfigToolStripMenuItem.Click += new System.EventHandler(this.outputConfigToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputResultToolStripMenuItem,
            this.outputResultToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.resultToolStripMenuItem.Text = "座位表";
            // 
            // inputResultToolStripMenuItem
            // 
            this.inputResultToolStripMenuItem.Name = "inputResultToolStripMenuItem";
            this.inputResultToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.inputResultToolStripMenuItem.Text = "导入座位表";
            this.inputResultToolStripMenuItem.Click += new System.EventHandler(this.inputResultToolStripMenuItem_Click);
            // 
            // outputResultToolStripMenuItem
            // 
            this.outputResultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbdatawToolStripMenuItem,
            this.csvToolStripMenuItem});
            this.outputResultToolStripMenuItem.Name = "outputResultToolStripMenuItem";
            this.outputResultToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.outputResultToolStripMenuItem.Text = "导出座位表";
            this.outputResultToolStripMenuItem.Click += new System.EventHandler(this.outputResultToolStripMenuItem_Click);
            // 
            // tbdatawToolStripMenuItem
            // 
            this.tbdatawToolStripMenuItem.Name = "tbdatawToolStripMenuItem";
            this.tbdatawToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tbdatawToolStripMenuItem.Text = ".tbdataw文件";
            this.tbdatawToolStripMenuItem.Click += new System.EventHandler(this.tbdatawToolStripMenuItem_Click);
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.csvToolStripMenuItem.Text = ".csv文件";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.helpToolStripMenuItem.Text = "帮助";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // newStudentName
            // 
            this.newStudentName.Location = new System.Drawing.Point(12, 415);
            this.newStudentName.Name = "newStudentName";
            this.newStudentName.Size = new System.Drawing.Size(90, 25);
            this.newStudentName.TabIndex = 4;
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(111, 383);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(90, 27);
            this.deleteStudent.TabIndex = 5;
            this.deleteStudent.Text = "删除";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(111, 415);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(88, 26);
            this.addStudent.TabIndex = 6;
            this.addStudent.Text = "添加";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // removeRow
            // 
            this.removeRow.Location = new System.Drawing.Point(334, 415);
            this.removeRow.Name = "removeRow";
            this.removeRow.Size = new System.Drawing.Size(120, 26);
            this.removeRow.TabIndex = 8;
            this.removeRow.Text = "删除行";
            this.removeRow.UseVisualStyleBackColor = true;
            this.removeRow.Click += new System.EventHandler(this.removeRow_Click);
            // 
            // rowNumber
            // 
            this.rowNumber.Location = new System.Drawing.Point(208, 385);
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.Size = new System.Drawing.Size(120, 25);
            this.rowNumber.TabIndex = 9;
            // 
            // colNumber
            // 
            this.colNumber.Location = new System.Drawing.Point(334, 385);
            this.colNumber.Name = "colNumber";
            this.colNumber.Size = new System.Drawing.Size(120, 25);
            this.colNumber.TabIndex = 10;
            // 
            // removeRowNumber
            // 
            this.removeRowNumber.Location = new System.Drawing.Point(208, 415);
            this.removeRowNumber.Name = "removeRowNumber";
            this.removeRowNumber.Size = new System.Drawing.Size(120, 25);
            this.removeRowNumber.TabIndex = 11;
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(460, 383);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(120, 28);
            this.AddRow.TabIndex = 12;
            this.AddRow.Text = "添加行";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // clearStudents
            // 
            this.clearStudents.Location = new System.Drawing.Point(12, 382);
            this.clearStudents.Name = "clearStudents";
            this.clearStudents.Size = new System.Drawing.Size(90, 27);
            this.clearStudents.TabIndex = 13;
            this.clearStudents.Text = "清空";
            this.clearStudents.UseVisualStyleBackColor = true;
            this.clearStudents.Click += new System.EventHandler(this.clearStudents_Click);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(698, 382);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(90, 27);
            this.Random.TabIndex = 14;
            this.Random.Text = "随机";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(602, 382);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(90, 27);
            this.Insert.TabIndex = 15;
            this.Insert.Text = "顺序";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // RandomEX
            // 
            this.RandomEX.Location = new System.Drawing.Point(602, 415);
            this.RandomEX.Name = "RandomEX";
            this.RandomEX.Size = new System.Drawing.Size(186, 26);
            this.RandomEX.TabIndex = 16;
            this.RandomEX.Text = "交换前后并随机";
            this.RandomEX.UseVisualStyleBackColor = true;
            this.RandomEX.Click += new System.EventHandler(this.RandomEX_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cleanTable
            // 
            this.cleanTable.Location = new System.Drawing.Point(460, 415);
            this.cleanTable.Name = "cleanTable";
            this.cleanTable.Size = new System.Drawing.Size(120, 26);
            this.cleanTable.TabIndex = 13;
            this.cleanTable.Text = "清空";
            this.cleanTable.UseVisualStyleBackColor = true;
            this.cleanTable.Click += new System.EventHandler(this.cleanTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cleanTable);
            this.Controls.Add(this.RandomEX);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.clearStudents);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.removeRowNumber);
            this.Controls.Add(this.colNumber);
            this.Controls.Add(this.rowNumber);
            this.Controls.Add(this.removeRow);
            this.Controls.Add(this.newStudentName);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.seatTable);
            this.Controls.Add(this.studentListTable);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeRowNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentListTable;
        private System.Windows.Forms.TableLayoutPanel seatTable;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputConfigToolStripMenuItem;
        private System.Windows.Forms.TextBox newStudentName;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button removeRow;
        private System.Windows.Forms.NumericUpDown rowNumber;
        private System.Windows.Forms.NumericUpDown colNumber;
        private System.Windows.Forms.NumericUpDown removeRowNumber;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Button clearStudents;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button RandomEX;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbdatawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.Button cleanTable;
    }
}

