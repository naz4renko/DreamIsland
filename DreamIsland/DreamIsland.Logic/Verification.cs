using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DreamIsland.Logic
{
    public class Verification
    {
        public static bool IsCorrectName(string name)
        {
            if (!Regex.IsMatch(name, @"^[а-яА-Я]+$") || name.Length <= 1)
            {
                return false;
            }
            else
                return true;
        }
        public static bool IsCorrectAge(int age)
        {
            if (age < 3 || age > 120)
                return false;
            else
                return true;
        }
        public static bool IsArgsEmpty(string[] args)
        {
            if (args.Length != 0) return true;
            return false;
        }
        public static bool IsPathExists(string filePath)
        {
            if (File.Exists(filePath)) return true;
            return false;
        }
    }
}
