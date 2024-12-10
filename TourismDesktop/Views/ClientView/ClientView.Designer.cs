namespace TourismDesktop.Views
{
    partial class ClientView
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
            dataGridClientView = new DataGridView();
            tabPageAddEdit = new TabPage();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            txtDocument = new TextBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            DateBirth = new DateTimePicker();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnModify = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientView).BeginInit();
            tabPageAddEdit.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 90);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 43;
            label3.Text = "BUSCAR CLIENTE";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(381, 86);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(278, 23);
            txtFilter.TabIndex = 42;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(24, 24, 29);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 63);
            panel1.TabIndex = 37;
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
            btnReturn.Location = new Point(831, 12);
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
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageAddEdit);
            tabControl1.Location = new Point(18, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 328);
            tabControl1.TabIndex = 36;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridClientView);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(633, 300);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "Lista";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridClientView
            // 
            dataGridClientView.AllowUserToAddRows = false;
            dataGridClientView.AllowUserToDeleteRows = false;
            dataGridClientView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridClientView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridClientView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridClientView.Location = new Point(0, 0);
            dataGridClientView.Margin = new Padding(3, 2, 3, 2);
            dataGridClientView.Name = "dataGridClientView";
            dataGridClientView.ReadOnly = true;
            dataGridClientView.RowHeadersWidth = 51;
            dataGridClientView.Size = new Size(633, 298);
            dataGridClientView.TabIndex = 16;
            // 
            // tabPageAddEdit
            // 
            tabPageAddEdit.Controls.Add(txtLastName);
            tabPageAddEdit.Controls.Add(txtPhoneNumber);
            tabPageAddEdit.Controls.Add(label7);
            tabPageAddEdit.Controls.Add(txtDocument);
            tabPageAddEdit.Controls.Add(btnCancel);
            tabPageAddEdit.Controls.Add(btnSave);
            tabPageAddEdit.Controls.Add(label8);
            tabPageAddEdit.Controls.Add(DateBirth);
            tabPageAddEdit.Controls.Add(label6);
            tabPageAddEdit.Controls.Add(txtEmail);
            tabPageAddEdit.Controls.Add(label5);
            tabPageAddEdit.Controls.Add(label4);
            tabPageAddEdit.Controls.Add(txtFirstName);
            tabPageAddEdit.Controls.Add(label2);
            tabPageAddEdit.Location = new Point(4, 24);
            tabPageAddEdit.Name = "tabPageAddEdit";
            tabPageAddEdit.Padding = new Padding(3);
            tabPageAddEdit.Size = new Size(633, 300);
            tabPageAddEdit.TabIndex = 1;
            tabPageAddEdit.Text = "Agregar/Editar";
            tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.InactiveCaption;
            txtLastName.Location = new Point(94, 63);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(269, 23);
            txtLastName.TabIndex = 30;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.InactiveCaption;
            txtPhoneNumber.Location = new Point(94, 177);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(269, 23);
            txtPhoneNumber.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 185);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 28;
            label7.Text = "Telefono:";
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(740, 358);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 63;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            btnSeeEliminated.Click += btnSeeEliminated_Click;
            // 
            // txtDocument
            // 
            txtDocument.BackColor = SystemColors.InactiveCaption;
            txtDocument.Location = new Point(94, 100);
            txtDocument.Margin = new Padding(3, 2, 3, 2);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(269, 23);
            txtDocument.TabIndex = 27;
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
            btnCancel.Location = new Point(565, 252);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(42, 39);
            btnCancel.TabIndex = 62;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnSave.Location = new Point(517, 252);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(42, 39);
            btnSave.TabIndex = 64;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 108);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 26;
            label8.Text = "DNI CUIL:";
            // 
            // DateBirth
            // 
            DateBirth.Format = DateTimePickerFormat.Custom;
            DateBirth.Location = new Point(442, 42);
            DateBirth.Name = "DateBirth";
            DateBirth.Size = new Size(146, 23);
            DateBirth.TabIndex = 23;
            DateBirth.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 24);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 22;
            label6.Text = "Fecha de Registro:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(94, 139);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 147);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 20;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 66);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 18;
            label4.Text = "Apellido:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.InactiveCaption;
            txtFirstName.Location = new Point(94, 21);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(269, 23);
            txtFirstName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 29);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
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
            btnDelete.Location = new Point(728, 292);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 45);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
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
            btnModify.Location = new Point(728, 206);
            btnModify.Margin = new Padding(3, 2, 3, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(130, 45);
            btnModify.TabIndex = 66;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click_1;
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
            btnAdd.Location = new Point(728, 118);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 45);
            btnAdd.TabIndex = 65;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // ClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 465);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(btnSeeEliminated);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClientView).EndInit();
            tabPageAddEdit.ResumeLayout(false);
            tabPageAddEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtFilter;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageList;
        private DataGridView dataGridClientView;
        private TabPage tabPageAddEdit;
        private ComboBox comboBoxLocalidades;
        private DateTimePicker DateBirth;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Label label7;
        private TextBox txtDocument;
        private Label label8;
        private TextBox txtLastName;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private FontAwesome.Sharp.IconButton btnAdd;
    }
}