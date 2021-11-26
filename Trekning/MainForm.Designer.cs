namespace Trekning
{
   partial class MainForm
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
         this.mainMeny = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.epostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.checkOgSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
         this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.sendButton = new System.Windows.Forms.Button();
         this.testButton = new System.Windows.Forms.Button();
         this.buttonSave = new System.Windows.Forms.Button();
         this.buttonLoad = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.vinterferie = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.paaske = new System.Windows.Forms.NumericUpDown();
         this.labelJul = new System.Windows.Forms.Label();
         this.jul = new System.Windows.Forms.NumericUpDown();
         this.buttonSjekk = new System.Windows.Forms.Button();
         this.buttonClear = new System.Windows.Forms.Button();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.dataGridViewTrekning = new System.Windows.Forms.DataGridView();
         this.userControlResultat = new UserControlResultat();
         this.vedlikehold = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.mainMeny.SuspendLayout();
         this.mainPanel.SuspendLayout();
         this.topPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.vinterferie)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.paaske)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.jul)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrekning)).BeginInit();
         this.SuspendLayout();
         // 
         // mainMeny
         // 
         this.mainMeny.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.epostToolStripMenuItem});
         this.mainMeny.Location = new System.Drawing.Point(0, 0);
         this.mainMeny.Name = "mainMeny";
         this.mainMeny.Size = new System.Drawing.Size(1118, 24);
         this.mainMeny.TabIndex = 0;
         this.mainMeny.Text = "MainMenu";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // loadToolStripMenuItem
         // 
         this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
         this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.loadToolStripMenuItem.Text = "Load";
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
         this.saveToolStripMenuItem.Text = "Save";
         // 
         // epostToolStripMenuItem
         // 
         this.epostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripMenuItem,
            this.checkOgSendToolStripMenuItem});
         this.epostToolStripMenuItem.Name = "epostToolStripMenuItem";
         this.epostToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
         this.epostToolStripMenuItem.Text = "Epost";
         // 
         // sendToolStripMenuItem
         // 
         this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
         this.sendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.sendToolStripMenuItem.Text = "Send";
         // 
         // checkOgSendToolStripMenuItem
         // 
         this.checkOgSendToolStripMenuItem.Name = "checkOgSendToolStripMenuItem";
         this.checkOgSendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.checkOgSendToolStripMenuItem.Text = "Check og send";
         // 
         // mainPanel
         // 
         this.mainPanel.ColumnCount = 1;
         this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.mainPanel.Controls.Add(this.topPanel, 0, 0);
         this.mainPanel.Controls.Add(this.splitContainer1, 0, 1);
         this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mainPanel.Location = new System.Drawing.Point(0, 24);
         this.mainPanel.Name = "mainPanel";
         this.mainPanel.RowCount = 2;
         this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.mainPanel.Size = new System.Drawing.Size(1118, 543);
         this.mainPanel.TabIndex = 1;
         // 
         // topPanel
         // 
         this.topPanel.AutoSize = true;
         this.topPanel.Controls.Add(this.sendButton);
         this.topPanel.Controls.Add(this.testButton);
         this.topPanel.Controls.Add(this.buttonSave);
         this.topPanel.Controls.Add(this.buttonLoad);
         this.topPanel.Controls.Add(this.label1);
         this.topPanel.Controls.Add(this.vinterferie);
         this.topPanel.Controls.Add(this.label2);
         this.topPanel.Controls.Add(this.paaske);
         this.topPanel.Controls.Add(this.labelJul);
         this.topPanel.Controls.Add(this.jul);
         this.topPanel.Controls.Add(this.buttonSjekk);
         this.topPanel.Controls.Add(this.buttonClear);
         this.topPanel.Controls.Add(this.label3);
         this.topPanel.Controls.Add(this.vedlikehold);
         this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.topPanel.Location = new System.Drawing.Point(3, 3);
         this.topPanel.Name = "topPanel";
         this.topPanel.Size = new System.Drawing.Size(1112, 29);
         this.topPanel.TabIndex = 0;
         // 
         // sendButton
         // 
         this.sendButton.AutoSize = true;
         this.sendButton.Location = new System.Drawing.Point(3, 3);
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
         this.testButton.Location = new System.Drawing.Point(88, 3);
         this.testButton.Name = "testButton";
         this.testButton.Size = new System.Drawing.Size(82, 23);
         this.testButton.TabIndex = 4;
         this.testButton.Text = "Test";
         this.testButton.UseVisualStyleBackColor = true;
         this.testButton.Click += new System.EventHandler(this.sendButton_Click);
         // 
         // buttonSave
         // 
         this.buttonSave.Location = new System.Drawing.Point(176, 3);
         this.buttonSave.Name = "buttonSave";
         this.buttonSave.Size = new System.Drawing.Size(75, 23);
         this.buttonSave.TabIndex = 2;
         this.buttonSave.Text = "Save";
         this.buttonSave.UseVisualStyleBackColor = true;
         this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
         // 
         // buttonLoad
         // 
         this.buttonLoad.Location = new System.Drawing.Point(257, 3);
         this.buttonLoad.Name = "buttonLoad";
         this.buttonLoad.Size = new System.Drawing.Size(75, 23);
         this.buttonLoad.TabIndex = 1;
         this.buttonLoad.Text = "Load data";
         this.buttonLoad.UseVisualStyleBackColor = true;
         this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
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
            15,
            0,
            0,
            0});
         // 
         // labelJul
         // 
         this.labelJul.AutoSize = true;
         this.labelJul.Location = new System.Drawing.Point(550, 0);
         this.labelJul.MinimumSize = new System.Drawing.Size(0, 26);
         this.labelJul.Name = "labelJul";
         this.labelJul.Size = new System.Drawing.Size(26, 26);
         this.labelJul.TabIndex = 0;
         this.labelJul.Text = "Jul: ";
         this.labelJul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // jul
         // 
         this.jul.Location = new System.Drawing.Point(582, 3);
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
            51,
            0,
            0,
            0});
         // 
         // buttonSjekk
         // 
         this.buttonSjekk.Location = new System.Drawing.Point(632, 3);
         this.buttonSjekk.Name = "buttonSjekk";
         this.buttonSjekk.Size = new System.Drawing.Size(75, 23);
         this.buttonSjekk.TabIndex = 9;
         this.buttonSjekk.Text = "Sjekk";
         this.buttonSjekk.UseVisualStyleBackColor = true;
         this.buttonSjekk.Click += new System.EventHandler(this.buttonSjekk_Click);
         // 
         // buttonClear
         // 
         this.buttonClear.Location = new System.Drawing.Point(713, 3);
         this.buttonClear.Name = "buttonClear";
         this.buttonClear.Size = new System.Drawing.Size(75, 23);
         this.buttonClear.TabIndex = 10;
         this.buttonClear.Text = "Clear";
         this.buttonClear.UseVisualStyleBackColor = true;
         this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(3, 38);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.dataGridViewPerson);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
         this.splitContainer1.Size = new System.Drawing.Size(1112, 502);
         this.splitContainer1.SplitterDistance = 473;
         this.splitContainer1.TabIndex = 1;
         // 
         // dataGridViewPerson
         // 
         this.dataGridViewPerson.AllowDrop = true;
         this.dataGridViewPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridViewPerson.Location = new System.Drawing.Point(0, 0);
         this.dataGridViewPerson.Name = "dataGridViewPerson";
         this.dataGridViewPerson.Size = new System.Drawing.Size(473, 502);
         this.dataGridViewPerson.TabIndex = 1;
         this.dataGridViewPerson.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewPerson_DragDrop);
         this.dataGridViewPerson.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewPerson_DragOver);
         // 
         // splitContainer2
         // 
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.dataGridViewTrekning);
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.userControlResultat);
         this.splitContainer2.Size = new System.Drawing.Size(635, 502);
         this.splitContainer2.SplitterDistance = 166;
         this.splitContainer2.TabIndex = 0;
         // 
         // dataGridViewTrekning
         // 
         this.dataGridViewTrekning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dataGridViewTrekning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridViewTrekning.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridViewTrekning.Location = new System.Drawing.Point(0, 0);
         this.dataGridViewTrekning.Name = "dataGridViewTrekning";
         this.dataGridViewTrekning.Size = new System.Drawing.Size(166, 502);
         this.dataGridViewTrekning.TabIndex = 1;
         // 
         // userControlResultat
         // 
         this.userControlResultat.Dock = System.Windows.Forms.DockStyle.Fill;
         this.userControlResultat.Location = new System.Drawing.Point(0, 0);
         this.userControlResultat.Name = "userControlResultat";
         this.userControlResultat.Size = new System.Drawing.Size(465, 502);
         this.userControlResultat.TabIndex = 0;
         // 
         // vedlikehold
         // 
         this.vedlikehold.Location = new System.Drawing.Point(868, 3);
         this.vedlikehold.Name = "vedlikehold";
         this.vedlikehold.Size = new System.Drawing.Size(231, 20);
         this.vedlikehold.TabIndex = 11;
         this.vedlikehold.Text = "4,10";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(794, 0);
         this.label3.MinimumSize = new System.Drawing.Size(0, 26);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(68, 26);
         this.label3.TabIndex = 12;
         this.label3.Text = "Vedlikehold: ";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1118, 567);
         this.Controls.Add(this.mainPanel);
         this.Controls.Add(this.mainMeny);
         this.MainMenuStrip = this.mainMeny;
         this.Name = "MainForm";
         this.Text = "MainForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonForm_FormClosing);
         this.mainMeny.ResumeLayout(false);
         this.mainMeny.PerformLayout();
         this.mainPanel.ResumeLayout(false);
         this.mainPanel.PerformLayout();
         this.topPanel.ResumeLayout(false);
         this.topPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.vinterferie)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.paaske)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.jul)).EndInit();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrekning)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip mainMeny;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem epostToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem checkOgSendToolStripMenuItem;
      private System.Windows.Forms.TableLayoutPanel mainPanel;
      private System.Windows.Forms.FlowLayoutPanel topPanel;
      private System.Windows.Forms.Label label1;
      public System.Windows.Forms.NumericUpDown jul;
      private System.Windows.Forms.Label labelJul;
      private System.Windows.Forms.NumericUpDown paaske;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown vinterferie;
      private System.Windows.Forms.Button sendButton;
      private System.Windows.Forms.Button testButton;
      private System.Windows.Forms.Button buttonSave;
      private System.Windows.Forms.Button buttonLoad;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.DataGridView dataGridViewPerson;
      private System.Windows.Forms.DataGridView dataGridViewTrekning;
      private System.Windows.Forms.Button buttonSjekk;
      private UserControlResultat userControlResultat;
      private System.Windows.Forms.Button buttonClear;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox vedlikehold;
   }
}