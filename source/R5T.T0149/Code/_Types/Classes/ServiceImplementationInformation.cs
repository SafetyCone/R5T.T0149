using System;

using R5T.T0142;


namespace R5T.T0149
{
    /// <summary>
    /// Information describing a service implementation.
    /// </summary>
    [DataTypeMarker]
    public class ServiceImplementationInformation
    {
        public string ImplementationNamespacedTypeName { get; set; }
        public string DefinitionNamespacedTypeName { get; set; }
        public string[] DependencyDefinitionNamespacedTypeNames { get; set; }
    }
}
