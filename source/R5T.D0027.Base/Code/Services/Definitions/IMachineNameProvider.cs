using System;

using R5T.T0064;


namespace R5T.D0027
{
    [ServiceDefinitionMarker]
    public interface IMachineNameProvider : IServiceDefinition
    {
        string GetMachineName();
    }
}
