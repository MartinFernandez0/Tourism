namespace TourismDesktop.Views.ActivityView
{
    partial class ActivityView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            txtFilter = new TextBox();
            panel1 = new Panel();
            btnReturn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageList = new TabPage();
            dataGridActivityView = new DataGridView();
            tabPageAddEdit = new TabPage();
            pictureBox1 = new PictureBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            CBoxDestination = new ComboBox();
            label8 = new Label();
            txtDescription = new TextBox();
            label7 = new Label();
            NumCost = new NumericUpDown();
            label5 = new Label();
            NumDuration = new NumericUpDown();
            txtURL_image = new TextBox();
            label4 = new Label();
            txtActivityName = new TextBox();
            label2 = new Label();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnModify = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridActivityView).BeginInit();
            tabPageAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumDuration).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(239, 93);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 51;
            label3.Text = "BUSCAR ACTIVIDAD";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(380, 85);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(278, 23);
            txtFilter.TabIndex = 50;
            txtFilter.TextChanged += txtFilter_TextChanged_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(24, 24, 29);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 63);
            panel1.TabIndex = 45;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.White;
            btnReturn.BackgroundImageLayout = ImageLayout.None;
            btnReturn.ForeColor = SystemColors.ActiveCaptionText;
            btnReturn.IconChar = FontAwesome.Sharp.IconChar.House;
            btnReturn.IconColor = Color.Black;
            btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturn.IconSize = 25;
            btnReturn.Location = new Point(832, 13);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(57, 37);
            btnReturn.TabIndex = 61;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "ACTIVIDADES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageAddEdit);
            tabControl1.Location = new Point(17, 93);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 328);
            tabControl1.TabIndex = 44;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridActivityView);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(633, 300);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "Lista";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridActivityView
            // 
            dataGridActivityView.AllowUserToAddRows = false;
            dataGridActivityView.AllowUserToDeleteRows = false;
            dataGridActivityView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridActivityView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridActivityView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridActivityView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridActivityView.Location = new Point(0, 0);
            dataGridActivityView.Margin = new Padding(3, 2, 3, 2);
            dataGridActivityView.Name = "dataGridActivityView";
            dataGridActivityView.ReadOnly = true;
            dataGridActivityView.RowHeadersWidth = 51;
            dataGridActivityView.Size = new Size(633, 300);
            dataGridActivityView.TabIndex = 16;
            // 
            // tabPageAddEdit
            // 
            tabPageAddEdit.Controls.Add(pictureBox1);
            tabPageAddEdit.Controls.Add(btnCancel);
            tabPageAddEdit.Controls.Add(btnSave);
            tabPageAddEdit.Controls.Add(label6);
            tabPageAddEdit.Controls.Add(CBoxDestination);
            tabPageAddEdit.Controls.Add(label8);
            tabPageAddEdit.Controls.Add(txtDescription);
            tabPageAddEdit.Controls.Add(label7);
            tabPageAddEdit.Controls.Add(NumCost);
            tabPageAddEdit.Controls.Add(label5);
            tabPageAddEdit.Controls.Add(NumDuration);
            tabPageAddEdit.Controls.Add(txtURL_image);
            tabPageAddEdit.Controls.Add(label4);
            tabPageAddEdit.Controls.Add(txtActivityName);
            tabPageAddEdit.Controls.Add(label2);
            tabPageAddEdit.Location = new Point(4, 24);
            tabPageAddEdit.Name = "tabPageAddEdit";
            tabPageAddEdit.Padding = new Padding(3);
            tabPageAddEdit.Size = new Size(633, 300);
            tabPageAddEdit.TabIndex = 1;
            tabPageAddEdit.Text = "Agregar/Editar";
            tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WEB_LOGO;
            pictureBox1.Location = new Point(415, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 30;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(568, 257);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(43, 36);
            btnCancel.TabIndex = 76;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnSave.IconColor = SystemColors.ActiveCaptionText;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 30;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(448, 256);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(42, 36);
            btnSave.TabIndex = 77;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 15);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 75;
            label6.Text = "Destinos:";
            // 
            // CBoxDestination
            // 
            CBoxDestination.BackColor = SystemColors.InactiveCaption;
            CBoxDestination.FormattingEnabled = true;
            CBoxDestination.Location = new Point(448, 33);
            CBoxDestination.Name = "CBoxDestination";
            CBoxDestination.Size = new Size(163, 23);
            CBoxDestination.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 180);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 73;
            label8.Text = "Descripción:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveCaption;
            txtDescription.Location = new Point(140, 177);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 65);
            txtDescription.TabIndex = 72;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 136);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 71;
            label7.Text = "COSTO:";
            // 
            // NumCost
            // 
            NumCost.BackColor = SystemColors.InactiveCaption;
            NumCost.DecimalPlaces = 2;
            NumCost.Location = new Point(140, 134);
            NumCost.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            NumCost.Name = "NumCost";
            NumCost.Size = new Size(60, 23);
            NumCost.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 106);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 69;
            label5.Text = "Cantidad MESES:";
            // 
            // NumDuration
            // 
            NumDuration.BackColor = SystemColors.InactiveCaption;
            NumDuration.DecimalPlaces = 2;
            NumDuration.Location = new Point(140, 104);
            NumDuration.Maximum = new decimal(new int[] { -1486618624, 232830643, 0, 0 });
            NumDuration.Name = "NumDuration";
            NumDuration.Size = new Size(60, 23);
            NumDuration.TabIndex = 68;
            // 
            // txtURL_image
            // 
            txtURL_image.BackColor = SystemColors.InactiveCaption;
            txtURL_image.Location = new Point(140, 65);
            txtURL_image.Margin = new Padding(3, 2, 3, 2);
            txtURL_image.Name = "txtURL_image";
            txtURL_image.Size = new Size(269, 23);
            txtURL_image.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 68);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 18;
            label4.Text = "Imagen URL:";
            // 
            // txtActivityName
            // 
            txtActivityName.BackColor = SystemColors.InactiveCaption;
            txtActivityName.Location = new Point(140, 33);
            txtActivityName.Margin = new Padding(3, 2, 3, 2);
            txtActivityName.Name = "txtActivityName";
            txtActivityName.Size = new Size(269, 23);
            txtActivityName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 36);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre Actividad:";
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(732, 358);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 66;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(24, 24, 29);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(721, 294);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 45);
            btnDelete.TabIndex = 70;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModify.BackColor = Color.FromArgb(24, 24, 29);
            btnModify.FlatStyle = FlatStyle.Popup;
            btnModify.ForeColor = SystemColors.Control;
            btnModify.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnModify.IconColor = Color.White;
            btnModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModify.IconSize = 20;
            btnModify.ImageAlign = ContentAlignment.MiddleLeft;
            btnModify.Location = new Point(721, 208);
            btnModify.Margin = new Padding(3, 2, 3, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(130, 45);
            btnModify.TabIndex = 69;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(24, 24, 29);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(721, 120);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 45);
            btnAdd.TabIndex = 68;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ActivityView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 465);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(btnSeeEliminated);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActivityView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActivityView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridActivityView).EndInit();
            tabPageAddEdit.ResumeLayout(false);
            tabPageAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtFilter;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnReturn;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageList;
        private DataGridView dataGridActivityView;
        private TabPage tabPageAddEdit;
        private TextBox txtURL_image;
        private Label label4;
        private TextBox txtActivityName;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        private Label label5;
        private NumericUpDown TimeDuration;
        private Label label8;
        private TextBox txtDescription;
        private Label label7;
        private NumericUpDown NumCost;
        private ComboBox CBoxDestination;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private PictureBox pictureBox1;
        private NumericUpDown NumDuration;
    }
}