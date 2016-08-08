//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using Nuclei.Build;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Nuclei.Configuration.Samples")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyProduct("Nuclei.Configuration.Samples")]

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
