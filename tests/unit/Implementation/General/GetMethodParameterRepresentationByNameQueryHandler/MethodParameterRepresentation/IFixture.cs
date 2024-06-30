namespace Paraminter.Parameters.Representations.MethodParameterRepresentation;

internal interface IFixture
{
    public abstract IMethodParameterRepresentation Sut { get; }

    public abstract string Name { get; }
}
