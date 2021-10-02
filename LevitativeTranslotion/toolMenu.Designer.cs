
namespace LevitativeTranslotion
{
    partial class toolMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toolMenu));
            this.FontS = new System.Windows.Forms.Button();
            this.ExitP = new System.Windows.Forms.Button();
            this.FontSize = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FontS
            // 
            this.FontS.Dock = System.Windows.Forms.DockStyle.Top;
            this.FontS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FontS.FlatAppearance.BorderSize = 0;
            this.FontS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FontS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FontS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontS.Location = new System.Drawing.Point(0, 66);
            this.FontS.Margin = new System.Windows.Forms.Padding(0);
            this.FontS.Name = "FontS";
            this.FontS.Size = new System.Drawing.Size(152, 33);
            this.FontS.TabIndex = 2;
            this.FontS.Text = "          字型大小";
            this.FontS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FontS.UseVisualStyleBackColor = true;
            // 
            // ExitP
            // 
            this.ExitP.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExitP.FlatAppearance.BorderSize = 0;
            this.ExitP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ExitP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ExitP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitP.Location = new System.Drawing.Point(0, 99);
            this.ExitP.Margin = new System.Windows.Forms.Padding(0);
            this.ExitP.Name = "ExitP";
            this.ExitP.Size = new System.Drawing.Size(152, 33);
            this.ExitP.TabIndex = 3;
            this.ExitP.Text = "          結束";
            this.ExitP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitP.UseVisualStyleBackColor = true;
            this.ExitP.Click += new System.EventHandler(this.ExitP_Click);
            this.ExitP.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.ExitP.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // FontSize
            // 
            this.FontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FontSize.Location = new System.Drawing.Point(5, 72);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(29, 21);
            this.FontSize.TabIndex = 5;
            this.FontSize.Text = "10";
            this.FontSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Down
            // 
            this.Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Down.BackgroundImage")));
            this.Down.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Down.FlatAppearance.BorderSize = 0;
            this.Down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Down.Location = new System.Drawing.Point(124, 84);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(16, 14);
            this.Down.TabIndex = 7;
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            this.Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down_MouseDown);
            this.Down.MouseEnter += new System.EventHandler(this.Down_MouseEnter);
            this.Down.MouseLeave += new System.EventHandler(this.Down_MouseLeave);
            this.Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Down_MouseUp);
            // 
            // Up
            // 
            this.Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Up.BackgroundImage")));
            this.Up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Up.FlatAppearance.BorderSize = 0;
            this.Up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Up.Location = new System.Drawing.Point(124, 66);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(16, 14);
            this.Up.TabIndex = 6;
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            this.Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_MouseDown);
            this.Up.MouseEnter += new System.EventHandler(this.Up_MouseEnter);
            this.Up.MouseLeave += new System.EventHandler(this.Up_MouseLeave);
            this.Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up_MouseUp);
            // 
            // Export
            // 
            this.Export.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.checkbutton_off_normal;
            this.Export.Dock = System.Windows.Forms.DockStyle.Top;
            this.Export.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Export.FlatAppearance.BorderSize = 0;
            this.Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Location = new System.Drawing.Point(0, 33);
            this.Export.Margin = new System.Windows.Forms.Padding(0);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(152, 33);
            this.Export.TabIndex = 1;
            this.Export.Text = "          輸出到文件";
            this.Export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            this.Export.MouseEnter += new System.EventHandler(this.checkbutton_MouseEnter);
            this.Export.MouseLeave += new System.EventHandler(this.checkbutton_MouseLeave);
            // 
            // Paste
            // 
            this.Paste.BackgroundImage = global::LevitativeTranslotion.Properties.Resources.checkbutton_off_normal;
            this.Paste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Paste.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Paste.FlatAppearance.BorderSize = 0;
            this.Paste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Paste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paste.Location = new System.Drawing.Point(0, 0);
            this.Paste.Margin = new System.Windows.Forms.Padding(0);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(152, 33);
            this.Paste.TabIndex = 0;
            this.Paste.Text = "          貼上到視窗";
            this.Paste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            this.Paste.MouseEnter += new System.EventHandler(this.checkbutton_MouseEnter);
            this.Paste.MouseLeave += new System.EventHandler(this.checkbutton_MouseLeave);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "單字本.csv";
            this.saveFileDialog1.Filter = "逗點分隔檔案|*.csv";
            // 
            // toolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(152, 132);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.ExitP);
            this.Controls.Add(this.FontS);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Paste);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "toolMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "toolMunu";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.toolMenu_Load);
            this.Deactivate += new System.EventHandler(this.toolMenu_Deactivate);
            this.Load += new System.EventHandler(this.toolMenu_Load);
            this.Leave += new System.EventHandler(this.toolMenu_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button FontS;
        private System.Windows.Forms.Button ExitP;
        private System.Windows.Forms.Label FontSize;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}