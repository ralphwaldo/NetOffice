﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Attributes;

/*
    Contains the following Type Libraries:
	Name - Description - SupportByVersion
	MSHTML - Microsoft HTML Object Library - 4

*/

[assembly: AssemblyTitle("MSHTML")]
[assembly: AssemblyDescription("Netoffice MSHTML Api")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("NetOfficeFw")]
[assembly: AssemblyProduct("NetOffice")]
[assembly: AssemblyCopyright("Copyright © 2012-2018 Sebastian Lange")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("2.0.0.0")]
[assembly: PrimaryInteropAssembly(1, 0)]
[assembly: ImportedFromTypeLib("MSHTML")]
[assembly: Guid("3050F1C5-98B5-11CF-BB82-00AA00BDCE0B")]
[assembly: NetOfficeAssemblyAttribute("2.0.0.0")]
[assembly: Dependency("NetOffice.dll", LoadHint.Default)]


/*
Alias Table
 
[SupportByVersion("MSHTML", 4)]
LONG_PTR as Int32

[SupportByVersion("MSHTML", 4)]
UINT_PTR as Int32

*/