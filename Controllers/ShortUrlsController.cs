using Microsoft.AspNetCore.Mvc;

namespace url_shortner.Controllers;

[ApiController]
[Route("[controller]")]
public class ShortUrlsController : ControllerBase
{
    private readonly ILogger<ShortUrlsController> _logger;

    public ShortUrlsController(ILogger<ShortUrlsController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{url1}")]
    public string GetUrl(string url1)
    {
        return "http://localhost:5097/navigate/" + url1;
    }

    [HttpPut("{url1}")]
    public string CreateUrl(string url1)
    {
        return "http://localhost:5097/navigate/ge123";
    }

    [HttpDelete("{url1}")]
    public NoContentResult DeleteUrl(string url1)
    {
        return NoContent();
    }

    [HttpGet("{url1}/hits")]
    public int GetUrlHits(string url1)
    {
        return 0;
    }

    [HttpGet("navigate/{url}")]
    public RedirectResult GetRedirect(string url1)
    {
        return Redirect(url1);
    }
}
