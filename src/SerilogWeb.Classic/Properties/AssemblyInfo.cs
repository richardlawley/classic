﻿using System.Reflection;
using System.Web;
using SerilogWeb.Classic;

[assembly: AssemblyTitle("Serilog.Web")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyCopyright("Copyright © Serilog Contributors 2013")]

[assembly: PreApplicationStartMethod(typeof(ApplicationLifecycleModule), "Register")]