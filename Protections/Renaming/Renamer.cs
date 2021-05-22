using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObfuscatorProject.Protections.Renaming
{
    class Renamer
    {
        private static Random random = new Random();

        private static string RandomString(int length)
        {
            string characters = " 1         2       3        4        5       ";
            return new string(Enumerable.Repeat(characters, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void Exec(ModuleDef module)
        {
            foreach (TypeDef type in module.Types)
            {
                type.Name = RandomString(random.Next(1000, 2100));
                type.Namespace = RandomString(random.Next(1000, 2100));
                if (type.IsGlobalModuleType || type.IsRuntimeSpecialName || type.IsSpecialName || type.IsWindowsRuntime || type.IsInterface)
                {
                    continue;
                }
                foreach (MethodDef method in type.Methods)
                {
                    if (method.IsConstructor || method.IsRuntimeSpecialName || method.IsRuntime || method.IsStaticConstructor || method.IsVirtual) continue;
                    method.Name = RandomString(random.Next(1000, 2100));
                    foreach (var field in type.Fields)
                    {
                        field.Name = RandomString(random.Next(1000, 2100));
                        foreach (EventDef eventdef in type.Events)
                        {
                            eventdef.Name = RandomString(random.Next(1000, 2100));
                            foreach (PropertyDef property in type.Properties)
                            {
                                if (property.IsRuntimeSpecialName) continue;
                                property.Name = RandomString(random.Next(1000, 2100));
                            }
                        }
                    }

                    foreach (ParamDef p in method.ParamDefs)
                    {
                        p.Name = RandomString(random.Next(1000, 2100));
                    }
                }
            }
        }
    }
}
