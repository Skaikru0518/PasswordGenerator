using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public enum CharType
    {
        LowerCase,
        UpperCase,
        Digit,
        Symbol
    }
    public class PasswordGenHelper
    {
        public static string GeneratePassword(GenerateConfig generateConfig)
        {
            string generatedPassword = string.Empty;

            List<char> characters = new List<char>();

            if (generateConfig.IsLower)
            {
                characters.AddRange(GetCharacters(CharType.LowerCase));
            }
            if (generateConfig.IsUpper)
            {
                characters.AddRange(GetCharacters(CharType.UpperCase));
            }
            if (generateConfig.IsDigit)
            {
                characters.AddRange(GetCharacters(CharType.Digit));
            }
            if (generateConfig.IsSymbol)
            {
                characters.AddRange(GetCharacters(CharType.Symbol));
            }

            Random random = new Random();

            List<char> selectedChars = Enumerable.Range(0, generateConfig.Lenght).Select(i => characters[random.Next(characters.Count)]).ToList();

            generatedPassword = string.Join("", selectedChars);

            return generatedPassword;
        }

        public static List<char> GetCharacters(CharType charType)
        {
            if(charType == CharType.LowerCase)
            {
                return Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToList();
            }
            if (charType == CharType.UpperCase)
            {
                return Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (char)i).ToList();
            }
            if (charType == CharType.Digit)
            {
                return Enumerable.Range('0', '9' - '0' + 1).Select(i => (char)i).ToList();
            }

            return "!@#$%^&*()_+{}|:?".Where(c => char.IsSymbol(c)).ToList();

        }
    }
}
