using SoapCore;
using MotorvognDataService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMotorvognDataService, MotorvognDataServiceImpl>();
builder.Services.AddSoapCore();

var app = builder.Build();

app.UseRouting();

((IEndpointRouteBuilder)app).UseSoapEndpoint<IMotorvognDataService>(
    path: "/ws/SVV/MotorvognData.pl",
    encoder: new SoapEncoderOptions(),
    serializer: SoapSerializer.XmlSerializer);

app.Run();
