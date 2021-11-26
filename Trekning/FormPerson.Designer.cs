namespace Trekning
{
    partial class FormPerson
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
         this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.buttonLoad = new System.Windows.Forms.Button();
         this.buttonSave = new System.Windows.Forms.Button();
         this.sendButton = new System.Windows.Forms.Button();
         this.testButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.vinterferie = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.paaske = new System.Windows.Forms.NumericUpDown();
         this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
         this.labelJul = new System.Windows.Forms.Label();
         this.jul = new System.Windows.Forms.NumericUpDown();
         this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
         this.tableLayoutPanel1.SuspendLayout();
         this.flowLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.vinterferie)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.paaske)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.jul)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridViewPerson
         // 
         this.dataGridViewPerson.AllowDrop = true;
         this.dataGridViewPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridViewPerson.Location = new System.Drawing.Point(3, 38);
         this.dataGridViewPerson.Name = "dataGridViewPerson";
         this.dataGridViewPerson.Size = new System.Drawing.Size(741, 365);
         this.dataGridViewPerson.TabIndex = 0;
         this.dataGridViewPerson.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewPerson_DragDrop);
         this.dataGridViewPerson.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewPerson_DragOver);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.dataGridViewPerson, 0, 1);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 406);
         this.tableLayoutPanel1.TabIndex = 2;
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.AutoSize = true;
         this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
         this.flowLayoutPanel1.Controls.Add(this.buttonSave);
         this.flowLayoutPanel1.Controls.Add(this.sendButton);
         this.flowLayoutPanel1.Controls.Add(this.testButton);
         this.flowLayoutPanel1.Controls.Add(this.label1);
         this.flowLayoutPanel1.Controls.Add(this.vinterferie);
         this.flowLayoutPanel1.Controls.Add(this.label2);
         this.flowLayoutPanel1.Controls.Add(this.paaske);
         this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
         this.flowLayoutPanel1.Controls.Add(this.labelJul);
         this.flowLayoutPanel1.Controls.Add(this.jul);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(741, 29);
         this.flowLayoutPanel1.TabIndex = 1;
         // 
         // buttonLoad
         // 
         this.buttonLoad.Location = new System.Drawing.Point(3, 3);
         this.buttonLoad.Name = "buttonLoad";
         this.buttonLoad.Size = new System.Drawing.Size(75, 23);
         this.buttonLoad.TabIndex = 1;
         this.buttonLoad.Text = "Load data";
         this.buttonLoad.UseVisualStyleBackColor = true;
         this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
         // 
         // buttonSave
         // 
         this.buttonSave.Location = new System.Drawing.Point(84, 3);
         this.buttonSave.Name = "buttonSave";
         this.buttonSave.Size = new System.Drawing.Size(75, 23);
         this.buttonSave.TabIndex = 2;
         this.buttonSave.Text = "Save";
         this.buttonSave.UseVisualStyleBackColor = true;
         this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
         // 
         // sendButton
         // 
         this.sendButton.AutoSize = true;
         this.sendButton.Location = new System.Drawing.Point(165, 3);
         this.sendButton.Name = "sendButton";
         this.sendButton.Size = new System.Drawing.Size(79, 23);
         this.sendButton.TabIndex = 3;
         this.sendButton.Text = "Send resultat";
         this.sendButton.UseVisualStyleBackColor = true;
         this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
         // 
         // testButton
         // 
         this.testButton.AutoSize = true;
         this.testButton.Location = new System.Drawing.Point(250, 3);
         this.testButton.Name = "testButton";
         this.testButton.Size = new System.Drawing.Size(82, 23);
         this.testButton.TabIndex = 4;
         this.testButton.Text = "Test";
         this.testButton.UseVisualStyleBackColor = true;
         this.testButton.Click += new System.EventHandler(this.sendButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(338, 0);
         this.label1.MinimumSize = new System.Drawing.Size(0, 26);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 26);
         this.label1.TabIndex = 5;
         this.label1.Text = "Vinterferie:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // vinterferie
         // 
         this.vinterferie.Location = new System.Drawing.Point(401, 3);
         this.vinterferie.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
         this.vinterferie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.vinterferie.Name = "vinterferie";
         this.vinterferie.Size = new System.Drawing.Size(44, 20);
         this.vinterferie.TabIndex = 6;
         this.vinterferie.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(451, 0);
         this.label2.MinimumSize = new System.Drawing.Size(0, 26);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(43, 26);
         this.label2.TabIndex = 7;
         this.label2.Text = "Påske: ";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // paaske
         // 
         this.paaske.Location = new System.Drawing.Point(500, 3);
         this.paaske.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
         this.paaske.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.paaske.Name = "paaske";
         this.paaske.Size = new System.Drawing.Size(44, 20);
         this.paaske.TabIndex = 8;
         this.paaske.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
         // 
         // flowLayoutPanel2
         // 
         this.flowLayoutPanel2.AutoSize = true;
         this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayoutPanel2.Location = new System.Drawing.Point(550, 3);
         this.flowLayoutPanel2.Name = "flowLayoutPanel2";
         this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 23);
         this.flowLayoutPanel2.TabIndex = 9;
         // 
         // labelJul
         // 
         this.labelJul.AutoSize = true;
         this.labelJul.Location = new System.Drawing.Point(556, 0);
         this.labelJul.MinimumSize = new System.Drawing.Size(0, 26);
         this.labelJul.Name = "labelJul";
         this.labelJul.Size = new System.Drawing.Size(26, 26);
         this.labelJul.TabIndex = 0;
         this.labelJul.Text = "Jul: ";
         this.labelJul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // jul
         // 
         this.jul.Location = new System.Drawing.Point(588, 3);
         this.jul.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
         this.jul.Minimum = new decimal(new int[] {
            51,
            0,
            0,
            0});
         this.jul.Name = "jul";
         this.jul.Size = new System.Drawing.Size(44, 20);
         this.jul.TabIndex = 1;
         this.jul.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
         // 
         // FormPerson
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(747, 406);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "FormPerson";
         this.Text = "Person";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonForm_FormClosing);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.vinterferie)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.paaske)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.jul)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown vinterferie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown paaske;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelJul;
        public System.Windows.Forms.NumericUpDown jul;
    }
}

