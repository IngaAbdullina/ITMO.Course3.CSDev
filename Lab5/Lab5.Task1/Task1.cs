using System;
using System.IO;

namespace Lab5
{
    internal class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            // foreach (string arg in args)
            // {
            //     Console.WriteLine(arg);
            // }
        
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            
            for (int i = 0; i < size; i++) {
                contents[i] = (char)reader.Read( );
            }
            foreach(char ch in contents) {
                Console.Write(ch);
            }
            reader.Close();
        }

        static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;
            foreach (char current in contents) {
                if (Char.IsLetter(current)) {
                    if ("AEIOUaeiou".IndexOf(current) != -1) {
                        vowels++;
                    } else {
                        consonants++;
                    }
                }
                else if (current == '\n') {
                    lines++;
                }
            }
            Console.WriteLine("Total no of characters: " + contents.Length);
            Console.WriteLine("Total no of vowels : " + vowels);
            Console.WriteLine("Total no of consonants: " + consonants);
            Console.WriteLine("Total no of lines : " + lines);
        }
    }
}