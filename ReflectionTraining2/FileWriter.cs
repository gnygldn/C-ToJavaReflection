using System.Collections.Generic;
using System.Reflection;
using ReflectionTraining2;

namespace gny.FromCSharpToJava
{
    public class FileWriter
    {
        private string location;
        private Assembly sourceAssembly;


        public FileWriter(string location, Assembly sourceFile)
        {
            this.location = location;
            sourceAssembly = sourceFile;
        }

        public void Write()
        {
            foreach (var type in sourceAssembly.GetTypes())
            {
                if (type.IsClass)
                {
                    new ClassWriter(location, type);
                }
                else if (type.IsEnum)
                {
                    new EnumWriter(location, type);
                }

                else if (type.IsValueType)
                {
                    new StructWriter(location, type);
                }
            }
        }
    }
}