namespace TourismDesktop.Views
{
    partial class ItineraryView
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
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnModify = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnReturn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            tabPageAddEdit = new TabPage();
            label7 = new Label();
            label5 = new Label();
            ReturnDate = new DateTimePicker();
            CBoxActivity = new ComboBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            DepartureDate = new DateTimePicker();
            label6 = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label2 = new Label();
            tabPageList = new TabPage();
            dataGridItineraryView = new DataGridView();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            tabPageAddEdit.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryView).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(239, 96);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 59;
            label3.Text = "BUSCAR ITINERARIO";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(380, 88);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(278, 23);
            txtFilter.TabIndex = 58;
            txtFilter.TextChanged += txtFilter_TextChanged;
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
            btnDelete.TabIndex = 56;
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
            btnModify.TabIndex = 55;
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
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            panel1.TabIndex = 53;
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
            btnReturn.TabIndex = 60;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 0;
            label1.Text = "ITINERARIO";
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(306, 261);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 60;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            btnSeeEliminated.Click += btnSeeEliminated_Click;
            // 
            // tabPageAddEdit
            // 
            tabPageAddEdit.Controls.Add(btnSeeEliminated);
            tabPageAddEdit.Controls.Add(label7);
            tabPageAddEdit.Controls.Add(label5);
            tabPageAddEdit.Controls.Add(ReturnDate);
            tabPageAddEdit.Controls.Add(CBoxActivity);
            tabPageAddEdit.Controls.Add(txtDescription);
            tabPageAddEdit.Controls.Add(txtName);
            tabPageAddEdit.Controls.Add(DepartureDate);
            tabPageAddEdit.Controls.Add(label6);
            tabPageAddEdit.Controls.Add(btnCancel);
            tabPageAddEdit.Controls.Add(btnSave);
            tabPageAddEdit.Controls.Add(label4);
            tabPageAddEdit.Controls.Add(label2);
            tabPageAddEdit.Location = new Point(4, 24);
            tabPageAddEdit.Name = "tabPageAddEdit";
            tabPageAddEdit.Padding = new Padding(3);
            tabPageAddEdit.Size = new Size(633, 300);
            tabPageAddEdit.TabIndex = 1;
            tabPageAddEdit.Text = "Agregar/Editar";
            tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 15);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 63;
            label7.Text = "Actividad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 189);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 62;
            label5.Text = "Fecha Regreso:";
            // 
            // ReturnDate
            // 
            ReturnDate.Format = DateTimePickerFormat.Custom;
            ReturnDate.Location = new Point(148, 183);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(146, 23);
            ReturnDate.TabIndex = 32;
            ReturnDate.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // CBoxActivity
            // 
            CBoxActivity.FormattingEnabled = true;
            CBoxActivity.Location = new Point(339, 38);
            CBoxActivity.Name = "CBoxActivity";
            CBoxActivity.Size = new Size(269, 23);
            CBoxActivity.TabIndex = 31;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 80);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 23);
            txtDescription.TabIndex = 30;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 38);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 23);
            txtName.TabIndex = 15;
            // 
            // DepartureDate
            // 
            DepartureDate.Format = DateTimePickerFormat.Custom;
            DepartureDate.Location = new Point(148, 137);
            DepartureDate.Name = "DepartureDate";
            DepartureDate.Size = new Size(146, 23);
            DepartureDate.TabIndex = 23;
            DepartureDate.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 143);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 22;
            label6.Text = "Fecha Comienzo:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 20;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(527, 265);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 25);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = SystemColors.ActiveCaptionText;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 20;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(421, 265);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 25);
            btnSave.TabIndex = 61;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 88);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 18;
            label4.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridItineraryView);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(633, 300);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "Lista";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridItineraryView
            // 
            dataGridItineraryView.AllowUserToAddRows = false;
            dataGridItineraryView.AllowUserToDeleteRows = false;
            dataGridItineraryView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridItineraryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridItineraryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridItineraryView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridItineraryView.Location = new Point(0, 0);
            dataGridItineraryView.Margin = new Padding(3, 2, 3, 2);
            dataGridItineraryView.Name = "dataGridItineraryView";
            dataGridItineraryView.ReadOnly = true;
            dataGridItineraryView.RowHeadersWidth = 51;
            dataGridItineraryView.Size = new Size(633, 300);
            dataGridItineraryView.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageAddEdit);
            tabControl1.Location = new Point(17, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 328);
            tabControl1.TabIndex = 52;
            // 
            // ItineraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 465);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItineraryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItineraryView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageAddEdit.ResumeLayout(false);
            tabPageAddEdit.PerformLayout();
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryView).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtFilter;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private FontAwesome.Sharp.IconButton btnAdd;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnReturn;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        private TabPage tabPageAddEdit;
        private Label label7;
        private Label label5;
        private DateTimePicker ReturnDate;
        private ComboBox CBoxActivity;
        private TextBox txtDescription;
        private TextBox txtName;
        private DateTimePicker DepartureDate;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private Label label4;
        private Label label2;
        private TabPage tabPageList;
        private DataGridView dataGridItineraryView;
        private TabControl tabControl1;
    }
}