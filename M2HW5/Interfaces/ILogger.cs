﻿namespace M2HW5.Interfaces
{
    public interface ILogger
    {
        public void LogInfo(string message);

        public void LogWarning(string message);

        public void LogError(string message);
    }
}
