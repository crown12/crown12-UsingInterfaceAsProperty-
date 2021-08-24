using System;

namespace UsingInterfaceAsProperty
{
    class Program
    {

        public interface IProtectedPsk
        {
            string Key{ get; set; }
            string Value{ get; set; }

        }


        public class ProtectedSections
        {
            public IProtectedPsk SecurityA { get; set; }
            public IProtectedPsk SecurityB { get; set; }
            public IProtectedPsk SecurityC { get; set; }
        }


        //A need of an intermediate class type to performe W/R
        public class ReadWrite : IProtectedPsk
        {
            public string Key { get; set ; }
            public string Value { get ; set ; }
        }

        static void Main(string[] args)
        {

            var sections = new ProtectedSections();
            sections.SecurityA = new ReadWrite();

            sections.SecurityA.Key = "001";
            sections.SecurityA.Value = "Sky";

            Console.WriteLine($"{sections.SecurityA.Key} | {sections.SecurityA.Value}");
        }
    }
}
