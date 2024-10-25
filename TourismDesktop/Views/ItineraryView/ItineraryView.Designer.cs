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
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            txtDocument = new TextBox();
            label8 = new Label();
            DateBirth = new DateTimePicker();
            label6 = new Label();
            txtEmail = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridItineraryView).BeginInit();
            tabPageAddEdit.SuspendLayout();
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
            tabPageAddEdit.Controls.Add(txtLastName);
            tabPageAddEdit.Controls.Add(txtPhoneNumber);
            tabPageAddEdit.Controls.Add(label7);
            tabPageAddEdit.Controls.Add(txtDocument);
            tabPageAddEdit.Controls.Add(label8);
            tabPageAddEdit.Controls.Add(DateBirth);
            tabPageAddEdit.Controls.Add(label6);
            tabPageAddEdit.Controls.Add(txtEmail);
            tabPageAddEdit.Controls.Add(btnCancelar);
            tabPageAddEdit.Controls.Add(btnGuardar);
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
            txtLastName.Location = new Point(100, 80);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(269, 23);
            txtLastName.TabIndex = 30;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(100, 194);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(269, 23);
            txtPhoneNumber.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 208);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 28;
            label7.Text = "Telefono:";
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(100, 117);
            txtDocument.Margin = new Padding(3, 2, 3, 2);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(269, 23);
            txtDocument.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 131);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 26;
            label8.Text = "DNI CUIL:";
            // 
            // DateBirth
            // 
            DateBirth.Format = DateTimePickerFormat.Custom;
            DateBirth.Location = new Point(144, 257);
            DateBirth.Name = "DateBirth";
            DateBirth.Size = new Size(146, 23);
            DateBirth.TabIndex = 23;
            DateBirth.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 245);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 22;
            label6.Text = "Fecha de Registro:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 156);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 35;
            btnCancelar.Location = new Point(427, 125);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(182, 27);
            btnCancelar.TabIndex = 17;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 24, 29);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(427, 74);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(182, 32);
            btnGuardar.TabIndex = 16;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 170);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 20;
            label5.Text = "Email:";
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
            // txtFirstName
            // 
            txtFirstName.Location = new Point(100, 38);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(269, 23);
            txtFirstName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // ItineraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 465);
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
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private Label label7;
        private TextBox txtDocument;
        private Label label8;
        private DateTimePicker DateBirth;
        private Label label6;
        private TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label5;
        private Label label4;
        private TextBox txtFirstName;
        private Label label2;
    }
}