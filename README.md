[![NuGet](https://img.shields.io/nuget/v/Pawotter.NetworkActivityManager.svg)](https://www.nuget.org/packages/Pawotter.NetworkActivityManager) [![License](https://img.shields.io/cocoapods/l/BadgeSwift.svg?style=flat)](/LICENSE)

NetworkActivityManager
===

This is a a Network Activity Indicator Manager for Xamarin.iOS projects.

### Lisence

MIT


### Install

Install from NuGet.

```
> Install-Package Pawotter.NetworkActivityManger
```


### Usage

```csharp
NetworkActivityManger.Instance.Attach();
// activity_count = 1, UIApplication#NetworkActivityIndicatorVisible = true

NetworkActivityManger.Instance.Attach();
// activity_count = 2, UIApplication#NetworkActivityIndicatorVisible = true

NetworkActivityManger.Instance.Detach();
// activity_count = 1, UIApplication#NetworkActivityIndicatorVisible = true

NetworkActivityManger.Instance.Detach();
// activity_count = 0, UIApplication#NetworkActivityIndicatorVisible = false

NetworkActivityManger.Instance.Detach();
// activity_count = 0, UIApplication#NetworkActivityIndicatorVisible = false
```


### Usage (with System.Net.HttpClient)

```csharp
var httpClient = new HttpClient(new HttpNetworkActivityDelegatingHandler());
```

