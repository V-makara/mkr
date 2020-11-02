namespace Lesson_8
{
    partial class Form1
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
            this.txb_Tuner = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rtxb_Tuner = new System.Windows.Forms.RichTextBox();
            this.txb_Note = new System.Windows.Forms.TextBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.rtxb_note = new System.Windows.Forms.RichTextBox();
            this.Combo_condition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txb_Tuner
            // 
            this.txb_Tuner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txb_Tuner.Location = new System.Drawing.Point(388, 50);
            this.txb_Tuner.Name = "txb_Tuner";
            this.txb_Tuner.Size = new System.Drawing.Size(614, 116);
            this.txb_Tuner.TabIndex = 0;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_Ok.Location = new System.Drawing.Point(1049, 50);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(287, 116);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl1.Location = new System.Drawing.Point(44, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(295, 108);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Tuner";
            // 
            // rtxb_Tuner
            // 
            this.rtxb_Tuner.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.rtxb_Tuner.Location = new System.Drawing.Point(61, 365);
            this.rtxb_Tuner.Name = "rtxb_Tuner";
            this.rtxb_Tuner.Size = new System.Drawing.Size(490, 819);
            this.rtxb_Tuner.TabIndex = 3;
            this.rtxb_Tuner.Text = "";
            // 
            // txb_Note
            // 
            this.txb_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.txb_Note.Location = new System.Drawing.Point(61, 201);
            this.txb_Note.Name = "txb_Note";
            this.txb_Note.Size = new System.Drawing.Size(490, 116);
            this.txb_Note.TabIndex = 4;
            // 
            // btn_Go
            // 
            this.btn_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btn_Go.Location = new System.Drawing.Point(1123, 201);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(213, 116);
            this.btn_Go.TabIndex = 6;
            this.btn_Go.Text = "GO";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtxb_note
            // 
            this.rtxb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.rtxb_note.Location = new System.Drawing.Point(597, 365);
            this.rtxb_note.Name = "rtxb_note";
            this.rtxb_note.Size = new System.Drawing.Size(739, 819);
            this.rtxb_note.TabIndex = 7;
            this.rtxb_note.Text = "";
            // 
            // Combo_condition
            // 
            this.Combo_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Combo_condition.FormattingEnabled = true;
            this.Combo_condition.Location = new System.Drawing.Point(597, 201);
            this.Combo_condition.Name = "Combo_condition";
            this.Combo_condition.Size = new System.Drawing.Size(489, 116);
            this.Combo_condition.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 1287);
            this.Controls.Add(this.Combo_condition);
            this.Controls.Add(this.rtxb_note);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.txb_Note);
            this.Controls.Add(this.rtxb_Tuner);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txb_Tuner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Tuner;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RichTextBox rtxb_Tuner;
        private System.Windows.Forms.TextBox txb_Note;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.RichTextBox rtxb_note;
        private System.Windows.Forms.ComboBox Combo_condition;
    }
}

