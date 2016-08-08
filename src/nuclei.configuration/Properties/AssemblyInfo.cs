//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Nuclei.Build;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Nuclei.Configuration")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyProduct("Nuclei.Configuration")]

// Resources
[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.MainAssembly)]

[assembly: AssemblyCompany("TheNucleus")]
[assembly: AssemblyCopyright("Copyright (c) - TheNucleus 2013 - 2016. All rights reserved.")]

[assembly: AssemblyCulture("")]

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTrademark("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Indicate that the assembly is CLS compliant.
[assembly: CLSCompliant(true)]

[assembly: AssemblyConfiguration("Release")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.9.0.0")]
[assembly: AssemblyFileVersion("0.9.1.1")]
[assembly: AssemblyInformationalVersion("0.9.1")]

// The time the assembly was build
[assembly: AssemblyBuildTime(buildTime: "2016-08-09T08:13:09.1870154+12:00")]

// The version from which the assembly was build
[module: SuppressMessage(
    "Microsoft.Usage",
    "CA2243:AttributeStringLiteralsShouldParseCorrectly",
    Justification = "It's a VCS revision, not a version")]
[assembly: AssemblyBuildInformation(buildNumber: 1, versionControlInformation: "f50022210d1b5448d16e9849e5efe27d1f80aac1")]
#if RELEASE
[assembly: InternalsVisibleTo("Moq, PublicKey=00240000048000009400000006020000002400005253413100040000010001009f7a95086500f8f66d892174803850fed9c22225c2ccfff21f39c8af8abfa5415b1664efd0d8e0a6f7f2513b1c11659bd84723dc7900c3d481b833a73a2bcf1ed94c16c4be64d54352c86956c89930444e9ac15124d3693e3f029818e8410f167399d6b995324b635e95353ba97bfab856abbaeb9b40c9b160070c6325e22ddc")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
#endif
