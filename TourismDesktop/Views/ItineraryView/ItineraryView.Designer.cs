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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label3 = new Label();
            txtFilter = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnModify = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnReturn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageList = new TabPage();
            dataGridItineraryView = new DataGridView();
            tabPageAddEdit = new TabPage();
            ReturnDate = new DateTimePicker();
            CBoxActivity = new ComboBox();
            txtDescription = new TextBox();
            DepartureDate = new DateTimePicker();
            label6 = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            tabPageDelete = new TabPage();
            dataGridItineraryDelete = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryView).BeginInit();
            tabPageAddEdit.SuspendLayout();
            tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryDelete).BeginInit();
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
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 20;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(721, 79);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(127, 38);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "Busqueda";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(721, 264);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 38);
            btnDelete.TabIndex = 56;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModify.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnModify.IconColor = Color.Black;
            btnModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModify.IconSize = 20;
            btnModify.ImageAlign = ContentAlignment.MiddleLeft;
            btnModify.Location = new Point(721, 222);
            btnModify.Margin = new Padding(3, 2, 3, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(127, 38);
            btnModify.TabIndex = 55;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 20;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(721, 180);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 38);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
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
            btnReturn.Location = new Point(764, 13);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageAddEdit);
            tabControl1.Controls.Add(tabPageDelete);
            tabControl1.Location = new Point(17, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 328);
            tabControl1.TabIndex = 52;
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
            dataGridItineraryView.Location = new Point(6, 6);
            dataGridItineraryView.Margin = new Padding(3, 2, 3, 2);
            dataGridItineraryView.Name = "dataGridItineraryView";
            dataGridItineraryView.ReadOnly = true;
            dataGridItineraryView.RowHeadersWidth = 51;
            dataGridItineraryView.Size = new Size(1487, 686);
            dataGridItineraryView.TabIndex = 16;
            // 
            // tabPageAddEdit
            // 
            tabPageAddEdit.Controls.Add(ReturnDate);
            tabPageAddEdit.Controls.Add(CBoxActivity);
            tabPageAddEdit.Controls.Add(txtDescription);
            tabPageAddEdit.Controls.Add(DepartureDate);
            tabPageAddEdit.Controls.Add(label6);
            tabPageAddEdit.Controls.Add(btnCancel);
            tabPageAddEdit.Controls.Add(btnSave);
            tabPageAddEdit.Controls.Add(label4);
            tabPageAddEdit.Controls.Add(txtName);
            tabPageAddEdit.Controls.Add(label2);
            tabPageAddEdit.Location = new Point(4, 24);
            tabPageAddEdit.Name = "tabPageAddEdit";
            tabPageAddEdit.Padding = new Padding(3);
            tabPageAddEdit.Size = new Size(633, 300);
            tabPageAddEdit.TabIndex = 1;
            tabPageAddEdit.Text = "Agregar/Editar";
            tabPageAddEdit.UseVisualStyleBackColor = true;
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
            CBoxActivity.Location = new Point(159, 237);
            CBoxActivity.Name = "CBoxActivity";
            CBoxActivity.Size = new Size(121, 23);
            CBoxActivity.TabIndex = 31;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 80);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 23);
            txtDescription.TabIndex = 30;
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
            label6.Location = new Point(6, 137);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 22;
            label6.Text = "Fecha de Registro:";
            // 
            // btnCancel
            // 
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 35;
            btnCancel.Location = new Point(427, 125);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(182, 27);
            btnCancel.TabIndex = 17;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 24, 29);
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 20;
            btnSave.Location = new Point(427, 74);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 32);
            btnSave.TabIndex = 16;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 89);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 18;
            label4.Text = "Apellido:";
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 38);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 23);
            txtName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(721, 386);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(127, 38);
            btnSeeEliminated.TabIndex = 60;
            btnSeeEliminated.Text = "Papelera";
            btnSeeEliminated.UseVisualStyleBackColor = true;
            btnSeeEliminated.Click += btnSeeEliminated_Click;
            // 
            // tabPageDelete
            // 
            tabPageDelete.Controls.Add(dataGridItineraryDelete);
            tabPageDelete.Location = new Point(4, 24);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Padding = new Padding(3);
            tabPageDelete.Size = new Size(633, 300);
            tabPageDelete.TabIndex = 2;
            tabPageDelete.Text = "Papelera";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridItineraryDelete
            // 
            dataGridItineraryDelete.AllowUserToAddRows = false;
            dataGridItineraryDelete.AllowUserToDeleteRows = false;
            dataGridItineraryDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridItineraryDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridItineraryDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridItineraryDelete.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridItineraryDelete.Location = new Point(-427, -193);
            dataGridItineraryDelete.Margin = new Padding(3, 2, 3, 2);
            dataGridItineraryDelete.Name = "dataGridItineraryDelete";
            dataGridItineraryDelete.ReadOnly = true;
            dataGridItineraryDelete.RowHeadersWidth = 51;
            dataGridItineraryDelete.Size = new Size(1487, 686);
            dataGridItineraryDelete.TabIndex = 17;
            // 
            // ItineraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 465);
            Controls.Add(btnSeeEliminated);
            Controls.Add(label3);
            Controls.Add(txtFilter);
            Controls.Add(btnSearch);
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
            tabControl1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryView).EndInit();
            tabPageAddEdit.ResumeLayout(false);
            tabPageAddEdit.PerformLayout();
            tabPageDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtFilter;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private FontAwesome.Sharp.IconButton btnAdd;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnReturn;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageList;
        private DataGridView dataGridItineraryView;
        private TabPage tabPageAddEdit;
        private TextBox txtDescription;
        private DateTimePicker DepartureDate;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private ComboBox CBoxActivity;
        private DateTimePicker ReturnDate;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        private TabPage tabPageDelete;
        private DataGridView dataGridItineraryDelete;
    }
}