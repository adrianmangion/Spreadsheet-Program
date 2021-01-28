namespace Adrian_Spreadsheet
{
    partial class form_spreadsheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_spreadsheet));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_charts = new System.Windows.Forms.Button();
            this.btn_formulas = new System.Windows.Forms.Button();
            this.btn_changeTheme = new System.Windows.Forms.Button();
            this.btn_newSheet = new System.Windows.Forms.Button();
            this.btn_cornerButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_menu.Controls.Add(this.btn_setting);
            this.panel_menu.Controls.Add(this.btn_charts);
            this.panel_menu.Controls.Add(this.btn_formulas);
            this.panel_menu.Controls.Add(this.btn_changeTheme);
            this.panel_menu.Controls.Add(this.btn_newSheet);
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.Name = "panel_menu";
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_setting, "btn_setting");
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btn_setting.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btn_charts
            // 
            this.btn_charts.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_charts, "btn_charts");
            this.btn_charts.ForeColor = System.Drawing.Color.White;
            this.btn_charts.Name = "btn_charts";
            this.btn_charts.UseVisualStyleBackColor = false;
            this.btn_charts.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btn_charts.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btn_formulas
            // 
            this.btn_formulas.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_formulas, "btn_formulas");
            this.btn_formulas.ForeColor = System.Drawing.Color.White;
            this.btn_formulas.Name = "btn_formulas";
            this.btn_formulas.UseVisualStyleBackColor = false;
            this.btn_formulas.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btn_formulas.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btn_changeTheme
            // 
            this.btn_changeTheme.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_changeTheme, "btn_changeTheme");
            this.btn_changeTheme.ForeColor = System.Drawing.Color.White;
            this.btn_changeTheme.Name = "btn_changeTheme";
            this.btn_changeTheme.UseVisualStyleBackColor = false;
            this.btn_changeTheme.Click += new System.EventHandler(this.Btn_changeTheme_Click);
            this.btn_changeTheme.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btn_changeTheme.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btn_newSheet
            // 
            this.btn_newSheet.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btn_newSheet, "btn_newSheet");
            this.btn_newSheet.ForeColor = System.Drawing.Color.White;
            this.btn_newSheet.Name = "btn_newSheet";
            this.btn_newSheet.UseVisualStyleBackColor = false;
            this.btn_newSheet.Click += new System.EventHandler(this.Btn_newSheet_Click);
            this.btn_newSheet.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btn_newSheet.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btn_cornerButton
            // 
            this.btn_cornerButton.BackgroundImage = global::Adrian_Spreadsheet.Properties.Resources.down_arrow;
            resources.ApplyResources(this.btn_cornerButton, "btn_cornerButton");
            this.btn_cornerButton.Name = "btn_cornerButton";
            this.btn_cornerButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // form_spreadsheet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_cornerButton);
            this.Controls.Add(this.panel_menu);
            this.Name = "form_spreadsheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_changeTheme;
        private System.Windows.Forms.Button btn_newSheet;
        private System.Windows.Forms.Button btn_charts;
        private System.Windows.Forms.Button btn_formulas;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_cornerButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

