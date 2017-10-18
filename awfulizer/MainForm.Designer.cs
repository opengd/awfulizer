/*
 * Created by SharpDevelop.
 * User: akeda
 * Date: 2011-09-08
 * Time: 18:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace awfulizer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControlMainWindow = new System.Windows.Forms.TabControl();
			this.tabPageSelectedFiles = new System.Windows.Forms.TabPage();
			this.buttonSelectFolder = new System.Windows.Forms.Button();
			this.buttonRemoveSelectedFiles = new System.Windows.Forms.Button();
			this.listViewInputFiles = new System.Windows.Forms.ListView();
			this.columnHeaderInputFiles = new System.Windows.Forms.ColumnHeader();
			this.imageListProfile = new System.Windows.Forms.ImageList(this.components);
			this.buttonClearFileList = new System.Windows.Forms.Button();
			this.buttonSelectFiles = new System.Windows.Forms.Button();
			this.tabPageRunLog = new System.Windows.Forms.TabPage();
			this.buttonClearLog = new System.Windows.Forms.Button();
			this.textBoxRunLog = new System.Windows.Forms.TextBox();
			this.tabPageSettings = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxOnTop = new System.Windows.Forms.CheckBox();
			this.checkBoxRemoveOutputFiles = new System.Windows.Forms.CheckBox();
			this.checkBoxRemoveFiles = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listViewDefaultProfiles = new System.Windows.Forms.ListView();
			this.columnHeaderProfile = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderPrefix = new System.Windows.Forms.ColumnHeader();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDefeultPrefix = new System.Windows.Forms.TextBox();
			this.buttonBatchProfile = new System.Windows.Forms.Button();
			this.buttonRemoveBatchProfile = new System.Windows.Forms.Button();
			this.textBoxSelectedBatchProfile = new System.Windows.Forms.TextBox();
			this.checkBoxBatchMode = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBoxQuickMode = new System.Windows.Forms.CheckBox();
			this.tabPageAbout = new System.Windows.Forms.TabPage();
			this.labelBuildNumber = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonRun = new System.Windows.Forms.Button();
			this.openFileDialogSelectFiles = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialogSelectProfile = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialogSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelNumberOffFiles = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBarFileProcessing = new System.Windows.Forms.ToolStripProgressBar();
			this.tabControlMainWindow.SuspendLayout();
			this.tabPageSelectedFiles.SuspendLayout();
			this.tabPageRunLog.SuspendLayout();
			this.tabPageSettings.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPageAbout.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Drop files and folders in window to add them to the processing list.";
			// 
			// tabControlMainWindow
			// 
			this.tabControlMainWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMainWindow.Controls.Add(this.tabPageSelectedFiles);
			this.tabControlMainWindow.Controls.Add(this.tabPageRunLog);
			this.tabControlMainWindow.Controls.Add(this.tabPageSettings);
			this.tabControlMainWindow.Controls.Add(this.tabPageAbout);
			this.tabControlMainWindow.Location = new System.Drawing.Point(4, 39);
			this.tabControlMainWindow.Name = "tabControlMainWindow";
			this.tabControlMainWindow.SelectedIndex = 0;
			this.tabControlMainWindow.Size = new System.Drawing.Size(447, 349);
			this.tabControlMainWindow.TabIndex = 1;
			this.tabControlMainWindow.SelectedIndexChanged += new System.EventHandler(this.TabControlMainWindowSelectedIndexChanged);
			// 
			// tabPageSelectedFiles
			// 
			this.tabPageSelectedFiles.Controls.Add(this.buttonSelectFolder);
			this.tabPageSelectedFiles.Controls.Add(this.buttonRemoveSelectedFiles);
			this.tabPageSelectedFiles.Controls.Add(this.listViewInputFiles);
			this.tabPageSelectedFiles.Controls.Add(this.buttonClearFileList);
			this.tabPageSelectedFiles.Controls.Add(this.buttonSelectFiles);
			this.tabPageSelectedFiles.Location = new System.Drawing.Point(4, 22);
			this.tabPageSelectedFiles.Name = "tabPageSelectedFiles";
			this.tabPageSelectedFiles.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSelectedFiles.Size = new System.Drawing.Size(439, 323);
			this.tabPageSelectedFiles.TabIndex = 0;
			this.tabPageSelectedFiles.Text = "Selected Files";
			this.tabPageSelectedFiles.UseVisualStyleBackColor = true;
			// 
			// buttonSelectFolder
			// 
			this.buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSelectFolder.Location = new System.Drawing.Point(249, 4);
			this.buttonSelectFolder.Name = "buttonSelectFolder";
			this.buttonSelectFolder.Size = new System.Drawing.Size(89, 23);
			this.buttonSelectFolder.TabIndex = 7;
			this.buttonSelectFolder.Text = "Select Folder...";
			this.buttonSelectFolder.UseVisualStyleBackColor = true;
			this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolderClick);
			// 
			// buttonRemoveSelectedFiles
			// 
			this.buttonRemoveSelectedFiles.Location = new System.Drawing.Point(92, 4);
			this.buttonRemoveSelectedFiles.Name = "buttonRemoveSelectedFiles";
			this.buttonRemoveSelectedFiles.Size = new System.Drawing.Size(102, 23);
			this.buttonRemoveSelectedFiles.TabIndex = 6;
			this.buttonRemoveSelectedFiles.Text = "Remove Selected";
			this.buttonRemoveSelectedFiles.UseVisualStyleBackColor = true;
			this.buttonRemoveSelectedFiles.Click += new System.EventHandler(this.ButtonRemoveSelectedFilesClick);
			// 
			// listViewInputFiles
			// 
			this.listViewInputFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewInputFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderInputFiles});
			this.listViewInputFiles.FullRowSelect = true;
			this.listViewInputFiles.GridLines = true;
			this.listViewInputFiles.LargeImageList = this.imageListProfile;
			this.listViewInputFiles.Location = new System.Drawing.Point(3, 33);
			this.listViewInputFiles.Name = "listViewInputFiles";
			this.listViewInputFiles.Size = new System.Drawing.Size(433, 287);
			this.listViewInputFiles.SmallImageList = this.imageListProfile;
			this.listViewInputFiles.TabIndex = 5;
			this.listViewInputFiles.UseCompatibleStateImageBehavior = false;
			this.listViewInputFiles.View = System.Windows.Forms.View.Details;
			this.listViewInputFiles.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ListViewInputFilesControlAdded);
			this.listViewInputFiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ListViewInputFilesControlRemoved);
			// 
			// columnHeaderInputFiles
			// 
			this.columnHeaderInputFiles.Tag = "Input Files";
			this.columnHeaderInputFiles.Text = "Input Files";
			this.columnHeaderInputFiles.Width = 500;
			// 
			// imageListProfile
			// 
			this.imageListProfile.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListProfile.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListProfile.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// buttonClearFileList
			// 
			this.buttonClearFileList.Location = new System.Drawing.Point(11, 4);
			this.buttonClearFileList.Name = "buttonClearFileList";
			this.buttonClearFileList.Size = new System.Drawing.Size(75, 23);
			this.buttonClearFileList.TabIndex = 4;
			this.buttonClearFileList.Text = "Clear List";
			this.buttonClearFileList.UseVisualStyleBackColor = true;
			this.buttonClearFileList.Click += new System.EventHandler(this.ButtonClearFileListClick);
			// 
			// buttonSelectFiles
			// 
			this.buttonSelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSelectFiles.Location = new System.Drawing.Point(344, 4);
			this.buttonSelectFiles.Name = "buttonSelectFiles";
			this.buttonSelectFiles.Size = new System.Drawing.Size(85, 23);
			this.buttonSelectFiles.TabIndex = 3;
			this.buttonSelectFiles.Text = "Select Files...";
			this.buttonSelectFiles.UseVisualStyleBackColor = true;
			this.buttonSelectFiles.Click += new System.EventHandler(this.ButtonSelectFilesClick);
			// 
			// tabPageRunLog
			// 
			this.tabPageRunLog.Controls.Add(this.buttonClearLog);
			this.tabPageRunLog.Controls.Add(this.textBoxRunLog);
			this.tabPageRunLog.Location = new System.Drawing.Point(4, 22);
			this.tabPageRunLog.Name = "tabPageRunLog";
			this.tabPageRunLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageRunLog.Size = new System.Drawing.Size(439, 323);
			this.tabPageRunLog.TabIndex = 1;
			this.tabPageRunLog.Text = "Run Log";
			this.tabPageRunLog.UseVisualStyleBackColor = true;
			// 
			// buttonClearLog
			// 
			this.buttonClearLog.Location = new System.Drawing.Point(358, 1);
			this.buttonClearLog.Name = "buttonClearLog";
			this.buttonClearLog.Size = new System.Drawing.Size(75, 23);
			this.buttonClearLog.TabIndex = 1;
			this.buttonClearLog.Text = "Clear";
			this.buttonClearLog.UseVisualStyleBackColor = true;
			this.buttonClearLog.Click += new System.EventHandler(this.ButtonClearLogClick);
			// 
			// textBoxRunLog
			// 
			this.textBoxRunLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRunLog.Location = new System.Drawing.Point(3, 25);
			this.textBoxRunLog.Multiline = true;
			this.textBoxRunLog.Name = "textBoxRunLog";
			this.textBoxRunLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxRunLog.Size = new System.Drawing.Size(436, 320);
			this.textBoxRunLog.TabIndex = 0;
			// 
			// tabPageSettings
			// 
			this.tabPageSettings.BackColor = System.Drawing.Color.White;
			this.tabPageSettings.Controls.Add(this.groupBox2);
			this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSettings.Size = new System.Drawing.Size(439, 323);
			this.tabPageSettings.TabIndex = 2;
			this.tabPageSettings.Text = "Settings";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxOnTop);
			this.groupBox2.Controls.Add(this.checkBoxRemoveOutputFiles);
			this.groupBox2.Controls.Add(this.checkBoxRemoveFiles);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.checkBoxQuickMode);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(433, 317);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Run Settings";
			// 
			// checkBoxOnTop
			// 
			this.checkBoxOnTop.Location = new System.Drawing.Point(272, 59);
			this.checkBoxOnTop.Name = "checkBoxOnTop";
			this.checkBoxOnTop.Size = new System.Drawing.Size(134, 24);
			this.checkBoxOnTop.TabIndex = 7;
			this.checkBoxOnTop.Text = "Main window On Top";
			this.checkBoxOnTop.UseVisualStyleBackColor = true;
			this.checkBoxOnTop.CheckedChanged += new System.EventHandler(this.CheckBoxOnTopCheckedChanged);
			// 
			// checkBoxRemoveOutputFiles
			// 
			this.checkBoxRemoveOutputFiles.Location = new System.Drawing.Point(272, 29);
			this.checkBoxRemoveOutputFiles.Name = "checkBoxRemoveOutputFiles";
			this.checkBoxRemoveOutputFiles.Size = new System.Drawing.Size(158, 24);
			this.checkBoxRemoveOutputFiles.TabIndex = 6;
			this.checkBoxRemoveOutputFiles.Text = "Only save last output file";
			this.checkBoxRemoveOutputFiles.UseVisualStyleBackColor = true;
			// 
			// checkBoxRemoveFiles
			// 
			this.checkBoxRemoveFiles.Checked = true;
			this.checkBoxRemoveFiles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRemoveFiles.Location = new System.Drawing.Point(6, 29);
			this.checkBoxRemoveFiles.Name = "checkBoxRemoveFiles";
			this.checkBoxRemoveFiles.Size = new System.Drawing.Size(239, 24);
			this.checkBoxRemoveFiles.TabIndex = 5;
			this.checkBoxRemoveFiles.Text = "Remove files from list after being processed";
			this.checkBoxRemoveFiles.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.listViewDefaultProfiles);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxDefeultPrefix);
			this.groupBox1.Controls.Add(this.buttonBatchProfile);
			this.groupBox1.Controls.Add(this.buttonRemoveBatchProfile);
			this.groupBox1.Controls.Add(this.textBoxSelectedBatchProfile);
			this.groupBox1.Controls.Add(this.checkBoxBatchMode);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(6, 89);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(420, 222);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Batch Mode";
			// 
			// listViewDefaultProfiles
			// 
			this.listViewDefaultProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewDefaultProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderProfile,
									this.columnHeaderPrefix});
			this.listViewDefaultProfiles.FullRowSelect = true;
			this.listViewDefaultProfiles.GridLines = true;
			this.listViewDefaultProfiles.LargeImageList = this.imageListProfile;
			this.listViewDefaultProfiles.Location = new System.Drawing.Point(6, 105);
			this.listViewDefaultProfiles.Name = "listViewDefaultProfiles";
			this.listViewDefaultProfiles.Size = new System.Drawing.Size(326, 111);
			this.listViewDefaultProfiles.SmallImageList = this.imageListProfile;
			this.listViewDefaultProfiles.TabIndex = 10;
			this.listViewDefaultProfiles.UseCompatibleStateImageBehavior = false;
			this.listViewDefaultProfiles.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderProfile
			// 
			this.columnHeaderProfile.Tag = "Profile";
			this.columnHeaderProfile.Text = "Profile";
			this.columnHeaderProfile.Width = 206;
			// 
			// columnHeaderPrefix
			// 
			this.columnHeaderPrefix.Tag = "Prefix";
			this.columnHeaderPrefix.Text = "Prefix";
			this.columnHeaderPrefix.Width = 182;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(232, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Extension ( * = all):";
			// 
			// textBoxDefeultPrefix
			// 
			this.textBoxDefeultPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDefeultPrefix.Location = new System.Drawing.Point(232, 79);
			this.textBoxDefeultPrefix.Name = "textBoxDefeultPrefix";
			this.textBoxDefeultPrefix.Size = new System.Drawing.Size(181, 20);
			this.textBoxDefeultPrefix.TabIndex = 8;
			this.textBoxDefeultPrefix.Text = "*";
			// 
			// buttonBatchProfile
			// 
			this.buttonBatchProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBatchProfile.Location = new System.Drawing.Point(338, 105);
			this.buttonBatchProfile.Name = "buttonBatchProfile";
			this.buttonBatchProfile.Size = new System.Drawing.Size(75, 23);
			this.buttonBatchProfile.TabIndex = 7;
			this.buttonBatchProfile.Text = "Add";
			this.buttonBatchProfile.UseVisualStyleBackColor = true;
			this.buttonBatchProfile.Click += new System.EventHandler(this.ButtonBatchProfileClick);
			// 
			// buttonRemoveBatchProfile
			// 
			this.buttonRemoveBatchProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveBatchProfile.Location = new System.Drawing.Point(338, 193);
			this.buttonRemoveBatchProfile.Name = "buttonRemoveBatchProfile";
			this.buttonRemoveBatchProfile.Size = new System.Drawing.Size(75, 23);
			this.buttonRemoveBatchProfile.TabIndex = 6;
			this.buttonRemoveBatchProfile.Text = "Remove";
			this.buttonRemoveBatchProfile.UseVisualStyleBackColor = true;
			this.buttonRemoveBatchProfile.Click += new System.EventHandler(this.ButtonRemoveBatchProfileClick);
			// 
			// textBoxSelectedBatchProfile
			// 
			this.textBoxSelectedBatchProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSelectedBatchProfile.Location = new System.Drawing.Point(6, 79);
			this.textBoxSelectedBatchProfile.Name = "textBoxSelectedBatchProfile";
			this.textBoxSelectedBatchProfile.Size = new System.Drawing.Size(220, 20);
			this.textBoxSelectedBatchProfile.TabIndex = 3;
			// 
			// checkBoxBatchMode
			// 
			this.checkBoxBatchMode.Location = new System.Drawing.Point(6, 16);
			this.checkBoxBatchMode.Name = "checkBoxBatchMode";
			this.checkBoxBatchMode.Size = new System.Drawing.Size(138, 24);
			this.checkBoxBatchMode.TabIndex = 0;
			this.checkBoxBatchMode.Text = "Automatic Batch Mode";
			this.checkBoxBatchMode.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Select Profile...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// checkBoxQuickMode
			// 
			this.checkBoxQuickMode.Checked = true;
			this.checkBoxQuickMode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxQuickMode.Location = new System.Drawing.Point(6, 59);
			this.checkBoxQuickMode.Name = "checkBoxQuickMode";
			this.checkBoxQuickMode.Size = new System.Drawing.Size(285, 24);
			this.checkBoxQuickMode.TabIndex = 2;
			this.checkBoxQuickMode.Text = "Quick Mode (\"Run Profile...\" will open on file drop)";
			this.checkBoxQuickMode.UseVisualStyleBackColor = true;
			// 
			// tabPageAbout
			// 
			this.tabPageAbout.Controls.Add(this.labelBuildNumber);
			this.tabPageAbout.Controls.Add(this.label6);
			this.tabPageAbout.Controls.Add(this.label5);
			this.tabPageAbout.Controls.Add(this.label4);
			this.tabPageAbout.Controls.Add(this.label2);
			this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
			this.tabPageAbout.Name = "tabPageAbout";
			this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAbout.Size = new System.Drawing.Size(439, 323);
			this.tabPageAbout.TabIndex = 3;
			this.tabPageAbout.Text = "About";
			this.tabPageAbout.UseVisualStyleBackColor = true;
			// 
			// labelBuildNumber
			// 
			this.labelBuildNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelBuildNumber.Location = new System.Drawing.Point(146, 71);
			this.labelBuildNumber.Name = "labelBuildNumber";
			this.labelBuildNumber.Size = new System.Drawing.Size(100, 23);
			this.labelBuildNumber.TabIndex = 4;
			this.labelBuildNumber.Text = "label7";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.Location = new System.Drawing.Point(111, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Build:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(77, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(289, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Images taken from: http://openiconlibrary.sourceforge.net/";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.Location = new System.Drawing.Point(193, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "@2011";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.Location = new System.Drawing.Point(111, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(228, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Awfulizer version \"Slighter better Working\"";
			// 
			// buttonRun
			// 
			this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRun.Location = new System.Drawing.Point(359, 12);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(82, 23);
			this.buttonRun.TabIndex = 3;
			this.buttonRun.Text = "Run Profile...";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.ButtonRunClick);
			// 
			// openFileDialogSelectFiles
			// 
			this.openFileDialogSelectFiles.Multiselect = true;
			this.openFileDialogSelectFiles.SupportMultiDottedExtensions = true;
			this.openFileDialogSelectFiles.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogSelectFilesFileOk);
			// 
			// openFileDialogSelectProfile
			// 
			this.openFileDialogSelectProfile.DefaultExt = "xml";
			this.openFileDialogSelectProfile.Filter = "xml|*.xml";
			this.openFileDialogSelectProfile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogSelectProfileFileOk);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabelNumberOffFiles,
									this.toolStripProgressBarFileProcessing});
			this.statusStrip1.Location = new System.Drawing.Point(0, 391);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip1.Size = new System.Drawing.Size(453, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStripMain";
			// 
			// toolStripStatusLabelNumberOffFiles
			// 
			this.toolStripStatusLabelNumberOffFiles.Name = "toolStripStatusLabelNumberOffFiles";
			this.toolStripStatusLabelNumberOffFiles.Size = new System.Drawing.Size(70, 17);
			this.toolStripStatusLabelNumberOffFiles.Text = "0 Input Files";
			// 
			// toolStripProgressBarFileProcessing
			// 
			this.toolStripProgressBarFileProcessing.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBarFileProcessing.Name = "toolStripProgressBarFileProcessing";
			this.toolStripProgressBarFileProcessing.Size = new System.Drawing.Size(100, 16);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 413);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.buttonRun);
			this.Controls.Add(this.tabControlMainWindow);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Awfulizer - main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
			this.tabControlMainWindow.ResumeLayout(false);
			this.tabPageSelectedFiles.ResumeLayout(false);
			this.tabPageRunLog.ResumeLayout(false);
			this.tabPageRunLog.PerformLayout();
			this.tabPageSettings.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPageAbout.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelBuildNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarFileProcessing;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNumberOffFiles;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button buttonClearLog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSelectFolder;
		private System.Windows.Forms.Button buttonSelectFolder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPageAbout;
		private System.Windows.Forms.CheckBox checkBoxOnTop;
		private System.Windows.Forms.CheckBox checkBoxRemoveOutputFiles;
		private System.Windows.Forms.TextBox textBoxRunLog;
		private System.Windows.Forms.Button buttonRemoveSelectedFiles;
		private System.Windows.Forms.ColumnHeader columnHeaderInputFiles;
		private System.Windows.Forms.ListView listViewInputFiles;
		private System.Windows.Forms.ImageList imageListProfile;
		private System.Windows.Forms.ColumnHeader columnHeaderPrefix;
		private System.Windows.Forms.ColumnHeader columnHeaderProfile;
		private System.Windows.Forms.ListView listViewDefaultProfiles;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControlMainWindow;
		private System.Windows.Forms.TabPage tabPageSelectedFiles;
		private System.Windows.Forms.TabPage tabPageRunLog;
		private System.Windows.Forms.TabPage tabPageSettings;
		private System.Windows.Forms.Button buttonSelectFiles;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.CheckBox checkBoxQuickMode;
		private System.Windows.Forms.CheckBox checkBoxBatchMode;
		private System.Windows.Forms.Button buttonClearFileList;
		private System.Windows.Forms.OpenFileDialog openFileDialogSelectFiles;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxSelectedBatchProfile;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialogSelectProfile;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxRemoveFiles;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxDefeultPrefix;
		private System.Windows.Forms.Button buttonRemoveBatchProfile;
		private System.Windows.Forms.Button buttonBatchProfile;
		private System.Windows.Forms.ListBox listBox1;
	}
}
