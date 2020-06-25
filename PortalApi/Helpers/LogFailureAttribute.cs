using Hangfire.Common;
using Hangfire.Logging;
using Hangfire.States;
using Hangfire.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Helpers
{
    public class LogFailureAttribute : JobFilterAttribute, IApplyStateFilter
    {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public void OnStateApplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            var failedState = context.NewState as FailedState;
            if (failedState != null)
            {
                Logger.ErrorException(
                    String.Format("Background job #{0} was failed with an exception.", context.BackgroundJob.Id),
                    failedState.Exception);
            }
        }

        public void OnStateUnapplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
        }
    }
}
