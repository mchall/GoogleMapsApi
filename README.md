# Google Maps Api
Host a Google Maps control in your WinForms or WPF application.

NOTE: The Google Maps Javascript API no longer supports the browsers in the samples, but the implementation is not tied to any specific browser. It will still work correctly with more recent browser controls. 

![Original](http://mchall.github.io/Images/GoogleMapsApi/googlemaps.png)

### Usage ###

To use the wrapper, implement the IGoogleMapHost interface and then use the following code for use with a WPF browser:

```C#
public void RegisterScriptingObject(IGoogleMapRequired wrapper)
{
    Browser.ObjectForScripting = wrapper;
}

public void SetHostDocumentText(string text)
{
    Browser.NavigateToString(text);
}

public object InvokeScript(string methodName, params object[] parameters)
{
    return Browser.InvokeScript(methodName, parameters);
}

public bool HandleException(string message, string url, string line)
{
    //Log exceptions
    return true;
}
```

Or for a WinForms browser:

```C#
public void SetHostDocumentText(string text)
{
    browser.DocumentText = text;
}

public void RegisterScriptingObject(IGoogleMapRequired wrapper)
{
    browser.ObjectForScripting = wrapper;
}

public object InvokeScript(string methodName, params object[] parameters)
{
    return browser.Document.InvokeScript(methodName, parameters);
}

public bool HandleException(string message, string url, string line)
{
    //Log exceptions
    return true;
}
```

Then instantiate the wrapper with this line of code:

```C#
GoogleMapWrapper.Create(this);
```
