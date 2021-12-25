
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColorStringTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelVisualiztionMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxPereferencesMenu = new System.Windows.Forms.GroupBox();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBoxToolsMenu = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelVisualiztionMenu.SuspendLayout();
            this.groupBoxPereferencesMenu.SuspendLayout();
            this.groupBoxToolsMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.chart1.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(744, 407);
            this.chart1.TabIndex = 53;
            this.chart1.Text = "chart1";
            // 
            // panelVisualiztionMenu
            // 
            this.panelVisualiztionMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVisualiztionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panelVisualiztionMenu.Controls.Add(this.chart1);
            this.panelVisualiztionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelVisualiztionMenu.Location = new System.Drawing.Point(428, 41);
            this.panelVisualiztionMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelVisualiztionMenu.Name = "panelVisualiztionMenu";
            this.panelVisualiztionMenu.Padding = new System.Windows.Forms.Padding(0);
            this.panelVisualiztionMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelVisualiztionMenu.Size = new System.Drawing.Size(744, 422);
            this.panelVisualiztionMenu.TabIndex = 61;
            this.panelVisualiztionMenu.TabStop = false;
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
            this.groupBoxPereferencesMenu.Location = new System.Drawing.Point(14, 473);
            this.groupBoxPereferencesMenu.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxPereferencesMenu.Name = "groupBoxPereferencesMenu";
            this.groupBoxPereferencesMenu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPereferencesMenu.Size = new System.Drawing.Size(1158, 163);
            this.groupBoxPereferencesMenu.TabIndex = 62;
            this.groupBoxPereferencesMenu.TabStop = false;
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar3.Location = new System.Drawing.Point(2, 59);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(1154, 21);
            this.hScrollBar3.TabIndex = 2;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar2.Location = new System.Drawing.Point(2, 38);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(1154, 21);
            this.hScrollBar2.TabIndex = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar1.Location = new System.Drawing.Point(2, 17);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1154, 21);
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
            this.groupBoxToolsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxToolsMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxToolsMenu.Location = new System.Drawing.Point(19, 41);
            this.groupBoxToolsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxToolsMenu.Name = "groupBoxToolsMenu";
            this.groupBoxToolsMenu.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.groupBoxToolsMenu.Size = new System.Drawing.Size(404, 422);
            this.groupBoxToolsMenu.TabIndex = 63;
            this.groupBoxToolsMenu.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(20, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(4, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(4, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 8;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(1186, 33);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 29);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(1111, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1186, 650);
            this.Controls.Add(this.groupBoxToolsMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelVisualiztionMenu);
            this.Controls.Add(this.groupBoxPereferencesMenu);
            this.Controls.Add(this.ColorStringTextBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelVisualiztionMenu.ResumeLayout(false);
            this.groupBoxPereferencesMenu.ResumeLayout(false);
            this.groupBoxToolsMenu.ResumeLayout(false);
            this.groupBoxToolsMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ColorStringTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox panelVisualiztionMenu;
        private System.Windows.Forms.GroupBox groupBoxPereferencesMenu;
        private System.Windows.Forms.GroupBox groupBoxToolsMenu;
        //private Buttons.CircleKnob circleKnob1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Buttons.CircleKnob[] circleKnob = new Buttons.CircleKnob[4];
/*        private Buttons.CircleKnob circleKnob3;
        private Buttons.CircleKnob circleKnob4;*/
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

