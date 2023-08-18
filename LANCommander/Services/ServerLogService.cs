﻿using LANCommander.Data;
using LANCommander.Data.Models;
using System.Diagnostics;

namespace LANCommander.Services
{
    public class ServerConsoleService : BaseDatabaseService<ServerConsole>
    {
        public ServerConsoleService(DatabaseContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor) { }

        public async Task<string[]> ReadLog(Guid logId)
        {
            var log = await Get(logId);

            var logPath = Path.Combine(log.Server.WorkingDirectory, log.Path);

            return await File.ReadAllLinesAsync(logPath);
        }
    }
}