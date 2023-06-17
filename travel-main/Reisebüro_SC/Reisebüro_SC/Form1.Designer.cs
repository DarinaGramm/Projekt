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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reisebüro));
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.cbNP = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fromLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(36, 162);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1481, 817);
            this.flp.TabIndex = 10;
            // 
            // cbPlace
            // 
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(36, 76);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(202, 24);
            this.cbPlace.TabIndex = 11;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1324, 73);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 12;
            this.search.Text = "Suchen";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // cbNP
            // 
            this.cbNP.FormattingEnabled = true;
            this.cbNP.Location = new System.Drawing.Point(302, 73);
            this.cbNP.Name = "cbNP";
            this.cbNP.Size = new System.Drawing.Size(135, 24);
            this.cbNP.TabIndex = 13;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(33, 53);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(53, 17);
            this.country.TabIndex = 14;
            this.country.Text = "Länder";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(299, 55);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(104, 16);
            this.number.TabIndex = 15;
            this.number.Text = "Personenanzahl";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(713, 53);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(31, 16);
            this.fromLabel.TabIndex = 19;
            this.fromLabel.Text = "Von";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1018, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(1015, 54);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(26, 16);
            this.toLabel.TabIndex = 22;
            this.toLabel.Text = "Bis";
            // 
            // cbPrice
            // 
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(501, 74);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(158, 24);
            this.cbPrice.TabIndex = 23;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(498, 54);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(38, 16);
            this.costLabel.TabIndex = 24;
            this.costLabel.Text = "Preis";
            // 
            // Reisebüro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1431, 632);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.number);
            this.Controls.Add(this.country);
            this.Controls.Add(this.cbNP);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.flp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reisebüro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reisebüro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox cbNP;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.Label costLabel;
    }
}

