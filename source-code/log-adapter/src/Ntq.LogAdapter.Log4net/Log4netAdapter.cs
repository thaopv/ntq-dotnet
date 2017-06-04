﻿using System;
using System.Collections.Generic;
using System.IO;
using log4net;
using log4net.Core;

namespace Ntq.LogAdapter.Log4net
{
    public class Log4netAdapter : Core.LogAdapterBase
    {
        private static readonly Dictionary<Core.LogLevel, Level> LogLevel2Log4netLevel = new Dictionary<Core.LogLevel, Level>()
        {
            { Core.LogLevel.Debug, Level.Debug },
            { Core.LogLevel.Info, Level.Info },
            { Core.LogLevel.Warning, Level.Warn },
            { Core.LogLevel.Error, Level.Error },
            { Core.LogLevel.Fatal, Level.Fatal },
        };

        static Log4netAdapter()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));
        }

        private readonly ILog _logger;

        public Log4netAdapter()
            : base()
        {
            this._logger = LogManager.GetLogger(GetCallerInfo().ClassName);
        }

        public Log4netAdapter(string name)
            : base(name)
        {
            this._logger = LogManager.GetLogger(name);
        }

        public override void Log(Core.LogLevel logLevel, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public override void Log(Core.LogLevel logLevel, Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        private LoggingEvent CreateLogEventInfo(Core.LogLevel logLevel, Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
