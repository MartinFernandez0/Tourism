﻿namespace TourismDesktop.Views
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
            label26 = new Label();
            NumberTotalAmount = new NumericUpDown();
            label25 = new Label();
            dateTimeTransactionDate = new DateTimePicker();
            label24 = new Label();
            CBoxPaymentConfirmation = new ComboBox();
            label23 = new Label();
            CBoxPaymentMethod = new ComboBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            CBoxItinerary = new ComboBox();
            label19 = new Label();
            CBoxReservationStatus = new ComboBox();
            label18 = new Label();
            dateTimeReservation = new DateTimePicker();
            label17 = new Label();
            NumberOfPeople = new NumericUpDown();
            CBoxActivity = new ComboBox();
            CBoxDestination = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            CBoxAccommodationPreference = new ComboBox();
            CBoxFoodPreference = new ComboBox();
            txtPostalCode = new TextBox();
            label12 = new Label();
            txtCountry = new TextBox();
            label13 = new Label();
            txtCity = new TextBox();
            label14 = new Label();
            label11 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            CBoxGender = new ComboBox();
            Birthdate = new DateTimePicker();
            label9 = new Label();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            txtDocument = new TextBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            btnSeeEliminated = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnModify = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientView).BeginInit();
            tabPageAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberTotalAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPeople).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 43;
            label3.Text = "BUSCAR CLIENTE";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(142, 76);
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
            panel1.Size = new Size(1106, 63);
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
            tabControl1.Location = new Point(6, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1085, 432);
            tabControl1.TabIndex = 36;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridClientView);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(1077, 404);
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
            tabPageAddEdit.Controls.Add(label26);
            tabPageAddEdit.Controls.Add(NumberTotalAmount);
            tabPageAddEdit.Controls.Add(label25);
            tabPageAddEdit.Controls.Add(dateTimeTransactionDate);
            tabPageAddEdit.Controls.Add(label24);
            tabPageAddEdit.Controls.Add(CBoxPaymentConfirmation);
            tabPageAddEdit.Controls.Add(label23);
            tabPageAddEdit.Controls.Add(CBoxPaymentMethod);
            tabPageAddEdit.Controls.Add(label22);
            tabPageAddEdit.Controls.Add(label21);
            tabPageAddEdit.Controls.Add(label20);
            tabPageAddEdit.Controls.Add(CBoxItinerary);
            tabPageAddEdit.Controls.Add(label19);
            tabPageAddEdit.Controls.Add(CBoxReservationStatus);
            tabPageAddEdit.Controls.Add(label18);
            tabPageAddEdit.Controls.Add(dateTimeReservation);
            tabPageAddEdit.Controls.Add(label17);
            tabPageAddEdit.Controls.Add(NumberOfPeople);
            tabPageAddEdit.Controls.Add(CBoxActivity);
            tabPageAddEdit.Controls.Add(CBoxDestination);
            tabPageAddEdit.Controls.Add(label15);
            tabPageAddEdit.Controls.Add(label16);
            tabPageAddEdit.Controls.Add(CBoxAccommodationPreference);
            tabPageAddEdit.Controls.Add(CBoxFoodPreference);
            tabPageAddEdit.Controls.Add(txtPostalCode);
            tabPageAddEdit.Controls.Add(label12);
            tabPageAddEdit.Controls.Add(txtCountry);
            tabPageAddEdit.Controls.Add(label13);
            tabPageAddEdit.Controls.Add(txtCity);
            tabPageAddEdit.Controls.Add(label14);
            tabPageAddEdit.Controls.Add(label11);
            tabPageAddEdit.Controls.Add(txtAddress);
            tabPageAddEdit.Controls.Add(label10);
            tabPageAddEdit.Controls.Add(CBoxGender);
            tabPageAddEdit.Controls.Add(Birthdate);
            tabPageAddEdit.Controls.Add(label9);
            tabPageAddEdit.Controls.Add(txtLastName);
            tabPageAddEdit.Controls.Add(txtPhoneNumber);
            tabPageAddEdit.Controls.Add(label7);
            tabPageAddEdit.Controls.Add(txtDocument);
            tabPageAddEdit.Controls.Add(btnCancel);
            tabPageAddEdit.Controls.Add(btnSave);
            tabPageAddEdit.Controls.Add(label8);
            tabPageAddEdit.Controls.Add(txtEmail);
            tabPageAddEdit.Controls.Add(label5);
            tabPageAddEdit.Controls.Add(label4);
            tabPageAddEdit.Controls.Add(txtFirstName);
            tabPageAddEdit.Controls.Add(label2);
            tabPageAddEdit.Location = new Point(4, 24);
            tabPageAddEdit.Name = "tabPageAddEdit";
            tabPageAddEdit.Padding = new Padding(3);
            tabPageAddEdit.Size = new Size(1077, 404);
            tabPageAddEdit.TabIndex = 1;
            tabPageAddEdit.Text = "Agregar/Editar";
            tabPageAddEdit.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(661, 347);
            label26.Name = "label26";
            label26.Size = new Size(108, 15);
            label26.TabIndex = 101;
            label26.Text = "Cantidad Personas:";
            // 
            // NumberTotalAmount
            // 
            NumberTotalAmount.Location = new Point(821, 339);
            NumberTotalAmount.Name = "NumberTotalAmount";
            NumberTotalAmount.Size = new Size(64, 23);
            NumberTotalAmount.TabIndex = 100;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(695, 304);
            label25.Name = "label25";
            label25.Size = new Size(122, 15);
            label25.TabIndex = 99;
            label25.Text = "Fecha de Transaccion:";
            // 
            // dateTimeTransactionDate
            // 
            dateTimeTransactionDate.Format = DateTimePickerFormat.Custom;
            dateTimeTransactionDate.Location = new Point(821, 298);
            dateTimeTransactionDate.Name = "dateTimeTransactionDate";
            dateTimeTransactionDate.Size = new Size(98, 23);
            dateTimeTransactionDate.TabIndex = 98;
            dateTimeTransactionDate.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(690, 265);
            label24.Name = "label24";
            label24.Size = new Size(98, 15);
            label24.TabIndex = 97;
            label24.Text = "Metodo de pago:";
            // 
            // CBoxPaymentConfirmation
            // 
            CBoxPaymentConfirmation.FormattingEnabled = true;
            CBoxPaymentConfirmation.Location = new Point(825, 262);
            CBoxPaymentConfirmation.Name = "CBoxPaymentConfirmation";
            CBoxPaymentConfirmation.Size = new Size(198, 23);
            CBoxPaymentConfirmation.TabIndex = 96;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(690, 228);
            label23.Name = "label23";
            label23.Size = new Size(98, 15);
            label23.TabIndex = 95;
            label23.Text = "Metodo de pago:";
            // 
            // CBoxPaymentMethod
            // 
            CBoxPaymentMethod.FormattingEnabled = true;
            CBoxPaymentMethod.Location = new Point(825, 225);
            CBoxPaymentMethod.Name = "CBoxPaymentMethod";
            CBoxPaymentMethod.Size = new Size(198, 23);
            CBoxPaymentMethod.TabIndex = 94;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(316, 298);
            label22.Name = "label22";
            label22.Size = new Size(60, 15);
            label22.TabIndex = 93;
            label22.Text = "Actividad:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(316, 265);
            label21.Name = "label21";
            label21.Size = new Size(50, 15);
            label21.TabIndex = 92;
            label21.Text = "Destino:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(665, 183);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 91;
            label20.Text = "Itinerario:";
            // 
            // CBoxItinerary
            // 
            CBoxItinerary.FormattingEnabled = true;
            CBoxItinerary.Location = new Point(739, 180);
            CBoxItinerary.Name = "CBoxItinerary";
            CBoxItinerary.Size = new Size(150, 23);
            CBoxItinerary.TabIndex = 90;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(665, 128);
            label19.Name = "label19";
            label19.Size = new Size(124, 15);
            label19.TabIndex = 89;
            label19.Text = "Estado de reservación:";
            // 
            // CBoxReservationStatus
            // 
            CBoxReservationStatus.FormattingEnabled = true;
            CBoxReservationStatus.Location = new Point(791, 123);
            CBoxReservationStatus.Name = "CBoxReservationStatus";
            CBoxReservationStatus.Size = new Size(98, 23);
            CBoxReservationStatus.TabIndex = 88;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(665, 93);
            label18.Name = "label18";
            label18.Size = new Size(120, 15);
            label18.TabIndex = 87;
            label18.Text = "Fecha de reservación:";
            // 
            // dateTimeReservation
            // 
            dateTimeReservation.Format = DateTimePickerFormat.Custom;
            dateTimeReservation.Location = new Point(791, 87);
            dateTimeReservation.Name = "dateTimeReservation";
            dateTimeReservation.Size = new Size(98, 23);
            dateTimeReservation.TabIndex = 86;
            dateTimeReservation.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(665, 57);
            label17.Name = "label17";
            label17.Size = new Size(108, 15);
            label17.TabIndex = 85;
            label17.Text = "Cantidad Personas:";
            // 
            // NumberOfPeople
            // 
            NumberOfPeople.Location = new Point(825, 49);
            NumberOfPeople.Name = "NumberOfPeople";
            NumberOfPeople.Size = new Size(64, 23);
            NumberOfPeople.TabIndex = 84;
            // 
            // CBoxActivity
            // 
            CBoxActivity.FormattingEnabled = true;
            CBoxActivity.Location = new Point(384, 295);
            CBoxActivity.Name = "CBoxActivity";
            CBoxActivity.Size = new Size(198, 23);
            CBoxActivity.TabIndex = 83;
            // 
            // CBoxDestination
            // 
            CBoxDestination.FormattingEnabled = true;
            CBoxDestination.Location = new Point(384, 257);
            CBoxDestination.Name = "CBoxDestination";
            CBoxDestination.Size = new Size(198, 23);
            CBoxDestination.TabIndex = 82;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(316, 215);
            label15.Name = "label15";
            label15.Size = new Size(128, 15);
            label15.TabIndex = 81;
            label15.Text = "Preferencia de comida:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(316, 179);
            label16.Name = "label16";
            label16.Size = new Size(75, 15);
            label16.TabIndex = 80;
            label16.Text = "Alojamiento:";
            // 
            // CBoxAccommodationPreference
            // 
            CBoxAccommodationPreference.FormattingEnabled = true;
            CBoxAccommodationPreference.Location = new Point(445, 176);
            CBoxAccommodationPreference.Name = "CBoxAccommodationPreference";
            CBoxAccommodationPreference.Size = new Size(137, 23);
            CBoxAccommodationPreference.TabIndex = 79;
            // 
            // CBoxFoodPreference
            // 
            CBoxFoodPreference.FormattingEnabled = true;
            CBoxFoodPreference.Location = new Point(445, 210);
            CBoxFoodPreference.Name = "CBoxFoodPreference";
            CBoxFoodPreference.Size = new Size(137, 23);
            CBoxFoodPreference.TabIndex = 78;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.InactiveCaption;
            txtPostalCode.Location = new Point(384, 119);
            txtPostalCode.Margin = new Padding(3, 2, 3, 2);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(198, 23);
            txtPostalCode.TabIndex = 77;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(316, 127);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 76;
            label12.Text = "C.Postal:";
            // 
            // txtCountry
            // 
            txtCountry.BackColor = SystemColors.InactiveCaption;
            txtCountry.Location = new Point(384, 83);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(198, 23);
            txtCountry.TabIndex = 75;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(316, 91);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 74;
            label13.Text = "Pais:";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.InactiveCaption;
            txtCity.Location = new Point(384, 45);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(198, 23);
            txtCity.TabIndex = 73;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(316, 53);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 72;
            label14.Text = "Ciudad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 216);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 71;
            label11.Text = "Genero:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.InactiveCaption;
            txtAddress.Location = new Point(92, 331);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(198, 23);
            txtAddress.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 339);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 69;
            label10.Text = "Domicilio:";
            // 
            // CBoxGender
            // 
            CBoxGender.FormattingEnabled = true;
            CBoxGender.Location = new Point(92, 213);
            CBoxGender.Name = "CBoxGender";
            CBoxGender.Size = new Size(198, 23);
            CBoxGender.TabIndex = 68;
            // 
            // Birthdate
            // 
            Birthdate.Format = DateTimePickerFormat.Custom;
            Birthdate.Location = new Point(108, 176);
            Birthdate.Name = "Birthdate";
            Birthdate.Size = new Size(146, 23);
            Birthdate.TabIndex = 66;
            Birthdate.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, 158);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 65;
            label9.Text = "Fecha de Nacimiento:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.InactiveCaption;
            txtLastName.Location = new Point(92, 87);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(198, 23);
            txtLastName.TabIndex = 30;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.InactiveCaption;
            txtPhoneNumber.Location = new Point(92, 295);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(198, 23);
            txtPhoneNumber.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 303);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 28;
            label7.Text = "Telefono:";
            // 
            // txtDocument
            // 
            txtDocument.BackColor = SystemColors.InactiveCaption;
            txtDocument.Location = new Point(92, 124);
            txtDocument.Margin = new Padding(3, 2, 3, 2);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(198, 23);
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
            btnCancel.Location = new Point(1016, 360);
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
            btnSave.Location = new Point(968, 360);
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
            label8.Location = new Point(24, 132);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 26;
            label8.Text = "DNI CUIL:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(92, 257);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 23);
            txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 265);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 20;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 90);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 18;
            label4.Text = "Apellido:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.InactiveCaption;
            txtFirstName.Location = new Point(92, 45);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(198, 23);
            txtFirstName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 53);
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
            btnSeeEliminated.Location = new Point(527, 73);
            btnSeeEliminated.Margin = new Padding(3, 2, 3, 2);
            btnSeeEliminated.Name = "btnSeeEliminated";
            btnSeeEliminated.Size = new Size(100, 33);
            btnSeeEliminated.TabIndex = 63;
            btnSeeEliminated.UseVisualStyleBackColor = true;
            btnSeeEliminated.Click += btnSeeEliminated_Click;
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
            btnDelete.Location = new Point(934, 76);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 30);
            btnDelete.TabIndex = 67;
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
            btnModify.Location = new Point(794, 76);
            btnModify.Margin = new Padding(3, 2, 3, 2);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(105, 30);
            btnModify.TabIndex = 66;
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
            btnAdd.Location = new Point(656, 75);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 30);
            btnAdd.TabIndex = 65;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // ClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 554);
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
            ((System.ComponentModel.ISupportInitialize)NumberTotalAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPeople).EndInit();
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
        private ComboBox CBoxGender;
        private DateTimePicker Birthdate;
        private Label label9;
        private TextBox txtPostalCode;
        private Label label12;
        private TextBox txtCountry;
        private Label label13;
        private TextBox txtCity;
        private Label label14;
        private Label label11;
        private TextBox txtAddress;
        private Label label10;
        private ComboBox CBoxAccommodationPreference;
        private ComboBox CBoxFoodPreference;
        private Label label15;
        private Label label16;
        private ComboBox CBoxActivity;
        private ComboBox CBoxDestination;
        private Label label22;
        private Label label21;
        private Label label20;
        private ComboBox comboBox3;
        private Label label19;
        private ComboBox CBoxReservationStatus;
        private Label label18;
        private DateTimePicker dateTimeReservation;
        private Label label17;
        private NumericUpDown NumberOfPeople;
        private Label label26;
        private NumericUpDown NumberTotalAmount;
        private Label label25;
        private DateTimePicker dateTimeTransactionDate;
        private Label label24;
        private ComboBox CBoxPaymentConfirmation;
        private Label label23;
        private ComboBox CBoxPaymentMethod;
        private ComboBox CBoxItinerary;
    }
}