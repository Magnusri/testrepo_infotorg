using System.Xml.Serialization;

namespace MotorvognDataService.Models;

// Request types

[XmlRoot(ElementName = "hentMotorvognData", Namespace = MotorvognConstants.Namespace)]
public class HentMotorvognDataRequest
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "understellsnummer")]
    public string? Understellsnummer { get; set; }
}

[XmlRoot(ElementName = "hentMotorvognEier", Namespace = MotorvognConstants.Namespace)]
public class HentMotorvognEierRequest
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "understellsnummer")]
    public string? Understellsnummer { get; set; }
}

[XmlRoot(ElementName = "hentMotorvognTeknisk", Namespace = MotorvognConstants.Namespace)]
public class HentMotorvognTekniskRequest
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "understellsnummer")]
    public string? Understellsnummer { get; set; }
}

[XmlRoot(ElementName = "hentMotorvognNavneSok", Namespace = MotorvognConstants.Namespace)]
public class HentMotorvognNavneSokRequest
{
    [XmlElement(ElementName = "navn")]
    public string? Navn { get; set; }

    [XmlElement(ElementName = "postnummer")]
    public string? Postnummer { get; set; }
}

[XmlRoot(ElementName = "hentMotorvognOppslag", Namespace = MotorvognConstants.Namespace)]
public class HentMotorvognOppslagRequest
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "understellsnummer")]
    public string? Understellsnummer { get; set; }
}

[XmlRoot(ElementName = "hentMotorvognHistorisk", Namespace = MotorvognConstants.Namespace)]
public class HentMotorvognHistoriskRequest
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "understellsnummer")]
    public string? Understellsnummer { get; set; }
}

// Response types

[XmlRoot(ElementName = "MotorvognData", Namespace = MotorvognConstants.Namespace)]
public class MotorvognData
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }
}

[XmlRoot(ElementName = "MotorvognEier", Namespace = MotorvognConstants.Namespace)]
public class MotorvognEier
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }
}

[XmlRoot(ElementName = "MotorvognTeknisk", Namespace = MotorvognConstants.Namespace)]
public class MotorvognTeknisk
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }
}

[XmlRoot(ElementName = "MotorvognNavneSok", Namespace = MotorvognConstants.Namespace)]
public class MotorvognNavneSok
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }
}

[XmlRoot(ElementName = "MotorvognOppslag", Namespace = MotorvognConstants.Namespace)]
public class MotorvognOppslag
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }
}

[XmlRoot(ElementName = "MotorvognHistorisk", Namespace = MotorvognConstants.Namespace)]
public class MotorvognHistorisk
{
    [XmlElement(ElementName = "kjennemerke")]
    public string? Kjennemerke { get; set; }
}

public static class MotorvognConstants
{
    public const string Namespace = "http://ws.infotorg.no/xml/SVV/MotorvognData/2022-03-15/MotorvognData.xsd";
}
