using Quartz;

namespace PlanLogisticsWebApp.ofJob
{
    [DisallowConcurrentExecution]
    public class HelloWorldJob : IJob
    {
        private readonly ILogger<HelloWorldJob> _logger;
        private int cnt = 0;
        public HelloWorldJob(ILogger<HelloWorldJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation($"Hello world! {cnt}");
            cnt++;
            return Task.CompletedTask;
        }
    }
}
