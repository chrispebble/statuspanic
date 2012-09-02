using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Utilities
/// </summary>
public static class Utilities
{
    public static string MD5Hash(string input)
    {
        MD5 algorithm = MD5.Create();
        byte[] data = algorithm.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sb.Append(data[i].ToString("x2"));
        }

        return sb.ToString(); 
    }
}