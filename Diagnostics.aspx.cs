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

//http://msdn.microsoft.com/en-us/library/system.diagnostics.tracelistener.aspx
//http://msdn.microsoft.com/en-us/library/vstudio/wwh16c6c(v=vs.100).aspx
//http://www.hanselman.com/blog/StreamingDiagnosticsTraceLoggingFromTheAzureCommandLinePlusGlimpse.aspx
public partial class Crash : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TraceError_Click(object sender, EventArgs e)
    {
        string message = string.Format("Error trace at {0}", DateTime.Now.ToString(CultureInfo.CurrentUICulture));
        System.Diagnostics.Trace.TraceError(message);
        Message.Text = message;
    }
    protected void TraceWarning_Click(object sender, System.EventArgs e)
    {
        string message = string.Format("Warning trace at {0}", DateTime.Now.ToString(CultureInfo.CurrentUICulture));
        System.Diagnostics.Trace.TraceWarning(message);
        Message.Text = message;
    }
    protected void TraceInfo_Click(object sender, System.EventArgs e)
    {
        string message = string.Format("Information trace at {0}", DateTime.Now.ToString(CultureInfo.CurrentUICulture));
        System.Diagnostics.Trace.TraceInformation(message);
        Message.Text = message;
    }
    protected void CrashPage_Click(object sender, System.EventArgs e)
    {
        Message.Text = string.Empty;
        throw new Exception("Crashing the page for test purpose...");
    }
}