using Microsoft.Extensions.Primitives;

namespace Rsp.QuestionSetService.Application.Authentication.Helpers;

public interface ITokenHelper
{
    string DeBearerizeAuthToken(StringValues authToken);

    string BearerizeAuthToken(StringValues authToken);
}