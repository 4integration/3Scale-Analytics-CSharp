#Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (M3ScaleAnalytics.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the M3ScaleAnalytics library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

### 3. Add reference of the library project

In order to use the M3ScaleAnalytics library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` M3ScaleAnalytics.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```M3ScaleAnalytics.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=3Scale%20Analytics-CSharp&workspaceName=M3ScaleAnalytics&projectName=M3ScaleAnalytics.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

M3ScaleAnalyticsClient client = new M3ScaleAnalyticsClient();
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [ServiceOpsController](#service_ops_controller)
* [ApplicationOpsController](#application_ops_controller)

### <a name="service_ops_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAnalytics.PCL.Controllers.ServiceOpsController") ServiceOpsController

#### Get singleton instance

The singleton instance of the ``` ServiceOpsController ``` class can be accessed from the API Client.

```csharp
ServiceOpsController serviceOps = client.ServiceOps;
```

#### <a name="get_stats_services_top_applications_by_service_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAnalytics.PCL.Controllers.ServiceOpsController.GetStatsServicesTopApplicationsByServiceId") GetStatsServicesTopApplicationsByServiceId

> *Tags:*  ``` Skips Authentication ``` 

> Returns usage and application data for the top 10 most active applications of a service.


```csharp
Task<dynamic> GetStatsServicesTopApplicationsByServiceId(
        FormatEnum format,
        string accessToken,
        int serviceId,
        string since,
        string metricName,
        PeriodEnum? period = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| format |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| since |  ``` Required ```  | TODO: Add a parameter description |
| metricName |  ``` Required ```  | TODO: Add a parameter description |
| period |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var format = FormatEnumHelper.ParseString("json");
string accessToken = "access_token";
int serviceId = 21;
string since = "since";
string metricName = "metric_name";
var period = PeriodEnum?Helper.ParseString("year");

dynamic result = await serviceOps.GetStatsServicesTopApplicationsByServiceId(format, accessToken, serviceId, since, metricName, period);

```


#### <a name="get_stats_services_usage_by_service_id_and_format"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAnalytics.PCL.Controllers.ServiceOpsController.GetStatsServicesUsageByServiceIdAndFormat") GetStatsServicesUsageByServiceIdAndFormat

> *Tags:*  ``` Skips Authentication ``` 

> Returns the usage data of a given metric (or method) of a service.


```csharp
Task<dynamic> GetStatsServicesUsageByServiceIdAndFormat(
        FormatEnum format,
        string accessToken,
        int serviceId,
        string metricName,
        string since,
        GranularityEnum granularity,
        PeriodEnum? period = null,
        string until = null,
        TimezoneEnum? timezone = TimezoneEnum.UTC,
        bool? skipChange = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| format |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| serviceId |  ``` Required ```  | TODO: Add a parameter description |
| metricName |  ``` Required ```  | TODO: Add a parameter description |
| since |  ``` Required ```  | TODO: Add a parameter description |
| granularity |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| period |  ``` Optional ```  | TODO: Add a parameter description |
| until |  ``` Optional ```  | TODO: Add a parameter description |
| timezone |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| skipChange |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var format = FormatEnumHelper.ParseString("json");
string accessToken = "access_token";
int serviceId = 21;
string metricName = "metric_name";
string since = "since";
var granularity = GranularityEnumHelper.ParseString("month");
var period = PeriodEnum?Helper.ParseString("year");
string until = "until";
var timezone = TimezoneEnum?Helper.ParseString("UTC");
bool? skipChange = false;

dynamic result = await serviceOps.GetStatsServicesUsageByServiceIdAndFormat(format, accessToken, serviceId, metricName, since, granularity, period, until, timezone, skipChange);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="application_ops_controller"></a>![Class: ](http://apidocs.io/img/class.png "M3ScaleAnalytics.PCL.Controllers.ApplicationOpsController") ApplicationOpsController

#### Get singleton instance

The singleton instance of the ``` ApplicationOpsController ``` class can be accessed from the API Client.

```csharp
ApplicationOpsController applicationOps = client.ApplicationOps;
```

#### <a name="get_stats_applications_usage_by_application_id"></a>![Method: ](http://apidocs.io/img/method.png "M3ScaleAnalytics.PCL.Controllers.ApplicationOpsController.GetStatsApplicationsUsageByApplicationId") GetStatsApplicationsUsageByApplicationId

> *Tags:*  ``` Skips Authentication ``` 

> Returns the usage data for a given metric (or method) of an application.


```csharp
Task<dynamic> GetStatsApplicationsUsageByApplicationId(
        FormatEnum format,
        string accessToken,
        int applicationId,
        string metricName,
        string since,
        GranularityEnum granularity,
        PeriodEnum? period = null,
        string until = null,
        TimezoneEnum? timezone = TimezoneEnum.UTC,
        bool? skipChange = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| format |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| accessToken |  ``` Required ```  | TODO: Add a parameter description |
| applicationId |  ``` Required ```  | TODO: Add a parameter description |
| metricName |  ``` Required ```  | TODO: Add a parameter description |
| since |  ``` Required ```  | TODO: Add a parameter description |
| granularity |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| period |  ``` Optional ```  | TODO: Add a parameter description |
| until |  ``` Optional ```  | TODO: Add a parameter description |
| timezone |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| skipChange |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var format = FormatEnumHelper.ParseString("json");
string accessToken = "access_token";
int applicationId = 21;
string metricName = "metric_name";
string since = "since";
var granularity = GranularityEnumHelper.ParseString("month");
var period = PeriodEnum?Helper.ParseString("year");
string until = "until";
var timezone = TimezoneEnum?Helper.ParseString("UTC");
bool? skipChange = false;

dynamic result = await applicationOps.GetStatsApplicationsUsageByApplicationId(format, accessToken, applicationId, metricName, since, granularity, period, until, timezone, skipChange);

```


[Back to List of Controllers](#list_of_controllers)



