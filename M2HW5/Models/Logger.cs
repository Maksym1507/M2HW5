﻿using M2HW5.Enums;
using M2HW5.Interfaces;

namespace M2HW5.Models
{
    public class Logger : ILogger
    {
        public Logger(INotificationService notificationService, IFileService fileService)
        {
            Message = notificationService;
            FileService = fileService;
        }

        private IFileService FileService { get; }

        private INotificationService Message { get; }

        public void LogInfo(string message)
        {
            WriteAndPrintLogs(LogType.Info, message);
        }

        public void LogWarning(string message)
        {
            WriteAndPrintLogs(LogType.Warning, message);
        }

        public void LogError(string message)
        {
            WriteAndPrintLogs(LogType.Error, message);
        }

        public void WriteAndPrintLogs(LogType type, string message)
        {
            var log = $"{DateTime.Now}: {type}: {message}";
            Message.ShowMessage(log);
            FileService.WriteToFile(log);
        }
    }
}
