using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Unifac.BlueYonder.Library;
using Unifac.BlueYonder.Web.Library;

namespace Unifac.BlueYonder.Library.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private MocaValidating class1;

        [TestInitialize]
        public void Init()
        {
            class1 = new MocaValidating();
        }

        [TestMethod]
        public void ColumnEquals()
        {
            var column1 = new Column
            {
                DataType = "S",
                Name = "tests",
                Nullable = true
            };
            var actual = column1.Equals(new Column
            {
                DataType = "S",
                Name = "tests",
                Nullable = true
            });
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ColumnEqualsShouldReturnFalseWhenTheDataTypesAreDifferent()
        {
            var column1 = new Column
            {
                DataType = "S2",
                Name = "tests",
                Nullable = true
            };
            var actual = column1.Equals(new Column
            {
                DataType = "S",
                Name = "tests",
                Nullable = true
            });
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CanGetColumnsProperly()
        {
            //arrange
            var mocaXmlReportInput = "<moca-response><session-id></session-id><status>0</status><moca-results><metadata><column name=\"usr_id\" type=\"S\" length=\"40\" nullable=\"false\"/></metadata><data><row><field>1GLORIAT</field></row></data></moca-results></moca-response>";

            //act
            var actual = class1.GetColumns(mocaXmlReportInput);

            var expected = new List<Column>
            {
                new Column
                {
                    Name = "usr_id",
                    DataType = "S",
                    Nullable = false
                }
            };
            //CollectionAssert.AreEquivalent(expected, actual);
            Assert.AreEqual(actual.Count, 1);
            Assert.AreEqual(actual[0], expected[0]);
        }

        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var mocaXmlReportInput = "<moca-response><session-id></session-id><status>0</status><moca-results><metadata><column name=\"usr_id\" type=\"S\" length=\"40\" nullable=\"false\"/></metadata><data><row><field>1GLORIAT</field></row></data></moca-results></moca-response>";

            //act
            var actual = class1.GetData(mocaXmlReportInput);

            //assert
            var expected = new JArray();
            var blah2 = JToken.FromObject(new
            {
                usr_id = "1GLORIAT"
            });
            expected.Add(blah2);
            Assert.AreEqual(actual.Count, 1);
            Assert.IsTrue(JToken.DeepEquals(actual[0], expected[0]));
        }
    }
}
