using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"Pushed C# Timer trigger function executed at: {DateTime.Now}");
}
