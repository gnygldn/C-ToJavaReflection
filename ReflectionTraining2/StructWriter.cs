using System;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    public class StructWriter
    {
        public StructWriter(string location, Type type)
        {
            var newPage = new NewPageCreator(location + type.Name + ".java");
            newPage.StreamWriter.WriteLine("class" + " " + type.Name + " \n{");

            
            FieldWriter field = new FieldWriter();
            field.WriteField(newPage, type.GetFields());
            

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
