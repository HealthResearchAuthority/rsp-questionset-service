using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using Rsp.QuestionSetService.Application.Authentication.Helpers;

namespace Rsp.QuestionSetService.UnitTests.Application.Helpers;

public class TokenHelpersTests
{
    private readonly TokenHelper _tokenHelper;

    public TokenHelpersTests()
    {
        _tokenHelper = new TokenHelper();
    }

    [Fact]
    public void DeBearerizeAuthToken_RemovesBearerPrefix()
    {
        // Arrange
        var authToken = new StringValues("Bearer my-token");

        // Act
        var result = _tokenHelper.DeBearerizeAuthToken(authToken);

        // Assert
        Assert.Equal("my-token", result);
    }

    [Fact]
    public void DeBearerizeAuthToken_ThrowsException_OnEmptyToken()
    {
        // Arrange
        var authToken = new StringValues();

        // Act & Assert
        Assert.Throws<SecurityTokenException>(() => _tokenHelper.DeBearerizeAuthToken(authToken));
    }

    [Fact]
    public void DeBearerizeAuthToken_ThrowsException_OnNullToken()
    {
        // Arrange
        var authToken = new StringValues((string?)null);

        // Act & Assert
        Assert.Throws<SecurityTokenException>(() => _tokenHelper.DeBearerizeAuthToken(authToken));
    }

    [Fact]
    public void DeBearerizeAuthToken_ReturnsSameToken_IfNoBearerPrefix()
    {
        // Arrange
        var authToken = new StringValues("my-token");

        // Act
        var result = _tokenHelper.DeBearerizeAuthToken(authToken);

        // Assert
        Assert.Equal("my-token", result);
    }

    [Fact]
    public void BearerizeAuthToken_AddsBearerPrefix_IfNotPresent()
    {
        // Arrange
        var authToken = new StringValues("my-token");

        // Act
        var result = _tokenHelper.BearerizeAuthToken(authToken);

        // Assert
        Assert.Equal("Bearer my-token", result);
    }

    [Fact]
    public void BearerizeAuthToken_ReturnsSameToken_IfAlreadyHasBearerPrefix()
    {
        // Arrange
        var authToken = new StringValues("Bearer my-token");

        // Act
        var result = _tokenHelper.BearerizeAuthToken(authToken);

        // Assert
        Assert.Equal("Bearer my-token", result);
    }

    [Fact]
    public void BearerizeAuthToken_ThrowsException_OnEmptyToken()
    {
        // Arrange
        var authToken = new StringValues();

        // Act & Assert
        Assert.Throws<SecurityTokenException>(() => _tokenHelper.BearerizeAuthToken(authToken));
    }

    [Fact]
    public void BearerizeAuthToken_ThrowsException_OnNullToken()
    {
        // Arrange
        var authToken = new StringValues((string?)null);

        // Act & Assert
        Assert.Throws<SecurityTokenException>(() => _tokenHelper.BearerizeAuthToken(authToken));
    }
}