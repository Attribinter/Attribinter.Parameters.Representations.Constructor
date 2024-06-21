namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IParameterRepresentationFactory<IMethodParameter, IMethodParameterRepresentation> Sut { get; }

    public abstract Mock<IMethodParameterRepresentationFactory> InnerFactoryMock { get; }
}
