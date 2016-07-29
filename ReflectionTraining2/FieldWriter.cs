using System;
using System.Reflection;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    public class FieldWriter
    {
        public void WriteField(NewPageCreator page, FieldInfo[] fields)
        {
            // TODO: type checker classı yarat. type'ı orda al ,kontrol et ve return et.
            foreach (var field in fields)
            {
                var fieldType = CheckFieldType(field);
                //var fieldType = FileWriter.dictionary[field.FieldType.ToString()];

                page.StreamWriter.WriteLine("\t" + "public" + " " + fieldType + " " + field.Name + ";\n");
            }
        }

        public string CheckFieldType(FieldInfo field)
        {
            CSharpJavaValueTypesDictionary dictionary = new CSharpJavaValueTypesDictionary();

            if (field.FieldType.FullName.Contains("Nullable`1"))
            {
                return dictionary.SystemValueTypesDictionary[Nullable.GetUnderlyingType(field.FieldType).Name];
            }
            if (dictionary.SystemValueTypesDictionary.ContainsKey(field.FieldType.Name))
            {
                var gny = dictionary.SystemValueTypesDictionary[field.FieldType.Name];
                return gny;
            }
            var gny1 = field.FieldType.Name;
            return gny1;
        }
    }
}