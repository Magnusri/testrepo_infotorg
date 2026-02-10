using System.Xml.Serialization;

namespace MotorvognDataService.Models;

[XmlType(Namespace = MotorvognConstants.Namespace)]
public enum SearchType
{
    [XmlEnum("ssn")]
    Ssn,

    [XmlEnum("chassis")]
    Chassis,

    [XmlEnum("registration-number")]
    RegistrationNumber,

    [XmlEnum("company")]
    Company
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Kodeverdier
{
    [XmlElement(ElementName = "kodeNavn", IsNullable = true)]
    public string? KodeNavn { get; set; }

    [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
    public string? KodeVerdi { get; set; }

    [XmlElement(ElementName = "kodeBeskrivelse", IsNullable = true)]
    public string? KodeBeskrivelse { get; set; }

    [XmlElement(ElementName = "kodeTypeId", IsNullable = true)]
    public string? KodeTypeId { get; set; }

    [XmlElement(ElementName = "tidligereKodeVerdier", IsNullable = true)]
    public TidligereKodeVerdierType? TidligereKodeVerdier { get; set; }

    public class TidligereKodeVerdierType
    {
        [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
        public string[]? KodeVerdi { get; set; }
    }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Periode
{
    [XmlElement(ElementName = "fomTidspunkt", IsNullable = true)]
    public string? FomTidspunkt { get; set; }

    [XmlElement(ElementName = "sistEndretTidspunkt", IsNullable = true)]
    public string? SistEndretTidspunkt { get; set; }

    [XmlElement(ElementName = "tilTidspunkt", IsNullable = true)]
    public string? TilTidspunkt { get; set; }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Avgiftskode
{
    [XmlElement(ElementName = "kodeNavn", IsNullable = true)]
    public string? KodeNavn { get; set; }

    [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
    public string? KodeVerdi { get; set; }

    [XmlElement(ElementName = "kodeBeskrivelse", IsNullable = true)]
    public string? KodeBeskrivelse { get; set; }

    [XmlElement(ElementName = "tidligereKodeVerdier", IsNullable = true)]
    public TidligereKodeVerdierType? TidligereKodeVerdier { get; set; }

    public class TidligereKodeVerdierType
    {
        [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
        public string[]? KodeVerdi { get; set; }
    }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Registreringsstatus
{
    [XmlElement(ElementName = "fomTidspunkt", IsNullable = true)]
    public DateTime? FomTidspunkt { get; set; }

    [XmlElement(ElementName = "tilTidspunkt", IsNullable = true)]
    public DateTime? TilTidspunkt { get; set; }

    [XmlElement(ElementName = "registrertForstegangNorgeDato", IsNullable = true)]
    public DateTime? RegistrertForstegangNorgeDato { get; set; }

    [XmlElement(ElementName = "kodeNavn", IsNullable = true)]
    public string? KodeNavn { get; set; }

    [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
    public string? KodeVerdi { get; set; }

    [XmlElement(ElementName = "kodeBeskrivelse", IsNullable = true)]
    public string? KodeBeskrivelse { get; set; }

    [XmlElement(ElementName = "tidligereKodeVerdier", IsNullable = true)]
    public TidligereKodeVerdierType? TidligereKodeVerdier { get; set; }

    public class TidligereKodeVerdierType
    {
        [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
        public string[]? KodeVerdi { get; set; }
    }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Kjoretoymerknad
{
    [XmlElement(ElementName = "merknad", IsNullable = true)]
    public string? Merknad { get; set; }

    [XmlElement(ElementName = "merknadtypeKode", IsNullable = true)]
    public string? MerknadtypeKode { get; set; }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Registreringsbegrensning
{
    [XmlElement(ElementName = "kodeBeskrivelse", IsNullable = true)]
    public string? KodeBeskrivelse { get; set; }

    [XmlElement(ElementName = "kodeVerdi", IsNullable = true)]
    public string? KodeVerdi { get; set; }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Responskode
{
    [XmlElement(ElementName = "beskrivelse", IsNullable = true)]
    public string? Beskrivelse { get; set; }

    [XmlElement(ElementName = "kode", IsNullable = true)]
    public string? Kode { get; set; }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class ResponskodeOppslag
{
    [XmlElement(ElementName = "beskrivelse", IsNullable = true)]
    public string? Beskrivelse { get; set; }

    [XmlElement(ElementName = "kode", IsNullable = true)]
    public string? Kode { get; set; }

    [XmlElement(ElementName = "dtg", IsNullable = true)]
    public string? Dtg { get; set; }

    [XmlElement(ElementName = "kjennemerke", IsNullable = true)]
    public string? Kjennemerke { get; set; }
}

[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Kryssbytte
{
    [XmlElement(ElementName = "kryssbyttetMedKuid", IsNullable = true)]
    public string? KryssbyttetMedKuid { get; set; }

    [XmlElement(ElementName = "periode", IsNullable = true)]
    public Periode? Periode { get; set; }
}
