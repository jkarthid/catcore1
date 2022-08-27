using System;
using Serilog.Core;
using Serilog.Events;
using Serilog.Eventid;
namespace CatCore.Logging
{
	internal sealed class ActionableLogSink : ILogEventSink
	{
		private readonly Action<LogEvent> _logEventHandler;

		public ActionableLogSink(Action<LogEvent> logEventHandler)
		{
			_logEventHandler = logEventHandler;
		}

		public void Emit(LogEvent logEvent)
		{
			_logEventHandler(logEvent);
		}
	}
}