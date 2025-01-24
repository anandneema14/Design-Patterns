namespace DefineAndUseConfiguration;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConfiguration _configuration;

    public Worker(ILogger<Worker> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }

            //Ways to access config values
            //1.
            var x = _configuration["DelayDurationSeconds"];
            await Task.Delay(int.Parse(x), stoppingToken);
            
            //2. Better way
            var delayDurationSeconds = _configuration.GetValue<int>("DelayDurationSeconds", 1);
            
            await Task.Delay(TimeSpan.FromSeconds(delayDurationSeconds), stoppingToken);
        }
    }
}