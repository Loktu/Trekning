namespace ReplyToMany
{
    partial class ReplyForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.orginalText = new System.Windows.Forms.CheckBox();
            this.confirmAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.acceptedOnly = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(717, 379);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.description);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 110);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Red;
            this.description.Location = new System.Drawing.Point(3, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(677, 31);
            this.description.TabIndex = 0;
            this.description.Text = "Her kan du svare på alle valgte e-poster i en operasjon.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hvis du velger et møte, blir det sendt purring til de som ikke har svart.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Skriv en melding i tekstboksen under.  (<navn>, <fornavn> og <etternavn> blir " +
    "erstattet)\r\n2. Velg flere e-poster eller ett møte i outlook.\r\n3. Trykk Send og h" +
    "åp det beste.\r\n";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.orginalText);
            this.flowLayoutPanel2.Controls.Add(this.confirmAll);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.acceptedOnly);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 347);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(711, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // orginalText
            // 
            this.orginalText.AutoSize = true;
            this.orginalText.Location = new System.Drawing.Point(3, 3);
            this.orginalText.Name = "orginalText";
            this.orginalText.Size = new System.Drawing.Size(115, 17);
            this.orginalText.TabIndex = 2;
            this.orginalText.Text = "Include orginal text";
            this.orginalText.UseVisualStyleBackColor = true;
            // 
            // confirmAll
            // 
            this.confirmAll.AutoSize = true;
            this.confirmAll.Location = new System.Drawing.Point(124, 3);
            this.confirmAll.Name = "confirmAll";
            this.confirmAll.Size = new System.Drawing.Size(74, 17);
            this.confirmAll.TabIndex = 4;
            this.confirmAll.Text = "Confirm all";
            this.confirmAll.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(3, 119);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(711, 222);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "Skriv en melding her:\r\nHei <fornavn>\r\n";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // acceptedOnly
            // 
            this.acceptedOnly.AutoSize = true;
            this.acceptedOnly.Location = new System.Drawing.Point(285, 3);
            this.acceptedOnly.Name = "acceptedOnly";
            this.acceptedOnly.Size = new System.Drawing.Size(140, 17);
            this.acceptedOnly.TabIndex = 5;
            this.acceptedOnly.Text = "Accepted only (meeting)";
            this.acceptedOnly.UseVisualStyleBackColor = true;
            // 
            // ReplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 379);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ReplyForm";
            this.Text = "Reply";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox orginalText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox confirmAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox acceptedOnly;
    }
}

