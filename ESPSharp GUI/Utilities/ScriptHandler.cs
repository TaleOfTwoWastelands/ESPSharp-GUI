using System;
using System.Collections.Generic;
using System.Linq;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using Microsoft.CSharp;

namespace ESPSharp_GUI.Utilities
{
	public class ScriptHandler
	{

		public ScriptHandler(string fileName, List<object> records)
		{
			var path = Path.Combine(Util.UserScriptsPath, fileName);

			var csc = new CSharpCodeProvider(new Dictionary<string, string>() { {"CompilerVersion", "v3.5"} });
			var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" });

			var stream = new FileStream(path, FileMode.Open);
			using (var sm = new StreamReader(stream))
			{
				var results = csc.CompileAssemblyFromSource(parameters, sm.ReadToEnd());

				if (results.Errors.HasErrors || results.Errors.HasWarnings)
					results.Errors.Cast<CompilerError>().ToList().ForEach(error => Messenger.AddWarning(error.ErrorText));

				Module module = results.CompiledAssembly.GetModules()[0];
				Type mt = null;
				MethodInfo methInfo = null;

				if (module != null)
				{
					mt = module.GetType("DynaCore.DynaCore");
				}

				if (mt != null)
				{
					methInfo = mt.GetMethod("Main");
				}

				if (methInfo != null)
				{
					Console.WriteLine(methInfo.Invoke(null, new object[] { "here in dyna code" }));
				}




				//var module = results.CompiledAssembly.GetModules()[0];
				//var type = module.GetType("Program");
				//var info = type.GetMethod("Main");
				//info?.Invoke(null, null);

			}

		}

	}
}
