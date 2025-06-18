namespace RS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonKitchen = new System.Windows.Forms.Button();
            this.buttonPOS = new System.Windows.Forms.Button();
            this.buttonStaf = new System.Windows.Forms.Button();
            this.buttonTables = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(93)))));
            this.panelButtons.Controls.Add(this.buttonCategories);
            this.panelButtons.Controls.Add(this.buttonHome);
            this.panelButtons.Controls.Add(this.buttonSettings);
            this.panelButtons.Controls.Add(this.buttonKitchen);
            this.panelButtons.Controls.Add(this.buttonPOS);
            this.panelButtons.Controls.Add(this.buttonStaf);
            this.panelButtons.Controls.Add(this.buttonTables);
            this.panelButtons.Controls.Add(this.buttonProducts);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.pictureBox1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(196, 749);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::RS.Properties.Resources.settings1;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(29, 531);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(167, 51);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "    Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Restaurant\r\nManagement System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.labelUser);
            this.panel2.Controls.Add(this.buttonMin);
            this.panel2.Controls.Add(this.buttonMax);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(196, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 54);
            this.panel2.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(27, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(52, 21);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "label2";
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(196, 54);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1170, 695);
            this.ContainerPanel.TabIndex = 2;
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(152)))), ((int)(((byte)(167)))));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.Location = new System.Drawing.Point(999, 12);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(49, 33);
            this.buttonMin.TabIndex = 0;
            this.buttonMin.UseVisualStyleBackColor = false;
            // 
            // buttonMax
            // 
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(152)))), ((int)(((byte)(167)))));
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Image = ((System.Drawing.Image)(resources.GetObject("buttonMax.Image")));
            this.buttonMax.Location = new System.Drawing.Point(1054, 12);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(49, 33);
            this.buttonMax.TabIndex = 0;
            this.buttonMax.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(152)))), ((int)(((byte)(167)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1109, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.BackColor = System.Drawing.Color.Transparent;
            this.buttonCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCategories.FlatAppearance.BorderSize = 0;
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategories.ForeColor = System.Drawing.Color.White;
            this.buttonCategories.Image = ((System.Drawing.Image)(resources.GetObject("buttonCategories.Image")));
            this.buttonCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategories.Location = new System.Drawing.Point(29, 189);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(167, 51);
            this.buttonCategories.TabIndex = 5;
            this.buttonCategories.Text = "    Categories";
            this.buttonCategories.UseVisualStyleBackColor = false;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(29, 132);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(167, 51);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "      Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonKitchen
            // 
            this.buttonKitchen.BackColor = System.Drawing.Color.Transparent;
            this.buttonKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKitchen.FlatAppearance.BorderSize = 0;
            this.buttonKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKitchen.ForeColor = System.Drawing.Color.White;
            this.buttonKitchen.Image = ((System.Drawing.Image)(resources.GetObject("buttonKitchen.Image")));
            this.buttonKitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKitchen.Location = new System.Drawing.Point(29, 474);
            this.buttonKitchen.Name = "buttonKitchen";
            this.buttonKitchen.Size = new System.Drawing.Size(167, 51);
            this.buttonKitchen.TabIndex = 5;
            this.buttonKitchen.Text = "    Kitchen";
            this.buttonKitchen.UseVisualStyleBackColor = false;
            this.buttonKitchen.Click += new System.EventHandler(this.buttonKitchen_Click);
            // 
            // buttonPOS
            // 
            this.buttonPOS.BackColor = System.Drawing.Color.Transparent;
            this.buttonPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPOS.FlatAppearance.BorderSize = 0;
            this.buttonPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPOS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPOS.Image = ((System.Drawing.Image)(resources.GetObject("buttonPOS.Image")));
            this.buttonPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPOS.Location = new System.Drawing.Point(29, 417);
            this.buttonPOS.Name = "buttonPOS";
            this.buttonPOS.Size = new System.Drawing.Size(167, 51);
            this.buttonPOS.TabIndex = 5;
            this.buttonPOS.Text = "    POS";
            this.buttonPOS.UseVisualStyleBackColor = false;
            this.buttonPOS.Click += new System.EventHandler(this.buttonPOS_Click);
            // 
            // buttonStaf
            // 
            this.buttonStaf.BackColor = System.Drawing.Color.Transparent;
            this.buttonStaf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStaf.FlatAppearance.BorderSize = 0;
            this.buttonStaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaf.ForeColor = System.Drawing.Color.White;
            this.buttonStaf.Image = ((System.Drawing.Image)(resources.GetObject("buttonStaf.Image")));
            this.buttonStaf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStaf.Location = new System.Drawing.Point(29, 360);
            this.buttonStaf.Name = "buttonStaf";
            this.buttonStaf.Size = new System.Drawing.Size(167, 51);
            this.buttonStaf.TabIndex = 5;
            this.buttonStaf.Text = "    Staf";
            this.buttonStaf.UseVisualStyleBackColor = false;
            this.buttonStaf.Click += new System.EventHandler(this.buttonStaf_Click);
            // 
            // buttonTables
            // 
            this.buttonTables.BackColor = System.Drawing.Color.Transparent;
            this.buttonTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTables.FlatAppearance.BorderSize = 0;
            this.buttonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTables.ForeColor = System.Drawing.Color.White;
            this.buttonTables.Image = ((System.Drawing.Image)(resources.GetObject("buttonTables.Image")));
            this.buttonTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTables.Location = new System.Drawing.Point(29, 303);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(167, 51);
            this.buttonTables.TabIndex = 5;
            this.buttonTables.Text = "    Tables";
            this.buttonTables.UseVisualStyleBackColor = false;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.Transparent;
            this.buttonProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(29, 246);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(167, 51);
            this.buttonProducts.TabIndex = 5;
            this.buttonProducts.Text = "    Products";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonKitchen;
        private System.Windows.Forms.Button buttonPOS;
        private System.Windows.Forms.Button buttonStaf;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Label labelUser;
    }
}