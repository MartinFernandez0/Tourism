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
            dataGridDestinationView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDestinationView).BeginInit();
            SuspendLayout();
            // 
            // dataGridDestinationView
            // 
            dataGridDestinationView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDestinationView.Location = new Point(154, 91);
            dataGridDestinationView.Name = "dataGridDestinationView";
            dataGridDestinationView.Size = new Size(498, 218);
            dataGridDestinationView.TabIndex = 0;
            // 
            // DestinationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridDestinationView);
            Name = "DestinationView";
            Text = "DestinationView";
            ((System.ComponentModel.ISupportInitialize)dataGridDestinationView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridDestinationView;
    }
}