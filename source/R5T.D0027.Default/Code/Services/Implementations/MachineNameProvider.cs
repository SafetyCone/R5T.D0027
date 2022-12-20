using System;using R5T.T0064;


namespace R5T.D0027.Default
{
    /// <summary>
    /// Provides the <see cref="Environment.MachineName"/> value.
    /// </summary>
    [ServiceImplementationMarker]
    public class MachineNameProvider : IMachineNameProvider,IServiceImplementation
    {
        public string GetMachineName()
        {
            var machineName = Environment.MachineName;
            return machineName;
        }
    }
}
