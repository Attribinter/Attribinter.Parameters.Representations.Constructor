namespace Paraminter.Parameters.Representations.MethodParameterRepresentationEqualityComparer;

using Moq;

using System.Collections.Generic;

internal interface IFixture
{
    public abstract IEqualityComparer<IMethodParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}
