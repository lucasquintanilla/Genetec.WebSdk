using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Genetec.WebSdk.XML
{
    [XmlRoot(ElementName = "Cell")]
    public class Cell
    {
        [XmlElement(ElementName = "HeaderColumnName")]
        public string HeaderColumnName { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlText]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "HeaderRow")]
    public class HeaderRow
    {
        [XmlElement(ElementName = "Cell")]
        public Cell Cell { get; set; }
    }

    [XmlRoot(ElementName = "Row")]
    public class Row
    {
        [XmlElement(ElementName = "Cell")]
        public Cell Cell { get; set; }
    }

    [XmlRoot(ElementName = "QueryResult")]
    public class QueryResult
    {
        [XmlElement(ElementName = "HeaderRow")]
        public HeaderRow HeaderRow { get; set; }
        [XmlElement(ElementName = "Row")]
        public List<Row> Row { get; set; }
    }

    [XmlRoot(ElementName = "rsp")]
    public class RspCredentialConfiguration
    {
        [XmlElement(ElementName = "QueryResult")]
        public QueryResult QueryResult { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }
}
