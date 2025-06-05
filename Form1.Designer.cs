namespace IDZ_OPI
{
    partial class Form1
{
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            openFile = new Button();
            filename = new TextBox();
            label1 = new Label();
            source = new TextBox();
            label2 = new Label();
            openFileDialog = new OpenFileDialog();
            statistics = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            save = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            cut = new ToolStripMenuItem();
            cutMenu = new ToolStripMenuItem();
            copy = new ToolStripMenuItem();
            paste = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutAuthor = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            getStatistics = new ToolStripMenuItem();
            getCorrectMailAdresses = new ToolStripMenuItem();
            copyFile = new ToolStripMenuItem();
            panel1 = new Panel();
            label3 = new Label();
            saveFileDialog = new SaveFileDialog();
            getNews = new Button();
            label4 = new Label();
            maxVal = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFile
            // 
            openFile.FlatAppearance.BorderColor = Color.Navy;
            openFile.FlatAppearance.BorderSize = 4;
            openFile.FlatAppearance.MouseDownBackColor = Color.MintCream;
            openFile.FlatAppearance.MouseOverBackColor = Color.MintCream;
            openFile.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point);
            openFile.Location = new Point(21, 89);
            openFile.Margin = new Padding(3, 4, 3, 4);
            openFile.Name = "openFile";
            openFile.Size = new Size(120, 45);
            openFile.TabIndex = 0;
            openFile.Text = "Open file";
            openFile.UseVisualStyleBackColor = true;
            openFile.Click += openFile_Click;
            // 
            // filename
            // 
            filename.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            filename.Location = new Point(161, 94);
            filename.Margin = new Padding(3, 4, 3, 4);
            filename.Multiline = true;
            filename.Name = "filename";
            filename.Size = new Size(309, 83);
            filename.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(169, 51);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 3;
            label1.Text = "The name of a file";
            // 
            // source
            // 
            source.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            source.Location = new Point(21, 295);
            source.Margin = new Padding(3, 4, 3, 4);
            source.Multiline = true;
            source.Name = "source";
            source.ScrollBars = ScrollBars.Vertical;
            source.Size = new Size(631, 483);
            source.TabIndex = 5;
            source.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 254);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 6;
            label2.Text = "View contents:";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "All files | *.*";
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // statistics
            // 
            statistics.BackColor = Color.LightSteelBlue;
            statistics.BorderStyle = BorderStyle.None;
            statistics.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            statistics.Location = new Point(686, 100);
            statistics.Margin = new Padding(3, 4, 3, 4);
            statistics.Multiline = true;
            statistics.Name = "statistics";
            statistics.Size = new Size(312, 688);
            statistics.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, cut, aboutToolStripMenuItem, statisticsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { open, save, exit });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 24);
            toolStripMenuItem1.Text = "File";
            // 
            // open
            // 
            open.Name = "open";
            open.Size = new Size(128, 26);
            open.Text = "Open";
            open.Click += open_Click;
            // 
            // save
            // 
            save.Name = "save";
            save.Size = new Size(128, 26);
            save.Text = "Save";
            save.Click += save_Click;
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.Size = new Size(128, 26);
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // cut
            // 
            cut.DropDownItems.AddRange(new ToolStripItem[] { cutMenu, copy, paste });
            cut.Name = "cut";
            cut.Size = new Size(49, 24);
            cut.Text = "Edit";
            // 
            // cutMenu
            // 
            cutMenu.Name = "cutMenu";
            cutMenu.Size = new Size(126, 26);
            cutMenu.Text = "Cut";
            cutMenu.Click += cutMenu_Click;
            // 
            // copy
            // 
            copy.Name = "copy";
            copy.Size = new Size(126, 26);
            copy.Text = "Copy";
            copy.Click += copy_Click;
            // 
            // paste
            // 
            paste.Name = "paste";
            paste.Size = new Size(126, 26);
            paste.Text = "Paste";
            paste.Click += paste_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutAuthor });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutAuthor
            // 
            aboutAuthor.Name = "aboutAuthor";
            aboutAuthor.Size = new Size(158, 26);
            aboutAuthor.Text = "About file";
            aboutAuthor.Click += aboutAuthor_Click;
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getStatistics, getCorrectMailAdresses, copyFile });
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(81, 24);
            statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // getStatistics
            // 
            getStatistics.Name = "getStatistics";
            getStatistics.Size = new Size(266, 26);
            getStatistics.Text = "Get statistics";
            getStatistics.Click += getStatistics_Click;
            // 
            // getCorrectMailAdresses
            // 
            getCorrectMailAdresses.Name = "getCorrectMailAdresses";
            getCorrectMailAdresses.Size = new Size(266, 26);
            getCorrectMailAdresses.Text = "Get correct email adresses";
            getCorrectMailAdresses.Click += getCorrectMailAdresses_Click;
            // 
            // copyFile
            // 
            copyFile.Name = "copyFile";
            copyFile.Size = new Size(266, 26);
            copyFile.Text = "Copy file";
            copyFile.Click += copyFile_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(670, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 871);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(788, 51);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 13;
            label3.Text = "File statictics";
            // 
            // getNews
            // 
            getNews.FlatAppearance.BorderColor = Color.Navy;
            getNews.FlatAppearance.BorderSize = 4;
            getNews.FlatAppearance.MouseDownBackColor = Color.MintCream;
            getNews.FlatAppearance.MouseOverBackColor = Color.MintCream;
            getNews.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point);
            getNews.Location = new Point(21, 141);
            getNews.Margin = new Padding(3, 4, 3, 4);
            getNews.Name = "getNews";
            getNews.Size = new Size(120, 36);
            getNews.TabIndex = 16;
            getNews.Text = "Load news";
            getNews.UseVisualStyleBackColor = true;
            getNews.Click += getNews_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 196);
            label4.Name = "label4";
            label4.Size = new Size(250, 18);
            label4.TabIndex = 17;
            label4.Text = "Enter the number of news items:";
            // 
            // maxVal
            // 
            maxVal.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maxVal.Location = new Point(278, 190);
            maxVal.Margin = new Padding(3, 4, 3, 4);
            maxVal.Multiline = true;
            maxVal.Name = "maxVal";
            maxVal.Size = new Size(149, 38);
            maxVal.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1010, 791);
            Controls.Add(maxVal);
            Controls.Add(label4);
            Controls.Add(getNews);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(statistics);
            Controls.Add(label2);
            Controls.Add(source);
            Controls.Add(label1);
            Controls.Add(filename);
            Controls.Add(openFile);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFile;
    private System.Windows.Forms.TextBox filename;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox source;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.TextBox statistics;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem open;
    private System.Windows.Forms.ToolStripMenuItem save;
    private System.Windows.Forms.ToolStripMenuItem exit;
    private System.Windows.Forms.ToolStripMenuItem cut;
    private System.Windows.Forms.ToolStripMenuItem cutMenu;
    private System.Windows.Forms.ToolStripMenuItem copy;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutAuthor;
    private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem getStatistics;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolStripMenuItem paste;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.ToolStripMenuItem getCorrectMailAdresses;
    private System.Windows.Forms.ToolStripMenuItem copyFile;
    private System.Windows.Forms.Button getNews;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox maxVal;
    }
}
