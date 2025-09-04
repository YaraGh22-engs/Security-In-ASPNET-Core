using JWT_Authentication.Requests;
using JWT_Authentication.Services;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Authentication.Controllers;

[ApiController]
[Route("api/token")]
public class TokenController(JwtTokenProvider tokenProvider) : ControllerBase
{

    [HttpPost("generate")]
    public IActionResult GenerateToken(GenerateTokenRequest request)
    {
        return Ok(tokenProvider.GenerateJwtToken(request));
    }
}