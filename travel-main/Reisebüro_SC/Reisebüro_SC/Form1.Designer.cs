namespace Reisebüro_SC
{
    partial class Reisebüro
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reisebüro));
            this.TravelID = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Place = new System.Windows.Forms.TextBox();
            this.HotelName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TravelID
            // 
            this.TravelID.BackColor = System.Drawing.Color.Teal;
            this.TravelID.Location = new System.Drawing.Point(44, 258);
            this.TravelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TravelID.Name = "TravelID";
            this.TravelID.Size = new System.Drawing.Size(183, 38);
            this.TravelID.TabIndex = 0;
            this.TravelID.Text = "Zur Buchung";
            this.TravelID.UseVisualStyleBackColor = false;
            this.TravelID.Click += new System.EventHandler(this.ZurBuchung_Click);
            // 
            // Picture
            // 
            this.Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(44, 26);
            this.Picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(183, 115);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            // 
            // Place
            // 
            this.Place.BackColor = System.Drawing.Color.Teal;
            this.Place.Location = new System.Drawing.Point(44, 184);
            this.Place.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Place.Multiline = true;
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(184, 38);
            this.Place.TabIndex = 4;
            this.Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Place.TextChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // HotelName
            // 
            this.HotelName.BackColor = System.Drawing.Color.Teal;
            this.HotelName.Location = new System.Drawing.Point(44, 158);
            this.HotelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(184, 22);
            this.HotelName.TabIndex = 7;
            this.HotelName.TextChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.Teal;
            this.Price.Location = new System.Drawing.Point(138, 225);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(89, 22);
            this.Price.TabIndex = 8;
            this.Price.TextChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1147, 419);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Controls.Add(this.Place);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.HotelName);
            this.panel1.Controls.Add(this.TravelID);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 328);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 55);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1144, 40);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // Reisebüro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1171, 632);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reisebüro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reisebüro";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TravelID;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.TextBox HotelName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

