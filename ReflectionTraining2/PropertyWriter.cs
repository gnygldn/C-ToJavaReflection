using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    public class PropertyWriter
    {
        public void WriteProperty(NewPageCreator page, PropertyInfo[] properties)
        {
            foreach (var property in properties)
            {
                CSharpJavaValueTypesDictionary dictionary = new CSharpJavaValueTypesDictionary();
                var propertyType = dictionary.SystemValueTypesDictionary[property.PropertyType.Name];
                page.StreamWriter.WriteLine("\t" + "public" + " " + propertyType + " " + property.Name + ";");
            }
        }
    }
}