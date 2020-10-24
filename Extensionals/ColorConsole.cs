/*
 * MIT License
 *
 * Copyright (c) 2020 TheAlgorithm476
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;

namespace Extensionals {
    public class ColorConsole {
        /* START Wildcards */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in the specified color.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLine(string color, string format) {
            switch (color) {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                case "darkblue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                case "darkgray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                case "darkgreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                case "darkmagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                case "darkred":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                case "darkyellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }
        /* END Wildcards */
        /* START Black */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a black color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInBlack(string format) {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a black color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInBlack(string format) {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInBlack() {
            Console.ForegroundColor = ConsoleColor.Black;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Black */
        /* START Blue */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a blue color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInBlue(string format) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a blue color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInBlue(string format) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInBlue() {
            Console.ForegroundColor = ConsoleColor.Blue;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Blue */
        /* START Cyan */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a cyan color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInCyan(string format) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a cyan color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInCyan(string format) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInCyan() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Cyan */
        /* START DarkBlue */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a dark blue color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInDarkBlue(string format) {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }
        /// <summary>
        /// Writes the specified string value to the standard output stream in a dark blue color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>

        public static string WriteInDarkBlue(string format) {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInDarkBlue() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END DarkBlue */
        /* START DarkGray */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a dark gray color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInDarkGray(string format) {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a dark gray color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInDarkGray(string format) {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInDarkGray() {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END DarkGray */
        /* START DarkGreen */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a dark green color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInDarkGreen(string format) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }
        /// <summary>
        /// Writes the specified string value to the standard output stream in a dark green color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>

        public static string WriteInDarkGreen(string format) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInDarkGreen() {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END DarkGreen */
        /* START DarkMagenta */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a dark magenta color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInDarkMagenta(string format) {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a dark magenta color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInDarkMagenta(string format) {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInDarkMagenta() {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END DarkMagenta */
        /* START DarkRed */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a dark red color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInDarkRed(string format) {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a dark red color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInDarkRed(string format) {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInDarkRed() {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END DarkRed */
        /* START DarkYellow */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a dark yellow color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInDarkYellow(string format) {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a dark yellow color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInDarkYellow(string format) {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInDarkYellow() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END DarkYellow */
        /* START Gray */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a gray color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInGray(string format) {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a gray color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInGray(string format) {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInGray() {
            Console.ForegroundColor = ConsoleColor.Gray;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Gray */
        /* START Green */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a green color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInGreen(string format) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a green color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInGreen(string format) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInGreen() {
            Console.ForegroundColor = ConsoleColor.Green;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Green */
        /* START Magenta */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a magenta color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInMagenta(string format) {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a magenta color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInMagenta(string format) {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInMagenta() {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Magenta */
        /* START Red */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a red color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInRed(string format) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a yellow color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInRed(string format) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInRed() {
            Console.ForegroundColor = ConsoleColor.Red;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Red */
        /* START White */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a white color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInWhite(string format) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a white color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInWhite(string format) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInWhite() {
            Console.ForegroundColor = ConsoleColor.White;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END White */
        /* START Yellow */
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator, to the standard output stream in a yellow color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteLineInYellow(string format) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Writes the specified string value to the standard output stream in a yellow color.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        /// <exception cref="System.IO.IOException"></exception>
        public static string WriteInYellow(string format) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(format);
            Console.ResetColor();
            return format;
        }

        /// <summary>
        /// Reads the next line of characters from the standard input stream in a black color.
        /// </summary>
        /// <returns>The next line from the input stream, or null if no more lines are available.</returns>
        /// <exception cref="System.IO.IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ReadLineInYellow() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string returns = Console.ReadLine();
            Console.ResetColor();
            return returns;
        }

        /* END Yellow */
    }
}