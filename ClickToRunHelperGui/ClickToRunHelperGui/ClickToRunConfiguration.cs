using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClickToRunHelperGui
{
    [XmlRoot(ElementName = "Configuration")]
    public class ClickToRunConfiguration
    {
        public ClickToRunAddSetting Add { get; set; }
        public ClickToRunRemoveSetting Remove { get; set; }
        public ClickToRunUpdatesSetting Updates { get; set; }
        public ClickToRunDisplaySetting Display { get; set; }
        public ClickToRunLoggingSetting Logging { get; set; }
    }

    [XmlRoot(ElementName = "Add")]
    public class ClickToRunAddSetting
    {
        [XmlAttribute]
        public string SourcePath { get; set; }
        [XmlAttribute]
        public string Version { get; set; }
        [XmlAttribute]
        public int OfficeClientEdition { get; set; }
        [XmlAttribute]
        public string Channel { get; set; }
        [XmlAttribute]
        public string DownloadPath { get; set; }

        [XmlElement(ElementName = "Product")]
        public List<ClickToRunProductSetting> ProductList { get; set; } = new List<ClickToRunProductSetting>();
    }

    [XmlRoot(ElementName = "Product")]
    public class ClickToRunProductSetting
    {
        [XmlAttribute]
        public string ID { get; set; }

        [XmlElement(ElementName = "Language")]
        public List<ClickToRunLanguageSetting> LanguageList { get; set; } = new List<ClickToRunLanguageSetting>();
        [XmlElement(ElementName = "ExcludeApp")]
        public List<ClickToRunExcludeAppSetting> ExcludeAppList { get; set; } = new List<ClickToRunExcludeAppSetting>();
    }

    [XmlRoot(ElementName = "Language")]
    public class ClickToRunLanguageSetting
    {
        [XmlAttribute]
        public string ID { get; set; }
    }

    [XmlRoot(ElementName = "Display")]
    public class ClickToRunDisplaySetting
    {
        [XmlAttribute]
        public string Level { get; set; }
        [XmlAttribute]
        public bool AcceptEULA { get; set; }

    }

    [XmlRoot(ElementName = "ExcludeApp")]
    public class ClickToRunExcludeAppSetting {
        [XmlAttribute]
        public string ID { get; set; }
    }

    [XmlRoot(ElementName = "Logging")]
    public class ClickToRunLoggingSetting
    {
        [XmlAttribute]
        public string Level { get; set; }
        [XmlAttribute]
        public string Path { get; set; }
    }

    [XmlRoot(ElementName = "Property")]
    public class ClickToRunPropertySetting
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "Remove")]
    public class ClickToRunRemoveSetting
    {
        [XmlAttribute]
        public bool All { get; set; }

        [XmlElement(ElementName = "Product")]
        public List<ClickToRunProductSetting> ProductList { get; set; } = new List<ClickToRunProductSetting>();

    }

    [XmlRoot(ElementName = "Updates")]
    public class ClickToRunUpdatesSetting
    {
        [XmlAttribute]
        public bool Enabled { get; set; }
        [XmlAttribute]
        public string UpdatePath { get; set; }
        [XmlAttribute]
        public string TargetVersion { get; set; }
        [XmlAttribute]
        public string Deadline { get; set; }
        [XmlAttribute]
        public string Channel { get; set; }
    }
}
