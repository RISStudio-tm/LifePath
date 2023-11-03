using LifePath.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LifePath.Api.Controllers;

[ApiController]
public class GatewayController : ApiBaseController
{
    private readonly ILogger<GatewayController> _logger;



    public GatewayController(
        ILogger<GatewayController> logger)
    {
        _logger = logger;
    }



    [HttpGet("ping")]
    public IResult Ping()
    {
        return Results.Ok();
    }

    [HttpGet("test/{id:int}")]
    public IResult Test(
        int id,
        [FromBody] TestData data)
    {
        var result = new
        {
            id,
            data = data.Data,
            dataReversed = new string(
                data.Data.Reverse().ToArray())
        };

        return Results.Json(
            result);
    }
}
