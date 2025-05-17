using AutoGenerator.Schedulers;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Schedulers
{
    public class UserSoftwareJob : BaseJob
    {
        public override Task Execute(JobEventArgs context)
        {
            Console.WriteLine($"Executing job: {_options.JobName} with cron: {_options.Cron}");
            return Task.CompletedTask;
        }

        protected override void InitializeJobOptions()
        {
            // _options.
            _options.JobName = "UserSoftware1";
        }
    }
}