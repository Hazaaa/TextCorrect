﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TextCorrect.Core
{
    public enum Typography
    {
        Cyrillic,
        Latin
    }

    public enum Language
    {
        Serbian_latin,
        Serbian_cyrillic,
        English
    }

    public class TextManipulation
    {
        private readonly Dictionary<string, string> latinToCyrillicAlphabet = new Dictionary<string, string>();
        private readonly Dictionary<string, string> cyrillicToLatinAlphabet = new Dictionary<string, string>();
        private readonly Dictionary<string, string> specialCyrillicLetters = new Dictionary<string, string>();

        public TextManipulation(){}

        /// <summary>
        /// Removes unnecessary whitespaces, double special characters and capitalize first letter of each sentence.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string PreCorrectText(string text)
        {
            string whitespaceRemoved = String.Join(" ", text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));

            string specialCharactersRemoved = RemoveUnnecessarySpecialCharacters(whitespaceRemoved);

            string capitalizedLetters = CapitalizeFirstLetterOfSentence(specialCharactersRemoved);

            return capitalizedLetters;
        }

        public string CapitalizeFirstLetterOfSentence(string input)
        {
            bool IsNewSentense = true;
            var result = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if (IsNewSentense && char.IsLetter(input[i]))
                {
                    result.Append(char.ToUpper(input[i]));
                    IsNewSentense = false;
                }
                else
                    result.Append(input[i]);

                if (input[i] == '!' || input[i] == '?' || input[i] == '.')
                {
                    IsNewSentense = true;
                }
            }

            return result.ToString();
        }

        public string RemoveUnnecessarySpecialCharacters(string input)
        {
            HashSet<char> specialCharacters = new HashSet<char> { '_', '/', '.', '?', ':', ';', '[', ']', '{', '}', ',', '|', '>', '<', '=', '+', '*', '!', '@', '#', '$', '%', '^', '&', '(', ')', '~', '`', '"' };

            string result = input[0].ToString();

            for (int i = 1; i < input.Length; i++)
            {
                if (specialCharacters.Contains(input[i]))
                {
                    if (result.Last() != input[i])
                    {
                        result += input[i];
                    }
                }
                else
                {
                    result += input[i];
                }
            }

            return result;
        }


        /// <summary>
        /// Populates dictionaries with translation of each letter from cyrillic and latin alphabet.
        /// </summary>
        public void PopulateDictionaries()
        {
            if(latinToCyrillicAlphabet.Count == 0 && cyrillicToLatinAlphabet.Count == 0 && specialCyrillicLetters.Count == 0)
            {
                string[] latinUp = { "A", "B", "V", "G", "D", "Đ", "E", "Ž", "Z", "I", "J", "K", "L", "Lj", "M", "N", "Nj", "O", "P", "R", "S", "T", "Ć", "U", "F", "H", "C", "Č", "Dž", "Š" };
                string[] latinLow = latinUp.Select(x => x.ToLower()).ToArray();

                string[] cyrillicUp = { "А", "Б", "В", "Г", "Д", "Ђ", "Е", "Ж", "З", "И", "Ј", "К", "Л", "Љ", "М", "Н", "Њ", "О", "П", "Р", "С", "Т", "Ћ", "У", "Ф", "Х", "Ц", "Ч", "Џ", "Ш" };
                string[] cyrillicLow = cyrillicUp.Select(x => x.ToLower()).ToArray();

                for (int i = 0; i < 30; i++)
                {
                    latinToCyrillicAlphabet.Add(latinUp[i], cyrillicUp[i]);
                    latinToCyrillicAlphabet.Add(latinLow[i], cyrillicLow[i]);

                    cyrillicToLatinAlphabet.Add(cyrillicUp[i], latinUp[i]);
                    cyrillicToLatinAlphabet.Add(cyrillicLow[i], latinLow[i]);
                }

                // Adding special letters for cyrillic conversion
                specialCyrillicLetters.Add("lj", "љ");
                specialCyrillicLetters.Add("Lj", "Љ");
                specialCyrillicLetters.Add("nj", "њ");
                specialCyrillicLetters.Add("Nj", "Њ");
                specialCyrillicLetters.Add("dj", "ђ");
                specialCyrillicLetters.Add("Dj", "Ђ");
                specialCyrillicLetters.Add("dz", "џ");
                specialCyrillicLetters.Add("Dz", "Џ");
                specialCyrillicLetters.Add("dž", "џ");
                specialCyrillicLetters.Add("Dž", "Џ");
            }
        }

        /// <summary>
        /// Returns text translated from latin to cyrillic.
        /// </summary>
        public string ConvertTextToCyrillic(string text)
        {
            if (text == "")
                return text;

            PopulateDictionaries();
            string result = text;

            foreach (var specialLetter in specialCyrillicLetters)
            {
                result = result.Replace(specialLetter.Key, specialLetter.Value);
            }

            foreach (var letter in latinToCyrillicAlphabet)
            {
                result = result.Replace(letter.Key, letter.Value);
            }

            return result;
        }

        /// <summary>
        /// Returns text translated from cyrillic to latin.
        /// </summary>
        public string ConvertTextToLatin(string text)
        {
            if (text == "")
                return text;

            PopulateDictionaries();
            string result = text;

            foreach (var letter in cyrillicToLatinAlphabet)
            {
                result = result.Replace(letter.Key, letter.Value);
            }

            foreach (var specialLetter in specialCyrillicLetters)
            {
                result = result.Replace(specialLetter.Value, specialLetter.Key);
            }

            return result;
        }

        /// <summary>
        /// Removes all special characters from string leaving only letters.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
