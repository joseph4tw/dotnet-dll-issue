# dotnet-dll-issue

Here we have a .NET Framework project targeting v4.7.1.

I want the `System.Runtime.InteropServices.RuntimeInformation` DLL to be copied to the `bin/(Debug|Release)` directory.

I have set `<Private>True</Private>` in the csproj file for the reference in the item group.

If someone can explain why the `System.Xml.dll` and `Newtonsoft.Json.dll` files are copied over, but not `System.Runtime.InteropServices.RuntimeInformation.dll` that would be great.
