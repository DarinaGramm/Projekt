namespace Reisebüro_SC
{
    partial class Buchung
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
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(128, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(179, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Persönliche Angaben";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(144, 77);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(156, 26);
            this.Title.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anrede *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vorname *";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(144, 123);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(156, 26);
            this.FirstName.TabIndex = 4;
            this.FirstName.Enter += new System.EventHandler(this.FirstName_Enter);
            this.FirstName.Leave += new System.EventHandler(this.FirstName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nachname *";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(144, 170);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(156, 26);
            this.Surname.TabIndex = 6;
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geburtsdatum *";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(144, 215);
            this.DateOfBirth.Mask = "0000/00/00";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(156, 26);
            this.DateOfBirth.TabIndex = 9;
            this.DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.Location = new System.Drawing.Point(144, 256);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TelephoneNumber.Size = new System.Drawing.Size(156, 26);
            this.TelephoneNumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefonnummer *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail-Adresse *";
            // 
            // E_Mail
            // 
            this.E_Mail.Location = new System.Drawing.Point(144, 304);
            this.E_Mail.Name = "E_Mail";
            this.E_Mail.Size = new System.Drawing.Size(156, 26);
            this.E_Mail.TabIndex = 13;
            this.E_Mail.Enter += new System.EventHandler(this.E_Mail_Enter);
            this.E_Mail.Leave += new System.EventHandler(this.E_Mail_Leave);
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(168, 363);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(104, 53);
            this.Reserve.TabIndex = 14;
            this.Reserve.Text = "buchen";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Buchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(813, 564);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buchung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchung";
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
    }
}