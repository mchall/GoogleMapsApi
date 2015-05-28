using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleMapsApi
{
    public interface IGoogleMapHost
    {
        void RegisterScriptingObject(IGoogleMapRequired wrapper);
        void SetHostDocumentText(string text);
        object InvokeScript(string methodName, params object[] parameters);
        bool HandleException(string message, string url, string line);
    }
}