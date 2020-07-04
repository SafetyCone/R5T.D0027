using System;


namespace R5T.D0027.Default
{
    /// <summary>
    /// Provides the <see cref="Environment.MachineName"/> value.
    /// </summary>
    public class MachineNameProvider : IMachineNameProvider
    {
        public string GetMachineName()
        {
            var machineName = Environment.MachineName;
            return machineName;
        }
    }
}
