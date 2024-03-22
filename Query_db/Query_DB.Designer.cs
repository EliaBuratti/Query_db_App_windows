namespace Query_db
{
    partial class Query_DB
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConnectDB = new System.Windows.Forms.Button();
            this.ListColumnDB = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SELECT = new System.Windows.Forms.Label();
            this.FROM = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.ComboBox();
            this.Execute_Query = new System.Windows.Forms.Button();
            this.Clear_Form = new System.Windows.Forms.Button();
            this.Column_name = new System.Windows.Forms.ComboBox();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.Input_condition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectDB
            // 
            this.ConnectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectDB.Location = new System.Drawing.Point(12, 12);
            this.ConnectDB.Name = "ConnectDB";
            this.ConnectDB.Size = new System.Drawing.Size(250, 57);
            this.ConnectDB.TabIndex = 1;
            this.ConnectDB.Text = "Connect to DB";
            this.ConnectDB.UseVisualStyleBackColor = true;
            this.ConnectDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListColumnDB
            // 
            this.ListColumnDB.AllowDrop = true;
            this.ListColumnDB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListColumnDB.CheckOnClick = true;
            this.ListColumnDB.FormattingEnabled = true;
            this.ListColumnDB.Location = new System.Drawing.Point(175, 231);
            this.ListColumnDB.Name = "ListColumnDB";
            this.ListColumnDB.Size = new System.Drawing.Size(223, 142);
            this.ListColumnDB.TabIndex = 2;
            this.ListColumnDB.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SELECT
            // 
            this.SELECT.AutoSize = true;
            this.SELECT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SELECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT.Location = new System.Drawing.Point(22, 231);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(131, 36);
            this.SELECT.TabIndex = 3;
            this.SELECT.Text = "SELECT";
            this.SELECT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SELECT.Click += new System.EventHandler(this.label1_Click);
            // 
            // FROM
            // 
            this.FROM.AutoSize = true;
            this.FROM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FROM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FROM.Location = new System.Drawing.Point(417, 231);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(373, 36);
            this.FROM.TabIndex = 4;
            this.FROM.Text = "FROM Anagrafica_Furgoni";
            this.FROM.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 588);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1796, 300);
            this.Result.TabIndex = 5;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Condition
            // 
            this.Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition.FormattingEnabled = true;
            this.Condition.Items.AddRange(new object[] {
            "WHERE"});
            this.Condition.Location = new System.Drawing.Point(806, 231);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(133, 44);
            this.Condition.TabIndex = 6;
            this.Condition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Execute_Query
            // 
            this.Execute_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute_Query.Location = new System.Drawing.Point(12, 502);
            this.Execute_Query.Name = "Execute_Query";
            this.Execute_Query.Size = new System.Drawing.Size(304, 64);
            this.Execute_Query.TabIndex = 8;
            this.Execute_Query.Text = "Execute Query";
            this.Execute_Query.UseVisualStyleBackColor = true;
            this.Execute_Query.Click += new System.EventHandler(this.Execute_Query_Click);
            // 
            // Clear_Form
            // 
            this.Clear_Form.BackColor = System.Drawing.Color.Red;
            this.Clear_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Form.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear_Form.Location = new System.Drawing.Point(337, 502);
            this.Clear_Form.Name = "Clear_Form";
            this.Clear_Form.Size = new System.Drawing.Size(203, 64);
            this.Clear_Form.TabIndex = 9;
            this.Clear_Form.Text = "Clear Form";
            this.Clear_Form.UseVisualStyleBackColor = false;
            this.Clear_Form.Click += new System.EventHandler(this.Clear_Form_Click);
            // 
            // Column_name
            // 
            this.Column_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Column_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_name.FormattingEnabled = true;
            this.Column_name.Location = new System.Drawing.Point(958, 231);
            this.Column_name.Name = "Column_name";
            this.Column_name.Size = new System.Drawing.Size(212, 44);
            this.Column_name.TabIndex = 10;
            this.Column_name.SelectedIndexChanged += new System.EventHandler(this.Column_name_SelectedIndexChanged);
            // 
            // Operator
            // 
            this.Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            ">",
            "LIKE"});
            this.Operator.Location = new System.Drawing.Point(1193, 231);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(175, 44);
            this.Operator.TabIndex = 11;
            this.Operator.SelectedIndexChanged += new System.EventHandler(this.Operator_SelectedIndexChanged);
            // 
            // Input_condition
            // 
            this.Input_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_condition.Location = new System.Drawing.Point(1402, 234);
            this.Input_condition.Name = "Input_condition";
            this.Input_condition.Size = new System.Drawing.Size(406, 41);
            this.Input_condition.TabIndex = 12;
            this.Input_condition.TextChanged += new System.EventHandler(this.Input_condition_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Colonne";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Condizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(994, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Colonna";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1200, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Operatore";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1468, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Scrivi la condizione ";
            // 
            // Query_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 932);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_condition);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.Column_name);
            this.Controls.Add(this.Clear_Form);
            this.Controls.Add(this.Execute_Query);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.FROM);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.ListColumnDB);
            this.Controls.Add(this.ConnectDB);
            this.Name = "Query_DB";
            this.Text = "Query_DB";
            this.Load += new System.EventHandler(this.Query_DB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectDB;
        private System.Windows.Forms.CheckedListBox ListColumnDB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label SELECT;
        private System.Windows.Forms.Label FROM;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ComboBox Condition;
        private System.Windows.Forms.Button Execute_Query;
        private System.Windows.Forms.Button Clear_Form;
        private System.Windows.Forms.ComboBox Column_name;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.TextBox Input_condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}