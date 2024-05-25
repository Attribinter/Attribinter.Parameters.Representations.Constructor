namespace Paraminter.Parameters.Representations.MethodParameterRepresentationEqualityComparerFactoryCases.MethodParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal interface IComparerFixture
{
    public abstract IEqualityComparer<IMethodParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}
