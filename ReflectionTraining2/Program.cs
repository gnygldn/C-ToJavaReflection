using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    class Program
    {
        static void Main()
        {
            FileReader file = new FileReader("C:/Users/gnygl/Downloads/ReflectionOrnekClass.dll");
            FileWriter fileWriter = new FileWriter("C:/Users/gnygl/Desktop/gnytry/", file.SourceFile);
            fileWriter.Write();
        }
    }
}