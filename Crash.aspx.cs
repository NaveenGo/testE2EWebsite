using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Crash : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Diagnostics.Trace.TraceInformation("Information trace");
        System.Diagnostics.Trace.TraceWarning("Warning trace");
        System.Diagnostics.Trace.TraceError("Error trace");
        System.Diagnostics.Trace.Flush();
        throw new Exception("Crashing the page for test purpose...");
    }
}