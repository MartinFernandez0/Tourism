namespace TourismDesktop
{
    partial class MainMenuView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuView));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menubutton = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label2 = new Label();
            btnItineraryMain = new FontAwesome.Sharp.IconButton();
            btnDestinationMain = new FontAwesome.Sharp.IconButton();
            btnActivityMain = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnClientMain = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnCloseMain = new FontAwesome.Sharp.IconPictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 24, 29);
            sidebar.BackgroundImageLayout = ImageLayout.Zoom;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel2);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(240, 465);
            sidebar.MinimumSize = new Size(64, 465);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(240, 465);
            sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubutton);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 59);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 21);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 3;
            label1.Text = "TURISMOS ARG";
            // 
            // menubutton
            // 
            menubutton.BackColor = Color.Transparent;
            menubutton.BackgroundImageLayout = ImageLayout.Stretch;
            menubutton.IconChar = FontAwesome.Sharp.IconChar.Equals;
            menubutton.IconColor = Color.White;
            menubutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menubutton.IconSize = 37;
            menubutton.Location = new Point(15, 16);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(40, 37);
            menubutton.TabIndex = 3;
            menubutton.TabStop = false;
            menubutton.Click += menubutton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnItineraryMain);
            panel3.Controls.Add(btnDestinationMain);
            panel3.Controls.Add(btnActivityMain);
            panel3.Controls.Add(iconButton4);
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(btnClientMain);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(3, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 327);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 32);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 4;
            label2.Text = "Explora y Crea";
            // 
            // btnItineraryMain
            // 
            btnItineraryMain.BackColor = Color.Teal;
            btnItineraryMain.Cursor = Cursors.Hand;
            btnItineraryMain.FlatAppearance.BorderSize = 0;
            btnItineraryMain.FlatStyle = FlatStyle.Popup;
            btnItineraryMain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnItineraryMain.ForeColor = Color.Transparent;
            btnItineraryMain.IconChar = FontAwesome.Sharp.IconChar.None;
            btnItineraryMain.IconColor = Color.White;
            btnItineraryMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnItineraryMain.IconSize = 30;
            btnItineraryMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnItineraryMain.Location = new Point(90, 233);
            btnItineraryMain.Margin = new Padding(8, 15, 3, 3);
            btnItineraryMain.Name = "btnItineraryMain";
            btnItineraryMain.Padding = new Padding(7, 0, 0, 0);
            btnItineraryMain.Size = new Size(100, 34);
            btnItineraryMain.TabIndex = 15;
            btnItineraryMain.Text = "Itinerarios";
            btnItineraryMain.UseVisualStyleBackColor = false;
            btnItineraryMain.Click += btnItineraryMain_Click;
            // 
            // btnDestinationMain
            // 
            btnDestinationMain.BackColor = Color.Teal;
            btnDestinationMain.Cursor = Cursors.Hand;
            btnDestinationMain.FlatAppearance.BorderSize = 0;
            btnDestinationMain.FlatStyle = FlatStyle.Popup;
            btnDestinationMain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDestinationMain.ForeColor = Color.Transparent;
            btnDestinationMain.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDestinationMain.IconColor = Color.White;
            btnDestinationMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDestinationMain.IconSize = 30;
            btnDestinationMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnDestinationMain.Location = new Point(90, 181);
            btnDestinationMain.Margin = new Padding(8, 15, 3, 3);
            btnDestinationMain.Name = "btnDestinationMain";
            btnDestinationMain.Padding = new Padding(7, 0, 0, 0);
            btnDestinationMain.Size = new Size(100, 34);
            btnDestinationMain.TabIndex = 14;
            btnDestinationMain.Text = "Destinos";
            btnDestinationMain.UseVisualStyleBackColor = false;
            btnDestinationMain.Click += btnDestinationMain_Click;
            // 
            // btnActivityMain
            // 
            btnActivityMain.BackColor = Color.Teal;
            btnActivityMain.Cursor = Cursors.Hand;
            btnActivityMain.FlatAppearance.BorderSize = 0;
            btnActivityMain.FlatStyle = FlatStyle.Popup;
            btnActivityMain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnActivityMain.ForeColor = Color.Transparent;
            btnActivityMain.IconChar = FontAwesome.Sharp.IconChar.None;
            btnActivityMain.IconColor = Color.White;
            btnActivityMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivityMain.IconSize = 30;
            btnActivityMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivityMain.Location = new Point(90, 129);
            btnActivityMain.Margin = new Padding(8, 15, 3, 3);
            btnActivityMain.Name = "btnActivityMain";
            btnActivityMain.Padding = new Padding(7, 0, 0, 0);
            btnActivityMain.Size = new Size(100, 34);
            btnActivityMain.TabIndex = 13;
            btnActivityMain.Text = "Actividades";
            btnActivityMain.UseVisualStyleBackColor = false;
            btnActivityMain.Click += btnActivityMain_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Transparent;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Arrows;
            iconButton4.IconColor = Color.MediumTurquoise;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(6, 233);
            iconButton4.Margin = new Padding(8, 15, 3, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(7, 0, 0, 0);
            iconButton4.Size = new Size(52, 34);
            iconButton4.TabIndex = 12;
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.Transparent;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Plane;
            iconButton3.IconColor = Color.MediumTurquoise;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(6, 181);
            iconButton3.Margin = new Padding(8, 15, 3, 3);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(7, 0, 0, 0);
            iconButton3.Size = new Size(52, 34);
            iconButton3.TabIndex = 11;
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Transparent;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            iconButton2.IconColor = Color.MediumTurquoise;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(6, 129);
            iconButton2.Margin = new Padding(8, 15, 3, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(7, 0, 0, 0);
            iconButton2.Size = new Size(52, 34);
            iconButton2.TabIndex = 10;
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.MediumTurquoise;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(6, 82);
            iconButton1.Margin = new Padding(8, 15, 3, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(7, 0, 0, 0);
            iconButton1.Size = new Size(52, 34);
            iconButton1.TabIndex = 9;
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnClientMain
            // 
            btnClientMain.BackColor = Color.Teal;
            btnClientMain.Cursor = Cursors.Hand;
            btnClientMain.FlatAppearance.BorderSize = 0;
            btnClientMain.FlatStyle = FlatStyle.Popup;
            btnClientMain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientMain.ForeColor = Color.Transparent;
            btnClientMain.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClientMain.IconColor = Color.White;
            btnClientMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientMain.IconSize = 30;
            btnClientMain.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientMain.Location = new Point(90, 82);
            btnClientMain.Margin = new Padding(8, 15, 3, 3);
            btnClientMain.Name = "btnClientMain";
            btnClientMain.Padding = new Padding(7, 0, 0, 0);
            btnClientMain.Size = new Size(100, 34);
            btnClientMain.TabIndex = 4;
            btnClientMain.Text = "Usuarios";
            btnClientMain.UseVisualStyleBackColor = false;
            btnClientMain.Click += btnClientMain_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(btnCloseMain);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(3, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 59);
            panel2.TabIndex = 28;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(24, 24, 29);
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(181, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(42, 38);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // btnCloseMain
            // 
            btnCloseMain.BackColor = Color.FromArgb(24, 24, 29);
            btnCloseMain.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseMain.ForeColor = Color.Brown;
            btnCloseMain.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btnCloseMain.IconColor = Color.Brown;
            btnCloseMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseMain.IconSize = 38;
            btnCloseMain.Location = new Point(14, 12);
            btnCloseMain.Name = "btnCloseMain";
            btnCloseMain.Size = new Size(42, 38);
            btnCloseMain.TabIndex = 4;
            btnCloseMain.TabStop = false;
            btnCloseMain.Click += btnCloseMain_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(901, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 465);
            Controls.Add(sidebar);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(900, 465);
            Name = "MainMenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina Principal";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnClientMain;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox menubutton;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox btnCloseMain;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnActivityMain;
        private FontAwesome.Sharp.IconButton btnItineraryMain;
        private FontAwesome.Sharp.IconButton btnDestinationMain;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
