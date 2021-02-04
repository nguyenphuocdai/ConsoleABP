using Abp.Core.AbpModularity.Extension;
using Abp.Core.AbpModularity.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace ConsoleAppABP
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                using var application = AbpApplicationFactory.Create<App2Module>(options =>
                {
                    options.UseAutofac();
                });

                application.Initialize();

                var messagingService = application
                    .ServiceProvider
                    .GetRequiredService<App2MessagingService>();

                await messagingService.RunAsync();

                application.Shutdown();
                Console.WriteLine("Hello World!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
