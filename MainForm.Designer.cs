
namespace SubtitleFileNameSync
{
    partial class MainForm
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
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.lstSubtitles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVideosFolder = new System.Windows.Forms.Button();
            this.btnSubtitlesFolder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVideos
            // 
            this.lstVideos.AllowDrop = true;
            this.lstVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVideos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.HorizontalScrollbar = true;
            this.lstVideos.ItemHeight = 21;
            this.lstVideos.Location = new System.Drawing.Point(3, 43);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(382, 409);
            this.lstVideos.TabIndex = 0;
            this.lstVideos.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstVideos.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstVideos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstSubtitles
            // 
            this.lstSubtitles.AllowDrop = true;
            this.lstSubtitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSubtitles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSubtitles.FormattingEnabled = true;
            this.lstSubtitles.HorizontalScrollbar = true;
            this.lstSubtitles.ItemHeight = 21;
            this.lstSubtitles.Location = new System.Drawing.Point(391, 43);
            this.lstSubtitles.Name = "lstSubtitles";
            this.lstSubtitles.Size = new System.Drawing.Size(382, 409);
            this.lstSubtitles.TabIndex = 1;
            this.lstSubtitles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstSubtitles.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstSubtitles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstVideos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstSubtitles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVideosFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtitlesFolder, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 455);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnVideosFolder
            // 
            this.btnVideosFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVideosFolder.AutoSize = true;
            this.btnVideosFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideosFolder.Location = new System.Drawing.Point(115, 4);
            this.btnVideosFolder.Name = "btnVideosFolder";
            this.btnVideosFolder.Size = new System.Drawing.Size(158, 31);
            this.btnVideosFolder.TabIndex = 3;
            this.btnVideosFolder.Text = "Videos Folder";
            this.btnVideosFolder.UseVisualStyleBackColor = true;
            this.btnVideosFolder.Click += new System.EventHandler(this.btnMoviesFolder_Click);
            // 
            // btnSubtitlesFolder
            // 
            this.btnSubtitlesFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubtitlesFolder.AutoSize = true;
            this.btnSubtitlesFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtitlesFolder.Location = new System.Drawing.Point(498, 4);
            this.btnSubtitlesFolder.Name = "btnSubtitlesFolder";
            this.btnSubtitlesFolder.Size = new System.Drawing.Size(168, 31);
            this.btnSubtitlesFolder.TabIndex = 4;
            this.btnSubtitlesFolder.Text = "Subtitles Folder";
            this.btnSubtitlesFolder.UseVisualStyleBackColor = true;
            this.btnSubtitlesFolder.Click += new System.EventHandler(this.btnOriginalSubtitlesFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(269, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(403, 473);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "SubtitleFileNameSync";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.ListBox lstSubtitles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnVideosFolder;
        private System.Windows.Forms.Button btnSubtitlesFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}

