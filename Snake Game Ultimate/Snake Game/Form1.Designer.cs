namespace Snake_Game
{
    partial class Snake_Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nivel_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.nivel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Puntos_Snake = new System.Windows.Forms.ToolStripStatusLabel();
            this.Start = new System.Windows.Forms.Label();
            this.cmd_archivo = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::Snake_Game.Properties.Resources._1367888813926s;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivel_label,
            this.nivel,
            this.toolStripStatusLabel1,
            this.Puntos_Snake});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(299, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // nivel_label
            // 
            this.nivel_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nivel_label.Name = "nivel_label";
            this.nivel_label.Size = new System.Drawing.Size(43, 17);
            this.nivel_label.Text = "Nivel:  ";
            // 
            // nivel
            // 
            this.nivel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(13, 17);
            this.nivel.Text = "1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Puntos: ";
            // 
            // Puntos_Snake
            // 
            this.Puntos_Snake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Puntos_Snake.Name = "Puntos_Snake";
            this.Puntos_Snake.Size = new System.Drawing.Size(13, 17);
            this.Puntos_Snake.Text = "0";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(27, 135);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(251, 20);
            this.Start.TabIndex = 1;
            this.Start.Text = "Barra Espaciadora para iniciar";
            // 
            // cmd_archivo
            // 
            this.cmd_archivo.Location = new System.Drawing.Point(100, 276);
            this.cmd_archivo.Name = "cmd_archivo";
            this.cmd_archivo.Size = new System.Drawing.Size(96, 20);
            this.cmd_archivo.TabIndex = 2;
            this.cmd_archivo.Text = "Guardar Puntos";
            this.cmd_archivo.UseVisualStyleBackColor = true;
            this.cmd_archivo.Click += new System.EventHandler(this.cmd_archivo_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(100, 250);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(96, 20);
            this.nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nombre.Location = new System.Drawing.Point(123, 234);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // Snake_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Snake_Game.Properties.Resources.grass__;
            this.ClientSize = new System.Drawing.Size(299, 321);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cmd_archivo);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Snake_Game";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Puntos_Snake;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.ToolStripStatusLabel nivel_label;
        private System.Windows.Forms.ToolStripStatusLabel nivel;
        private System.Windows.Forms.Button cmd_archivo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label lbl_nombre;
    }
}

