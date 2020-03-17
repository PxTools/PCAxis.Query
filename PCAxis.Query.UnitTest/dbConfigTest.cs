using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PCAxis.Query.UnitTest
{
	[TestClass]
	public class dbConfigTest
	{
		[TestMethod]
		public void ShouldAddDbConfig()
		{

			//Arrange,
			var dbConfigList = new List<DbConfig>();
			var dbConfig = new DbConfig
			{
				Type = "type",
				Name = "Name",
				RootPath = "rootPath"
			};

			// Act
			dbConfigList.Add(dbConfig);


			//Assert
			Assert.AreEqual(dbConfigList.Count, 1);

		}
	}
}
