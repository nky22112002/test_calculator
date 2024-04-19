using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnitTestCalculator
{

    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest_03_Ky
    {
        static int index_03_Ky = 1;


        public TestContext TestContext
        {
            get;
            set;
        }
        public UnitTest_03_Ky()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataGameKeoBuaBao_03_Ky.csv", "TestDataGameKeoBuaBao_03_Ky#csv", DataAccessMethod.Sequential)]
        public void TestGameKeoBuaBao_03_Ky()
        {
            Console.WriteLine(index_03_Ky);

            string inputFilePath = @"D:\testing_course\test_calculator\Calculator\UnitTestCalculator\Data\TestDataGameKeoBuaBao_03_Ky.csv";
            Console.WriteLine(TestContext.DataRow[0].ToString());

            string a, b, expected, actual;
            a = TestContext.DataRow[0].ToString();
            b = TestContext.DataRow[1].ToString();
            expected = TestContext.DataRow[2].ToString();

            GameKeoBuaBao_03_Ky gameKeoBuaBao_03_Ky = new GameKeoBuaBao_03_Ky(a, b);
            gameKeoBuaBao_03_Ky.HandleKeoBuaBao_03_Ky();
            actual = gameKeoBuaBao_03_Ky.GetMessage();

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
                if (index_03_Ky <= lines.Count)
                {
                    if (!(index_03_Ky == 0))
                    {
                        lines[index_03_Ky] += $",{result}";
                    }
                }
                // Write the updated data back to the CSV file
                File.WriteAllLines(inputFilePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to CSV file: {ex.Message}");
            }
            index_03_Ky += 1;

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataPTBH_03_Ky.csv", "TestDataPTBH_03_Ky#csv", DataAccessMethod.Sequential)]
        public void TestPTBH_03_Ky() {
            string inputFilePath = @"D:\testing_course\test_calculator\Calculator\UnitTestCalculator\Data\TestDataPTBH_03_Ky.csv";
            GiaiPTBH_03_Ky giaiPTBH_03_Ky = new GiaiPTBH_03_Ky();
            double a, b, c;
            string expected;
            a = double.Parse(TestContext.DataRow[0].ToString());
            b = double.Parse(TestContext.DataRow[1].ToString());
            c = double.Parse(TestContext.DataRow[2].ToString());
            expected = TestContext.DataRow[3].ToString();
            string result = giaiPTBH_03_Ky.HandleButtonKQ_03_Ky(a, b, c);
            Assert.AreEqual(expected, result);
            // Determine test result
            string resultTest = TestContext.CurrentTestOutcome.ToString();

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
                string[] testData = { a.ToString(), b.ToString(), c.ToString(), expected, resultTest };
                string testDataLine = string.Join(",", testData);

                // Add data to new column next to "result"
                if (index_03_Ky <= lines.Count)
                {
                    if (!(index_03_Ky == 0))
                    {
                        lines[index_03_Ky] += $",{resultTest}";
                    }
                }
                // Write the updated data back to the CSV file
                File.WriteAllLines(inputFilePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to CSV file: {ex.Message}");
            }
            index_03_Ky += 1;
        }
    }
}
