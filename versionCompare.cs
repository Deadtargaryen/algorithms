using System;
using System.Linq;

namespace TestTaker
{
    public static class CustomCode
    {
        public static int VersionCompare(string version1, string version2)
        {
            // Split the versions into parts
            string[] parts1 = version1.Split('.').Select(s => s.PadLeft(3, '0')).ToArray();
            string[] parts2 = version2.Split('.').Select(s => s.PadLeft(3, '0')).ToArray();

            // Compare each part of the version
            for (int i = 0; i < Math.Max(parts1.Length, parts2.Length); i++)
            {
                int part1 = i < parts1.Length ? int.Parse(parts1[i]) : 0;
                int part2 = i < parts2.Length ? int.Parse(parts2[i]) : 0;

                if (part1 < part2)
                {
                    return -1;
                }
                else if (part1 > part2)
                {
                    return 1;
                }
            }

            // Versions are equal
            return 0;
        }
    }
}
