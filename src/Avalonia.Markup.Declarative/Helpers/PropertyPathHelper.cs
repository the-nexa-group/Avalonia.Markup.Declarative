using System;

namespace Avalonia.Markup.Declarative.Helpers;

internal static class PropertyPathHelper
{
    private static readonly char[] StopChars = [' ', '?', ',', '\"', '@', '\t', '\n'];
    
    public static string GetNameFromPropertyPath(string? path)
    {
        if (string.IsNullOrEmpty(path)) 
            return string.Empty;

        ReadOnlySpan<char> pathSpan = path.AsSpan();
        int startIndex = Math.Max(0, pathSpan.LastIndexOf(')'));
        bool propFound = false;
        
        for (int i = startIndex; i < pathSpan.Length; i++)
        {
            var curChar = pathSpan[i];
            if (propFound && StopChars.Contains(curChar))
                return pathSpan[startIndex..i].ToString();
            
            if (!propFound && curChar == '.')
            {
                startIndex = i + 1;
                propFound = true;
            }
        }

        if (propFound)
            return pathSpan[startIndex..].ToString();

        return pathSpan.TrimStart('@').ToString();
    }
}