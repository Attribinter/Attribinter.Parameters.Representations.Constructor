namespace Paraminter.Parameters.Representations;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="IMethodParameterRepresentationEqualityComparerFactory"/>
public sealed class MethodParameterRepresentationEqualityComparerFactory
    : IMethodParameterRepresentationEqualityComparerFactory
{
    /// <summary>Instantiates a <see cref="MethodParameterRepresentationEqualityComparerFactory"/>, handling creation of comparers of <see cref="IMethodParameterRepresentation"/>.</summary>
    public MethodParameterRepresentationEqualityComparerFactory() { }

    IEqualityComparer<IMethodParameterRepresentation> IMethodParameterRepresentationEqualityComparerFactory.Create(
        IEqualityComparer<string> nameComparer)
    {
        if (nameComparer is null)
        {
            throw new ArgumentNullException(nameof(nameComparer));
        }

        return new MethodParameterRepresentationEqualityComparer(nameComparer);
    }

    private sealed class MethodParameterRepresentationEqualityComparer
        : IEqualityComparer<IMethodParameterRepresentation>
    {
        private readonly IEqualityComparer<string> NameComparer;

        public MethodParameterRepresentationEqualityComparer(
            IEqualityComparer<string> nameComparer)
        {
            NameComparer = nameComparer;
        }

        bool IEqualityComparer<IMethodParameterRepresentation>.Equals(
            IMethodParameterRepresentation x,
            IMethodParameterRepresentation y)
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

        int IEqualityComparer<IMethodParameterRepresentation>.GetHashCode(
            IMethodParameterRepresentation obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return NameComparer.GetHashCode(obj.Name);
        }
    }
}
