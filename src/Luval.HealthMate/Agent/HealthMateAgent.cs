using Luval.GenAIBotMate.Core.Services;
using Luval.GenAIBotMate.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luval.HealthMate.Agent
{
    public class HealthMateAgent : GenAIBotService
    {
        private static Kernel? _kernel;
        private readonly ILogger<GenAIBotService> _logger;

        public HealthMateAgent(IKernelBuilder kernelBuilder, IGenAIBotStorageService chatbotStorageService, IMediaService mediaService, ILoggerFactory loggerFactory) : base(Create(kernelBuilder), chatbotStorageService, mediaService, loggerFactory.CreateLogger<GenAIBotService>())
        {
            if (loggerFactory == null) throw new ArgumentNullException(nameof(loggerFactory));
            if (_kernel != null)
                SetKernel(_kernel);
        }

        private static IChatCompletionService Create(IKernelBuilder kernelBuilder)
        {
            var kernel = kernelBuilder.Build();
            _kernel = kernel;
            return kernel.GetRequiredService<IChatCompletionService>();
        }
    }
}
