/*
 * Created by SharpDevelop.
 * User: akeda
 * Date: 2011-09-08
 * Time: 18:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace awfulizer
{
	partial class choose
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageChooseProfile = new System.Windows.Forms.TabPage();
			this.progressBarProcessingProgress = new System.Windows.Forms.ProgressBar();
			this.buttonRun = new System.Windows.Forms.Button();
			this.tabControlRun = new System.Windows.Forms.TabControl();
			this.tabPageSingle = new System.Windows.Forms.TabPage();
			this.comboBoxProfilePicker = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxOutputFilename = new System.Windows.Forms.TextBox();
			this.buttonChooseProfile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownRPM = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPageMulti = new System.Windows.Forms.TabPage();
			this.numericUpDownMultiTimes = new System.Windows.Forms.NumericUpDown();
			this.buttonMultiDown = new System.Windows.Forms.Button();
			this.buttonMultiUp = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.checkBoxMultiPipe = new System.Windows.Forms.CheckBox();
			this.comboBoxMultiProfile = new System.Windows.Forms.ComboBox();
			this.buttonMultiProfileChoose = new System.Windows.Forms.Button();
			this.buttonRemoveMultiProfile = new System.Windows.Forms.Button();
			this.buttonAddMultiProfile = new System.Windows.Forms.Button();
			this.listViewMutiProfiles = new System.Windows.Forms.ListView();
			this.columnHeaderMultiProfile = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderTimes = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderPipe = new System.Windows.Forms.ColumnHeader();
			this.imageListMultiProfile = new System.Windows.Forms.ImageList(this.components);
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBoxLogBox = new System.Windows.Forms.TextBox();
			this.tabPageAddEditProfile = new System.Windows.Forms.TabPage();
			this.buttonOpenProfile = new System.Windows.Forms.Button();
			this.buttonNewProfile = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.numericUpDownDefaultPipeTimes = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.buttonSelectOutputFolder = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxDefaultOutputFolder = new System.Windows.Forms.TextBox();
			this.textBoxDefaultOutput = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelVariables = new System.Windows.Forms.Label();
			this.textBoxVariables = new System.Windows.Forms.TextBox();
			this.buttonSelectCommand = new System.Windows.Forms.Button();
			this.textBoxCommand = new System.Windows.Forms.TextBox();
			this.buttonSaveProfile = new System.Windows.Forms.Button();
			this.openFileDialogChooseProfile = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialogSelectCommand = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogSaveProfile = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialogOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.processRunner = new System.Diagnostics.Process();
			this.label14 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageChooseProfile.SuspendLayout();
			this.tabControlRun.SuspendLayout();
			this.tabPageSingle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRPM)).BeginInit();
			this.tabPageMulti.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiTimes)).BeginInit();
			this.tabControl2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPageAddEditProfile.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefaultPipeTimes)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageChooseProfile);
			this.tabControl1.Controls.Add(this.tabPageAddEditProfile);
			this.tabControl1.Location = new System.Drawing.Point(4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(474, 431);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageChooseProfile
			// 
			this.tabPageChooseProfile.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageChooseProfile.Controls.Add(this.label14);
			this.tabPageChooseProfile.Controls.Add(this.progressBarProcessingProgress);
			this.tabPageChooseProfile.Controls.Add(this.buttonRun);
			this.tabPageChooseProfile.Controls.Add(this.tabControlRun);
			this.tabPageChooseProfile.Controls.Add(this.tabControl2);
			this.tabPageChooseProfile.Location = new System.Drawing.Point(4, 22);
			this.tabPageChooseProfile.Name = "tabPageChooseProfile";
			this.tabPageChooseProfile.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageChooseProfile.Size = new System.Drawing.Size(466, 405);
			this.tabPageChooseProfile.TabIndex = 0;
			this.tabPageChooseProfile.Text = "Choose Profile";
			// 
			// progressBarProcessingProgress
			// 
			this.progressBarProcessingProgress.Location = new System.Drawing.Point(78, 213);
			this.progressBarProcessingProgress.Name = "progressBarProcessingProgress";
			this.progressBarProcessingProgress.Size = new System.Drawing.Size(279, 23);
			this.progressBarProcessingProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarProcessingProgress.TabIndex = 17;
			// 
			// buttonRun
			// 
			this.buttonRun.Location = new System.Drawing.Point(381, 213);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(75, 23);
			this.buttonRun.TabIndex = 11;
			this.buttonRun.Text = "Run Single";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.ButtonRunClick);
			// 
			// tabControlRun
			// 
			this.tabControlRun.Controls.Add(this.tabPageSingle);
			this.tabControlRun.Controls.Add(this.tabPageMulti);
			this.tabControlRun.Location = new System.Drawing.Point(6, 6);
			this.tabControlRun.Multiline = true;
			this.tabControlRun.Name = "tabControlRun";
			this.tabControlRun.SelectedIndex = 0;
			this.tabControlRun.Size = new System.Drawing.Size(450, 201);
			this.tabControlRun.TabIndex = 16;
			this.tabControlRun.SelectedIndexChanged += new System.EventHandler(this.TabControlRunSelectedIndexChanged);
			// 
			// tabPageSingle
			// 
			this.tabPageSingle.Controls.Add(this.comboBoxProfilePicker);
			this.tabPageSingle.Controls.Add(this.label5);
			this.tabPageSingle.Controls.Add(this.textBoxOutputFilename);
			this.tabPageSingle.Controls.Add(this.buttonChooseProfile);
			this.tabPageSingle.Controls.Add(this.label2);
			this.tabPageSingle.Controls.Add(this.numericUpDownRPM);
			this.tabPageSingle.Controls.Add(this.label1);
			this.tabPageSingle.Location = new System.Drawing.Point(4, 22);
			this.tabPageSingle.Name = "tabPageSingle";
			this.tabPageSingle.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSingle.Size = new System.Drawing.Size(442, 175);
			this.tabPageSingle.TabIndex = 0;
			this.tabPageSingle.Text = "Single";
			this.tabPageSingle.UseVisualStyleBackColor = true;
			// 
			// comboBoxProfilePicker
			// 
			this.comboBoxProfilePicker.FormattingEnabled = true;
			this.comboBoxProfilePicker.Location = new System.Drawing.Point(10, 31);
			this.comboBoxProfilePicker.Name = "comboBoxProfilePicker";
			this.comboBoxProfilePicker.Size = new System.Drawing.Size(316, 21);
			this.comboBoxProfilePicker.TabIndex = 30;
			this.comboBoxProfilePicker.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProfilePickerSelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 29;
			this.label5.Text = "Output filename:";
			// 
			// textBoxOutputFilename
			// 
			this.textBoxOutputFilename.Location = new System.Drawing.Point(10, 87);
			this.textBoxOutputFilename.Name = "textBoxOutputFilename";
			this.textBoxOutputFilename.Size = new System.Drawing.Size(316, 20);
			this.textBoxOutputFilename.TabIndex = 28;
			// 
			// buttonChooseProfile
			// 
			this.buttonChooseProfile.Location = new System.Drawing.Point(332, 29);
			this.buttonChooseProfile.Name = "buttonChooseProfile";
			this.buttonChooseProfile.Size = new System.Drawing.Size(92, 23);
			this.buttonChooseProfile.TabIndex = 27;
			this.buttonChooseProfile.Text = "Choose profile...";
			this.buttonChooseProfile.UseVisualStyleBackColor = true;
			this.buttonChooseProfile.Click += new System.EventHandler(this.ButtonChooseProfileClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 23);
			this.label2.TabIndex = 26;
			this.label2.Text = "Run number of times:";
			// 
			// numericUpDownRPM
			// 
			this.numericUpDownRPM.Location = new System.Drawing.Point(127, 113);
			this.numericUpDownRPM.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.numericUpDownRPM.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownRPM.Name = "numericUpDownRPM";
			this.numericUpDownRPM.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownRPM.TabIndex = 25;
			this.numericUpDownRPM.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 19);
			this.label1.TabIndex = 24;
			this.label1.Text = "Profile to run:";
			// 
			// tabPageMulti
			// 
			this.tabPageMulti.Controls.Add(this.numericUpDownMultiTimes);
			this.tabPageMulti.Controls.Add(this.buttonMultiDown);
			this.tabPageMulti.Controls.Add(this.buttonMultiUp);
			this.tabPageMulti.Controls.Add(this.label13);
			this.tabPageMulti.Controls.Add(this.checkBoxMultiPipe);
			this.tabPageMulti.Controls.Add(this.comboBoxMultiProfile);
			this.tabPageMulti.Controls.Add(this.buttonMultiProfileChoose);
			this.tabPageMulti.Controls.Add(this.buttonRemoveMultiProfile);
			this.tabPageMulti.Controls.Add(this.buttonAddMultiProfile);
			this.tabPageMulti.Controls.Add(this.listViewMutiProfiles);
			this.tabPageMulti.Location = new System.Drawing.Point(4, 22);
			this.tabPageMulti.Name = "tabPageMulti";
			this.tabPageMulti.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMulti.Size = new System.Drawing.Size(442, 175);
			this.tabPageMulti.TabIndex = 1;
			this.tabPageMulti.Text = "Multi";
			this.tabPageMulti.UseVisualStyleBackColor = true;
			// 
			// numericUpDownMultiTimes
			// 
			this.numericUpDownMultiTimes.Location = new System.Drawing.Point(313, 33);
			this.numericUpDownMultiTimes.Maximum = new decimal(new int[] {
									100000,
									0,
									0,
									0});
			this.numericUpDownMultiTimes.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownMultiTimes.Name = "numericUpDownMultiTimes";
			this.numericUpDownMultiTimes.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownMultiTimes.TabIndex = 6;
			this.numericUpDownMultiTimes.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// buttonMultiDown
			// 
			this.buttonMultiDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonMultiDown.Image")));
			this.buttonMultiDown.Location = new System.Drawing.Point(358, 113);
			this.buttonMultiDown.Name = "buttonMultiDown";
			this.buttonMultiDown.Size = new System.Drawing.Size(26, 23);
			this.buttonMultiDown.TabIndex = 9;
			this.buttonMultiDown.UseVisualStyleBackColor = true;
			this.buttonMultiDown.Click += new System.EventHandler(this.ButtonMultiDownClick);
			// 
			// buttonMultiUp
			// 
			this.buttonMultiUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMultiUp.Image")));
			this.buttonMultiUp.Location = new System.Drawing.Point(358, 89);
			this.buttonMultiUp.Name = "buttonMultiUp";
			this.buttonMultiUp.Size = new System.Drawing.Size(26, 23);
			this.buttonMultiUp.TabIndex = 8;
			this.buttonMultiUp.UseVisualStyleBackColor = true;
			this.buttonMultiUp.Click += new System.EventHandler(this.ButtonMultiUpClick);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(195, 35);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(112, 23);
			this.label13.TabIndex = 7;
			this.label13.Text = "Run number of times:";
			// 
			// checkBoxMultiPipe
			// 
			this.checkBoxMultiPipe.Location = new System.Drawing.Point(7, 30);
			this.checkBoxMultiPipe.Name = "checkBoxMultiPipe";
			this.checkBoxMultiPipe.Size = new System.Drawing.Size(190, 24);
			this.checkBoxMultiPipe.TabIndex = 5;
			this.checkBoxMultiPipe.Text = "Use output as input on next profile";
			this.checkBoxMultiPipe.UseVisualStyleBackColor = true;
			// 
			// comboBoxMultiProfile
			// 
			this.comboBoxMultiProfile.FormattingEnabled = true;
			this.comboBoxMultiProfile.Location = new System.Drawing.Point(7, 7);
			this.comboBoxMultiProfile.Name = "comboBoxMultiProfile";
			this.comboBoxMultiProfile.Size = new System.Drawing.Size(322, 21);
			this.comboBoxMultiProfile.TabIndex = 4;
			// 
			// buttonMultiProfileChoose
			// 
			this.buttonMultiProfileChoose.Location = new System.Drawing.Point(335, 7);
			this.buttonMultiProfileChoose.Name = "buttonMultiProfileChoose";
			this.buttonMultiProfileChoose.Size = new System.Drawing.Size(98, 23);
			this.buttonMultiProfileChoose.TabIndex = 3;
			this.buttonMultiProfileChoose.Text = "Choose profile...";
			this.buttonMultiProfileChoose.UseVisualStyleBackColor = true;
			this.buttonMultiProfileChoose.Click += new System.EventHandler(this.ButtonMultiProfileChooseClick);
			// 
			// buttonRemoveMultiProfile
			// 
			this.buttonRemoveMultiProfile.Location = new System.Drawing.Point(358, 146);
			this.buttonRemoveMultiProfile.Name = "buttonRemoveMultiProfile";
			this.buttonRemoveMultiProfile.Size = new System.Drawing.Size(75, 23);
			this.buttonRemoveMultiProfile.TabIndex = 2;
			this.buttonRemoveMultiProfile.Text = "Remove";
			this.buttonRemoveMultiProfile.UseVisualStyleBackColor = true;
			this.buttonRemoveMultiProfile.Click += new System.EventHandler(this.ButtonRemoveMultiProfileClick);
			// 
			// buttonAddMultiProfile
			// 
			this.buttonAddMultiProfile.Location = new System.Drawing.Point(358, 60);
			this.buttonAddMultiProfile.Name = "buttonAddMultiProfile";
			this.buttonAddMultiProfile.Size = new System.Drawing.Size(75, 23);
			this.buttonAddMultiProfile.TabIndex = 1;
			this.buttonAddMultiProfile.Text = "Add";
			this.buttonAddMultiProfile.UseVisualStyleBackColor = true;
			this.buttonAddMultiProfile.Click += new System.EventHandler(this.ButtonAddMultiProfileClick);
			// 
			// listViewMutiProfiles
			// 
			this.listViewMutiProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderMultiProfile,
									this.columnHeaderTimes,
									this.columnHeaderPipe});
			this.listViewMutiProfiles.FullRowSelect = true;
			this.listViewMutiProfiles.GridLines = true;
			this.listViewMutiProfiles.LargeImageList = this.imageListMultiProfile;
			this.listViewMutiProfiles.Location = new System.Drawing.Point(3, 60);
			this.listViewMutiProfiles.Name = "listViewMutiProfiles";
			this.listViewMutiProfiles.Size = new System.Drawing.Size(353, 109);
			this.listViewMutiProfiles.SmallImageList = this.imageListMultiProfile;
			this.listViewMutiProfiles.TabIndex = 0;
			this.listViewMutiProfiles.UseCompatibleStateImageBehavior = false;
			this.listViewMutiProfiles.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderMultiProfile
			// 
			this.columnHeaderMultiProfile.Text = "Profile";
			this.columnHeaderMultiProfile.Width = 230;
			// 
			// columnHeaderTimes
			// 
			this.columnHeaderTimes.Text = "Pipe";
			// 
			// columnHeaderPipe
			// 
			this.columnHeaderPipe.Text = "Times";
			// 
			// imageListMultiProfile
			// 
			this.imageListMultiProfile.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListMultiProfile.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListMultiProfile.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tabControl2
			// 
			this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl2.Controls.Add(this.tabPage1);
			this.tabControl2.Location = new System.Drawing.Point(6, 242);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(457, 160);
			this.tabControl2.TabIndex = 15;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBoxLogBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(449, 134);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Output Log";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textBoxLogBox
			// 
			this.textBoxLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLogBox.Location = new System.Drawing.Point(3, 3);
			this.textBoxLogBox.Multiline = true;
			this.textBoxLogBox.Name = "textBoxLogBox";
			this.textBoxLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxLogBox.Size = new System.Drawing.Size(443, 128);
			this.textBoxLogBox.TabIndex = 16;
			// 
			// tabPageAddEditProfile
			// 
			this.tabPageAddEditProfile.Controls.Add(this.buttonOpenProfile);
			this.tabPageAddEditProfile.Controls.Add(this.buttonNewProfile);
			this.tabPageAddEditProfile.Controls.Add(this.groupBox1);
			this.tabPageAddEditProfile.Controls.Add(this.buttonSaveProfile);
			this.tabPageAddEditProfile.Location = new System.Drawing.Point(4, 22);
			this.tabPageAddEditProfile.Name = "tabPageAddEditProfile";
			this.tabPageAddEditProfile.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAddEditProfile.Size = new System.Drawing.Size(466, 405);
			this.tabPageAddEditProfile.TabIndex = 1;
			this.tabPageAddEditProfile.Text = "Add/Edit Profile";
			this.tabPageAddEditProfile.UseVisualStyleBackColor = true;
			// 
			// buttonOpenProfile
			// 
			this.buttonOpenProfile.Location = new System.Drawing.Point(28, 343);
			this.buttonOpenProfile.Name = "buttonOpenProfile";
			this.buttonOpenProfile.Size = new System.Drawing.Size(85, 23);
			this.buttonOpenProfile.TabIndex = 3;
			this.buttonOpenProfile.Text = "Open Profile...";
			this.buttonOpenProfile.UseVisualStyleBackColor = true;
			this.buttonOpenProfile.Click += new System.EventHandler(this.ButtonOpenProfileClick);
			// 
			// buttonNewProfile
			// 
			this.buttonNewProfile.Location = new System.Drawing.Point(186, 344);
			this.buttonNewProfile.Name = "buttonNewProfile";
			this.buttonNewProfile.Size = new System.Drawing.Size(75, 23);
			this.buttonNewProfile.TabIndex = 2;
			this.buttonNewProfile.Text = "New Profile";
			this.buttonNewProfile.UseVisualStyleBackColor = true;
			this.buttonNewProfile.Click += new System.EventHandler(this.ButtonNewProfileClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.numericUpDownDefaultPipeTimes);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.buttonSelectOutputFolder);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBoxDefaultOutputFolder);
			this.groupBox1.Controls.Add(this.textBoxDefaultOutput);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.labelVariables);
			this.groupBox1.Controls.Add(this.textBoxVariables);
			this.groupBox1.Controls.Add(this.buttonSelectCommand);
			this.groupBox1.Controls.Add(this.textBoxCommand);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 331);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profile Settings";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(188, 191);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(131, 23);
			this.label12.TabIndex = 18;
			this.label12.Text = "{RNBR} = Rotation/Pipe number";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(36, 191);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(145, 23);
			this.label11.TabIndex = 17;
			this.label11.Text = "{EXTEN} = In File extension";
			// 
			// numericUpDownDefaultPipeTimes
			// 
			this.numericUpDownDefaultPipeTimes.Location = new System.Drawing.Point(153, 293);
			this.numericUpDownDefaultPipeTimes.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.numericUpDownDefaultPipeTimes.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownDefaultPipeTimes.Name = "numericUpDownDefaultPipeTimes";
			this.numericUpDownDefaultPipeTimes.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownDefaultPipeTimes.TabIndex = 16;
			this.numericUpDownDefaultPipeTimes.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(20, 295);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(127, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Default Pipe/Run Times:";
			// 
			// buttonSelectOutputFolder
			// 
			this.buttonSelectOutputFolder.Location = new System.Drawing.Point(373, 262);
			this.buttonSelectOutputFolder.Name = "buttonSelectOutputFolder";
			this.buttonSelectOutputFolder.Size = new System.Drawing.Size(75, 23);
			this.buttonSelectOutputFolder.TabIndex = 14;
			this.buttonSelectOutputFolder.Text = "Select...";
			this.buttonSelectOutputFolder.UseVisualStyleBackColor = true;
			this.buttonSelectOutputFolder.Click += new System.EventHandler(this.ButtonSelectOutputFolderClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(36, 173);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(268, 23);
			this.label9.TabIndex = 13;
			this.label9.Text = "{INFILENAME} = The filename of the input file";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(171, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "{IN} = Input Filename";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(36, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "{OUT} = Output Filename";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(20, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(204, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Default output folder:";
			// 
			// textBoxDefaultOutputFolder
			// 
			this.textBoxDefaultOutputFolder.Location = new System.Drawing.Point(36, 266);
			this.textBoxDefaultOutputFolder.Name = "textBoxDefaultOutputFolder";
			this.textBoxDefaultOutputFolder.Size = new System.Drawing.Size(319, 20);
			this.textBoxDefaultOutputFolder.TabIndex = 7;
			this.textBoxDefaultOutputFolder.Text = "{INPUTFILEFOLDER}";
			// 
			// textBoxDefaultOutput
			// 
			this.textBoxDefaultOutput.Location = new System.Drawing.Point(36, 214);
			this.textBoxDefaultOutput.Name = "textBoxDefaultOutput";
			this.textBoxDefaultOutput.Size = new System.Drawing.Size(319, 20);
			this.textBoxDefaultOutput.TabIndex = 6;
			this.textBoxDefaultOutput.Text = "{RNBR}_{INFILENAME}.{EXTEN}";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(272, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Default output filename (Round number will be added):";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Run command:";
			// 
			// labelVariables
			// 
			this.labelVariables.Location = new System.Drawing.Point(20, 73);
			this.labelVariables.Name = "labelVariables";
			this.labelVariables.Size = new System.Drawing.Size(100, 23);
			this.labelVariables.TabIndex = 3;
			this.labelVariables.Text = "Arguments:";
			// 
			// textBoxVariables
			// 
			this.textBoxVariables.Location = new System.Drawing.Point(36, 117);
			this.textBoxVariables.Name = "textBoxVariables";
			this.textBoxVariables.Size = new System.Drawing.Size(319, 20);
			this.textBoxVariables.TabIndex = 2;
			this.textBoxVariables.Text = "{OUT} {IN}";
			// 
			// buttonSelectCommand
			// 
			this.buttonSelectCommand.Location = new System.Drawing.Point(373, 38);
			this.buttonSelectCommand.Name = "buttonSelectCommand";
			this.buttonSelectCommand.Size = new System.Drawing.Size(75, 23);
			this.buttonSelectCommand.TabIndex = 1;
			this.buttonSelectCommand.Text = "Select...";
			this.buttonSelectCommand.UseVisualStyleBackColor = true;
			this.buttonSelectCommand.Click += new System.EventHandler(this.ButtonSelectCommandClick);
			// 
			// textBoxCommand
			// 
			this.textBoxCommand.Location = new System.Drawing.Point(36, 41);
			this.textBoxCommand.Name = "textBoxCommand";
			this.textBoxCommand.Size = new System.Drawing.Size(319, 20);
			this.textBoxCommand.TabIndex = 0;
			// 
			// buttonSaveProfile
			// 
			this.buttonSaveProfile.Location = new System.Drawing.Point(381, 344);
			this.buttonSaveProfile.Name = "buttonSaveProfile";
			this.buttonSaveProfile.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveProfile.TabIndex = 0;
			this.buttonSaveProfile.Text = "Save...";
			this.buttonSaveProfile.UseVisualStyleBackColor = true;
			this.buttonSaveProfile.Click += new System.EventHandler(this.ButtonSaveProfileClick);
			// 
			// openFileDialogChooseProfile
			// 
			this.openFileDialogChooseProfile.DefaultExt = "xml";
			this.openFileDialogChooseProfile.Filter = "xml|*.xml";
			this.openFileDialogChooseProfile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogChooseProfileFileOk);
			// 
			// openFileDialogSelectCommand
			// 
			this.openFileDialogSelectCommand.FileName = "openFileDialog1";
			this.openFileDialogSelectCommand.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogSelectCommandFileOk);
			// 
			// saveFileDialogSaveProfile
			// 
			this.saveFileDialogSaveProfile.DefaultExt = "xml";
			this.saveFileDialogSaveProfile.Filter = "xml|*.xml";
			this.saveFileDialogSaveProfile.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogSaveProfileFileOk);
			// 
			// processRunner
			// 
			this.processRunner.StartInfo.CreateNoWindow = true;
			this.processRunner.StartInfo.Domain = "";
			this.processRunner.StartInfo.LoadUserProfile = false;
			this.processRunner.StartInfo.Password = null;
			this.processRunner.StartInfo.RedirectStandardOutput = true;
			this.processRunner.StartInfo.StandardErrorEncoding = null;
			this.processRunner.StartInfo.StandardOutputEncoding = null;
			this.processRunner.StartInfo.UserName = "";
			this.processRunner.StartInfo.UseShellExecute = false;
			this.processRunner.SynchronizingObject = this;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(10, 218);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(66, 23);
			this.label14.TabIndex = 18;
			this.label14.Text = "Progress:";
			// 
			// choose
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 436);
			this.Controls.Add(this.tabControl1);
			this.Name = "choose";
			this.Text = "Awfulizer - choose profile";
			this.tabControl1.ResumeLayout(false);
			this.tabPageChooseProfile.ResumeLayout(false);
			this.tabControlRun.ResumeLayout(false);
			this.tabPageSingle.ResumeLayout(false);
			this.tabPageSingle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRPM)).EndInit();
			this.tabPageMulti.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiTimes)).EndInit();
			this.tabControl2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPageAddEditProfile.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefaultPipeTimes)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ProgressBar progressBarProcessingProgress;
		private System.Windows.Forms.Button buttonMultiUp;
		private System.Windows.Forms.Button buttonMultiDown;
		private System.Windows.Forms.Button buttonMultiProfileChoose;
		private System.Windows.Forms.ComboBox comboBoxMultiProfile;
		private System.Windows.Forms.NumericUpDown numericUpDownMultiTimes;
		private System.Windows.Forms.ColumnHeader columnHeaderPipe;
		private System.Windows.Forms.ColumnHeader columnHeaderTimes;
		private System.Windows.Forms.ColumnHeader columnHeaderMultiProfile;
		private System.Windows.Forms.ImageList imageListMultiProfile;
		private System.Windows.Forms.ListView listViewMutiProfiles;
		private System.Windows.Forms.Button buttonAddMultiProfile;
		private System.Windows.Forms.Button buttonRemoveMultiProfile;
		private System.Windows.Forms.CheckBox checkBoxMultiPipe;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown numericUpDownRPM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPageMulti;
		private System.Windows.Forms.TabPage tabPageSingle;
		private System.Windows.Forms.TabControl tabControlRun;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBoxProfilePicker;
		private System.Windows.Forms.NumericUpDown numericUpDownDefaultPipeTimes;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Diagnostics.Process processRunner;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutputFolder;
		private System.Windows.Forms.Button buttonSelectOutputFolder;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxLogBox;
		private System.Windows.Forms.TextBox textBoxDefaultOutputFolder;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxOutputFilename;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDefaultOutput;
		private System.Windows.Forms.SaveFileDialog saveFileDialogSaveProfile;
		private System.Windows.Forms.Button buttonOpenProfile;
		private System.Windows.Forms.Button buttonNewProfile;
		private System.Windows.Forms.TextBox textBoxVariables;
		private System.Windows.Forms.Label labelVariables;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog openFileDialogSelectCommand;
		private System.Windows.Forms.TextBox textBoxCommand;
		private System.Windows.Forms.Button buttonSelectCommand;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonSaveProfile;
		private System.Windows.Forms.OpenFileDialog openFileDialogChooseProfile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonChooseProfile;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.TabPage tabPageAddEditProfile;
		private System.Windows.Forms.TabPage tabPageChooseProfile;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button button1;
		
	}
}
