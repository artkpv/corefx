// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Diagnostics
{
    public partial class Process : IDisposable
    {
        /// <summary>
        /// Creates an array of <see cref="Process"/> components that are associated with process resources on a
        /// remote computer. These process resources share the specified process name.
        /// </summary>
        public static Process[] GetProcessesByName(string processName, string machineName)
        {
            throw new PlatformNotSupportedException();
        }

        /// <summary>Gets the amount of time the process has spent running code inside the operating system core.</summary>
        public TimeSpan PrivilegedProcessorTime
        {
            get { throw new PlatformNotSupportedException(); }
        }

        /// <summary>Gets the time the associated process was started.</summary>
        public DateTime StartTime
        {
            get { throw new PlatformNotSupportedException(); }
        }

        /// <summary>
        /// Gets the amount of time the associated process has spent utilizing the CPU.
        /// It is the sum of the <see cref='System.Diagnostics.Process.UserProcessorTime'/> and
        /// <see cref='System.Diagnostics.Process.PrivilegedProcessorTime'/>.
        /// </summary>
        public TimeSpan TotalProcessorTime
        {
            get { throw new PlatformNotSupportedException(); }
        }

        /// <summary>
        /// Gets the amount of time the associated process has spent running code
        /// inside the application portion of the process (not the operating system core).
        /// </summary>
        public TimeSpan UserProcessorTime
        {
            get { throw new PlatformNotSupportedException(); }
        }

        /// <summary>
        /// Gets or sets which processors the threads in this process can be scheduled to run on.
        /// </summary>
        private unsafe IntPtr ProcessorAffinityCore
        {
            get { throw new PlatformNotSupportedException(); }
            set { throw new PlatformNotSupportedException(); }
        }

        /// <summary>
        /// Make sure we have obtained the min and max working set limits.
        /// </summary>
        private void GetWorkingSetLimits(out IntPtr minWorkingSet, out IntPtr maxWorkingSet)
        {
            throw new PlatformNotSupportedException();
        }

        /// <summary>Sets one or both of the minimum and maximum working set limits.</summary>
        /// <param name="newMin">The new minimum working set limit, or null not to change it.</param>
        /// <param name="newMax">The new maximum working set limit, or null not to change it.</param>
        /// <param name="resultingMin">The resulting minimum working set limit after any changes applied.</param>
        /// <param name="resultingMax">The resulting maximum working set limit after any changes applied.</param>
        private void SetWorkingSetLimitsCore(IntPtr? newMin, IntPtr? newMax, out IntPtr resultingMin, out IntPtr resultingMax)
        {
            throw new PlatformNotSupportedException();
        }

        private static string GetExePath()
        {
            throw new PlatformNotSupportedException();
        }
    }
}
