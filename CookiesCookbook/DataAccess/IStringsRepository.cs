﻿namespace CookiesCookbook.DataAccess
{
    public interface IStringsRepository
    {
        List<string> Read(string filepath);
        void Write(string filepath, List<string> strings);
    }
}
