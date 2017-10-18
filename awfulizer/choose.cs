/*
 * Created by SharpDevelop.
 * User: akeda
 * Date: 2011-09-08
 * Time: 18:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Collections;


namespace awfulizer
{
	/// <summary>
	/// Description of choose.
	/// </summary>
	public partial class choose : Form
	{
		
		ProfileTemplate pt;
		string[] listOfFiles;
		Boolean batchMode = false;
		MainForm parent;
		Boolean removeFiles = false;
		Boolean isRunning = false;
		Boolean stopPressed = false;
		Boolean isMulti = false;
		ProcessingInfo pi = new ProcessingInfo();
		public choose()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pt = new ProfileTemplate();
			SetProfileSettingsOnItems();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public choose(MainForm mf, Boolean removeFiles)
		{
			InitializeComponent();
			pt = new ProfileTemplate();
			SetProfileSettingsOnItems();
			this.removeFiles = removeFiles;
			this.parent = mf;
			comboBoxProfilePicker.Items.AddRange(this.parent.ht.profileHistory.ToArray());
			comboBoxMultiProfile.Items.AddRange(this.parent.ht.profileHistory.ToArray());
		}
		
		public choose(MainForm mf, Boolean batchmode, String ProfileTemplateFileName, string[] listOfFiles, Boolean removeFiles)
		{
			this.parent = mf;
			if(batchmode)
			{
				InitializeComponent();
				//pt = new ProfileTemplate();
				this.batchMode = batchmode;
				this.listOfFiles = listOfFiles;
				this.removeFiles = removeFiles;
				this.pt = DeserializeFromXML(ProfileTemplateFileName);
				SetProfileSettingsOnItems();
				if(RunProfileOnFilesSingle())
				{
					this.Close();
				}
				
			}
		}

		
		void ButtonChooseProfileClick(object sender, EventArgs e)
		{
			openFileDialogChooseProfile.ShowDialog();		
		}
		
		static public void SerializeToXML(ProfileTemplate pt, String path)
		{
  			XmlSerializer serializer = new XmlSerializer(typeof(ProfileTemplate));
   			TextWriter textWriter = new StreamWriter(path, false);
   			serializer.Serialize(textWriter, pt);
   			textWriter.Close();
 		}
		
		static public ProfileTemplate DeserializeFromXML(String path)
		{	 
  			XmlSerializer mySerializer = new XmlSerializer(typeof(ProfileTemplate));
  			FileStream myFileStream = new FileStream(path,FileMode.Open);
 			ProfileTemplate pt = (ProfileTemplate)mySerializer.Deserialize(myFileStream);
 			myFileStream.Close();
 	 		return pt;
 		}
		
		void ButtonSaveProfileClick(object sender, EventArgs e)
		{
			saveFileDialogSaveProfile.ShowDialog();
			
		}
		
		void ButtonSelectCommandClick(object sender, EventArgs e)
		{
			openFileDialogSelectCommand.ShowDialog();
		}
		
		void OpenFileDialogSelectCommandFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			textBoxCommand.Text = openFileDialogSelectCommand.FileName;
		}
		
		void ButtonNewProfileClick(object sender, EventArgs e)
		{
			pt = new ProfileTemplate();
			SetProfileSettingsOnItems();
		}
		
		void OpenFileDialogChooseProfileFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pt = DeserializeFromXML(openFileDialogChooseProfile.FileName);
			SetProfileSettingsOnItems();
			
		 	this.parent.ht.profileHistory.Remove(openFileDialogChooseProfile.FileName);
		 	this.parent.ht.profileHistory.Add(openFileDialogChooseProfile.FileName);
		 	comboBoxProfilePicker.Items.Remove(openFileDialogChooseProfile.FileName);
		 	comboBoxProfilePicker.Items.Add(openFileDialogChooseProfile.FileName);
		 	comboBoxProfilePicker.SelectedText = openFileDialogChooseProfile.FileName;
		 	
		 	comboBoxMultiProfile.Items.Remove(openFileDialogChooseProfile.FileName);
		 	comboBoxMultiProfile.Items.Add(openFileDialogChooseProfile.FileName);
		 	comboBoxMultiProfile.SelectedText = openFileDialogChooseProfile.FileName;		 	
		}
		
		void SetProfileSettingsOnItems()
		{
			textBoxCommand.Text = pt.command;
			textBoxVariables.Text = pt.variables;
			textBoxDefaultOutput.Text = pt.defaultOutput;
			textBoxOutputFilename.Text = pt.defaultOutput;
			textBoxDefaultOutputFolder.Text = pt.defaultOutputFolder;
			if(numericUpDownDefaultPipeTimes.Maximum < pt.defaultPipeTimes)
			{
				numericUpDownDefaultPipeTimes.Maximum = pt.defaultPipeTimes;
			}
			numericUpDownDefaultPipeTimes.Value = pt.defaultPipeTimes;
			numericUpDownRPM.Value = numericUpDownDefaultPipeTimes.Value;
		}
		
		
		void SaveFileDialogSaveProfileFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pt.command = textBoxCommand.Text;
			pt.variables = textBoxVariables.Text;
			pt.defaultOutput = textBoxDefaultOutput.Text;
			pt.defaultOutputFolder = textBoxDefaultOutputFolder.Text;
			pt.defaultPipeTimes = (int)numericUpDownDefaultPipeTimes.Value;
			SerializeToXML(pt, saveFileDialogSaveProfile.FileName);
		}

		
		void ButtonRunClick(object sender, EventArgs e)
		{
			//if( comboBoxProfilePicker.SelectedItem.EndsWith("xml") )
			//{
			if(this.isMulti)
			{
				
				RunProfileOnFilesMulti();
			}
			else {
					RunProfileOnFilesSingle();
				
			}
		}
		
		public Boolean RunProfileOnFilesSingle()
		{
			int currentFileNumber = 1;			
			foreach(string inFile in listOfFiles)
			{
				IsRunning(true);
				
				this.pi = new ProcessingInfo(inFile, pi.currentFileNumber, listOfFiles.Length);
				this.parent.DoProcessingInfo(pi);
				DoProcessingInfo(pi);
				currentFileNumber++;
				
				RunProfileOnFiles(inFile, textBoxOutputFilename.Text, (int)numericUpDownRPM.Value);
				IsRunning(false);
				this.parent.removeFilesFromList(inFile);
			}
			
			return true;
		}
		
		public Boolean RunProfileOnFilesMulti()
		{
			int currentFileNumber = 1;
			int totalnumberofturns = 0;
			foreach(ListViewItem lvi in listViewMutiProfiles.Items)
			{
				totalnumberofturns += int.Parse(lvi.SubItems[2].Text);
			}
			totalnumberofturns = totalnumberofturns * listOfFiles.Length;
			
			foreach(string inFile in listOfFiles)
			{
				IsRunning(true);
				
				this.pi = new ProcessingInfo(inFile, this.pi.currentFileNumber, totalnumberofturns);
				this.parent.DoProcessingInfo(pi);
				DoProcessingInfo(pi);
				currentFileNumber++;
				String outputfile = "";
				foreach(ListViewItem lvi in listViewMutiProfiles.Items)
				{				
					this.pt = DeserializeFromXML(lvi.Text);
					SetProfileSettingsOnItems();
					if( Boolean.Parse(lvi.SubItems[1].Text) && listViewMutiProfiles.Items.IndexOf(lvi) > 0)
					{
						outputfile = RunProfileOnFiles(outputfile, pt.defaultOutput, int.Parse(lvi.SubItems[2].Text));
					}
					else
					{
						outputfile = RunProfileOnFiles(inFile, pt.defaultOutput,int.Parse(lvi.SubItems[2].Text) );
					}
				}
				IsRunning(false);
				this.parent.removeFilesFromList(inFile);
			}
			return true;
		}
		
		public String RunProfileOnFiles(String inFileForProcessingFile, String outFileFromProcessing, int Turns)
		{
				String outputFilename = outFileFromProcessing.Replace("{INFILENAME}", Path.GetFileNameWithoutExtension(inFileForProcessingFile));
				outputFilename = outputFilename.Replace("{EXTEN}", Path.GetExtension(inFileForProcessingFile));

				String inFileExt =  Path.GetExtension(inFileForProcessingFile);
				String inFileFolder = textBoxDefaultOutputFolder.Text.Replace("{INPUTFILEFOLDER}", Path.GetDirectoryName(inFileForProcessingFile) + "\\");
				
				String outputFile = '"' + inFileFolder + outputFilename + '"';
				String inputFile = '"' + inFileForProcessingFile + '"';
				
				for(int i = 0;i < Turns; i++)
				{
						if(i > 1)
						{
							if(outputFilename.Contains("{RNBR}"))
							{
								inputFile = '"' + inFileFolder + outputFilename.Replace("{RNBR}", (i-1).ToString()) + '"';
								outputFile = '"'+ inFileFolder + outputFilename.Replace("{RNBR}", i.ToString()) + '"';
							}
							else
							{
								inputFile = '"' + inFileFolder + (i-1) + outputFilename + '"';
								outputFile = '"'+ inFileFolder + i + outputFilename + '"';
							}
							
						}
						else if (i == 1)
						{
							if(outputFilename.Contains("{RNBR}"))
							{
								inputFile = '"' + inFileFolder + outputFilename.Replace("{RNBR}", (i-1).ToString()) + '"';
								outputFile = '"'+ inFileFolder + outputFilename.Replace("{RNBR}", i.ToString()) +'"';
							}
							else {
								inputFile = '"' + inFileFolder + outputFilename + '"';
								outputFile = '"'+ inFileFolder + i + outputFilename +'"';
							}
						}
						
						outputFile = outputFile.Replace("{RNBR}", i.ToString());
						String inArguments = pt.variables.Replace("{IN}", inputFile);
						inArguments = inArguments.Replace("{OUT}", outputFile);
						
						processRunner.StartInfo.FileName = pt.command;
						processRunner.StartInfo.Arguments = inArguments;
						processRunner.Start();
	
						textBoxLogBox.Text += "---- Running Command ---- Round: " + (i+1) + " of " + Turns  + " \n";
						textBoxLogBox.Text += pt.command + " " + inArguments;
						textBoxLogBox.Text += processRunner.StandardOutput.ReadToEnd();
						
						if(this.removeFiles && i > 0)
						{
							String delFile = @inputFile.Replace("\"","");
							File.Delete(delFile);
							textBoxLogBox.Text += "\\r\n\\" + inputFile + " Deleted";
							
						}
						this.parent.getLogTextBox().Text += textBoxLogBox.Text;
						this.pi.currentFileNumber++;
						this.parent.DoProcessingInfo(pi);
						DoProcessingInfo(pi);
				}
				
							
			
				return @outputFile.Replace("\"","");
		}
		
		
		public void RunFiles(string[] listOfFiles)
		{
			this.listOfFiles = listOfFiles;
		}
		
		void ButtonSelectOutputFolderClick(object sender, EventArgs e)
		{
			if(folderBrowserDialogOutputFolder.ShowDialog() == DialogResult.OK)
			{
				textBoxDefaultOutputFolder.Text = folderBrowserDialogOutputFolder.SelectedPath;
			}
		}
		
		void TextBoxDefaultOutputFolderTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButtonOpenProfileClick(object sender, System.EventArgs e)
		{
			openFileDialogChooseProfile.ShowDialog();
		}
		
		void ComboBoxProfilePickerSelectedIndexChanged(object sender, EventArgs e)
		{
			this.pt = DeserializeFromXML((String)comboBoxProfilePicker.SelectedItem);
			SetProfileSettingsOnItems();
		}
		
		void ButtonMultiUpClick(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in listViewMutiProfiles.SelectedItems)
			{
				int iLvi = listViewMutiProfiles.Items.IndexOf(lvi);
				if(iLvi > 0)
				{
					listViewMutiProfiles.Items.Remove(lvi);
					
					listViewMutiProfiles.Items.Insert(iLvi-1, lvi);
					this.listViewMutiProfiles.Focus();
					listViewMutiProfiles.Items[iLvi-1].Selected =true;					
				}
			}
		}
		
		void ButtonMultiDownClick(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in listViewMutiProfiles.SelectedItems)
			{
				int iLvi = listViewMutiProfiles.Items.IndexOf(lvi);
				if(iLvi < (listViewMutiProfiles.Items.Count-1))
				{
					listViewMutiProfiles.Items.Remove(lvi);
					
					listViewMutiProfiles.Items.Insert(iLvi+1, lvi);
					this.listViewMutiProfiles.Focus();
					listViewMutiProfiles.Items[iLvi+1].Selected =true;
				}
			}
			//listViewMutiProfiles.
		}
		
		void ButtonMultiProfileChooseClick(object sender, EventArgs e)
		{
			openFileDialogChooseProfile.ShowDialog();	
		}
		
		void ButtonAddMultiProfileClick(object sender, EventArgs e)
		{
			ListViewItem lvi = new ListViewItem();
			lvi.Text = (String)comboBoxMultiProfile.SelectedItem;
			ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
			lvsi.Text = checkBoxMultiPipe.Checked.ToString();
          	lvi.SubItems.Add(lvsi);
          	lvsi = new ListViewItem.ListViewSubItem(); 
          	lvsi.Text = numericUpDownMultiTimes.Value.ToString();
			lvi.SubItems.Add(lvsi);
			listViewMutiProfiles.Items.Add(lvi);		
		}
		
		void ButtonRemoveMultiProfileClick(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in listViewMutiProfiles.SelectedItems)
			{
				listViewMutiProfiles.Items.Remove(lvi);
			}
		}
		
		void IsRunning(Boolean isRunning)
		{
			this.isRunning = isRunning;
			if(isRunning)
			{
				buttonRun.Enabled = false;
			}
			else {buttonRun.Enabled = true;
			}
		}
		
		void DoProcessingInfo(ProcessingInfo pi)
		{
			progressBarProcessingProgress.Maximum = pi.totalNumberOfFiles;
			progressBarProcessingProgress.Value = pi.currentFileNumber;
		}
		
		void TabControlRunSelectedIndexChanged(object sender, EventArgs e)
		{
			MultiOrSingMode();
				
		}
		
		void MultiOrSingMode()
		{
			buttonRun.Text = "Run " + tabControlRun.SelectedTab.Text;
			if(tabControlRun.SelectedTab.Text.Equals("Multi"))
			{
				   this.isMulti = true;
			}
			else {this.isMulti = false;}
		}
	}
	
	
}
