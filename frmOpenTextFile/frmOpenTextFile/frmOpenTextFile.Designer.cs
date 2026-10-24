namespace frmOpenTextFile
{
    partial class frmOpenTextFile
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
            lvShowText = new ListView();
            columnHeader1 = new ColumnHeader();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvShowText.Location = new Point(12, 12);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(397, 273);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 440;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(150, 291);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(115, 33);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 336);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "frmOpenTextFile";
            Text = "frmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private ColumnHeader columnHeader1;
    }
}
