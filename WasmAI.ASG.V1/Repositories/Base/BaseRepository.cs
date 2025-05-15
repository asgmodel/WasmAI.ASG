using AutoGenerator.Repositories.Base;
using WasmAI.ASG.Data;
using WasmAI.ASG.Models;
using Microsoft.AspNetCore.Identity;
using System;
using WasmAI.ASG.V1.BPR.Layers.Base;

namespace WasmAI.ASG.V1.Repositories.Base
{
    public sealed class BaseBPRRepository<T> : TBaseBPRRepository<ApplicationUser, IdentityRole, string, T>, IBPRLayer<T, T>, IBaseRepository<T> where T : class
    {
        public BaseBPRRepository(DataContext db, ILoggerFactory logger) : base(db, logger)
        {
        }
    }
}