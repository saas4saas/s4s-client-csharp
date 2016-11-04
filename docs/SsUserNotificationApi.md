# IO.Swagger.Api.SsUserNotificationApi

All URIs are relative to *https://api.saas4saas.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OperatorConf**](SsUserNotificationApi.md#operatorconf) | **GET** /s4s-user-notification/operator/conf/{notification-key} | 
[**OperatorSend**](SsUserNotificationApi.md#operatorsend) | **GET** /s4s-user-notification/operator/send/{notification-key} | 
[**OperatorSendEmail**](SsUserNotificationApi.md#operatorsendemail) | **POST** /s4s-user-notification/operator/sendEmail | 
[**UserSend**](SsUserNotificationApi.md#usersend) | **GET** /s4s-user-notification/user/send/{notification-key} | 
[**UserSendEmail**](SsUserNotificationApi.md#usersendemail) | **POST** /s4s-user-notification/user/sendEmail | 


<a name="operatorconf"></a>
# **OperatorConf**
> OperatorConfiguration OperatorConf (string notificationKey)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OperatorConfExample
    {
        public void main()
        {
            
            // Configure API key authorization: tenantid
            Configuration.Default.ApiKey.Add("tenantid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("tenantid", "Bearer");
            // Configure API key authorization: token
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SsUserNotificationApi();
            var notificationKey = notificationKey_example;  // string | 

            try
            {
                // 
                OperatorConfiguration result = apiInstance.OperatorConf(notificationKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserNotificationApi.OperatorConf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationKey** | **string**|  | 

### Return type

[**OperatorConfiguration**](OperatorConfiguration.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="operatorsend"></a>
# **OperatorSend**
> string OperatorSend (string notificationKey)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OperatorSendExample
    {
        public void main()
        {
            
            // Configure API key authorization: tenantid
            Configuration.Default.ApiKey.Add("tenantid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("tenantid", "Bearer");
            // Configure API key authorization: token
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SsUserNotificationApi();
            var notificationKey = notificationKey_example;  // string | 

            try
            {
                // 
                string result = apiInstance.OperatorSend(notificationKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserNotificationApi.OperatorSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationKey** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="operatorsendemail"></a>
# **OperatorSendEmail**
> string OperatorSendEmail (string notificationKey, Email email = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OperatorSendEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: tenantid
            Configuration.Default.ApiKey.Add("tenantid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("tenantid", "Bearer");
            // Configure API key authorization: token
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SsUserNotificationApi();
            var notificationKey = notificationKey_example;  // string | 
            var email = new Email(); // Email |  (optional) 

            try
            {
                // 
                string result = apiInstance.OperatorSendEmail(notificationKey, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserNotificationApi.OperatorSendEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationKey** | **string**|  | 
 **email** | [**Email**](Email.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersend"></a>
# **UserSend**
> string UserSend (string userId, string notificationKey)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSendExample
    {
        public void main()
        {
            
            // Configure API key authorization: tenantid
            Configuration.Default.ApiKey.Add("tenantid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("tenantid", "Bearer");
            // Configure API key authorization: token
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SsUserNotificationApi();
            var userId = userId_example;  // string | 
            var notificationKey = notificationKey_example;  // string | 

            try
            {
                // 
                string result = apiInstance.UserSend(userId, notificationKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserNotificationApi.UserSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **notificationKey** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersendemail"></a>
# **UserSendEmail**
> string UserSendEmail (string userId, Email email = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserSendEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: tenantid
            Configuration.Default.ApiKey.Add("tenantid", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("tenantid", "Bearer");
            // Configure API key authorization: token
            Configuration.Default.ApiKey.Add("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("token", "Bearer");

            var apiInstance = new SsUserNotificationApi();
            var userId = userId_example;  // string | 
            var email = new Email(); // Email |  (optional) 

            try
            {
                // 
                string result = apiInstance.UserSendEmail(userId, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserNotificationApi.UserSendEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **email** | [**Email**](Email.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

