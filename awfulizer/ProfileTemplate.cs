/*
 * Created by SharpDevelop.
 * User: joheri11
 * Date: 2011-09-10
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace awfulizer
{
	/// <summary>
	/// Description of ProfileTemplate.
	/// </summary>
	/// 
	[Serializable]
	public class ProfileTemplate
	{
		public String command = "";
		public String variables = "{IN} {OUT}";
		public String defaultOutput = "{RNBR}_{INFILENAME}.{EXTEN}";
		public String defaultOutputFolder = "{INPUTFILEFOLDER}";
		public int defaultPipeTimes = 1;
		public Boolean defaultPipe = true;
		public Boolean defaultSaveRPMOutput = false;
		
		public ProfileTemplate()
		{
			
		}
	}
}
