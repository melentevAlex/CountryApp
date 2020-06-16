namespace InfoAboutCountryApp
{
    partial class FirstForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SelectOneButton = new System.Windows.Forms.Button();
            this.MinimyzeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "There are a two function in the program:";
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAllButton.FlatAppearance.BorderSize = 0;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.ShowAllButton.Location = new System.Drawing.Point(42, 247);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(403, 46);
            this.ShowAllButton.TabIndex = 5;
            this.ShowAllButton.Text = "Show all Avaiable Coutries from DB";
            this.toolTip1.SetToolTip(this.ShowAllButton, "here u can see all country from database");
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            this.ShowAllButton.MouseLeave += new System.EventHandler(this.ShowAllButton_MouseLeave);
            this.ShowAllButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowAllButton_MouseMove);
            // 
            // SelectOneButton
            // 
            this.SelectOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectOneButton.FlatAppearance.BorderSize = 0;
            this.SelectOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.SelectOneButton.Location = new System.Drawing.Point(30, 152);
            this.SelectOneButton.Name = "SelectOneButton";
            this.SelectOneButton.Size = new System.Drawing.Size(250, 46);
            this.SelectOneButton.TabIndex = 6;
            this.SelectOneButton.Text = "Select one country";
            this.toolTip1.SetToolTip(this.SelectOneButton, "here u can search info about one country");
            this.SelectOneButton.UseVisualStyleBackColor = true;
            this.SelectOneButton.Click += new System.EventHandler(this.SelectOneButton_Click);
            this.SelectOneButton.MouseLeave += new System.EventHandler(this.SelectOneButton_MouseLeave);
            this.SelectOneButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectOneButton_MouseMove);
            // 
            // MinimyzeButton
            // 
            this.MinimyzeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimyzeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimyzeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimyzeButton.FlatAppearance.BorderSize = 0;
            this.MinimyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimyzeButton.Location = new System.Drawing.Point(481, 0);
            this.MinimyzeButton.Name = "MinimyzeButton";
            this.MinimyzeButton.Size = new System.Drawing.Size(42, 21);
            this.MinimyzeButton.TabIndex = 7;
            this.MinimyzeButton.Text = "--";
            this.MinimyzeButton.UseVisualStyleBackColor = true;
            this.MinimyzeButton.Click += new System.EventHandler(this.MinimyzeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(523, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(42, 21);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.MinimyzeButton);
            this.panel.Controls.Add(this.CloseButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(565, 21);
            this.panel.TabIndex = 7;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(565, 360);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.SelectOneButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 200);
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FirstForm";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button SelectOneButton;
        private System.Windows.Forms.Button MinimyzeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}