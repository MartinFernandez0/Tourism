namespace TourismDesktop.Views
{
    partial class DestinationView
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
            dataGridDestinationView = new DataGridView();
            tabPageAddEdit = new TabPage();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            CBoxItinerary = new ComboBox();
            pictureBoxDestinationList = new PictureBox();
            txtDescription = new TextBox();
            txtCountry = new TextBox();
            label7 = new Label();
            txtURL_image = new TextBox();
            label8 = new Label();
            txtCategoryName = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridDestinationView).BeginInit();
            tabPageAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestinationList).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(237, 91);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 51;
            label3.Text = "BUSCAR DESTINO";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(378, 86);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(278, 23);
            txtFilter.TabIndex = 50;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(24, 24, 29);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
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
            btnReturn.Location = new Point(834, 12);
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
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "DESTINOS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageAddEdit);
            tabControl1.Location = new Point(15, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 328);
            tabControl1.TabIndex = 44;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridDestinationView);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(633, 300);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "Lista";
            tabPageList.UseVisualStyleBackColor = true;
            // 
            // dataGridDestinationView
            // 
            dataGridDestinationView.AllowUserToAddRows = false;
            dataGridDestinationView.AllowUserToDeleteRows = false;
            dataGridDestinationView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDestinationView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDestinationView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridDestinationView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridDestinationView.Location = new Point(0, 0);
            dataGridDestinationView.Margin = new Padding(3, 2, 3, 2);
            dataGridDestinationView.Name = "dataGridDestinationView";
            dataGridDestinationView.ReadOnly = true;
            dataGridDestinationView.RowHeadersWidth = 51;
            dataGridDestinationView.Size = new Size(633, 298);
            dataGridDestinationView.TabIndex = 16;
            // 
            // tabPageAddEdit
            // 
            tabPageAddEdit.Controls.Add(btnSeeEliminated);
            tabPageAddEdit.Controls.Add(btnCancel);
            tabPageAddEdit.Controls.Add(btnSave);
            tabPageAddEdit.Controls.Add(label6);
            tabPageAddEdit.Controls.Add(CBoxItinerary);
            tabPageAddEdit.Controls.Add(pictureBoxDestinationList);
            tabPageAddEdit.Controls.Add(txtDescription);
            tabPageAddEdit.Controls.Add(txtCountry);
            tabPageAddEdit.Controls.Add(label7);
            tabPageAddEdit.Controls.Add(txtURL_image);
            tabPageAddEdit.Controls.Add(label8);
            tabPageAddEdit.Controls.Add(txtCategoryName);
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
            // btnSeeEliminated
            // 
            btnSeeEliminated.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeeEliminated.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnSeeEliminated.IconColor = Color.Black;
            btnSeeEliminated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeeEliminated.IconSize = 20;
            btnSeeEliminated.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeeEliminated.Location = new Point(306, 257);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 63;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            btnSeeEliminated.Click += btnSeeEliminated_Click;
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
            btnCancel.Location = new Point(527, 261);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 25);
            btnCancel.TabIndex = 62;
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
            btnSave.Location = new Point(421, 261);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 25);
            btnSave.TabIndex = 64;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 181);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 55;
            label6.Text = "Itinerario Disponible:";
            // 
            // CBoxItinerary
            // 
            CBoxItinerary.FormattingEnabled = true;
            CBoxItinerary.Location = new Point(421, 199);
            CBoxItinerary.Name = "CBoxItinerary";
            CBoxItinerary.Size = new Size(177, 23);
            CBoxItinerary.TabIndex = 54;
            // 
            // pictureBoxDestinationList
            // 
            pictureBoxDestinationList.Location = new Point(421, 28);
            pictureBoxDestinationList.Name = "pictureBoxDestinationList";
            pictureBoxDestinationList.Size = new Size(189, 126);
            pictureBoxDestinationList.TabIndex = 53;
            pictureBoxDestinationList.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(101, 70);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 23);
            txtDescription.TabIndex = 30;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(101, 184);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(269, 23);
            txtCountry.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 195);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 28;
            label7.Text = "Pais:";
            // 
            // txtURL_image
            // 
            txtURL_image.Location = new Point(101, 107);
            txtURL_image.Margin = new Padding(3, 2, 3, 2);
            txtURL_image.Name = "txtURL_image";
            txtURL_image.Size = new Size(269, 23);
            txtURL_image.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 118);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 26;
            label8.Text = "URL Image:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(101, 146);
            txtCategoryName.Margin = new Padding(3, 2, 3, 2);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(269, 23);
            txtCategoryName.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 157);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 20;
            label5.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 76);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 18;
            label4.Text = "Descripcion:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(101, 28);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(269, 23);
            txtFirstName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 39);
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
            btnDelete.Location = new Point(721, 295);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 45);
            btnDelete.TabIndex = 59;
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
            btnModify.Location = new Point(721, 209);
            btnModify.Margin = new Padding(3, 2, 3, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(130, 45);
            btnModify.TabIndex = 58;
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
            btnAdd.Location = new Point(721, 121);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 45);
            btnAdd.TabIndex = 57;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // DestinationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 465);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(btnModify);
            Controls.Add(txtFilter);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DestinationView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DestinationView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDestinationView).EndInit();
            tabPageAddEdit.ResumeLayout(false);
            tabPageAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestinationList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtFilter;
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageList;
        private DataGridView dataGridDestinationView;
        private TabPage tabPageAddEdit;
        private TextBox txtDescription;
        private TextBox txtCountry;
        private Label label7;
        private TextBox txtURL_image;
        private Label label8;
        private TextBox txtCategoryName;
        private Label label5;
        private Label label4;
        private TextBox txtFirstName;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnReturn;
        private PictureBox pictureBoxDestinationList;
        private Label label6;
        private ComboBox CBoxItinerary;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnModify;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnSeeEliminated;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}