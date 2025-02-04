using Moq.AutoMock;
using Rsp.QuestionSetService.Application.Mapping;

namespace Rsp.QuestionSetService.UnitTests;

public class TestServiceBase
{
    public AutoMocker Mocker { get; }

    public TestServiceBase()
    {
        Mocker = new AutoMocker();

        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(typeof(MappingRegister).Assembly);
    }
}