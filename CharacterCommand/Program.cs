using System;
using CharacterLibrary;

namespace CharacterCommand
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var character = new Character();
            character.GenerateCharacter();
            Console.WriteLine(character);
        }
    }
}
