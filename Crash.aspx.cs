#define TRACE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Globalization;

public partial class Crash : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TraceError_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Trace.TraceError(string.Format("Error trace at {0}", DateTime.Now.ToString(CultureInfo.CurrentUICulture)));
    }
    protected void TraceWarning_Click(object sender, System.EventArgs e)
    {
        System.Diagnostics.Trace.TraceWarning(string.Format("Warning trace at {0}", DateTime.Now.ToString(CultureInfo.CurrentUICulture)));
    }
    protected void TraceInfo_Click(object sender, System.EventArgs e)
    {
        System.Diagnostics.Trace.TraceInformation(string.Format("Information trace at {0}", DateTime.Now.ToString(CultureInfo.CurrentUICulture)));
    }
    protected void CrashPage_Click(object sender, System.EventArgs e)
    {
        throw new Exception("Crashing the page for test purpose...");
    }
}