namespace web_parsers
{
    partial class F_Main
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
            System.Windows.Forms.Panel panel1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tab_byCar = new System.Windows.Forms.TabControl();
            this.tp_ByMake = new System.Windows.Forms.TabPage();
            this.cbTrim = new System.Windows.Forms.ComboBox();
            this.txtTrim = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btnCompare = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_byCar.SuspendLayout();
            this.tp_ByMake.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.Location = new System.Drawing.Point(12, 216);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(641, 119);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Make,
            this.Model,
            this.Trim,
            this.Year});
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.Width = 150;
            // 
            // Trim
            // 
            this.Trim.HeaderText = "Trim";
            this.Trim.MinimumWidth = 10;
            this.Trim.Name = "Trim";
            this.Trim.Width = 250;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(360, 61);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbMake
            // 
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(12, 19);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(121, 21);
            this.cbMake.TabIndex = 2;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            this.cbMake.Leave += new System.EventHandler(this.cbMake_Leave);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(144, 19);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 3;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            this.cbModel.Leave += new System.EventHandler(this.cbModel_Leave);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(284, 19);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 4;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            this.cbYear.Leave += new System.EventHandler(this.cbYear_Leave);
            // 
            // tab_byCar
            // 
            this.tab_byCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_byCar.Controls.Add(this.tp_ByMake);
            this.tab_byCar.Location = new System.Drawing.Point(12, 58);
            this.tab_byCar.Name = "tab_byCar";
            this.tab_byCar.SelectedIndex = 0;
            this.tab_byCar.Size = new System.Drawing.Size(645, 120);
            this.tab_byCar.TabIndex = 5;
            // 
            // tp_ByMake
            // 
            this.tp_ByMake.Controls.Add(this.cbTrim);
            this.tp_ByMake.Controls.Add(this.txtTrim);
            this.tp_ByMake.Controls.Add(this.lblYear);
            this.tp_ByMake.Controls.Add(this.lblModel);
            this.tp_ByMake.Controls.Add(this.lblMake);
            this.tp_ByMake.Controls.Add(this.cbMake);
            this.tp_ByMake.Controls.Add(this.btn_Add);
            this.tp_ByMake.Controls.Add(this.cbYear);
            this.tp_ByMake.Controls.Add(this.cbModel);
            this.tp_ByMake.Location = new System.Drawing.Point(4, 22);
            this.tp_ByMake.Name = "tp_ByMake";
            this.tp_ByMake.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ByMake.Size = new System.Drawing.Size(637, 94);
            this.tp_ByMake.TabIndex = 0;
            this.tp_ByMake.Text = "Selection";
            this.tp_ByMake.UseVisualStyleBackColor = true;
            // 
            // cbTrim
            // 
            this.cbTrim.FormattingEnabled = true;
            this.cbTrim.Location = new System.Drawing.Point(12, 63);
            this.cbTrim.Name = "cbTrim";
            this.cbTrim.Size = new System.Drawing.Size(328, 21);
            this.cbTrim.TabIndex = 14;
            // 
            // txtTrim
            // 
            this.txtTrim.AutoSize = true;
            this.txtTrim.Location = new System.Drawing.Point(12, 48);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(27, 13);
            this.txtTrim.TabIndex = 13;
            this.txtTrim.Text = "Trim";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(281, 3);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(144, 3);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 3);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "State";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(83, 23);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(80, 20);
            this.txtZip.TabIndex = 9;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZip_KeyPress);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(16, 23);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(59, 21);
            this.cbState.TabIndex = 8;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Location = new System.Drawing.Point(12, 344);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // F_Main
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_byCar);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.cbState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "F_Main";
            this.Text = "Car Compare Report";
            this.Load += new System.EventHandler(this.F_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_byCar.ResumeLayout(false);
            this.tp_ByMake.ResumeLayout(false);
            this.tp_ByMake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.TabControl tab_byCar;
        private System.Windows.Forms.TabPage tp_ByMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Label txtTrim;
        private System.Windows.Forms.ComboBox cbTrim;
    }
}

