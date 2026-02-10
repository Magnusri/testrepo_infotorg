using System.Xml.Serialization;

namespace MotorvognDataService.Models;

[XmlRoot(ElementName = "Transaksjon", Namespace = "http://ws.infotorg.no/xml/Admin/Transaksjon/2006-07-07/Transaksjon.xsd")]
public class Transaksjon
{
    [XmlElement(ElementName = "Referanse")]
    public string? Referanse { get; set; }
}

[XmlRoot(ElementName = "Transaksjonsinfo", Namespace = "http://ws.infotorg.no/xml/Admin/Transaksjon/2006-07-07/Transaksjon.xsd")]
public class Transaksjonsinfo
{
    [XmlElement(ElementName = "Referanse")]
    public string? Referanse { get; set; }

    [XmlElement(ElementName = "TransaksjonsId")]
    public string? TransaksjonsId { get; set; }
}
