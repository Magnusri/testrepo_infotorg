using System.Xml.Serialization;

namespace MotorvognDataService.Models;

[XmlRoot(ElementName = "feil", Namespace = "http://ws.infotorg.no/xml/Feil/Feil.xsd")]
public class Feil
{
    [XmlElement(ElementName = "feilkode")]
    public string? Feilkode { get; set; }

    [XmlElement(ElementName = "feilmelding")]
    public string? Feilmelding { get; set; }
}
