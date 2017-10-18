/*
 * Created by SharpDevelop.
 * User: akeda
 * Date: 2011-09-08
 * Time: 18:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;


namespace awfulizer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public HistoryTemplate ht;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ht = new HistoryTemplate();
			try{
					string appPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + this.ht.fileName;
					this.ht = DeserializeFromXML(appPath);
			}
			catch(Exception e)
			{}
			
			LoadHistory();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LoadHistory()
		{
			checkBoxQuickMode.Checked = this.ht.quickMode;
			checkBoxBatchMode.Checked = this.ht.batchMode;
			checkBoxRemoveFiles.Checked = this.ht.clearList;
			textBoxSelectedBatchProfile.Text = this.ht.lastBatchProfile;
			checkBoxOnTop.Checked = this.ht.onTop;
			this.TopMost = checkBoxOnTop.Checked;
			checkBoxRemoveOutputFiles.Checked = this.ht.deleteOutputFiles;
			
			for(int i = 0; i < this.ht.batchProfileList.Count;i+=2)
			{
			
				ListViewItem lvi = new ListViewItem();
				lvi.Text = (String)this.ht.batchProfileList[i];
				lvi.Tag = (String)this.ht.batchProfileList[i];
				ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
          		lvsi.Text = (String)this.ht.batchProfileList[i+1];
          		lvsi.Tag = (String)this.ht.batchProfileList[i+1];
          		lvi.SubItems.Add(lvsi);
				listViewDefaultProfiles.Items.Add(lvi);          		
			}
		}
		
		void SaveHistory()
		{
			this.ht.quickMode = checkBoxQuickMode.Checked;
			this.ht.batchMode = checkBoxBatchMode.Checked;
			this.ht.clearList = checkBoxRemoveFiles.Checked;
			this.ht.onTop = checkBoxOnTop.Checked;
			this.ht.deleteOutputFiles = checkBoxRemoveOutputFiles.Checked;
			
			this.ht.batchProfileList.Clear();
			foreach(ListViewItem it in listViewDefaultProfiles.Items)
			{
				this.ht.batchProfileList.Add(it.Text);
				this.ht.batchProfileList.Add(it.SubItems[1].Text);
			}

		}
		
		
		void MainFormDragDrop(object sender, DragEventArgs e)
		{
			
			
			string[] s = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

			foreach(String fileorfolder in s)
			{
				addFilesToList(fileorfolder);
			}

			if(checkBoxQuickMode.Checked && !checkBoxBatchMode.Checked)
			{			
				OpenARunner(s);
			}
			else if (checkBoxBatchMode.Checked)
			{
				OpenARunnerBatch(s);
			}
			
		}
		
		void OpenARunner(string[] files)
		{
				choose ch = new choose(this, checkBoxRemoveOutputFiles.Checked);
				ch.RunFiles(files);				
				ch.Show();
		}
		
		void OpenARunnerBatch(string[] files)
		{
			if(listViewDefaultProfiles.Items.Count > 0)
			{
				this.textBoxRunLog.Text += "\r\n--- Starting Batch ---" + files.Length + " input files.";
				foreach(String file in files)
				{
					foreach(ListViewItem lvi in listViewDefaultProfiles.Items)
					{
						ListViewItem.ListViewSubItem presub = lvi.SubItems[1];
						//Regex r = new Regex(@presub.Text);
						
						//if(r.IsMatch(file))
						String inExt = Path.GetExtension(file);
						String pExt = presub.Text;
						
						if(inExt.EndsWith(pExt) || @presub.Text.Equals("*"))
						{
							choose ch = new choose(this, true, lvi.Text, new string[] {file}, checkBoxRemoveOutputFiles.Checked);
							
							this.textBoxRunLog.Text += "\r\n" + file + " match profile " + lvi.Text + "," + presub.Text;
						}
						else
						{
							this.textBoxRunLog.Text += "\r\n" + file + " did not match profile " + lvi.Text + "," + presub.Text;
						}
					}
				}
			}
			else {
				MessageBox.Show("No Batch profiles set.", "Batch Profile Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
			if(checkBoxRemoveFiles.Checked)
			{
				listViewInputFiles.Items.Clear();
			}
		}

		void ch_Closed(object sender, EventArgs e)
		{
			if(checkBoxRemoveFiles.Checked)
			{
				listViewInputFiles.Items.Clear();
			}
		}
		
		void MainFormDragEnter(object sender, DragEventArgs e)
		{
			
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
			e.Effect = DragDropEffects.All;
			else
				e.Effect = DragDropEffects.None;

		}
		
		void CheckBoxQuickModeCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButtonRunClick(object sender, EventArgs e)
		{
			string[] s = new string[listViewInputFiles.Items.Count];
			for(int i = 0; i < listViewInputFiles.Items.Count; i++)
			{
				s[i] = listViewInputFiles.Items[i].Text;
			}
			if(checkBoxBatchMode.Checked)
			{
				OpenARunnerBatch(s);
			}
			else {
				OpenARunner(s);
			}
			
		}
		
		void ButtonClearFileListClick(object sender, EventArgs e)
		{
			listViewInputFiles.Items.Clear();
			toolStripStatusLabelNumberOffFiles.Text = listViewInputFiles.Items.Count + " Input Files";
			
		}
		
		void ButtonSelectFilesClick(object sender, EventArgs e)
		{
			openFileDialogSelectFiles.ShowDialog();
		}
		
		void OpenFileDialogSelectFilesFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ListViewItem[] lvi = new ListViewItem[openFileDialogSelectFiles.FileNames.Length];
			for(int i = 0; i < openFileDialogSelectFiles.FileNames.Length;i++)
			{	
				lvi[i] = new ListViewItem(openFileDialogSelectFiles.FileNames[i]);
			}
			listViewInputFiles.Items.AddRange(lvi);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			openFileDialogSelectProfile.ShowDialog();
		}
		
		void OpenFileDialogSelectProfileFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			textBoxSelectedBatchProfile.Text = openFileDialogSelectProfile.FileName;
		}
		
		
		static public void SerializeToXML(HistoryTemplate ht, String path)
		{
  			XmlSerializer serializer = new XmlSerializer(typeof(HistoryTemplate));
   			TextWriter textWriter = new StreamWriter(path, false);
   			serializer.Serialize(textWriter, ht);
   			textWriter.Close();
 		}
		
		static public HistoryTemplate DeserializeFromXML(String path)
		{	 
  			XmlSerializer mySerializer = new XmlSerializer(typeof(HistoryTemplate));
  			FileStream myFileStream = new FileStream(path,FileMode.Open);
 			HistoryTemplate ht = (HistoryTemplate)mySerializer.Deserialize(myFileStream);
 			myFileStream.Close();
 	 		return ht;
 		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			SaveHistory();
			string appPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + this.ht.fileName;
			SerializeToXML(this.ht, appPath);
		}
		
		void ButtonBatchProfileClick(object sender, EventArgs e)
		{

			ListViewItem lvi = new ListViewItem();
			lvi.Text = textBoxSelectedBatchProfile.Text;
			lvi.Tag = textBoxSelectedBatchProfile.Text;
			ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
          	lvsi.Text = textBoxDefeultPrefix.Text;
          	lvsi.Tag = textBoxDefeultPrefix.Text;
          	lvi.SubItems.Add(lvsi);

			listViewDefaultProfiles.Items.Add(lvi);
			
		}
		
		void ButtonRemoveBatchProfileClick(object sender, EventArgs e)
		{
			foreach(ListViewItem si in listViewDefaultProfiles.SelectedItems)
			{
				listViewDefaultProfiles.Items.Remove(si);
			}
		}
		
		void ButtonRemoveSelectedFilesClick(object sender, EventArgs e)
		{
			foreach(ListViewItem si in listViewInputFiles.SelectedItems)
			{
				listViewInputFiles.Items.Remove(si);
			}
			toolStripStatusLabelNumberOffFiles.Text = listViewInputFiles.Items.Count + " Input Files";
		}
		
		public TextBox getLogTextBox()
		{
			return textBoxRunLog;
		}
		
		void CheckBoxOnTopCheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = checkBoxOnTop.Checked; 
		}
		
		void ButtonSelectFolderClick(object sender, EventArgs e)
		{
			if(folderBrowserDialogSelectFolder.ShowDialog() == DialogResult.OK)
			{
				addFilesToList(folderBrowserDialogSelectFolder.SelectedPath);
			}
		}
		
		void addFilesToList(String s)
		{
			if(Directory.Exists(s))
			{
				try{
					string[] filePaths = Directory.GetFiles(@s, "*.*", SearchOption.AllDirectories);
				
					foreach(String fp in filePaths)
					{
						listViewInputFiles.Items.Add(new ListViewItem(fp));
					}
				}
				catch(Exception ep)
				{
				
				}
			}
			else {
					listViewInputFiles.Items.Add(new ListViewItem(s));					
				}
			toolStripStatusLabelNumberOffFiles.Text = listViewInputFiles.Items.Count + " Input Files";
			
		}
		
		public void removeFilesFromList(String file)
		{
			if(checkBoxRemoveFiles.Checked)
			{
				//listViewInputFiles.Items.
				foreach(ListViewItem i in listViewInputFiles.Items)
				{
					if(i.Text.Equals(file)){
						listViewInputFiles.Items.Remove(i);
					}
				}
				toolStripStatusLabelNumberOffFiles.Text = listViewInputFiles.Items.Count + " Input Files";
			}
			//listViewInputFiles.Items.Remove(file);
		}
		
		void ButtonClearLogClick(object sender, EventArgs e)
		{
			textBoxRunLog.Text = "";
		}
		
		void ListViewInputFilesControlAdded(object sender, ControlEventArgs e)
		{
			toolStripStatusLabelNumberOffFiles.Text = listViewInputFiles.Items.Count + " Input Files";
		}
		
		void ListViewInputFilesControlRemoved(object sender, ControlEventArgs e)
		{
			toolStripStatusLabelNumberOffFiles.Text = listViewInputFiles.Items.Count + " Input Files";
		}
		
		void TabControlMainWindowSelectedIndexChanged(object sender, EventArgs e)
		{
			ChangeFormTitle();
		}
		
		void ChangeFormTitle()
		{
			this.Text = ProductName + " " + ProductVersion + " - " + tabControlMainWindow.SelectedTab.Text;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			ChangeFormTitle();
			labelBuildNumber.Text = ProductVersion;
		}
		
		public void DoProcessingInfo(ProcessingInfo pi)
		{
			if(!pi.isEmpty)
			{
				//toolStripStatusLabelProcessingFileText.Text = pi.currentFile;
				toolStripProgressBarFileProcessing.Maximum = pi.totalNumberOfFiles;
				toolStripProgressBarFileProcessing.Value = pi.currentFileNumber;
				
			}
		}
	}
	
	
}
