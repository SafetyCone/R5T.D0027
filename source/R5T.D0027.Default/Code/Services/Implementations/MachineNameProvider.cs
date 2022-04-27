using System;using R5T.T0064;


namespace R5T.D0027.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// Provides the <see cref="Environment.MachineName"/> value.
    /// </summary>
    public class MachineNameProvider : IMachineNameProvider,IServiceImplementation
    {
        public string GetMachineName()
        {
            var machineName = Environment.MachineName;
            return machineName;
        }
    }
}
