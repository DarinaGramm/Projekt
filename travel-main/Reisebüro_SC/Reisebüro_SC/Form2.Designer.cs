namespace Reisebüro_SC
{
    partial class Buchung
    {
        /// <summary>
        /// 
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buchung));
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.TelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Reserve = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.E_Mail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(303, 42);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(297, 40);
            this.label.TabIndex = 0;
            this.label.Text = "Persönliche Angaben";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(199, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anrede *";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(310, 165);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(280, 37);
            this.Title.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(184, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vorname *";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(310, 242);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(280, 37);
            this.FirstName.TabIndex = 4;
            this.FirstName.Enter += new System.EventHandler(this.FirstName_Enter);
            this.FirstName.Leave += new System.EventHandler(this.FirstName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(673, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nachname *";
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(812, 242);
            this.Surname.Margin = new System.Windows.Forms.Padding(4);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(280, 37);
            this.Surname.TabIndex = 6;
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(144, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geburtsdatum *";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(310, 321);
            this.DateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfBirth.Mask = "0000/00/00";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(280, 36);
            this.DateOfBirth.SkipLiterals = false;
            this.DateOfBirth.TabIndex = 9;
            this.DateOfBirth.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneNumber.Location = new System.Drawing.Point(812, 321);
            this.TelephoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TelephoneNumber.Size = new System.Drawing.Size(280, 36);
            this.TelephoneNumber.TabIndex = 10;
            this.TelephoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(635, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefonnummer *";
            // 
            // Reserve
            // 
            this.Reserve.BackColor = System.Drawing.Color.AliceBlue;
            this.Reserve.Cursor = System.Windows.Forms.Cursors.Default;
            this.Reserve.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserve.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Reserve.Location = new System.Drawing.Point(874, 410);
            this.Reserve.Margin = new System.Windows.Forms.Padding(4);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(163, 38);
            this.Reserve.TabIndex = 14;
            this.Reserve.Text = "Buchen";
            this.Reserve.UseVisualStyleBackColor = false;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(140, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail-Adresse *";
            // 
            // E_Mail
            // 
            this.E_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_Mail.Location = new System.Drawing.Point(310, 405);
            this.E_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.E_Mail.Multiline = true;
            this.E_Mail.Name = "E_Mail";
            this.E_Mail.Size = new System.Drawing.Size(404, 36);
            this.E_Mail.TabIndex = 13;
            this.E_Mail.Enter += new System.EventHandler(this.E_Mail_Enter);
            this.E_Mail.Leave += new System.EventHandler(this.E_Mail_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(25, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "zurück";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1245, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.E_Mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelephoneNumber);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Buchung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchung";
            this.Load += new System.EventHandler(this.Buchung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox DateOfBirth;
        private System.Windows.Forms.MaskedTextBox TelephoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox E_Mail;
        private System.Windows.Forms.Button button1;
    }
}