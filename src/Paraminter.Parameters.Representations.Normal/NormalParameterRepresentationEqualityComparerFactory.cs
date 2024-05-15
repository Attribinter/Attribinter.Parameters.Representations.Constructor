namespace Paraminter.Parameters.Representations;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="INormalParameterRepresentationEqualityComparerFactory"/>
public sealed class NormalParameterRepresentationEqualityComparerFactory : INormalParameterRepresentationEqualityComparerFactory
{
    /// <summary>Instantiates a <see cref="NormalParameterRepresentationEqualityComparerFactory"/>, handling creation of comparers of <see cref="INormalParameterRepresentation"/>.</summary>
    public NormalParameterRepresentationEqualityComparerFactory() { }

    IEqualityComparer<INormalParameterRepresentation> INormalParameterRepresentationEqualityComparerFactory.Create(IEqualityComparer<string> nameComparer)
    {
        if (nameComparer is null)
        {
            throw new ArgumentNullException(nameof(nameComparer));
        }

        return new NormalParameterRepresentationEqualityComparer(nameComparer);
    }

    private sealed class NormalParameterRepresentationEqualityComparer : IEqualityComparer<INormalParameterRepresentation>
    {
        private readonly IEqualityComparer<string> NameComparer;

        public NormalParameterRepresentationEqualityComparer(IEqualityComparer<string> nameComparer)
        {
            NameComparer = nameComparer;
        }

        bool IEqualityComparer<INormalParameterRepresentation>.Equals(INormalParameterRepresentation x, INormalParameterRepresentation y)
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

        int IEqualityComparer<INormalParameterRepresentation>.GetHashCode(INormalParameterRepresentation obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return NameComparer.GetHashCode(obj.Name);
        }
    }
}
