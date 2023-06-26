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
            this.cbCountry = new System.Windows.Forms.ComboBox();
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
            this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(36, 162);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1532, 1240);
            this.flp.TabIndex = 10;
            // 
            // cbCountry
            // 
            this.cbCountry.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(36, 80);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(227, 28);
            this.cbCountry.TabIndex = 11;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(1316, 78);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(82, 33);
            this.search.TabIndex = 12;
            this.search.Text = "Suchen";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // cbNP
            // 
            this.cbNP.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNP.FormattingEnabled = true;
            this.cbNP.Location = new System.Drawing.Point(327, 80);
            this.cbNP.Name = "cbNP";
            this.cbNP.Size = new System.Drawing.Size(135, 28);
            this.cbNP.TabIndex = 13;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.BackColor = System.Drawing.Color.Transparent;
            this.country.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.country.Location = new System.Drawing.Point(33, 53);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(62, 22);
            this.country.TabIndex = 14;
            this.country.Text = "Länder";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number.Location = new System.Drawing.Point(323, 55);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(131, 22);
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
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fromLabel.Location = new System.Drawing.Point(713, 53);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(41, 22);
            this.fromLabel.TabIndex = 19;
            this.fromLabel.Text = "Von";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(717, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(1019, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 27);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toLabel.Location = new System.Drawing.Point(1015, 54);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(31, 22);
            this.toLabel.TabIndex = 22;
            this.toLabel.Text = "Bis";
            // 
            // cbPrice
            // 
            this.cbPrice.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(528, 80);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(136, 28);
            this.cbPrice.TabIndex = 23;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.costLabel.Location = new System.Drawing.Point(524, 54);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(46, 22);
            this.costLabel.TabIndex = 24;
            this.costLabel.Text = "Preis";
            // 
            // Reisebüro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
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
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.flp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reisebüro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reisebüro";
            this.Load += new System.EventHandler(this.Reisebüro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.ComboBox cbCountry;
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

