using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestMultipleDB.Web
{
	public class WebContentDirectoryFinder
	{
		public static string CalculateContentRootFolder()
		{
			var coreAssemblyDirectoryPath = Path.GetDirectoryName(AppContext.BaseDirectory);
			if (coreAssemblyDirectoryPath == null)
			{
				throw new Exception("Could not find location of TestMultipleDB.Core assembly!");
			}

			var directoryInfo = new DirectoryInfo(coreAssemblyDirectoryPath);
			while (!DirectoryContains(directoryInfo.FullName, "TestMultipleDB.sln"))
			{
				if (directoryInfo.Parent == null)
				{
					throw new Exception("Could not find content root folder!");
				}

				directoryInfo = directoryInfo.Parent;
			}

			return Path.Combine(directoryInfo.FullName, "TestMultipleDB.Web");
		}

		private static bool DirectoryContains(string directory, string fileName)
		{
			return Directory.GetFiles(directory).Any(filePath => string.Equals(Path.GetFileName(filePath), fileName));
		}
	}
}
