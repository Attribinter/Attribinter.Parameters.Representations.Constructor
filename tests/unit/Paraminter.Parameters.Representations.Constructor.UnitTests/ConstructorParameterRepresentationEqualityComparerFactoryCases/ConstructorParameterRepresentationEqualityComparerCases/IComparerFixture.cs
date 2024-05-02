namespace Paraminter.Parameters.Representations.ConstructorParameterRepresentationEqualityComparerFactoryCases.ConstructorParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal interface IComparerFixture
{
    public abstract IEqualityComparer<IConstructorParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}
