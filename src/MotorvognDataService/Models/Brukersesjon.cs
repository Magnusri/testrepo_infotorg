using System.Xml.Serialization;

namespace MotorvognDataService.Models;

[XmlRoot(ElementName = "Brukersesjon", Namespace = "http://ws.infotorg.no/xml/Admin/Brukersesjon/2006-07-07/Brukersesjon.xsd")]
public class Brukersesjon
{
    [XmlElement(ElementName = "BrukerId")]
    public string? BrukerId { get; set; }

    [XmlElement(ElementName = "Passord")]
    public string? Passord { get; set; }

    [XmlElement(ElementName = "Systemnavn")]
    public string? Systemnavn { get; set; }

    [XmlElement(ElementName = "SystemVersjon")]
    public string? SystemVersjon { get; set; }
}
