/*
 * Created by SharpDevelop.
 * User: joheri11
 * Date: 2011-10-18
 * Time: 07:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Windows.Forms;

namespace awfulizer
{
	/// <summary>
	/// Description of HistoryTemplate.
	/// </summary>
	[Serializable]
	public class HistoryTemplate
	{
		public String fileName = "awfhistory.xml";
		public ArrayList profileHistory = new ArrayList();
		
		public ArrayList batchProfileList = new ArrayList();

		//public ListView.ListViewItemCollection batchProfileList;
		public String lastBatchProfile = "";
		public Boolean batchMode = false;
		public Boolean quickMode = true;
		public Boolean clearList = true;
		public Boolean onTop = false;
		public Boolean deleteOutputFiles = false;
		public HistoryTemplate()
		{
		}
	}
}
