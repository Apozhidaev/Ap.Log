﻿using System;
using System.Threading.Tasks;
using Any.Logs.Loggers;

namespace Any.Logs.Test
{
    public class ConsoleLogger : IMessageLogger
    {
        public void Flush() { }

        public bool IsEnabledFor(string methodName)
        {
            return true;
        }

        public Task WriteAsync(string message)
        {
            return Task.Run(() => Console.WriteLine(message));
        }
    }
}