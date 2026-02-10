using System.Xml.Serialization;

namespace MotorvognDataService.Models;

[XmlType(TypeName = "eierskap", Namespace = MotorvognConstants.Namespace)]
public class Eierskap
{
    [XmlElement(ElementName = "fodselsnummer", IsNullable = true)]
    public string? Fodselsnummer { get; set; }

    [XmlElement(ElementName = "fodselsdato", IsNullable = true)]
    public DateTime? Fodselsdato { get; set; }

    [XmlElement(ElementName = "etternavn", IsNullable = true)]
    public string? Etternavn { get; set; }

    [XmlElement(ElementName = "fornavn", IsNullable = true)]
    public string? Fornavn { get; set; }

    [XmlElement(ElementName = "mellomnavn", IsNullable = true)]
    public string? Mellomnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnavn", IsNullable = true)]
    public string? Organisasjonsnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnummer", IsNullable = true)]
    public string? Organisasjonsnummer { get; set; }

    [XmlElement(ElementName = "adresselinje1", IsNullable = true)]
    public string? Adresselinje1 { get; set; }

    [XmlElement(ElementName = "adresselinje2", IsNullable = true)]
    public string? Adresselinje2 { get; set; }

    [XmlElement(ElementName = "adresselinje3", IsNullable = true)]
    public string? Adresselinje3 { get; set; }

    [XmlElement(ElementName = "postnummer", IsNullable = true)]
    public string? Postnummer { get; set; }

    [XmlElement(ElementName = "poststed", IsNullable = true)]
    public string? Poststed { get; set; }
}

[XmlType(TypeName = "eierskapoppslag", Namespace = MotorvognConstants.Namespace)]
public class EierskapOppslag
{
    [XmlElement(ElementName = "fodselsnummer", IsNullable = true)]
    public string? Fodselsnummer { get; set; }

    [XmlElement(ElementName = "fodselsdato", IsNullable = true)]
    public DateTime? Fodselsdato { get; set; }

    [XmlElement(ElementName = "etternavn", IsNullable = true)]
    public string? Etternavn { get; set; }

    [XmlElement(ElementName = "fornavn", IsNullable = true)]
    public string? Fornavn { get; set; }

    [XmlElement(ElementName = "mellomnavn", IsNullable = true)]
    public string? Mellomnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnavn", IsNullable = true)]
    public string? Organisasjonsnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnummer", IsNullable = true)]
    public string? Organisasjonsnummer { get; set; }

    [XmlElement(ElementName = "adresselinje1", IsNullable = true)]
    public string? Adresselinje1 { get; set; }

    [XmlElement(ElementName = "adresselinje2", IsNullable = true)]
    public string? Adresselinje2 { get; set; }

    [XmlElement(ElementName = "adresselinje3", IsNullable = true)]
    public string? Adresselinje3 { get; set; }

    [XmlElement(ElementName = "postnummer", IsNullable = true)]
    public string? Postnummer { get; set; }

    [XmlElement(ElementName = "poststed", IsNullable = true)]
    public string? Poststed { get; set; }

    [XmlElement(ElementName = "fomTidspunkt", IsNullable = true)]
    public string? FomTidspunkt { get; set; }

    [XmlElement(ElementName = "tilTidspunkt", IsNullable = true)]
    public string? TilTidspunkt { get; set; }
}

[XmlType(TypeName = "eierskaphistorikk", Namespace = MotorvognConstants.Namespace)]
public class EierskapHistorikk
{
    [XmlElement(ElementName = "fodselsnummer", IsNullable = true)]
    public string? Fodselsnummer { get; set; }

    [XmlElement(ElementName = "etternavn", IsNullable = true)]
    public string? Etternavn { get; set; }

    [XmlElement(ElementName = "fornavn", IsNullable = true)]
    public string? Fornavn { get; set; }

    [XmlElement(ElementName = "mellomnavn", IsNullable = true)]
    public string? Mellomnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnavn", IsNullable = true)]
    public string? Organisasjonsnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnummer", IsNullable = true)]
    public string? Organisasjonsnummer { get; set; }

    [XmlElement(ElementName = "adresselinje1", IsNullable = true)]
    public string? Adresselinje1 { get; set; }

    [XmlElement(ElementName = "adresselinje2", IsNullable = true)]
    public string? Adresselinje2 { get; set; }

    [XmlElement(ElementName = "adresselinje3", IsNullable = true)]
    public string? Adresselinje3 { get; set; }

    [XmlElement(ElementName = "postnummer", IsNullable = true)]
    public string? Postnummer { get; set; }

    [XmlElement(ElementName = "poststed", IsNullable = true)]
    public string? Poststed { get; set; }

    [XmlElement(ElementName = "adressestatus", IsNullable = true)]
    public Kodeverdier? Adressestatus { get; set; }

    [XmlElement(ElementName = "periode", IsNullable = true)]
    public Periode? Periode { get; set; }
}

[XmlType(TypeName = "eierinformasjon", Namespace = MotorvognConstants.Namespace)]
public class Eierinformasjon
{
    [XmlElement(ElementName = "eier", IsNullable = true)]
    public Eierskap? Eier { get; set; }

    [XmlElement(ElementName = "medeier", IsNullable = true)]
    public Eierskap? Medeier { get; set; }

    [XmlElement(ElementName = "leasingtaker", IsNullable = true)]
    public Eierskap? Leasingtaker { get; set; }
}

[XmlType(TypeName = "eierinformasjonoppslag", Namespace = MotorvognConstants.Namespace)]
public class EierinformasjonOppslag
{
    [XmlElement(ElementName = "eier", IsNullable = true)]
    public EierskapOppslag? Eier { get; set; }

    [XmlElement(ElementName = "medeier", IsNullable = true)]
    public EierskapOppslag? Medeier { get; set; }

    [XmlElement(ElementName = "leasingtaker", IsNullable = true)]
    public EierskapOppslag? Leasingtaker { get; set; }
}

[XmlType(TypeName = "navnesok", Namespace = MotorvognConstants.Namespace)]
public class Navnesok
{
    [XmlElement(ElementName = "eier", IsNullable = true)]
    public Sok? Eier { get; set; }

    [XmlElement(ElementName = "leasingtaker", IsNullable = true)]
    public Sok? Leasingtaker { get; set; }
}

[XmlType(TypeName = "sok", Namespace = MotorvognConstants.Namespace)]
public class Sok
{
    [XmlElement(ElementName = "kjennemerke", IsNullable = true)]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "merke", IsNullable = true)]
    public string? Merke { get; set; }

    [XmlElement(ElementName = "modellaar", IsNullable = true)]
    public string? Modellaar { get; set; }

    [XmlElement(ElementName = "fodselsdato", IsNullable = true)]
    public DateTime? Fodselsdato { get; set; }

    [XmlElement(ElementName = "etternavn", IsNullable = true)]
    public string? Etternavn { get; set; }

    [XmlElement(ElementName = "fornavn", IsNullable = true)]
    public string? Fornavn { get; set; }

    [XmlElement(ElementName = "mellomnavn", IsNullable = true)]
    public string? Mellomnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnavn", IsNullable = true)]
    public string? Organisasjonsnavn { get; set; }

    [XmlElement(ElementName = "organisasjonsnummer", IsNullable = true)]
    public string? Organisasjonsnummer { get; set; }

    [XmlElement(ElementName = "adresselinje1", IsNullable = true)]
    public string? Adresselinje1 { get; set; }

    [XmlElement(ElementName = "postnummer", IsNullable = true)]
    public string? Postnummer { get; set; }

    [XmlElement(ElementName = "poststed", IsNullable = true)]
    public string? Poststed { get; set; }
}
