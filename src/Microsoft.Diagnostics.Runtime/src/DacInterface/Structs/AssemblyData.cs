﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;
using Microsoft.Diagnostics.Runtime.Desktop;

namespace Microsoft.Diagnostics.Runtime.DacInterface
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct AssemblyData : IAssemblyData
    {
        public readonly ulong Address;
        public readonly ulong ClassLoader;
        public readonly ulong ParentDomain;
        public readonly ulong AppDomain;
        public readonly ulong AssemblySecurityDescriptor;
        public readonly int Dynamic;
        public readonly int ModuleCount;
        public readonly uint LoadContext;
        public readonly int IsDomainNeutral;
        public readonly uint LocationFlags;

        ulong IAssemblyData.Address => Address;
        ulong IAssemblyData.ParentDomain => ParentDomain;
        ulong IAssemblyData.AppDomain => AppDomain;
        bool IAssemblyData.IsDynamic => Dynamic != 0;
        bool IAssemblyData.IsDomainNeutral => IsDomainNeutral != 0;
        int IAssemblyData.ModuleCount => ModuleCount;
    }
}