using System.Collections.Generic;

public static class errors
{

    public static Dictionary<int, string> err = new Dictionary<int, string>()
        {
            { 100,"Database Connectivity Error"},
            { 101,"Invalid Login Credentials" },
            { 102,"Issue with payload-data. Some details not found. Please check your payload."}
        };
}