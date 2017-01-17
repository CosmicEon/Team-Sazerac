﻿using System;

namespace OOPTeamwork.Core.Contracts
{
    public interface IWriter
    {
        void Write(string message);

        void Write(char message);

        void WriteLine(string message = null);
        
        void ChangeColor(ConsoleColor color);

        void ResetColor();

        void Clear();
    }
}