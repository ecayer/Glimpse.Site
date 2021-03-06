﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glimpse.Package
{ 
    public interface ISettings
    {
        ISystemLoggerProvider LoggerProvider { get; }

        bool Debug { get; set; }

        bool LoggingEnabled { get; set; }

        bool LogEverything { get; set; }

        string LoggingPath { get; set; }

        bool DisableAutoBuild { get; set; }

        bool ServiceEnabled { get; set; }

        int MinServiceTriggerInterval { get; set; }

        IUpdateReleaseRepositoryService UpdateReleaseRepositoryService { get; }

        IExistingReleaseQueryService ExistingReleaseService { get; }

        INewReleaseQueryService NewReleaseService { get; }

        IUpdateReleaseService UpdateReleaseService { get; }

        IReleaseService ReleaseService { get; }

        IReleaseQueryProvider QueryProvider { get; }

        void Initialize();
    }
}
