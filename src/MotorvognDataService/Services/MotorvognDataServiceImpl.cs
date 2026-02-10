using MotorvognDataService.Models;

namespace MotorvognDataService.Services;

public class MotorvognDataServiceImpl : IMotorvognDataService
{
    private readonly ILogger<MotorvognDataServiceImpl> _logger;

    public MotorvognDataServiceImpl(ILogger<MotorvognDataServiceImpl> logger)
    {
        _logger = logger;
    }

    public MotorvognData HentMotorvognData(HentMotorvognDataRequest hentMotorvognData)
    {
        _logger.LogWarning("hentMotorvognData is not yet implemented.");
        return new MotorvognData();
    }

    public MotorvognEier HentMotorvognEier(HentMotorvognEierRequest hentMotorvognEier)
    {
        _logger.LogWarning("hentMotorvognEier is not yet implemented.");
        return new MotorvognEier();
    }

    public MotorvognTeknisk HentMotorvognTeknisk(HentMotorvognTekniskRequest hentMotorvognTeknisk)
    {
        _logger.LogWarning("hentMotorvognTeknisk is not yet implemented.");
        return new MotorvognTeknisk();
    }

    public MotorvognNavneSok HentMotorvognNavneSok(HentMotorvognNavneSokRequest hentMotorvognNavneSok)
    {
        _logger.LogWarning("hentMotorvognNavneSok is not yet implemented.");
        return new MotorvognNavneSok();
    }

    public MotorvognOppslag HentMotorvognOppslag(HentMotorvognOppslagRequest hentMotorvognOppslag)
    {
        _logger.LogWarning("hentMotorvognOppslag is not yet implemented.");
        return new MotorvognOppslag();
    }

    public MotorvognHistorisk HentMotorvognHistorisk(HentMotorvognHistoriskRequest hentMotorvognHistorisk)
    {
        _logger.LogWarning("hentMotorvognHistorisk is not yet implemented.");
        return new MotorvognHistorisk();
    }
}
