using System;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    class ClassWriter
    {
        public ClassWriter(string location,Type type)
        {
            WriteClasses(location,type);
        }
        
        public void WriteClasses(string location,Type type)
        {
            var newPage = new NewPageCreator(location + type.Name + ".java");
            newPage.StreamWriter.WriteLine("public" + " " + type.Name + " \n{");


            FieldWriter field = new FieldWriter();
            field.WriteField(newPage, type.GetFields());
            PropertyWriter property = new PropertyWriter();
            property.WriteProperty(newPage, type.GetProperties());
            

            ClosePage(newPage);
        }
        
        private void ClosePage(NewPageCreator page)
        {
            page.StreamWriter.WriteLine("}");
            page.StreamWriter.Close();
            page.FileStream.Close();
        }
    }
}
