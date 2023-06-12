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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HotelName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TravelID
            // 
            this.TravelID.BackColor = System.Drawing.Color.Teal;
            this.TravelID.Location = new System.Drawing.Point(37, 354);
            this.TravelID.Name = "TravelID";
            this.TravelID.Size = new System.Drawing.Size(206, 48);
            this.TravelID.TabIndex = 0;
            this.TravelID.Text = "Zur Buchung";
            this.TravelID.UseVisualStyleBackColor = false;
            this.TravelID.Click += new System.EventHandler(this.ZurBuchung_Click);
            // 
            // Picture
            // 
            this.Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(37, 80);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(206, 143);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            // 
            // Place
            // 
            this.Place.BackColor = System.Drawing.Color.Teal;
            this.Place.Location = new System.Drawing.Point(37, 261);
            this.Place.Multiline = true;
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(206, 46);
            this.Place.TabIndex = 4;
            this.Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Place.TextChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // HotelName
            // 
            this.HotelName.BackColor = System.Drawing.Color.Teal;
            this.HotelName.Location = new System.Drawing.Point(37, 229);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(206, 26);
            this.HotelName.TabIndex = 7;
            this.HotelName.TextChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.Teal;
            this.Price.Location = new System.Drawing.Point(143, 313);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 26);
            this.Price.TabIndex = 8;
            this.Price.TextChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75717F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.24283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(305, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 790);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.TabIndexChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HotelName1,
            this.Place1,
            this.Price1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(247, 784);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.TabIndexChanged += new System.EventHandler(this.Reisebüro_Load);
            // 
            // Reisebüro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1061, 790);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.TravelID);
            this.Controls.Add(this.HotelName);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.Picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reisebüro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reisebüro";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TravelID;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.TextBox HotelName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader HotelName1;
        private System.Windows.Forms.ColumnHeader Place1;
        private System.Windows.Forms.ColumnHeader Price1;
    }
}

