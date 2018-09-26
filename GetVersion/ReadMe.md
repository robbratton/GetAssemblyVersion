# GetVersion

Gets versions of assemblies found in specified paths.

## Usage
GetVersion [options] [paths]

### Examples

*Command-Line:*

GetVersion -r=false c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin -o=TabDelimited 
- Recurse: False
- Output Format: Tab Delimited
- Paths: c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin

*Output:*

Note that tabs have been replaced by the ~ character.

```text
File~File Version~Product Version
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Aspose.Cells.dll~16.10.0.0~16.10.0.0
...
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\System.Xml.XPath.XDocument.dll~4.6.26011.01~4.6.26011.01 built by: dlab-DDVSOWINAGE026. 
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Business.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Business.Interfaces.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Common.Contracts.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Common.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.DataAccess.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.DataAccess.Interfaces.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Domain.Repositories.EF6.dll~0.1.0.0~0.1.0-unstable.39+Branch.develop.Sha.e4bb22fc6c55ba811efecfebf395d7798b5f9301
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Entities.Common.dll~0.1.0.0~0.1.0-unstable.21+Branch.develop.Sha.8959747e790a7b4a86e51ff33c1914914de0f052
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Messaging.Publishers.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Common.dll~1.1.0.0~1.1.0-unstable.21+Branch.develop.Sha.3bdd197a1e6077439fcd7408018e3a9147c4244c
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.DependencyInjection.dll~1.0.0.0~1.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.DependencyInjection.Ninject.dll~0.1.0.0~0.1.0-unstable.10+Branch.develop.Sha.587401a4dba6068048313bfe5fa76cb0030ea9c2
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Activity.V1.dll~0.1.0.0~0.1.0-unstable.25+Branch.develop.Sha.e66c4c33a381ece29979d2b6e5a606910dd89f80
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Assessments.V1.dll~1.0.0.0~1.0.0-unstable.21+Branch.develop.Sha.04d279979d64970986f49e86a9649cace3f72771
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Case.V1.dll~0.1.0.0~0.1.0-unstable.33+Branch.develop.Sha.5472e630be838a02141310fb74c37cce17b78db9
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.ConditionCenters.V1.dll~0.1.0.0~0.1.0-unstable.9+Branch.develop.Sha.317e3c07b5ccdf4e86fee59e59774f609374e594
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.dll~1.0.0.0~1.0.0-unstable.21+Branch.develop.Sha.77732b87bb95cd8d1d61acc6d67ec1fe62864b88
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Flags.V2.dll~1.0.0.0~1.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Letters.V1.dll~0.1.0.0~0.1.0-unstable.11+Branch.develop.Sha.6089777e116433312258740d4b1b85b8b6a7a3ba
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.LinkedItems.V1.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Problems.V1.dll~0.1.0.0~0.1.0-unstable.8+Branch.develop.Sha.2119a46044b69c6a10a5b03165481228843b4a4b
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Messages.Workflows.V1.dll~0.1.0.0~0.1.0-unstable.3+Branch.develop.Sha.e2c41c3368d4cce13c5a9d4599cf8f5a24694078
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceBus.Utilities.dll~0.1.0.0~0.1.0-unstable.8+Branch.develop.Sha.406e905ef41d51bcd7b54b9ed54dbadf1b73e6ee
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.ServiceHosts.Common.dll~0.1.0.0~0.1.0-unstable.19+Branch.develop.Sha.0f495dd4f14aec629ecab1e74002288136092c60
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Caching.dll~1.1.0.0~1.1.0-unstable.9+Branch.develop.Sha.e2b76a79dad92972dc8c1d60c5993426a290e403
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Caching.Redis.dll~0.1.0.0~0.1.0-unstable.24+Branch.develop.Sha.663b3548db1ac973ab7dcd2339b1c6c0f20e0949
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Clients.Common.dll~1.1.0.0~1.1.0-unstable.16+Branch.develop.Sha.bd1342f24e069427116343d82b11ee71dfc6ad79
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Common.dll~0.1.0.0~0.1.0-unstable.128+Branch.develop.Sha.98a43ec2ecf4627f8188f593b91964a7627e8b70
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Logging.dll~1.1.0.0~1.1.0-unstable.4+Branch.develop.Sha.95c57932ebd8cee2ce9d2b78a0f11eb923ba4508
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Logging.Sqlserver.dll~1.1.0.0~1.1.0-unstable.7+Branch.develop.Sha.23d71c768a428cf42f418294977788a3cddf9b24
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.MethodResponse.dll~1.1.0.0~1.1.0-unstable.15+Branch.develop.Sha.d3121cce76d79fa1418f3ed883136a8b0d70c90f
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.RuleEngine.dll~0.1.0.0~0.1.0-unstable.13+Branch.develop.Sha.1fa54a49ac69a9c8d373d899b052b648c195e90a
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Transaction.dll~1.1.0.0~1.1.0-unstable.7+Branch.develop.Sha.c0601be5a435debcf7d90f6cbf5ed39984933e4b
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Utilities.dll~1.1.0.0~1.1.0-unstable.79+Branch.develop.Sha.9ffb30f1b02a51105ced2dff21f9cf56a3ebbe70
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Web.Utils.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Web.WcfRestHttp.dll~0.0.0.0~0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMCHP.Integration.dll~1.0.0.0~1.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\WebActivatorEx.dll~2.2.0~2.2.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\WindowsBase.dll~4.6.1055.0 built by: NETFXREL2~4.6.1055.0
```

*Command-Line:*

GetVersion -r=false c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin

*Output:*

```text
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Aspose.Cells.dll: File Version: 16.10.0.0, Product Version: 16.10.0.0
...
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Caching.Redis.dll: File Version: 0.1.0.0, Product Version: 0.1.0-unstable.24+Branch.develop.Sha.663b3548db1ac973ab7dcd2339b1c6c0f20e0949
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Clients.Common.dll: File Version: 1.1.0.0, Product Version: 1.1.0-unstable.16+Branch.develop.Sha.bd1342f24e069427116343d82b11ee71dfc6ad79
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Common.dll: File Version: 0.1.0.0, Product Version: 0.1.0-unstable.128+Branch.develop.Sha.98a43ec2ecf4627f8188f593b91964a7627e8b70
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Logging.dll: File Version: 1.1.0.0, Product Version: 1.1.0-unstable.4+Branch.develop.Sha.95c57932ebd8cee2ce9d2b78a0f11eb923ba4508
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Logging.Sqlserver.dll: File Version: 1.1.0.0, Product Version: 1.1.0-unstable.7+Branch.develop.Sha.23d71c768a428cf42f418294977788a3cddf9b24
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.MethodResponse.dll: File Version: 1.1.0.0, Product Version: 1.1.0-unstable.15+Branch.develop.Sha.d3121cce76d79fa1418f3ed883136a8b0d70c90f
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.RuleEngine.dll: File Version: 0.1.0.0, Product Version: 0.1.0-unstable.13+Branch.develop.Sha.1fa54a49ac69a9c8d373d899b052b648c195e90a
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Transaction.dll: File Version: 1.1.0.0, Product Version: 1.1.0-unstable.7+Branch.develop.Sha.c0601be5a435debcf7d90f6cbf5ed39984933e4b
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\Upmc.Services.Utilities.dll: File Version: 1.1.0.0, Product Version: 1.1.0-unstable.79+Branch.develop.Sha.9ffb30f1b02a51105ced2dff21f9cf56a3ebbe70
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Web.Utils.dll: File Version: 0.0.0.0, Product Version: 0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMC.Web.WcfRestHttp.dll: File Version: 0.0.0.0, Product Version: 0.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\UPMCHP.Integration.dll: File Version: 1.0.0.0, Product Version: 1.0.0.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\WebActivatorEx.dll: File Version: 2.2.0, Product Version: 2.2.0
c:\git\monolith-hp\UPMC.Web.WcfRestHttp\bin\WindowsBase.dll: File Version: 4.6.1055.0 built by: NETFXREL2, Product Version: 4.6.1055.0

```


