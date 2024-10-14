namespace OTPR_C_SHARP_FinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            criteria_cln_all = new Button();
            criteria = new DataGridView();
            kr_name = new DataGridViewTextBoxColumn();
            criteria_add = new Button();
            criteria_del = new Button();
            criteria_inp = new TextBox();
            groupBox3 = new GroupBox();
            alternatives_cln_all = new Button();
            alternatives = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            alternatives_add = new Button();
            alternatives_del = new Button();
            alternatives_inp = new TextBox();
            groupBox4 = new GroupBox();
            tabs_sub = new TabControl();
            criteria_tab = new TabPage();
            button1 = new Button();
            criteria_comp = new DataGridView();
            criteria_cln = new Button();
            alternatives_tab = new TabPage();
            button2 = new Button();
            criteria_sel = new ComboBox();
            label1 = new Label();
            alternatives_comp = new DataGridView();
            alternatives_cln = new Button();
            tabs = new TabControl();
            main_tab = new TabPage();
            matrix_tab = new TabPage();
            result_tab = new TabPage();
            label3 = new Label();
            result_list = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            result_text = new Label();
            statusStrip1 = new StatusStrip();
            status_not_saved = new ToolStripStatusLabel();
            status_warning = new ToolStripStatusLabel();
            status_saved = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            початиЗПочаткуToolStripMenuItem = new ToolStripMenuItem();
            next_main = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)criteria).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alternatives).BeginInit();
            groupBox4.SuspendLayout();
            tabs_sub.SuspendLayout();
            criteria_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)criteria_comp).BeginInit();
            alternatives_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alternatives_comp).BeginInit();
            tabs.SuspendLayout();
            main_tab.SuspendLayout();
            matrix_tab.SuspendLayout();
            result_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)result_list).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(1838, 1289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Режим розрахунку";
            groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(574, 38);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(criteria_cln_all);
            groupBox2.Controls.Add(criteria);
            groupBox2.Controls.Add(criteria_add);
            groupBox2.Controls.Add(criteria_del);
            groupBox2.Controls.Add(criteria_inp);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(626, 804);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Критерії";
            // 
            // criteria_cln_all
            // 
            criteria_cln_all.BackColor = Color.Gainsboro;
            criteria_cln_all.FlatAppearance.BorderSize = 0;
            criteria_cln_all.FlatStyle = FlatStyle.Flat;
            criteria_cln_all.Location = new Point(324, 741);
            criteria_cln_all.Name = "criteria_cln_all";
            criteria_cln_all.Size = new Size(273, 42);
            criteria_cln_all.TabIndex = 4;
            criteria_cln_all.Text = "Очистити все";
            criteria_cln_all.UseVisualStyleBackColor = false;
            criteria_cln_all.Click += criteria_cln_all_Click;
            // 
            // criteria
            // 
            criteria.AllowUserToOrderColumns = true;
            criteria.BackgroundColor = SystemColors.ScrollBar;
            criteria.BorderStyle = BorderStyle.None;
            criteria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            criteria.Columns.AddRange(new DataGridViewColumn[] { kr_name });
            criteria.Location = new Point(23, 142);
            criteria.Name = "criteria";
            criteria.RowHeadersWidth = 62;
            criteria.Size = new Size(574, 593);
            criteria.TabIndex = 3;
            // 
            // kr_name
            // 
            kr_name.HeaderText = "Назва критерію";
            kr_name.MinimumWidth = 8;
            kr_name.Name = "kr_name";
            kr_name.Width = 500;
            // 
            // criteria_add
            // 
            criteria_add.BackColor = Color.Gainsboro;
            criteria_add.FlatAppearance.BorderSize = 0;
            criteria_add.FlatStyle = FlatStyle.Flat;
            criteria_add.Location = new Point(23, 94);
            criteria_add.Name = "criteria_add";
            criteria_add.Size = new Size(574, 42);
            criteria_add.TabIndex = 2;
            criteria_add.Text = "Додати";
            criteria_add.UseVisualStyleBackColor = false;
            criteria_add.Click += criteria_add_Click;
            // 
            // criteria_del
            // 
            criteria_del.BackColor = Color.Gainsboro;
            criteria_del.FlatAppearance.BorderSize = 0;
            criteria_del.FlatStyle = FlatStyle.Flat;
            criteria_del.Location = new Point(23, 741);
            criteria_del.Name = "criteria_del";
            criteria_del.Size = new Size(273, 42);
            criteria_del.TabIndex = 1;
            criteria_del.Text = "Видалити";
            criteria_del.UseVisualStyleBackColor = false;
            criteria_del.Click += criteria_del_Click;
            // 
            // criteria_inp
            // 
            criteria_inp.BackColor = Color.Silver;
            criteria_inp.BorderStyle = BorderStyle.None;
            criteria_inp.Location = new Point(23, 51);
            criteria_inp.Name = "criteria_inp";
            criteria_inp.Size = new Size(574, 30);
            criteria_inp.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(alternatives_cln_all);
            groupBox3.Controls.Add(alternatives);
            groupBox3.Controls.Add(alternatives_add);
            groupBox3.Controls.Add(alternatives_del);
            groupBox3.Controls.Add(alternatives_inp);
            groupBox3.Font = new Font("Segoe UI", 11F);
            groupBox3.Location = new Point(658, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(626, 804);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Альтернативи";
            // 
            // alternatives_cln_all
            // 
            alternatives_cln_all.BackColor = Color.Gainsboro;
            alternatives_cln_all.FlatAppearance.BorderSize = 0;
            alternatives_cln_all.FlatStyle = FlatStyle.Flat;
            alternatives_cln_all.Location = new Point(326, 741);
            alternatives_cln_all.Name = "alternatives_cln_all";
            alternatives_cln_all.Size = new Size(273, 42);
            alternatives_cln_all.TabIndex = 5;
            alternatives_cln_all.Text = "Очистити все";
            alternatives_cln_all.UseVisualStyleBackColor = false;
            alternatives_cln_all.Click += alternatives_cln_all_Click;
            // 
            // alternatives
            // 
            alternatives.AllowUserToOrderColumns = true;
            alternatives.BackgroundColor = SystemColors.ScrollBar;
            alternatives.BorderStyle = BorderStyle.None;
            alternatives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alternatives.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            alternatives.Location = new Point(25, 142);
            alternatives.Name = "alternatives";
            alternatives.RowHeadersWidth = 62;
            alternatives.Size = new Size(574, 593);
            alternatives.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Назва альтернативи";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 500;
            // 
            // alternatives_add
            // 
            alternatives_add.BackColor = Color.Gainsboro;
            alternatives_add.FlatAppearance.BorderSize = 0;
            alternatives_add.FlatStyle = FlatStyle.Flat;
            alternatives_add.Location = new Point(25, 94);
            alternatives_add.Name = "alternatives_add";
            alternatives_add.Size = new Size(574, 42);
            alternatives_add.TabIndex = 4;
            alternatives_add.Text = "Додати";
            alternatives_add.UseVisualStyleBackColor = false;
            alternatives_add.Click += alternatives_add_Click;
            // 
            // alternatives_del
            // 
            alternatives_del.BackColor = Color.Gainsboro;
            alternatives_del.FlatAppearance.BorderSize = 0;
            alternatives_del.FlatStyle = FlatStyle.Flat;
            alternatives_del.Location = new Point(25, 741);
            alternatives_del.Name = "alternatives_del";
            alternatives_del.Size = new Size(269, 42);
            alternatives_del.TabIndex = 3;
            alternatives_del.Text = "Видалити";
            alternatives_del.UseVisualStyleBackColor = false;
            alternatives_del.Click += alternatives_del_Click;
            // 
            // alternatives_inp
            // 
            alternatives_inp.BackColor = Color.Silver;
            alternatives_inp.BorderStyle = BorderStyle.None;
            alternatives_inp.Location = new Point(25, 51);
            alternatives_inp.Name = "alternatives_inp";
            alternatives_inp.Size = new Size(574, 30);
            alternatives_inp.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tabs_sub);
            groupBox4.Font = new Font("Segoe UI", 11F);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1321, 799);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Матриця парних порівнянь";
            // 
            // tabs_sub
            // 
            tabs_sub.Controls.Add(criteria_tab);
            tabs_sub.Controls.Add(alternatives_tab);
            tabs_sub.Location = new Point(10, 41);
            tabs_sub.Name = "tabs_sub";
            tabs_sub.SelectedIndex = 0;
            tabs_sub.Size = new Size(1311, 752);
            tabs_sub.TabIndex = 5;
            tabs_sub.Selected += tabs_sub_Selected;
            // 
            // criteria_tab
            // 
            criteria_tab.Controls.Add(button1);
            criteria_tab.Controls.Add(criteria_comp);
            criteria_tab.Controls.Add(criteria_cln);
            criteria_tab.Location = new Point(4, 39);
            criteria_tab.Name = "criteria_tab";
            criteria_tab.Padding = new Padding(3);
            criteria_tab.Size = new Size(1303, 709);
            criteria_tab.TabIndex = 0;
            criteria_tab.Text = "Порівняння критеріїв";
            criteria_tab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(446, 6);
            button1.Name = "button1";
            button1.Size = new Size(851, 42);
            button1.TabIndex = 4;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // criteria_comp
            // 
            criteria_comp.AllowUserToAddRows = false;
            criteria_comp.AllowUserToDeleteRows = false;
            criteria_comp.BackgroundColor = SystemColors.ScrollBar;
            criteria_comp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            criteria_comp.Location = new Point(6, 54);
            criteria_comp.Name = "criteria_comp";
            criteria_comp.RowHeadersWidth = 62;
            criteria_comp.Size = new Size(1291, 649);
            criteria_comp.TabIndex = 3;
            // 
            // criteria_cln
            // 
            criteria_cln.BackColor = Color.Gainsboro;
            criteria_cln.FlatAppearance.BorderSize = 0;
            criteria_cln.FlatStyle = FlatStyle.Flat;
            criteria_cln.Location = new Point(6, 6);
            criteria_cln.Name = "criteria_cln";
            criteria_cln.Size = new Size(434, 42);
            criteria_cln.TabIndex = 1;
            criteria_cln.Text = "Очистити\\перебудувати матрицю";
            criteria_cln.UseVisualStyleBackColor = false;
            criteria_cln.Click += criteria_cln_Click;
            // 
            // alternatives_tab
            // 
            alternatives_tab.Controls.Add(button2);
            alternatives_tab.Controls.Add(criteria_sel);
            alternatives_tab.Controls.Add(label1);
            alternatives_tab.Controls.Add(alternatives_comp);
            alternatives_tab.Controls.Add(alternatives_cln);
            alternatives_tab.Location = new Point(4, 39);
            alternatives_tab.Name = "alternatives_tab";
            alternatives_tab.Padding = new Padding(3);
            alternatives_tab.Size = new Size(1303, 709);
            alternatives_tab.TabIndex = 1;
            alternatives_tab.Text = "Порівняння альтернатив відносно критеріїв";
            alternatives_tab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(488, 63);
            button2.Name = "button2";
            button2.Size = new Size(799, 42);
            button2.TabIndex = 5;
            button2.Text = "Зберегти і записати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // criteria_sel
            // 
            criteria_sel.FormattingEnabled = true;
            criteria_sel.Location = new Point(488, 14);
            criteria_sel.Name = "criteria_sel";
            criteria_sel.Size = new Size(799, 38);
            criteria_sel.TabIndex = 7;
            criteria_sel.SelectedIndexChanged += criteria_sel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(458, 30);
            label1.TabIndex = 6;
            label1.Text = "Порівняти альтернативи відносно критерія:";
            // 
            // alternatives_comp
            // 
            alternatives_comp.AllowUserToOrderColumns = true;
            alternatives_comp.BackgroundColor = SystemColors.ScrollBar;
            alternatives_comp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alternatives_comp.Location = new Point(9, 111);
            alternatives_comp.Name = "alternatives_comp";
            alternatives_comp.RowHeadersWidth = 62;
            alternatives_comp.Size = new Size(1288, 592);
            alternatives_comp.TabIndex = 5;
            // 
            // alternatives_cln
            // 
            alternatives_cln.BackColor = Color.Gainsboro;
            alternatives_cln.FlatAppearance.BorderSize = 0;
            alternatives_cln.FlatStyle = FlatStyle.Flat;
            alternatives_cln.Location = new Point(9, 63);
            alternatives_cln.Name = "alternatives_cln";
            alternatives_cln.Size = new Size(467, 42);
            alternatives_cln.TabIndex = 4;
            alternatives_cln.Text = "Очистити/перебудувати матрицю";
            alternatives_cln.UseVisualStyleBackColor = false;
            alternatives_cln.Click += alternatives_cln_Click;
            // 
            // tabs
            // 
            tabs.Controls.Add(main_tab);
            tabs.Controls.Add(matrix_tab);
            tabs.Controls.Add(result_tab);
            tabs.Font = new Font("Segoe UI", 11F);
            tabs.Location = new Point(12, 63);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1341, 874);
            tabs.TabIndex = 5;
            tabs.Selected += tabs_Selected;
            // 
            // main_tab
            // 
            main_tab.Controls.Add(groupBox3);
            main_tab.Controls.Add(groupBox2);
            main_tab.Location = new Point(4, 39);
            main_tab.Name = "main_tab";
            main_tab.Padding = new Padding(3);
            main_tab.Size = new Size(1333, 831);
            main_tab.TabIndex = 0;
            main_tab.Text = "Визначення критеріїв та альтернатив";
            main_tab.UseVisualStyleBackColor = true;
            // 
            // matrix_tab
            // 
            matrix_tab.Controls.Add(groupBox4);
            matrix_tab.Location = new Point(4, 39);
            matrix_tab.Name = "matrix_tab";
            matrix_tab.Padding = new Padding(3);
            matrix_tab.Size = new Size(1333, 831);
            matrix_tab.TabIndex = 1;
            matrix_tab.Text = "Матриця парних порівнянь";
            matrix_tab.UseVisualStyleBackColor = true;
            // 
            // result_tab
            // 
            result_tab.Controls.Add(label3);
            result_tab.Controls.Add(result_list);
            result_tab.Controls.Add(result_text);
            result_tab.Location = new Point(4, 39);
            result_tab.Name = "result_tab";
            result_tab.Padding = new Padding(3);
            result_tab.Size = new Size(1333, 831);
            result_tab.TabIndex = 2;
            result_tab.Text = "Результат оцінки";
            result_tab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(34, 160);
            label3.Name = "label3";
            label3.Size = new Size(208, 30);
            label3.TabIndex = 2;
            label3.Text = "Результант оцінки: ";
            // 
            // result_list
            // 
            result_list.AllowUserToAddRows = false;
            result_list.AllowUserToDeleteRows = false;
            result_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            result_list.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            result_list.Location = new Point(22, 214);
            result_list.Name = "result_list";
            result_list.ReadOnly = true;
            result_list.RowHeadersWidth = 62;
            result_list.Size = new Size(1286, 579);
            result_list.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Назва альтернативи";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Пріорітет альтернативи";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // result_text
            // 
            result_text.AutoSize = true;
            result_text.Font = new Font("Segoe UI", 20F);
            result_text.Location = new Point(22, 26);
            result_text.Name = "result_text";
            result_text.Size = new Size(552, 54);
            result_text.TabIndex = 0;
            result_text.Text = "Найкращою з альтернатив є ";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { status_not_saved, status_warning, status_saved });
            statusStrip1.Location = new Point(0, 1004);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1374, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "status";
            // 
            // status_not_saved
            // 
            status_not_saved.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            status_not_saved.ForeColor = Color.Red;
            status_not_saved.Name = "status_not_saved";
            status_not_saved.Size = new Size(202, 32);
            status_not_saved.Text = "НЕ ЗБЕРЕЖЕНО!";
            status_not_saved.Visible = false;
            // 
            // status_warning
            // 
            status_warning.Font = new Font("Segoe UI", 11F);
            status_warning.ForeColor = Color.IndianRed;
            status_warning.Name = "status_warning";
            status_warning.Size = new Size(807, 32);
            status_warning.Text = "Натисніть \"зберегти\" перед тим як перейти до оцінки за наступним критерієм";
            status_warning.Visible = false;
            // 
            // status_saved
            // 
            status_saved.ActiveLinkColor = Color.Green;
            status_saved.Font = new Font("Segoe UI", 12F);
            status_saved.ForeColor = Color.Green;
            status_saved.Name = "status_saved";
            status_saved.Size = new Size(140, 32);
            status_saved.Text = "Збережено";
            status_saved.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { початиЗПочаткуToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1374, 38);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menu";
            // 
            // початиЗПочаткуToolStripMenuItem
            // 
            початиЗПочаткуToolStripMenuItem.Name = "початиЗПочаткуToolStripMenuItem";
            початиЗПочаткуToolStripMenuItem.Size = new Size(205, 34);
            початиЗПочаткуToolStripMenuItem.Text = "Почати з початку";
            // 
            // next_main
            // 
            next_main.BackColor = Color.FromArgb(185, 230, 150);
            next_main.FlatAppearance.BorderSize = 0;
            next_main.FlatStyle = FlatStyle.Flat;
            next_main.Font = new Font("Segoe UI", 11F);
            next_main.Location = new Point(22, 943);
            next_main.Name = "next_main";
            next_main.Size = new Size(1327, 42);
            next_main.TabIndex = 5;
            next_main.Text = "Далі  →";
            next_main.UseVisualStyleBackColor = false;
            next_main.Visible = false;
            next_main.Click += next_main_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 1026);
            Controls.Add(next_main);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabs);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1396, 1082);
            Name = "Form1";
            Text = "Метод аналізу ієрархій (МАІ)";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)criteria).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alternatives).EndInit();
            groupBox4.ResumeLayout(false);
            tabs_sub.ResumeLayout(false);
            criteria_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)criteria_comp).EndInit();
            alternatives_tab.ResumeLayout(false);
            alternatives_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alternatives_comp).EndInit();
            tabs.ResumeLayout(false);
            main_tab.ResumeLayout(false);
            matrix_tab.ResumeLayout(false);
            result_tab.ResumeLayout(false);
            result_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)result_list).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button criteria_add;
        private Button criteria_del;
        private TextBox criteria_inp;
        private TextBox alternatives_inp;
        private Button alternatives_add;
        private Button alternatives_del;
        private DataGridView criteria;
        private DataGridView alternatives;
        private GroupBox groupBox4;     
        private DataGridView criteria_comp;
        private Button criteria_cln;
        private TabControl tabs;
        private TabPage main_tab;
        private TabPage matrix_tab;
        private StatusStrip statusStrip1;
        private TabControl tabs_sub;
        private TabPage criteria_tab;
        private TabPage alternatives_tab;
        private DataGridView alternatives_comp;
        private Button alternatives_cln;
        private ComboBox criteria_sel;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem початиЗПочаткуToolStripMenuItem;
        private TabPage result_tab;
        private Label label3;
        private DataGridView result_list;
        private Label result_text;
        private Button criteria_cln_all;
        private Button alternatives_cln_all;
        private DataGridViewTextBoxColumn kr_name;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button next_main;
        private Button button1;
        private Button button2;
        private ToolStripStatusLabel status_not_saved;
        private ToolStripStatusLabel status_warning;
        private ToolStripStatusLabel status_saved;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
