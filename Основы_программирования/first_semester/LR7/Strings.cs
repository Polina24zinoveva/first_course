using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_7
{
    public class Strings
    {
        string podstroka;
        string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string number = "0123456789";
        string str = " ";

        public Strings(string str)
        {
            this.str = str;
        }
        private static bool IsLetter(char c)
        {
            if (('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z') || ('а' <= c && c <= 'я') || ('А' <= c && c <= 'Я'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool IsDigit(char c)
        {
            if ('0' <= c && c <= '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsSeparator(char c)
        {
            if ((char.IsLetter(c) == false) && (char.IsDigit(c) == false))
            {
                return true;
            }
            return false;
        }

        public static int CountLetters(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c) == true)
                {
                    count++;
                }
            }
            return count;
        }
        public static double AverageWordLength(string str)
        {
            str = str + ".";
            double countWords = 0;
            double count1word = 0;
            double countLetters = 0;
            foreach (char c in str)
            {
                if (IsSeparator(c) == false)
                {
                    count1word++;
                }
                else if (count1word != 0)
                {
                    countLetters += count1word;
                    count1word = 0;
                    countWords++;
                }
            }
            if (countWords != 0)
            {
                double result = countLetters / countWords;
                return result;
            }
            else
            {
                return 0;
            }
        }

        public static string ReplaceWord(string str, string podstroka, string newpodstroka)
        {
            str = str + ".";
            str = str.ToLower();
            string result = "";
            string word = "";
            foreach (char c in str)
            {
                if (IsSeparator(c) == false)
                {
                    word += c;
                }
                else
                {
                    if (word.Equals(podstroka))  //сравнение ссылочных типов.(т.к. ссылки разные, а значения одинаковые)
                    {
                        result += newpodstroka;
                    }
                    else
                    {
                        result += word;
                    }
                    result += c;
                    word = "";
                }
            }
            result = result.Substring(0, result.Length - 1);
            return result;
        }

        public static int SubstringCounter(string str, string podstroka)
        {
            str = str.ToLower();
            int count = 0;
            string word = "";
            foreach (char c in str)
            {
                if (IsSeparator(c) == false)
                {
                    word += c;
                }
                else if (IsSeparator(c) == true)
                {
                    word = "";
                }
                if (word.Contains((podstroka)))  //сравнение ссылочных типов.(т.к. ссылки разные, а значения одинаковые)
                {
                    count += 1;
                    word = "";
                }
                
            }
            return count;
        }

        public static bool Palindrom(string str)
        {
            str = str.ToLower();
            string strLetters = "";
            foreach (char c in str)
            {
                if (IsLetter(c) == true)
                {
                    strLetters += c;
                }
            }
            string strLettersRevers = "";
            for (int i = strLetters.Length - 1; i > -1; i--)
            {
                strLettersRevers += Convert.ToChar(strLetters[i]);
            }
            if (strLetters.Equals(strLettersRevers))  //сравнение ссылочных типов.(т.к. ссылки разные, а значения одинаковые)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool Data(string str)
        {
            //нужно ли учитывать правильность даты? типф: 44.50.2035
            if ((str.Length == 8) || (str.Length == 10))
            {
                if (IsDigit(str[0]) && IsDigit(str[1]) && str[2] == '.' && IsDigit(str[3]) && IsDigit(str[4]) && str[5] == '.' && IsDigit(str[6]) && IsDigit(str[7]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
