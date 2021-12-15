
namespace SpetralAmlysisForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColorStringTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxVisualiztionMenu = new System.Windows.Forms.GroupBox();
            this.circleKnob1 = new SpetralAmlysisForms.Buttons.CircleKnob();
            this.groupBoxPereferencesMenu = new System.Windows.Forms.GroupBox();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBoxToolsMenu = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.circleKnob2 = new SpetralAmlysisForms.Buttons.CircleKnob();
            this.circleKnob3 = new SpetralAmlysisForms.Buttons.CircleKnob();
            this.circleKnob4 = new SpetralAmlysisForms.Buttons.CircleKnob();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxVisualiztionMenu.SuspendLayout();
            this.groupBoxPereferencesMenu.SuspendLayout();
            this.groupBoxToolsMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorStringTextBox
            // 
            this.ColorStringTextBox.Location = new System.Drawing.Point(1362, 646);
            this.ColorStringTextBox.Name = "ColorStringTextBox";
            this.ColorStringTextBox.Size = new System.Drawing.Size(102, 22);
            this.ColorStringTextBox.TabIndex = 45;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chart1.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(661, 381);
            this.chart1.TabIndex = 53;
            this.chart1.Text = "chart1";
            // 
            // groupBoxVisualiztionMenu
            // 
            this.groupBoxVisualiztionMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVisualiztionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.groupBoxVisualiztionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxVisualiztionMenu.Controls.Add(this.circleKnob1);
            this.groupBoxVisualiztionMenu.Controls.Add(this.chart1);
            this.groupBoxVisualiztionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxVisualiztionMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxVisualiztionMenu.Location = new System.Drawing.Point(251, 14);
            this.groupBoxVisualiztionMenu.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxVisualiztionMenu.Name = "groupBoxVisualiztionMenu";
            this.groupBoxVisualiztionMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxVisualiztionMenu.Size = new System.Drawing.Size(667, 402);
            this.groupBoxVisualiztionMenu.TabIndex = 61;
            this.groupBoxVisualiztionMenu.TabStop = false;
            // 
            // circleKnob1
            // 
            this.circleKnob1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.circleKnob1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.circleKnob1.FlatAppearance.BorderSize = 0;
            this.circleKnob1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleKnob1.ForeColor = System.Drawing.Color.White;
            this.circleKnob1.Location = new System.Drawing.Point(596, 351);
            this.circleKnob1.Margin = new System.Windows.Forms.Padding(8);
            this.circleKnob1.Name = "circleKnob1";
            this.circleKnob1.Size = new System.Drawing.Size(60, 40);
            this.circleKnob1.TabIndex = 69;
            this.circleKnob1.UseVisualStyleBackColor = false;
            this.circleKnob1.Click += new System.EventHandler(this.circleKnob1_Click);
            // 
            // groupBoxPereferencesMenu
            // 
            this.groupBoxPereferencesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPereferencesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.groupBoxPereferencesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPereferencesMenu.Controls.Add(this.hScrollBar3);
            this.groupBoxPereferencesMenu.Controls.Add(this.hScrollBar2);
            this.groupBoxPereferencesMenu.Controls.Add(this.hScrollBar1);
            this.groupBoxPereferencesMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxPereferencesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPereferencesMenu.Location = new System.Drawing.Point(14, 426);
            this.groupBoxPereferencesMenu.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxPereferencesMenu.Name = "groupBoxPereferencesMenu";
            this.groupBoxPereferencesMenu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPereferencesMenu.Size = new System.Drawing.Size(904, 163);
            this.groupBoxPereferencesMenu.TabIndex = 62;
            this.groupBoxPereferencesMenu.TabStop = false;
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar3.Location = new System.Drawing.Point(2, 59);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(900, 21);
            this.hScrollBar3.TabIndex = 2;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar2.Location = new System.Drawing.Point(2, 38);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(900, 21);
            this.hScrollBar2.TabIndex = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar1.Location = new System.Drawing.Point(2, 17);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(900, 21);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // groupBoxToolsMenu
            // 
            this.groupBoxToolsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxToolsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.groupBoxToolsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxToolsMenu.Controls.Add(this.textBox1);
            this.groupBoxToolsMenu.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxToolsMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxToolsMenu.Location = new System.Drawing.Point(14, 14);
            this.groupBoxToolsMenu.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxToolsMenu.Name = "groupBoxToolsMenu";
            this.groupBoxToolsMenu.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.groupBoxToolsMenu.Size = new System.Drawing.Size(227, 402);
            this.groupBoxToolsMenu.TabIndex = 63;
            this.groupBoxToolsMenu.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.circleKnob2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.circleKnob3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.circleKnob4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // circleKnob2
            // 
            this.circleKnob2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.circleKnob2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleKnob2.FlatAppearance.BorderSize = 0;
            this.circleKnob2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleKnob2.ForeColor = System.Drawing.Color.White;
            this.circleKnob2.Location = new System.Drawing.Point(6, 6);
            this.circleKnob2.Margin = new System.Windows.Forms.Padding(5);
            this.circleKnob2.Name = "circleKnob2";
            this.circleKnob2.Size = new System.Drawing.Size(188, 40);
            this.circleKnob2.TabIndex = 0;
            this.circleKnob2.Text = "circleKnob2";
            this.circleKnob2.UseVisualStyleBackColor = false;
            this.circleKnob2.Click += new System.EventHandler(this.circleKnob2_Click);
            // 
            // circleKnob3
            // 
            this.circleKnob3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.circleKnob3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleKnob3.FlatAppearance.BorderSize = 0;
            this.circleKnob3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleKnob3.ForeColor = System.Drawing.Color.White;
            this.circleKnob3.Location = new System.Drawing.Point(6, 57);
            this.circleKnob3.Margin = new System.Windows.Forms.Padding(5);
            this.circleKnob3.Name = "circleKnob3";
            this.circleKnob3.Size = new System.Drawing.Size(188, 40);
            this.circleKnob3.TabIndex = 1;
            this.circleKnob3.Text = "circleKnob3";
            this.circleKnob3.UseVisualStyleBackColor = false;
            // 
            // circleKnob4
            // 
            this.circleKnob4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.circleKnob4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleKnob4.FlatAppearance.BorderSize = 0;
            this.circleKnob4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleKnob4.ForeColor = System.Drawing.Color.White;
            this.circleKnob4.Location = new System.Drawing.Point(6, 108);
            this.circleKnob4.Margin = new System.Windows.Forms.Padding(5);
            this.circleKnob4.Name = "circleKnob4";
            this.circleKnob4.Size = new System.Drawing.Size(188, 41);
            this.circleKnob4.TabIndex = 2;
            this.circleKnob4.Text = "circleKnob4";
            this.circleKnob4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.groupBoxToolsMenu);
            this.Controls.Add(this.groupBoxVisualiztionMenu);
            this.Controls.Add(this.groupBoxPereferencesMenu);
            this.Controls.Add(this.ColorStringTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectral Analysis";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.backgroundWorker1_DoWork);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxVisualiztionMenu.ResumeLayout(false);
            this.groupBoxPereferencesMenu.ResumeLayout(false);
            this.groupBoxToolsMenu.ResumeLayout(false);
            this.groupBoxToolsMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ColorStringTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxVisualiztionMenu;
        private System.Windows.Forms.GroupBox groupBoxPereferencesMenu;
        private System.Windows.Forms.GroupBox groupBoxToolsMenu;
        private Buttons.CircleKnob circleKnob1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Buttons.CircleKnob circleKnob2;
        private Buttons.CircleKnob circleKnob3;
        private Buttons.CircleKnob circleKnob4;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

