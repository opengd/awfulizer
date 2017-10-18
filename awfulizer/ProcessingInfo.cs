/*
 * Created by SharpDevelop.
 * User: SaraVidebeck
 * Date: 2011-10-20
 * Time: 16:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace awfulizer
{
	/// <summary>
	/// Description of ProcessingInfo.
	/// </summary>
	public class ProcessingInfo
	{
		public Boolean isEmpty = false; 
		public String currentFile = "";
		public int currentFileNumber = 0;
		public int totalNumberOfFiles = 0;
		public ProcessingInfo()
		{
		}
		public ProcessingInfo(String currentFile, int currentFileNumber, int totalNumberOfFiles)
		{
			this.currentFile = currentFile;
			this.currentFileNumber = currentFileNumber;
			this.totalNumberOfFiles = totalNumberOfFiles;
		}
		public ProcessingInfo(Boolean isEmpty)
		{
			this.isEmpty = isEmpty;
		}
		
	}
}
