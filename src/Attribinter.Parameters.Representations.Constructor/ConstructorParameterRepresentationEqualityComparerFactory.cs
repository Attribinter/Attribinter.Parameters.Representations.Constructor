namespace Attribinter.Parameters.Representations;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="IConstructorParameterRepresentationEqualityComparerFactory"/>
public sealed class ConstructorParameterRepresentationEqualityComparerFactory : IConstructorParameterRepresentationEqualityComparerFactory
{
    /// <summary>Instantiates a <see cref="ConstructorParameterRepresentationEqualityComparerFactory"/>, handling creation of comparers of <see cref="IConstructorParameterRepresentation"/>.</summary>
    public ConstructorParameterRepresentationEqualityComparerFactory() { }

    IEqualityComparer<IConstructorParameterRepresentation> IConstructorParameterRepresentationEqualityComparerFactory.Create(IEqualityComparer<string> nameComparer)
    {
        if (nameComparer is null)
        {
            throw new ArgumentNullException(nameof(nameComparer));
        }

        return new ConstructorParameterRepresentationEqualityComparer(nameComparer);
    }

    private sealed class ConstructorParameterRepresentationEqualityComparer : IEqualityComparer<IConstructorParameterRepresentation>
    {
        private readonly IEqualityComparer<string> NameComparer;

        public ConstructorParameterRepresentationEqualityComparer(IEqualityComparer<string> nameComparer)
        {
            NameComparer = nameComparer;
        }

        bool IEqualityComparer<IConstructorParameterRepresentation>.Equals(IConstructorParameterRepresentation x, IConstructorParameterRepresentation y)
        {
            if (x is null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y is null)
            {
                throw new ArgumentNullException(nameof(y));
            }

            return NameComparer.Equals(x.Name, y.Name);
        }

        int IEqualityComparer<IConstructorParameterRepresentation>.GetHashCode(IConstructorParameterRepresentation obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return NameComparer.GetHashCode(obj.Name);
        }
    }
}
