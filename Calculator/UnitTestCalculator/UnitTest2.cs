using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTestCalculator
{

    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        static int index = 1;

        
        public TestContext TestContext
        {
            get;
            set;
        }
        public UnitTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestGameKeoBuaBao.csv", "TestGameKeoBuaBao#csv", DataAccessMethod.Sequential)]

        public void TestGameKeoBuaBao()
        {
            Console.WriteLine(index);

            string inputFilePath = @"D:\testing_course\test_calculator\Calculator\UnitTestCalculator\Data\TestGameKeoBuaBao.csv";

            string a, b, expected, actual;
            a = TestContext.DataRow[0].ToString();
            b = TestContext.DataRow[1].ToString();
            expected = TestContext.DataRow[2].ToString();

            GameKeoBuaBao gameKeoBuaBao = new GameKeoBuaBao(a, b);
            gameKeoBuaBao.HandleKeoBuaBao();
            actual = gameKeoBuaBao.GetMessage();

            Assert.AreEqual(expected, actual);

            // Determine test result
            string result = TestContext.CurrentTestOutcome.ToString();

            try
            {
                // Read existing data from CSV file
                List<string> lines = new List<string>();
                if (File.Exists(inputFilePath))
                {
                    lines = File.ReadAllLines(inputFilePath).ToList();
                }

                // Add "Result" header if not already present
                if (lines.Count > 0 && !lines[0].Contains("result"))
                {
                    lines[0] += ",result";
                }

                // Append the test data and result to the CSV file
                string[] testData = { a, b, expected, result };
                string testDataLine = string.Join(",", testData);

                // Add data to new column next to "result"
                if(index <= lines.Count) {
                    if (!(index == 0))
                    {
                        lines[index] += $",{result}";
                    }
                }
                // Write the updated data back to the CSV file
                File.WriteAllLines(inputFilePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to CSV file: {ex.Message}");
            }
            index += 1;

        }
    }
}
