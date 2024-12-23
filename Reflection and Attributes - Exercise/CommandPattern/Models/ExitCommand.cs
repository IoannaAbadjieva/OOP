﻿namespace CommandPattern.Models
{
    using System;

    using Core.Contracts;

    public class ExitCommand : ICommand
    {
        private const int DefaultExitCode = 0;

        public string Execute(string[] args)
        {
            Environment.Exit(DefaultExitCode);

            return null;
        }
    }
}
