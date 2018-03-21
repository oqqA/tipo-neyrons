namespace WindowsFormsApp26.neyrons
{
   partial class Form1
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.trackBar1 = new System.Windows.Forms.TrackBar();
         this.trackBar2 = new System.Windows.Forms.TrackBar();
         this.trackBar3 = new System.Windows.Forms.TrackBar();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.pictureBox1.Location = new System.Drawing.Point(134, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(666, 450);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
         // 
         // timer1
         // 
         this.timer1.Interval = 20;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // trackBar1
         // 
         this.trackBar1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.trackBar1.Dock = System.Windows.Forms.DockStyle.Left;
         this.trackBar1.Location = new System.Drawing.Point(0, 0);
         this.trackBar1.Maximum = 800;
         this.trackBar1.Minimum = 1;
         this.trackBar1.Name = "trackBar1";
         this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
         this.trackBar1.Size = new System.Drawing.Size(45, 450);
         this.trackBar1.TabIndex = 1;
         this.trackBar1.TabStop = false;
         this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
         this.trackBar1.Value = 100;
         this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
         // 
         // trackBar2
         // 
         this.trackBar2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.trackBar2.Cursor = System.Windows.Forms.Cursors.Default;
         this.trackBar2.Dock = System.Windows.Forms.DockStyle.Left;
         this.trackBar2.Location = new System.Drawing.Point(45, 0);
         this.trackBar2.Maximum = 1000;
         this.trackBar2.Minimum = 1;
         this.trackBar2.Name = "trackBar2";
         this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
         this.trackBar2.Size = new System.Drawing.Size(45, 450);
         this.trackBar2.TabIndex = 1;
         this.trackBar2.TabStop = false;
         this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
         this.trackBar2.Value = 60;
         this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
         // 
         // trackBar3
         // 
         this.trackBar3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.trackBar3.Dock = System.Windows.Forms.DockStyle.Left;
         this.trackBar3.LargeChange = 1;
         this.trackBar3.Location = new System.Drawing.Point(90, 0);
         this.trackBar3.Maximum = 1000;
         this.trackBar3.Name = "trackBar3";
         this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
         this.trackBar3.Size = new System.Drawing.Size(45, 450);
         this.trackBar3.TabIndex = 1;
         this.trackBar3.TabStop = false;
         this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
         this.trackBar3.Value = 100;
         this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.trackBar3);
         this.Controls.Add(this.trackBar2);
         this.Controls.Add(this.trackBar1);
         this.Controls.Add(this.pictureBox1);
         this.Name = "Form1";
         this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.TrackBar trackBar2;
      private System.Windows.Forms.TrackBar trackBar3;
   }
}

