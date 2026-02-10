using System.ServiceModel;
using MotorvognDataService.Models;

namespace MotorvognDataService.Services;

[ServiceContract(
    Namespace = "http://ws.infotorg.no/xml/SVV/MotorvognData/2022-03-15/MotorvognData.wsdl",
    Name = "mvdPortType")]
public interface IMotorvognDataService
{
    [OperationContract(Name = "hentMotorvognData")]
    MotorvognData HentMotorvognData(HentMotorvognDataRequest hentMotorvognData);

    [OperationContract(Name = "hentMotorvognEier")]
    MotorvognEier HentMotorvognEier(HentMotorvognEierRequest hentMotorvognEier);

    [OperationContract(Name = "hentMotorvognTeknisk")]
    MotorvognTeknisk HentMotorvognTeknisk(HentMotorvognTekniskRequest hentMotorvognTeknisk);

    [OperationContract(Name = "hentMotorvognNavneSok")]
    MotorvognNavneSok HentMotorvognNavneSok(HentMotorvognNavneSokRequest hentMotorvognNavneSok);

    [OperationContract(Name = "hentMotorvognOppslag")]
    MotorvognOppslag HentMotorvognOppslag(HentMotorvognOppslagRequest hentMotorvognOppslag);

    [OperationContract(Name = "hentMotorvognHistorisk")]
    MotorvognHistorisk HentMotorvognHistorisk(HentMotorvognHistoriskRequest hentMotorvognHistorisk);
}
