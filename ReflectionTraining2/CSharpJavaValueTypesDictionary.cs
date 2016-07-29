using System.Collections.Generic;

namespace ReflectionTraining2
{
    public class CSharpJavaValueTypesDictionary
    {
        public Dictionary<string, string> SystemValueTypesDictionary = new Dictionary<string, string>();

        public CSharpJavaValueTypesDictionary()
        {
            SystemValueTypesDictionary.Add("String", "String");
            SystemValueTypesDictionary.Add("Int32", "int");
            SystemValueTypesDictionary.Add("Decimal", "double");
            SystemValueTypesDictionary.Add("Double", "double");
            SystemValueTypesDictionary.Add("Object", "obj");
            SystemValueTypesDictionary.Add("Char", "char");
            SystemValueTypesDictionary.Add("Boolean", "boolean");
            SystemValueTypesDictionary.Add("Single", "float");
            SystemValueTypesDictionary.Add("UInt64", "long");
            SystemValueTypesDictionary.Add("Int64", "long");
            SystemValueTypesDictionary.Add("UInt16", "short");
            SystemValueTypesDictionary.Add("Int16", "short");
            SystemValueTypesDictionary.Add("UInt32", "int");
            SystemValueTypesDictionary.Add("SByte", "sbyte");
            SystemValueTypesDictionary.Add("Byte", "byte");
        }
    }
}