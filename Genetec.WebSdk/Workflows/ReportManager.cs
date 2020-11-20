using Genetec.WebSdk.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Genetec.WebSdk.Workflows
{
    public sealed class ReportManager
    {
        public ReportQuery CreateReportQuery(ReportType type)
        {
            switch (type)
            {
                case ReportType.EntityConfiguration:
                    return new EntityConfigurationQuery();

                default:
                    throw new NotImplementedException();
            }               
        }
    }
}
