For the moment, I had to make some manual edits to converted go2cs .NET source
code to make Unity happy, specifically:

* go2cs supports .NET 5.0 features, such as native sized integers (nint) and
putting actual method implementations in interfaces. So for Unity code I had
to replace with normal int types and/or region out code, i.e.,
   #ifdef NET5_0
      ...incompatible code...
   #endif

* I have almost globally implemented "#nullable enable" in generated code from
go2cs but the Unity version I am using doesn't support this, i.e., 2019.4.17f1,
hopefully newer versions will support this very nice compiler feature, as it
helps prevent null reference exceptions, see:
    https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references

* Doesn't look like the project is setup to support "dynamic" variables, might
be missing a reference? This may be easy to resolve, but I just commented out
any code that referenced a "dyanmic" variable for now.

That said, I think should be easy enough to add a flag to go2cs to target .NET
Standard 2.0 for automated Unity targets and apply the above changes to
generated code - as the features that Unity is complaining about were only
recently added to go2cs.
