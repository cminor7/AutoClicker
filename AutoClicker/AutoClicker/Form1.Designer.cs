
namespace AutoClicker
{
    partial class ClickForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickForm));
            this.ConsoleText = new System.Windows.Forms.RichTextBox();
            this.ECPath = new System.Windows.Forms.TextBox();
            this.ECFile = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.XLab = new System.Windows.Forms.Label();
            this.YLab = new System.Windows.Forms.Label();
            this.XCoord = new System.Windows.Forms.Label();
            this.YCoord = new System.Windows.Forms.Label();
            this.Commands = new System.Windows.Forms.ComboBox();
            this.ScreenCap = new System.Windows.Forms.Button();
            this.Loops = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loadSeq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsoleText
            // 
            this.ConsoleText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ConsoleText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConsoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleText.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleText.Location = new System.Drawing.Point(-1, 0);
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.Size = new System.Drawing.Size(615, 296);
            this.ConsoleText.TabIndex = 1;
            this.ConsoleText.TabStop = false;
            this.ConsoleText.Text = "";
            // 
            // ECPath
            // 
            this.ECPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECPath.Location = new System.Drawing.Point(4, 327);
            this.ECPath.Name = "ECPath";
            this.ECPath.ReadOnly = true;
            this.ECPath.Size = new System.Drawing.Size(227, 24);
            this.ECPath.TabIndex = 2;
            this.ECPath.TabStop = false;
            // 
            // ECFile
            // 
            this.ECFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ECFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ECFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECFile.Location = new System.Drawing.Point(237, 326);
            this.ECFile.Name = "ECFile";
            this.ECFile.Size = new System.Drawing.Size(72, 29);
            this.ECFile.TabIndex = 3;
            this.ECFile.TabStop = false;
            this.ECFile.Text = "Browse";
            this.ECFile.UseVisualStyleBackColor = true;
            this.ECFile.Click += new System.EventHandler(this.ECFile_Click);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.PaleGreen;
            this.Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Location = new System.Drawing.Point(272, 389);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 29);
            this.Execute.TabIndex = 4;
            this.Execute.TabStop = false;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(532, 350);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 29);
            this.Add.TabIndex = 9;
            this.Add.TabStop = false;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "CSV";
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(183, 389);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 29);
            this.ClearAll.TabIndex = 14;
            this.ClearAll.TabStop = false;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = false;
            // 
            // Undo
            // 
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo.Location = new System.Drawing.Point(532, 389);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 29);
            this.Undo.TabIndex = 20;
            this.Undo.TabStop = false;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // XLab
            // 
            this.XLab.AutoSize = true;
            this.XLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLab.Location = new System.Drawing.Point(394, 311);
            this.XLab.Name = "XLab";
            this.XLab.Size = new System.Drawing.Size(31, 24);
            this.XLab.TabIndex = 22;
            this.XLab.Text = "X:";
            // 
            // YLab
            // 
            this.YLab.AutoSize = true;
            this.YLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLab.Location = new System.Drawing.Point(482, 311);
            this.YLab.Name = "YLab";
            this.YLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YLab.Size = new System.Drawing.Size(29, 24);
            this.YLab.TabIndex = 23;
            this.YLab.Text = "Y:";
            // 
            // XCoord
            // 
            this.XCoord.AutoSize = true;
            this.XCoord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.XCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCoord.ForeColor = System.Drawing.Color.Lime;
            this.XCoord.Location = new System.Drawing.Point(421, 311);
            this.XCoord.Name = "XCoord";
            this.XCoord.Size = new System.Drawing.Size(20, 24);
            this.XCoord.TabIndex = 24;
            this.XCoord.Text = "0";
            // 
            // YCoord
            // 
            this.YCoord.AutoSize = true;
            this.YCoord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YCoord.ForeColor = System.Drawing.Color.Lime;
            this.YCoord.Location = new System.Drawing.Point(506, 311);
            this.YCoord.Name = "YCoord";
            this.YCoord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YCoord.Size = new System.Drawing.Size(20, 24);
            this.YCoord.TabIndex = 25;
            this.YCoord.Text = "0";
            // 
            // Commands
            // 
            this.Commands.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Commands.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Commands.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Commands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commands.FormattingEnabled = true;
            this.Commands.Items.AddRange(new object[] {
            "lclick",
            "rclick",
            "moveto",
            "copy",
            "copyall",
            "sclick",
            "imgwait",
            "timewait"});
            this.Commands.Location = new System.Drawing.Point(389, 351);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(139, 28);
            this.Commands.TabIndex = 27;
            // 
            // ScreenCap
            // 
            this.ScreenCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ScreenCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScreenCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScreenCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenCap.Location = new System.Drawing.Point(353, 389);
            this.ScreenCap.Name = "ScreenCap";
            this.ScreenCap.Size = new System.Drawing.Size(95, 29);
            this.ScreenCap.TabIndex = 32;
            this.ScreenCap.TabStop = false;
            this.ScreenCap.Text = "ScreenCap";
            this.ScreenCap.UseVisualStyleBackColor = false;
            this.ScreenCap.Click += new System.EventHandler(this.ScreenCap_Click);
            // 
            // Loops
            // 
            this.Loops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loops.Location = new System.Drawing.Point(73, 366);
            this.Loops.MaxLength = 6;
            this.Loops.Name = "Loops";
            this.Loops.Size = new System.Drawing.Size(61, 26);
            this.Loops.TabIndex = 33;
            this.Loops.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Loops:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(158, 357);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 19);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Headers";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // loadSeq
            // 
            this.loadSeq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadSeq.Location = new System.Drawing.Point(454, 389);
            this.loadSeq.Name = "loadSeq";
            this.loadSeq.Size = new System.Drawing.Size(72, 29);
            this.loadSeq.TabIndex = 37;
            this.loadSeq.TabStop = false;
            this.loadSeq.Text = "Load";
            this.loadSeq.UseVisualStyleBackColor = true;
            this.loadSeq.Click += new System.EventHandler(this.loadSeq_Click);
            // 
            // ClickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 425);
            this.Controls.Add(this.loadSeq);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loops);
            this.Controls.Add(this.ScreenCap);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.YCoord);
            this.Controls.Add(this.XCoord);
            this.Controls.Add(this.YLab);
            this.Controls.Add(this.XLab);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.ECFile);
            this.Controls.Add(this.ECPath);
            this.Controls.Add(this.ConsoleText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClickForm";
            this.Text = "AutoClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ConsoleText;
        private System.Windows.Forms.TextBox ECPath;
        private System.Windows.Forms.Button ECFile;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Label XLab;
        private System.Windows.Forms.Label YLab;
        private System.Windows.Forms.Label XCoord;
        private System.Windows.Forms.Label YCoord;
        private System.Windows.Forms.ComboBox Commands;
        private System.Windows.Forms.Button ScreenCap;
        private System.Windows.Forms.TextBox Loops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button loadSeq;
    }
}

