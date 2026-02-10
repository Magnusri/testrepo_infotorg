using System.Xml.Serialization;

namespace MotorvognDataService.Models;

// periodiskKjoretoyKontroller
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class PeriodiskKjoretoyKontroller
{
    [XmlElement(ElementName = "periodiskKjoretoyKontroll", IsNullable = true)]
    public PeriodiskKjoretoyKontrollType? PeriodiskKjoretoyKontroll { get; set; }

    public class PeriodiskKjoretoyKontrollType
    {
        [XmlElement(ElementName = "kontrollfrist", IsNullable = true)]
        public DateTime? Kontrollfrist { get; set; }

        [XmlElement(ElementName = "sistGodkjent", IsNullable = true)]
        public DateTime? SistGodkjent { get; set; }
    }
}

// kjoretoeyinformasjon
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Kjoretoeyinformasjon
{
    [XmlElement(ElementName = "fabrikanter", IsNullable = true)]
    public FabrikanterType? Fabrikanter { get; set; }

    [XmlElement(ElementName = "merker", IsNullable = true)]
    public MerkerType? Merker { get; set; }

    [XmlElement(ElementName = "kjennemerker", IsNullable = true)]
    public KjennemerkerType? Kjennemerker { get; set; }

    [XmlElement(ElementName = "godkjenning", IsNullable = true)]
    public GodkjenningType? Godkjenning { get; set; }

    [XmlElement(ElementName = "handelsbetegnelser", IsNullable = true)]
    public HandelsbetegnelserType? Handelsbetegnelser { get; set; }

    [XmlElement(ElementName = "avgiftskode", IsNullable = true)]
    public Avgiftskode? Avgiftskode { get; set; }

    [XmlElement(ElementName = "registreringsstatus", IsNullable = true)]
    public Registreringsstatus? Registreringsstatus { get; set; }

    [XmlElement(ElementName = "kjoretoymerknader", IsNullable = true)]
    public KjoretoymerknaderType? Kjoretoymerknader { get; set; }

    [XmlElement(ElementName = "registreringsbegrensninger", IsNullable = true)]
    public RegistreringsbegrensningerType? Registreringsbegrensninger { get; set; }

    [XmlElement(ElementName = "tekniskKode", IsNullable = true)]
    public Kodeverdier? TekniskKode { get; set; }

    [XmlElement(ElementName = "tekniskUnderkode", IsNullable = true)]
    public Kodeverdier? TekniskUnderkode { get; set; }

    [XmlElement(ElementName = "typebetegnelse", IsNullable = true)]
    public string? Typebetegnelse { get; set; }
}

public class FabrikanterType
{
    [XmlElement(ElementName = "fabrikant", IsNullable = true)]
    public FabrikantType[]? Fabrikant { get; set; }
}

public class FabrikantType
{
    [XmlElement(ElementName = "fabrikantAdresse", IsNullable = true)]
    public string? FabrikantAdresse { get; set; }

    [XmlElement(ElementName = "fabrikantNavn", IsNullable = true)]
    public string? FabrikantNavn { get; set; }

    [XmlElement(ElementName = "fabrikantRepresentantAdresse", IsNullable = true)]
    public string? FabrikantRepresentantAdresse { get; set; }

    [XmlElement(ElementName = "fabrikantRepresentantNavn", IsNullable = true)]
    public string? FabrikantRepresentantNavn { get; set; }
}

public class MerkerType
{
    [XmlElement(ElementName = "merke", IsNullable = true)]
    public MerkeType[]? Merke { get; set; }
}

public class MerkeType
{
    [XmlAttribute(AttributeName = "navn")]
    public string? Navn { get; set; }

    [XmlAttribute(AttributeName = "kode")]
    public string? Kode { get; set; }
}

public class KjennemerkerType
{
    [XmlElement(ElementName = "kjennemerke", IsNullable = true)]
    public KjennemerkeInfoType[]? Kjennemerke { get; set; }
}

public class KjennemerkeInfoType
{
    [XmlAttribute(AttributeName = "kjennemerkekategori")]
    public string? Kjennemerkekategori { get; set; }

    [XmlElement(ElementName = "stjaaletDato", IsNullable = true)]
    public string? StjaaletDato { get; set; }

    [XmlElement(ElementName = "kjennemerke", IsNullable = true)]
    public string? Kjennemerke { get; set; }

    [XmlElement(ElementName = "kjennemerketype", IsNullable = true)]
    public string? Kjennemerketype { get; set; }

    [XmlElement(ElementName = "understellsnummer", IsNullable = true)]
    public string? Understellsnummer { get; set; }

    [XmlElement(ElementName = "fomTidspunkt", IsNullable = true)]
    public DateTime? FomTidspunkt { get; set; }
}

public class GodkjenningType
{
    [XmlElement(ElementName = "forstegangRegistrertDato", IsNullable = true)]
    public DateTime? ForstegangRegistrertDato { get; set; }

    [XmlElement(ElementName = "registrertForstegangPaEierskap", IsNullable = true)]
    public DateTime? RegistrertForstegangPaEierskap { get; set; }

    [XmlElement(ElementName = "bruktimport", IsNullable = true)]
    public BruktimportType[]? Bruktimport { get; set; }
}

public class BruktimportType
{
    [XmlElement(ElementName = "importland", IsNullable = true)]
    public string? Importland { get; set; }

    [XmlElement(ElementName = "landskode", IsNullable = true)]
    public string? Landskode { get; set; }

    [XmlElement(ElementName = "kilometerstand", IsNullable = true)]
    public string? Kilometerstand { get; set; }
}

public class HandelsbetegnelserType
{
    [XmlElement(ElementName = "handelsbetegnelse", IsNullable = true)]
    public HandelsbetegnelseType[]? Handelsbetegnelse { get; set; }
}

public class HandelsbetegnelseType
{
    [XmlAttribute(AttributeName = "navn")]
    public string? Navn { get; set; }
}

public class KjoretoymerknaderType
{
    [XmlElement(ElementName = "kjoretoymerknad", IsNullable = true)]
    public Kjoretoymerknad[]? Kjoretoymerknad { get; set; }
}

public class RegistreringsbegrensningerType
{
    [XmlElement(ElementName = "registreringsbegrensning", IsNullable = true)]
    public Registreringsbegrensning[]? Registreringsbegrensning { get; set; }
}

// maalOgVekt
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class MaalOgVekt
{
    [XmlElement(ElementName = "egenvekt", IsNullable = true)]
    public int? Egenvekt { get; set; }

    [XmlElement(ElementName = "egenvektMaksimum", IsNullable = true)]
    public int? EgenvektMaksimum { get; set; }

    [XmlElement(ElementName = "egenvektMinimum", IsNullable = true)]
    public int? EgenvektMinimum { get; set; }

    [XmlElement(ElementName = "egenvektTilhengerkopling", IsNullable = true)]
    public int? EgenvektTilhengerkopling { get; set; }

    [XmlElement(ElementName = "nyttelast", IsNullable = true)]
    public int? Nyttelast { get; set; }

    [XmlElement(ElementName = "tekniskTillattForhoyetTotalvekt", IsNullable = true)]
    public int? TekniskTillattForhoyetTotalvekt { get; set; }

    [XmlElement(ElementName = "tekniskTillattTotalvekt", IsNullable = true)]
    public int? TekniskTillattTotalvekt { get; set; }

    [XmlElement(ElementName = "tillattTaklast", IsNullable = true)]
    public int? TillattTaklast { get; set; }

    [XmlElement(ElementName = "tillattTilhengervektMedBrems", IsNullable = true)]
    public int? TillattTilhengervektMedBrems { get; set; }

    [XmlElement(ElementName = "tillattTilhengervektUtenBrems", IsNullable = true)]
    public int? TillattTilhengervektUtenBrems { get; set; }

    [XmlElement(ElementName = "tillattTotalvekt", IsNullable = true)]
    public int? TillattTotalvekt { get; set; }

    [XmlElement(ElementName = "tillattVertikalKoplingslast", IsNullable = true)]
    public int? TillattVertikalKoplingslast { get; set; }

    [XmlElement(ElementName = "tillattVogntogvekt", IsNullable = true)]
    public int? TillattVogntogvekt { get; set; }

    [XmlElement(ElementName = "vogntogvektAvhBremsesystemer", IsNullable = true)]
    public VogntogvektAvhBremsesystemerType? VogntogvektAvhBremsesystemer { get; set; }

    [XmlElement(ElementName = "bredde", IsNullable = true)]
    public int? Bredde { get; set; }

    [XmlElement(ElementName = "lengde", IsNullable = true)]
    public int? Lengde { get; set; }

    [XmlElement(ElementName = "hoyde", IsNullable = true)]
    public int? Hoyde { get; set; }

    [XmlElement(ElementName = "lengdeInnvendigLasteplan", IsNullable = true)]
    public int? LengdeInnvendigLasteplan { get; set; }

    [XmlElement(ElementName = "maksimalHoyde", IsNullable = true)]
    public int? MaksimalHoyde { get; set; }

    [XmlElement(ElementName = "maksimalLengde", IsNullable = true)]
    public int? MaksimalLengde { get; set; }

    [XmlElement(ElementName = "maksimalBredde", IsNullable = true)]
    public int? MaksimalBredde { get; set; }

    [XmlElement(ElementName = "abs", IsNullable = true)]
    public string? Abs { get; set; }

    [XmlElement(ElementName = "bremsesystem", IsNullable = true)]
    public string? Bremsesystem { get; set; }

    [XmlElement(ElementName = "driftsbremsBak", IsNullable = true)]
    public string? DriftsbremsBak { get; set; }

    [XmlElement(ElementName = "driftsbremsForan", IsNullable = true)]
    public string? DriftsbremsForan { get; set; }

    [XmlElement(ElementName = "tilhengerBremseforbindelser", IsNullable = true)]
    public TilhengerBremseforbindelserType? TilhengerBremseforbindelser { get; set; }
}

public class VogntogvektAvhBremsesystemerType
{
    [XmlElement(ElementName = "vogntogvektAvhBremsesystem", IsNullable = true)]
    public string[]? VogntogvektAvhBremsesystem { get; set; }
}

public class TilhengerBremseforbindelserType
{
    [XmlElement(ElementName = "tilhengerBremseforbindelse", IsNullable = true)]
    public string[]? TilhengerBremseforbindelse { get; set; }
}

// motorOgKraftoverfoering
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class MotorOgKraftoverfoering
{
    [XmlElement(ElementName = "antallGir", IsNullable = true)]
    public int? AntallGir { get; set; }

    [XmlElement(ElementName = "girPlassering", IsNullable = true)]
    public string? GirPlassering { get; set; }

    [XmlElement(ElementName = "girkassetype", IsNullable = true)]
    public Kodeverdier? Girkassetype { get; set; }

    [XmlElement(ElementName = "giroverforingsType", IsNullable = true)]
    public string? GiroverforingsType { get; set; }

    [XmlElement(ElementName = "hybridElektriskKjoretoy", IsNullable = true)]
    public bool? HybridElektriskKjoretoy { get; set; }

    [XmlElement(ElementName = "hybridKategori", IsNullable = true)]
    public Kodeverdier? HybridKategori { get; set; }

    [XmlElement(ElementName = "maksimumHastighet", IsNullable = true)]
    public MaksimumHastighetType? MaksimumHastighet { get; set; }

    [XmlElement(ElementName = "maksimumHastighetMalt", IsNullable = true)]
    public MaksimumHastighetType? MaksimumHastighetMalt { get; set; }

    [XmlElement(ElementName = "obd", IsNullable = true)]
    public string? Obd { get; set; }

    [XmlElement(ElementName = "totalUtvekslingHoyesteGir", IsNullable = true)]
    public float? TotalUtvekslingHoyesteGir { get; set; }

    [XmlElement(ElementName = "utelukkendeElektriskDrift", IsNullable = true)]
    public bool? UtelukkendeElektriskDrift { get; set; }

    [XmlElement(ElementName = "girutvekslingerPrGir", IsNullable = true)]
    public GirutvekslingerPrGirType? GirutvekslingerPrGir { get; set; }

    [XmlElement(ElementName = "motorer", IsNullable = true)]
    public Motorer? Motorer { get; set; }
}

public class MaksimumHastighetType
{
    [XmlElement(ElementName = "hastighet", IsNullable = true)]
    public int[]? Hastighet { get; set; }
}

public class GirutvekslingerPrGirType
{
    [XmlElement(ElementName = "girutvekslingPrGir", IsNullable = true)]
    public string[]? GirutvekslingPrGir { get; set; }
}

// motorer
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Motorer
{
    [XmlElement(ElementName = "motor", IsNullable = true)]
    public MotorType[]? Motor { get; set; }
}

public class MotorType
{
    [XmlElement(ElementName = "antallSylindre", IsNullable = true)]
    public int? AntallSylindre { get; set; }

    [XmlElement(ElementName = "arbeidsprinsipp", IsNullable = true)]
    public Kodeverdier? Arbeidsprinsipp { get; set; }

    [XmlElement(ElementName = "avgassResirkulering", IsNullable = true)]
    public bool? AvgassResirkulering { get; set; }

    [XmlElement(ElementName = "fabrikant", IsNullable = true)]
    public string? Fabrikant { get; set; }

    [XmlElement(ElementName = "fordampningsutslippKontrollSystem", IsNullable = true)]
    public bool? FordampningsutslippKontrollSystem { get; set; }

    [XmlElement(ElementName = "katalysator", IsNullable = true)]
    public bool? Katalysator { get; set; }

    [XmlElement(ElementName = "kjolesystem", IsNullable = true)]
    public string? Kjolesystem { get; set; }

    [XmlElement(ElementName = "ladeluftkjoler", IsNullable = true)]
    public bool? Ladeluftkjoler { get; set; }

    [XmlElement(ElementName = "luftInnsproytning", IsNullable = true)]
    public bool? LuftInnsproytning { get; set; }

    [XmlElement(ElementName = "motorKode", IsNullable = true)]
    public string? MotorKode { get; set; }

    [XmlElement(ElementName = "motorNummer", IsNullable = true)]
    public string? MotorNummer { get; set; }

    [XmlElement(ElementName = "oksygenSensor", IsNullable = true)]
    public bool? OksygenSensor { get; set; }

    [XmlElement(ElementName = "overladet", IsNullable = true)]
    public bool? Overladet { get; set; }

    [XmlElement(ElementName = "partikkelfilterMotor", IsNullable = true)]
    public bool? PartikkelfilterMotor { get; set; }

    [XmlElement(ElementName = "slagvolum", IsNullable = true)]
    public int? Slagvolum { get; set; }

    [XmlElement(ElementName = "sylinderArrangement", IsNullable = true)]
    public Kodeverdier? SylinderArrangement { get; set; }

    [XmlElement(ElementName = "drivstoff", IsNullable = true)]
    public Drivstoff? Drivstoff { get; set; }
}

// drivstoff
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Drivstoff
{
    [XmlElement(ElementName = "drivstofftype", IsNullable = true)]
    public DrivstofftypeType[]? Drivstofftype { get; set; }
}

public class DrivstofftypeType
{
    [XmlElement(ElementName = "drivstoffKode", IsNullable = true)]
    public Kodeverdier? DrivstoffKode { get; set; }

    [XmlElement(ElementName = "effektVektForhold", IsNullable = true)]
    public float? EffektVektForhold { get; set; }

    [XmlElement(ElementName = "maksNettoEffekt", IsNullable = true)]
    public float? MaksNettoEffekt { get; set; }

    [XmlElement(ElementName = "maksNettoEffektVedOmdreiningstallMin1", IsNullable = true)]
    public int? MaksNettoEffektVedOmdreiningstallMin1 { get; set; }

    [XmlElement(ElementName = "maksNettoEffektVedOmdreiningstallMin1Maks", IsNullable = true)]
    public int? MaksNettoEffektVedOmdreiningstallMin1Maks { get; set; }

    [XmlElement(ElementName = "maksEffektPrTime", IsNullable = true)]
    public float? MaksEffektPrTime { get; set; }

    [XmlElement(ElementName = "spenning", IsNullable = true)]
    public float? Spenning { get; set; }

    [XmlElement(ElementName = "tomgangsOmdreiningstall", IsNullable = true)]
    public int? TomgangsOmdreiningstall { get; set; }
}

// miljoedata
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Miljoedata
{
    [XmlElement(ElementName = "euroKlasse", IsNullable = true)]
    public Kodeverdier? EuroKlasse { get; set; }

    [XmlElement(ElementName = "lyddemperUtblas", IsNullable = true)]
    public string? LyddemperUtblas { get; set; }

    [XmlElement(ElementName = "miljoOgdrivstoffGrupper", IsNullable = true)]
    public MiljoOgdrivstoffGrupper? MiljoOgdrivstoffGrupper { get; set; }
}

// miljoOgdrivstoffGrupper
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class MiljoOgdrivstoffGrupper
{
    [XmlElement(ElementName = "miljoOgdrivstoffGruppe", IsNullable = true)]
    public MiljoOgdrivstoffGruppeType[]? MiljoOgdrivstoffGruppe { get; set; }
}

public class MiljoOgdrivstoffGruppeType
{
    [XmlElement(ElementName = "drivstoffKodeMiljodata", IsNullable = true)]
    public Kodeverdier? DrivstoffKodeMiljodata { get; set; }

    [XmlElement(ElementName = "kjorestoy", IsNullable = true)]
    public int? Kjorestoy { get; set; }

    [XmlElement(ElementName = "standstoy", IsNullable = true)]
    public int? Standstoy { get; set; }

    [XmlElement(ElementName = "innvendigStoyniva", IsNullable = true)]
    public int? InnvendigStoyniva { get; set; }

    [XmlElement(ElementName = "stoyMalingOppgittAv", IsNullable = true)]
    public Kodeverdier? StoyMalingOppgittAv { get; set; }

    [XmlElement(ElementName = "vedAntallOmdreininger", IsNullable = true)]
    public int? VedAntallOmdreininger { get; set; }

    [XmlElement(ElementName = "forbrukOgUtslipp", IsNullable = true)]
    public ForbrukOgUtslipp? ForbrukOgUtslipp { get; set; }
}

// forbrukOgUtslipp
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class ForbrukOgUtslipp
{
    [XmlElement(ElementName = "ettForbrukOgUtslipp", IsNullable = true)]
    public EttForbrukOgUtslippType[]? EttForbrukOgUtslipp { get; set; }
}

public class EttForbrukOgUtslippType
{
    [XmlElement(ElementName = "wltpKjoretoyspesifikk", IsNullable = true)]
    public WltpKjoretoyspesifikk? WltpKjoretoyspesifikk { get; set; }

    [XmlElement(ElementName = "drivstoffKode", IsNullable = true)]
    public Kodeverdier? DrivstoffKode { get; set; }

    [XmlElement(ElementName = "antallPartikler", IsNullable = true)]
    public int? AntallPartikler { get; set; }

    [XmlElement(ElementName = "co2BlandetKjoring", IsNullable = true)]
    public float? Co2BlandetKjoring { get; set; }

    [XmlElement(ElementName = "co2Bykjoring", IsNullable = true)]
    public float? Co2Bykjoring { get; set; }

    [XmlElement(ElementName = "co2Landeveiskjoring", IsNullable = true)]
    public float? Co2Landeveiskjoring { get; set; }

    [XmlElement(ElementName = "elEnergiforbruk", IsNullable = true)]
    public float? ElEnergiforbruk { get; set; }

    [XmlElement(ElementName = "forbrukBlandetKjoring", IsNullable = true)]
    public float? ForbrukBlandetKjoring { get; set; }

    [XmlElement(ElementName = "forbrukBykjoring", IsNullable = true)]
    public float? ForbrukBykjoring { get; set; }

    [XmlElement(ElementName = "forbrukLandeveiskjoring", IsNullable = true)]
    public float? ForbrukLandeveiskjoring { get; set; }

    [XmlElement(ElementName = "malemetode", IsNullable = true)]
    public Kodeverdier? Malemetode { get; set; }

    [XmlElement(ElementName = "partikkelfilterFabrikkmontert", IsNullable = true)]
    public bool? PartikkelfilterFabrikkmontert { get; set; }

    [XmlElement(ElementName = "partikkelfilterUtslipp", IsNullable = true)]
    public bool? PartikkelfilterUtslipp { get; set; }

    [XmlElement(ElementName = "rekkeviddeKm", IsNullable = true)]
    public float? RekkeviddeKm { get; set; }

    [XmlElement(ElementName = "utslippKorrigertAbsorpsjonskoeffisient", IsNullable = true)]
    public float? UtslippKorrigertAbsorpsjonskoeffisient { get; set; }

    [XmlElement(ElementName = "utslippNOxGPrKWh", IsNullable = true)]
    public float? UtslippNOxGPrKWh { get; set; }

    [XmlElement(ElementName = "utslippCOmgPrKm", IsNullable = true)]
    public float? UtslippCOmgPrKm { get; set; }

    [XmlElement(ElementName = "utslippNMHCmgPrKm", IsNullable = true)]
    public float? UtslippNMHCmgPrKm { get; set; }

    [XmlElement(ElementName = "utslippNOxMgPrKm", IsNullable = true)]
    public float? UtslippNOxMgPrKm { get; set; }

    [XmlElement(ElementName = "utslippTHCmgPrKm", IsNullable = true)]
    public float? UtslippTHCmgPrKm { get; set; }

    [XmlElement(ElementName = "utslippPartikkelAntallPrKm", IsNullable = true)]
    public float? UtslippPartikkelAntallPrKm { get; set; }

    [XmlElement(ElementName = "utslippPartiklerGPrKWh", IsNullable = true)]
    public float? UtslippPartiklerGPrKWh { get; set; }

    [XmlElement(ElementName = "utslippPartiklerMgPrKm", IsNullable = true)]
    public float? UtslippPartiklerMgPrKm { get; set; }

    [XmlElement(ElementName = "utslippTHCogNOxMgPrKm", IsNullable = true)]
    public float? UtslippTHCogNOxMgPrKm { get; set; }

    [XmlElement(ElementName = "vektetKombinertDrivstoff", IsNullable = true)]
    public float? VektetKombinertDrivstoff { get; set; }

    [XmlElement(ElementName = "vektetKombinertDrivstoffCO2", IsNullable = true)]
    public float? VektetKombinertDrivstoffCO2 { get; set; }
}

// wltpKjoretoyspesifikk
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class WltpKjoretoyspesifikk
{
    [XmlElement(ElementName = "co2EkstraHoy", IsNullable = true)]
    public string? Co2EkstraHoy { get; set; }

    [XmlElement(ElementName = "co2Hoy", IsNullable = true)]
    public string? Co2Hoy { get; set; }

    [XmlElement(ElementName = "co2Kombinert", IsNullable = true)]
    public string? Co2Kombinert { get; set; }

    [XmlElement(ElementName = "co2Lav", IsNullable = true)]
    public string? Co2Lav { get; set; }

    [XmlElement(ElementName = "co2Middels", IsNullable = true)]
    public string? Co2Middels { get; set; }

    [XmlElement(ElementName = "co2VektetKombinert", IsNullable = true)]
    public string? Co2VektetKombinert { get; set; }

    [XmlElement(ElementName = "forbrukEkstraHoy", IsNullable = true)]
    public string? ForbrukEkstraHoy { get; set; }

    [XmlElement(ElementName = "forbrukHoy", IsNullable = true)]
    public string? ForbrukHoy { get; set; }

    [XmlElement(ElementName = "forbrukKombinert", IsNullable = true)]
    public string? ForbrukKombinert { get; set; }

    [XmlElement(ElementName = "forbrukLav", IsNullable = true)]
    public string? ForbrukLav { get; set; }

    [XmlElement(ElementName = "forbrukMiddels", IsNullable = true)]
    public string? ForbrukMiddels { get; set; }

    [XmlElement(ElementName = "forbrukVektetKombinert", IsNullable = true)]
    public string? ForbrukVektetKombinert { get; set; }

    [XmlElement(ElementName = "rekkeviddeKmBlandetkjoring", IsNullable = true)]
    public string? RekkeviddeKmBlandetkjoring { get; set; }

    [XmlElement(ElementName = "rekkeviddeKmBykjoring", IsNullable = true)]
    public string? RekkeviddeKmBykjoring { get; set; }
}

// annetTeknisk
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class AnnetTeknisk
{
    [XmlElement(ElementName = "doerer", IsNullable = true)]
    public DoererType? Doerer { get; set; }

    [XmlElement(ElementName = "avstandNavSkjermbueBak", IsNullable = true)]
    public int? AvstandNavSkjermbueBak { get; set; }

    [XmlElement(ElementName = "avstandNavSkjermbueForan", IsNullable = true)]
    public int? AvstandNavSkjermbueForan { get; set; }

    [XmlElement(ElementName = "bussKategori", IsNullable = true)]
    public string? BussKategori { get; set; }

    [XmlElement(ElementName = "dorUtforminger", IsNullable = true)]
    public DorUtformingerType? DorUtforminger { get; set; }

    [XmlElement(ElementName = "fargeFjar", IsNullable = true)]
    public string? FargeFjar { get; set; }

    [XmlElement(ElementName = "karosseriArt", IsNullable = true)]
    public string? KarosseriArt { get; set; }

    [XmlElement(ElementName = "hydrauliskLoft", IsNullable = true)]
    public bool? HydrauliskLoft { get; set; }

    [XmlElement(ElementName = "karosseritype", IsNullable = true)]
    public Kodeverdier? Karosseritype { get; set; }

    [XmlElement(ElementName = "kjennemerketypeBak", IsNullable = true)]
    public Kodeverdier? KjennemerketypeBak { get; set; }

    [XmlElement(ElementName = "kjennemerketypeForan", IsNullable = true)]
    public Kodeverdier? KjennemerketypeForan { get; set; }

    [XmlElement(ElementName = "kjoringSide", IsNullable = true)]
    public string? KjoringSide { get; set; }

    [XmlElement(ElementName = "oppbygningUnderstellsnummer", IsNullable = true)]
    public string? OppbygningUnderstellsnummer { get; set; }

    [XmlElement(ElementName = "pabyggsKode", IsNullable = true)]
    public Kodeverdier? PabyggsKode { get; set; }

    [XmlElement(ElementName = "overhengBak", IsNullable = true)]
    public int? OverhengBak { get; set; }

    [XmlElement(ElementName = "passasjerHandtak", IsNullable = true)]
    public string? PassasjerHandtak { get; set; }

    [XmlElement(ElementName = "plasseringAvDorer", IsNullable = true)]
    public Kodeverdier? PlasseringAvDorer { get; set; }

    [XmlElement(ElementName = "plasseringFabrikasjonsplater", IsNullable = true)]
    public PlasseringFabrikasjonsplaterType? PlasseringFabrikasjonsplater { get; set; }

    [XmlElement(ElementName = "plasseringMerkeplateTrimming", IsNullable = true)]
    public string? PlasseringMerkeplateTrimming { get; set; }

    [XmlElement(ElementName = "plasseringUnderstellsnummere", IsNullable = true)]
    public PlasseringUnderstellsnummereType? PlasseringUnderstellsnummere { get; set; }

    [XmlElement(ElementName = "rFarger", IsNullable = true)]
    public RFargerType? RFarger { get; set; }

    [XmlElement(ElementName = "vendbarForerplass", IsNullable = true)]
    public bool? VendbarForerplass { get; set; }

    [XmlElement(ElementName = "temperaturregulertSkap", IsNullable = true)]
    public bool? TemperaturregulertSkap { get; set; }

    [XmlElement(ElementName = "styremekanismeArt", IsNullable = true)]
    public string? StyremekanismeArt { get; set; }
}

public class DoererType
{
    [XmlElement(ElementName = "antallDorer", IsNullable = true)]
    public int[]? AntallDorer { get; set; }
}

public class DorUtformingerType
{
    [XmlElement(ElementName = "dorUtforming", IsNullable = true)]
    public string[]? DorUtforming { get; set; }
}

public class PlasseringFabrikasjonsplaterType
{
    [XmlElement(ElementName = "plasseringFabrikasjonsplate", IsNullable = true)]
    public Kodeverdier[]? PlasseringFabrikasjonsplate { get; set; }
}

public class PlasseringUnderstellsnummereType
{
    [XmlElement(ElementName = "plasseringUnderstellsnummer", IsNullable = true)]
    public Kodeverdier[]? PlasseringUnderstellsnummer { get; set; }
}

public class RFargerType
{
    [XmlElement(ElementName = "rFarge", IsNullable = true)]
    public Kodeverdier[]? RFarge { get; set; }
}

// sitteOgStaaplasser
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class SitteOgStaaplasser
{
    [XmlElement(ElementName = "bareplasser", IsNullable = true)]
    public int? Bareplasser { get; set; }

    [XmlElement(ElementName = "rullestolplasser", IsNullable = true)]
    public int? Rullestolplasser { get; set; }

    [XmlElement(ElementName = "sitteplasser", IsNullable = true)]
    public Sitteplasser? Sitteplasser { get; set; }

    [XmlElement(ElementName = "sitteplasserForan", IsNullable = true)]
    public int? SitteplasserForan { get; set; }

    [XmlElement(ElementName = "sitteplasserStillstand", IsNullable = true)]
    public int? SitteplasserStillstand { get; set; }

    [XmlElement(ElementName = "sitteplasserTotalt", IsNullable = true)]
    public int? SitteplasserTotalt { get; set; }

    [XmlElement(ElementName = "staplasser", IsNullable = true)]
    public int? Staplasser { get; set; }
}

// sitteplasser
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Sitteplasser
{
    [XmlElement(ElementName = "sitteplass", IsNullable = true)]
    public SitteplassType[]? Sitteplass { get; set; }
}

public class SitteplassType
{
    [XmlElement(ElementName = "beltestrammer", IsNullable = true)]
    public bool? Beltestrammer { get; set; }

    [XmlElement(ElementName = "frontairbag", IsNullable = true)]
    public bool? Frontairbag { get; set; }

    [XmlElement(ElementName = "hodegardinairbag", IsNullable = true)]
    public bool? Hodegardinairbag { get; set; }

    [XmlElement(ElementName = "kneairbag", IsNullable = true)]
    public bool? Kneairbag { get; set; }

    [XmlElement(ElementName = "posisjon", IsNullable = true)]
    public string? Posisjon { get; set; }

    [XmlElement(ElementName = "rad", IsNullable = true)]
    public int? Rad { get; set; }

    [XmlElement(ElementName = "sideairbag", IsNullable = true)]
    public bool? Sideairbag { get; set; }
}

// tilhengerkopling
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Tilhengerkopling
{
    [XmlElement(ElementName = "koplinger", IsNullable = true)]
    public Koplinger? Koplinger { get; set; }
}

// koplinger
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Koplinger
{
    [XmlElement(ElementName = "kopling", IsNullable = true)]
    public KoplingType[]? Kopling { get; set; }
}

public class KoplingType
{
    [XmlElement(ElementName = "avstandSenterKoplingTilForsteAksel", IsNullable = true)]
    public int? AvstandSenterKoplingTilForsteAksel { get; set; }

    [XmlElement(ElementName = "avstandSisteAkselTilSenterKopling", IsNullable = true)]
    public int? AvstandSisteAkselTilSenterKopling { get; set; }

    [XmlElement(ElementName = "belastningDverdi", IsNullable = true)]
    public float? BelastningDverdi { get; set; }

    [XmlElement(ElementName = "belastningSverdi", IsNullable = true)]
    public float? BelastningSverdi { get; set; }

    [XmlElement(ElementName = "belastningVverdi", IsNullable = true)]
    public float? BelastningVverdi { get; set; }

    [XmlElement(ElementName = "fabrikantKopling", IsNullable = true)]
    public string? FabrikantKopling { get; set; }

    [XmlElement(ElementName = "type", IsNullable = true)]
    public Kodeverdier? Type { get; set; }
}

// akselinformasjon
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Akselinformasjon
{
    [XmlElement(ElementName = "akselGrupper", IsNullable = true)]
    public AkselGrupper? AkselGrupper { get; set; }

    [XmlElement(ElementName = "antallAksler", IsNullable = true)]
    public int? AntallAksler { get; set; }
}

// akselGrupper
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class AkselGrupper
{
    [XmlElement(ElementName = "akselGruppe", IsNullable = true)]
    public AkselGruppeType[]? AkselGruppe { get; set; }
}

public class AkselGruppeType
{
    [XmlElement(ElementName = "aksler", IsNullable = true)]
    public Aksler? Aksler { get; set; }

    [XmlElement(ElementName = "fordelingAvTillattTotalvektAkselGruppeMaks", IsNullable = true)]
    public int? FordelingAvTillattTotalvektAkselGruppeMaks { get; set; }

    [XmlElement(ElementName = "fordelingAvTillattTotalvektAkselGruppeMin", IsNullable = true)]
    public int? FordelingAvTillattTotalvektAkselGruppeMin { get; set; }

    [XmlElement(ElementName = "egenvektAkselGruppe", IsNullable = true)]
    public int? EgenvektAkselGruppe { get; set; }

    [XmlElement(ElementName = "egenvektAkselGruppeMin", IsNullable = true)]
    public int? EgenvektAkselGruppeMin { get; set; }

    [XmlElement(ElementName = "id", IsNullable = true)]
    public int? Id { get; set; }

    [XmlElement(ElementName = "plasseringAkselGruppe", IsNullable = true)]
    public string? PlasseringAkselGruppe { get; set; }

    [XmlElement(ElementName = "tekniskTillattAkselGruppeLast", IsNullable = true)]
    public int? TekniskTillattAkselGruppeLast { get; set; }
}

// aksler
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class Aksler
{
    [XmlElement(ElementName = "aksel", IsNullable = true)]
    public AkselType[]? Aksel { get; set; }
}

public class AkselType
{
    [XmlElement(ElementName = "antallHjul", IsNullable = true)]
    public int? AntallHjul { get; set; }

    [XmlElement(ElementName = "avstandTilNesteAksling", IsNullable = true)]
    public int? AvstandTilNesteAksling { get; set; }

    [XmlElement(ElementName = "bremseAksel", IsNullable = true)]
    public bool? BremseAksel { get; set; }

    [XmlElement(ElementName = "drivAksel", IsNullable = true)]
    public bool? DrivAksel { get; set; }

    [XmlElement(ElementName = "egenvektAksel", IsNullable = true)]
    public int? EgenvektAksel { get; set; }

    [XmlElement(ElementName = "egenvektAkselMin", IsNullable = true)]
    public int? EgenvektAkselMin { get; set; }

    [XmlElement(ElementName = "fordelingAvTillattTotalvektAkselMaks", IsNullable = true)]
    public int? FordelingAvTillattTotalvektAkselMaks { get; set; }

    [XmlElement(ElementName = "fordelingAvTillattTotalvektAkselMin", IsNullable = true)]
    public int? FordelingAvTillattTotalvektAkselMin { get; set; }

    [XmlElement(ElementName = "id", IsNullable = true)]
    public int? Id { get; set; }

    [XmlElement(ElementName = "luftfjaering", IsNullable = true)]
    public bool? Luftfjaering { get; set; }

    [XmlElement(ElementName = "maksimalSporvidde", IsNullable = true)]
    public int? MaksimalSporvidde { get; set; }

    [XmlElement(ElementName = "minAvstandTilNesteAksling", IsNullable = true)]
    public int? MinAvstandTilNesteAksling { get; set; }

    [XmlElement(ElementName = "minimalSporvidde", IsNullable = true)]
    public int? MinimalSporvidde { get; set; }

    [XmlElement(ElementName = "plasseringAksel", IsNullable = true)]
    public int? PlasseringAksel { get; set; }

    [XmlElement(ElementName = "styreAksel", IsNullable = true)]
    public bool? StyreAksel { get; set; }

    [XmlElement(ElementName = "tekniskTillattAkselLast", IsNullable = true)]
    public int? TekniskTillattAkselLast { get; set; }

    [XmlElement(ElementName = "tekniskTillattAkselLastForhoyet", IsNullable = true)]
    public int? TekniskTillattAkselLastForhoyet { get; set; }
}

// dekkOgFelgtype
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class DekkOgFelgtype
{
    [XmlElement(ElementName = "akselDekkOgFelgKombinasjon", IsNullable = true)]
    public AkselDekkOgFelgKombinasjon[]? AkselDekkOgFelgKombinasjon { get; set; }
}

// akselDekkOgFelgKombinasjon
[XmlType(Namespace = MotorvognConstants.Namespace)]
public class AkselDekkOgFelgKombinasjon
{
    [XmlElement(ElementName = "akslerDekkOgFelg", IsNullable = true)]
    public AkslerDekkOgFelgType[]? AkslerDekkOgFelg { get; set; }
}

public class AkslerDekkOgFelgType
{
    [XmlElement(ElementName = "akselDekkOgFelg", IsNullable = true)]
    public AkselDekkOgFelgType[]? AkselDekkOgFelg { get; set; }

    [XmlElement(ElementName = "tillattTotalvektTraktor", IsNullable = true)]
    public int? TillattTotalvektTraktor { get; set; }
}

public class AkselDekkOgFelgType
{
    [XmlElement(ElementName = "akselId", IsNullable = true)]
    public int? AkselId { get; set; }

    [XmlElement(ElementName = "belastningskodeDekk", IsNullable = true)]
    public string? BelastningskodeDekk { get; set; }

    [XmlElement(ElementName = "dekkdimensjon", IsNullable = true)]
    public string? Dekkdimensjon { get; set; }

    [XmlElement(ElementName = "felgdimensjon", IsNullable = true)]
    public string? Felgdimensjon { get; set; }

    [XmlElement(ElementName = "hastighetskodeDekk", IsNullable = true)]
    public string? HastighetskodeDekk { get; set; }

    [XmlElement(ElementName = "innpress", IsNullable = true)]
    public string? Innpress { get; set; }

    [XmlElement(ElementName = "tillattAkselLastTraktor", IsNullable = true)]
    public int? TillattAkselLastTraktor { get; set; }

    [XmlElement(ElementName = "tvilling", IsNullable = true)]
    public bool? Tvilling { get; set; }
}
