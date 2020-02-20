namespace Serpientes_Escaleras
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.btn_jugar = new System.Windows.Forms.Button();
            this.btn_como = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jugar
            // 
            this.btn_jugar.BackColor = System.Drawing.Color.Transparent;
            this.btn_jugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_jugar.BackgroundImage")));
            this.btn_jugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_jugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_jugar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jugar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_jugar.Location = new System.Drawing.Point(3, 490);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(115, 57);
            this.btn_jugar.TabIndex = 0;
            this.btn_jugar.UseVisualStyleBackColor = false;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // btn_como
            // 
            this.btn_como.BackColor = System.Drawing.Color.Transparent;
            this.btn_como.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_como.BackgroundImage")));
            this.btn_como.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_como.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_como.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_como.ForeColor = System.Drawing.Color.White;
            this.btn_como.Location = new System.Drawing.Point(124, 490);
            this.btn_como.Name = "btn_como";
            this.btn_como.Size = new System.Drawing.Size(142, 57);
            this.btn_como.TabIndex = 1;
            this.btn_como.UseVisualStyleBackColor = false;
            this.btn_como.Click += new System.EventHandler(this.btn_como_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(536, 490);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(105, 57);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(278, 266);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 200);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(584, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_como);
            this.Controls.Add(this.btn_jugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serpientes y escaleras bien PRO";
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.Button btn_como;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}