﻿using Microsoft.AspNetCore.Http;

namespace TaikoLocalServer.Controllers;

[Route("/v12r03/chassis/mydonentry.php")]
[ApiController]
public class MyDonEntryController : ControllerBase
{
    private readonly ILogger<MyDonEntryController> logger;
    public MyDonEntryController(ILogger<MyDonEntryController> logger) {
        this.logger = logger;
    }

    [HttpPost]
    [Produces("application/protobuf")]
    public IActionResult GetMyDonEntry([FromBody] MydonEntryRequest request)
    {
        logger.LogInformation("MyDonEntryController request : {Request}", request.Stringify());

        var response = new MydonEntryResponse
        {
            Result = 1
        };

        return Ok(response);
    }
}