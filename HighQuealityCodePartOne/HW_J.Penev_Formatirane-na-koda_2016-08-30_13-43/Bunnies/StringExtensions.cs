﻿namespace Bunnies
{
    using System.Text;

    public static class StringExtensions
    {
        private const char Whitespace = ' ';
        private const int StringMargin = 10;

        public static string SeparateDifferentWords(this string sequence)
        {
            var stringSize = sequence.Length + StringMargin;
            var builder = new StringBuilder(stringSize);

            foreach (var letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(Whitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}