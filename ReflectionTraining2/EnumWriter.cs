using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gny.FromCSharpToJava
{
    public class EnumWriter
    {
        public EnumWriter(string location,Type type)
        {
            WriteEnums(location,type);
        }
        private void WriteEnums(string location,Type type)
        {
            var newPage = new NewPageCreator(location + type.Name + ".java");
            
            newPage.StreamWriter.WriteLine(" private enum" + " " + type.Name + " \n{");

            foreach (var enumValues in type.GetEnumValues())
            {
                newPage.StreamWriter.WriteLine("\t" + enumValues + "="+ (int)enumValues + ",");
            }

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
