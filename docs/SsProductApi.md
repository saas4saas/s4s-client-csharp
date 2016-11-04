# IO.Swagger.Api.SsProductApi

All URIs are relative to *https://api.saas4saas.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomerEnjoyAdd**](SsProductApi.md#customerenjoyadd) | **POST** /s4s-product/customer/{customer-id}/enjoy | 
[**CustomerEnjoyClose**](SsProductApi.md#customerenjoyclose) | **GET** /s4s-product/customer/{customer-id}/enjoy/{enjoy-id}/close | 
[**CustomerEnjoyGet**](SsProductApi.md#customerenjoyget) | **GET** /s4s-product/customer/{customer-id}/enjoy/{enjoy-id} | 
[**CustomerEnjoyGetAll**](SsProductApi.md#customerenjoygetall) | **GET** /s4s-product/customer/{customer-id}/enjoy | 
[**CustomerEnjoySpend**](SsProductApi.md#customerenjoyspend) | **GET** /s4s-product/customer/{customer-id}/enjoy/{customer-pack-id}/spend | 
[**CustomerEnjoyValues**](SsProductApi.md#customerenjoyvalues) | **GET** /s4s-product/customer/{customer-id}/enjoy/values | 
[**CustomerHistoryPackGet**](SsProductApi.md#customerhistorypackget) | **GET** /s4s-product/customer/{customer-id}/history/pack/{id} | 
[**CustomerHistoryPackGetAll**](SsProductApi.md#customerhistorypackgetall) | **GET** /s4s-product/customer/{customer-id}/history/pack | 
[**CustomerHistoryPackValues**](SsProductApi.md#customerhistorypackvalues) | **GET** /s4s-product/customer/{customer-id}/history/pack/values | 
[**CustomerHistorySubscriptionGet**](SsProductApi.md#customerhistorysubscriptionget) | **GET** /s4s-product/customer/{customer-id}/history/subscription/{id} | 
[**CustomerHistorySubscriptionGetAll**](SsProductApi.md#customerhistorysubscriptiongetall) | **GET** /s4s-product/customer/{customer-id}/history/subscription | 
[**CustomerHistorySubscriptionValues**](SsProductApi.md#customerhistorysubscriptionvalues) | **GET** /s4s-product/customer/{customer-id}/history/subscription/values | 
[**CustomerResource**](SsProductApi.md#customerresource) | **GET** /s4s-product/customer/{customer-id}/resource | 
[**CustomerSubscriptionAdd**](SsProductApi.md#customersubscriptionadd) | **POST** /s4s-product/customer/{customer-id}/subscription | 
[**CustomerSubscriptionClose**](SsProductApi.md#customersubscriptionclose) | **GET** /s4s-product/customer/{customer-id}/subscription/{subscription-id}/close | 
[**CustomerSubscriptionGet**](SsProductApi.md#customersubscriptionget) | **GET** /s4s-product/customer/{customer-id}/subscription/{subscription-id} | 
[**CustomerSubscriptionGetAll**](SsProductApi.md#customersubscriptiongetall) | **GET** /s4s-product/customer/{customer-id}/subscription | 
[**CustomerSubscriptionRenew**](SsProductApi.md#customersubscriptionrenew) | **GET** /s4s-product/customer/{customer-id}/subscription/{subscription-id}/renew | 
[**CustomerSubscriptionSpend**](SsProductApi.md#customersubscriptionspend) | **GET** /s4s-product/customer/{customer-id}/subscription/{customer-subscription-id}/spend | 
[**CustomerSubscriptionValues**](SsProductApi.md#customersubscriptionvalues) | **GET** /s4s-product/customer/{customer-id}/subscription/values | 
[**ProductConfigGet**](SsProductApi.md#productconfigget) | **GET** /s4s-product/productConfig | 
[**ProductConfigPut**](SsProductApi.md#productconfigput) | **PUT** /s4s-product/productConfig | 


<a name="customerenjoyadd"></a>
# **CustomerEnjoyAdd**
> CustomerPack CustomerEnjoyAdd (string customerId, long? expirationOffset, string overrideEnjoyId, string overrideSubscriptionId, CustomerPack newEnjoy = null)



Relationate a new product with the customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerEnjoyAddExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var expirationOffset = 789;  // long? | 
            var overrideEnjoyId = overrideEnjoyId_example;  // string | 
            var overrideSubscriptionId = overrideSubscriptionId_example;  // string | 
            var newEnjoy = new CustomerPack(); // CustomerPack |  (optional) 

            try
            {
                // 
                CustomerPack result = apiInstance.CustomerEnjoyAdd(customerId, expirationOffset, overrideEnjoyId, overrideSubscriptionId, newEnjoy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerEnjoyAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **expirationOffset** | **long?**|  | 
 **overrideEnjoyId** | **string**|  | 
 **overrideSubscriptionId** | **string**|  | 
 **newEnjoy** | [**CustomerPack**](CustomerPack.md)|  | [optional] 

### Return type

[**CustomerPack**](CustomerPack.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerenjoyclose"></a>
# **CustomerEnjoyClose**
> CustomerPack CustomerEnjoyClose (string customerId, string enjoyId)



Will close the enjoyId product, an create the the a new equivalent EnjoyProduct. Only refreshing the limits if its need

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerEnjoyCloseExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var enjoyId = enjoyId_example;  // string | 

            try
            {
                // 
                CustomerPack result = apiInstance.CustomerEnjoyClose(customerId, enjoyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerEnjoyClose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **enjoyId** | **string**|  | 

### Return type

[**CustomerPack**](CustomerPack.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerenjoyget"></a>
# **CustomerEnjoyGet**
> CustomerPack CustomerEnjoyGet (string customerId, string enjoyId)



Get a certain product releated to customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerEnjoyGetExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var enjoyId = enjoyId_example;  // string | 

            try
            {
                // 
                CustomerPack result = apiInstance.CustomerEnjoyGet(customerId, enjoyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerEnjoyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **enjoyId** | **string**|  | 

### Return type

[**CustomerPack**](CustomerPack.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerenjoygetall"></a>
# **CustomerEnjoyGetAll**
> List<string> CustomerEnjoyGetAll (string customerId)



Get all the current products relationed with the customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerEnjoyGetAllExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service

            try
            {
                // 
                List&lt;string&gt; result = apiInstance.CustomerEnjoyGetAll(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerEnjoyGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 

### Return type

**List<string>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerenjoyspend"></a>
# **CustomerEnjoySpend**
> Dictionary<string, long?> CustomerEnjoySpend (string customerId, string customerPackId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerEnjoySpendExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var customerPackId = customerPackId_example;  // string | 

            try
            {
                // 
                Dictionary&lt;string, long?&gt; result = apiInstance.CustomerEnjoySpend(customerId, customerPackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerEnjoySpend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **customerPackId** | **string**|  | 

### Return type

**Dictionary<string, long?>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerenjoyvalues"></a>
# **CustomerEnjoyValues**
> void CustomerEnjoyValues (string customerId, int? page, int? numberPerPage, bool? loadResourceStatusList)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerEnjoyValuesExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 
            var loadResourceStatusList = true;  // bool? | 

            try
            {
                // 
                apiInstance.CustomerEnjoyValues(customerId, page, numberPerPage, loadResourceStatusList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerEnjoyValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **page** | **int?**|  | 
 **numberPerPage** | **int?**|  | 
 **loadResourceStatusList** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerhistorypackget"></a>
# **CustomerHistoryPackGet**
> CustomerPack CustomerHistoryPackGet (string customerId, string id)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistoryPackGetExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var id = id_example;  // string | 

            try
            {
                // 
                CustomerPack result = apiInstance.CustomerHistoryPackGet(customerId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerHistoryPackGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **id** | **string**|  | 

### Return type

[**CustomerPack**](CustomerPack.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerhistorypackgetall"></a>
# **CustomerHistoryPackGetAll**
> List<string> CustomerHistoryPackGetAll (string customerId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistoryPackGetAllExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service

            try
            {
                // 
                List&lt;string&gt; result = apiInstance.CustomerHistoryPackGetAll(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerHistoryPackGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 

### Return type

**List<string>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerhistorypackvalues"></a>
# **CustomerHistoryPackValues**
> void CustomerHistoryPackValues (string customerId, int? page, int? numberPerPage, bool? loadResourceStatusList)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistoryPackValuesExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 
            var loadResourceStatusList = true;  // bool? | 

            try
            {
                // 
                apiInstance.CustomerHistoryPackValues(customerId, page, numberPerPage, loadResourceStatusList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerHistoryPackValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **page** | **int?**|  | 
 **numberPerPage** | **int?**|  | 
 **loadResourceStatusList** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerhistorysubscriptionget"></a>
# **CustomerHistorySubscriptionGet**
> CustomerPack CustomerHistorySubscriptionGet (string customerId, string id)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistorySubscriptionGetExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var id = id_example;  // string | 

            try
            {
                // 
                CustomerPack result = apiInstance.CustomerHistorySubscriptionGet(customerId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerHistorySubscriptionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **id** | **string**|  | 

### Return type

[**CustomerPack**](CustomerPack.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerhistorysubscriptiongetall"></a>
# **CustomerHistorySubscriptionGetAll**
> List<string> CustomerHistorySubscriptionGetAll (string customerId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistorySubscriptionGetAllExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service

            try
            {
                // 
                List&lt;string&gt; result = apiInstance.CustomerHistorySubscriptionGetAll(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerHistorySubscriptionGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 

### Return type

**List<string>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerhistorysubscriptionvalues"></a>
# **CustomerHistorySubscriptionValues**
> void CustomerHistorySubscriptionValues (string customerId, int? page, int? numberPerPage, bool? loadResourceStatusList)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistorySubscriptionValuesExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 
            var loadResourceStatusList = true;  // bool? | 

            try
            {
                // 
                apiInstance.CustomerHistorySubscriptionValues(customerId, page, numberPerPage, loadResourceStatusList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerHistorySubscriptionValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **page** | **int?**|  | 
 **numberPerPage** | **int?**|  | 
 **loadResourceStatusList** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerresource"></a>
# **CustomerResource**
> void CustomerResource (string customerId, int? page, int? numberPerPage)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerResourceExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 

            try
            {
                // 
                apiInstance.CustomerResource(customerId, page, numberPerPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **page** | **int?**|  | 
 **numberPerPage** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptionadd"></a>
# **CustomerSubscriptionAdd**
> CustomerPackSubscription CustomerSubscriptionAdd (string customerId, string overrideSubscriptionId, string overrideEnjoyId, CustomerPackSubscription newSubscription = null)



Add a new subscription to customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionAddExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var overrideSubscriptionId = overrideSubscriptionId_example;  // string | 
            var overrideEnjoyId = overrideEnjoyId_example;  // string | 
            var newSubscription = new CustomerPackSubscription(); // CustomerPackSubscription |  (optional) 

            try
            {
                // 
                CustomerPackSubscription result = apiInstance.CustomerSubscriptionAdd(customerId, overrideSubscriptionId, overrideEnjoyId, newSubscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **overrideSubscriptionId** | **string**|  | 
 **overrideEnjoyId** | **string**|  | 
 **newSubscription** | [**CustomerPackSubscription**](CustomerPackSubscription.md)|  | [optional] 

### Return type

[**CustomerPackSubscription**](CustomerPackSubscription.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptionclose"></a>
# **CustomerSubscriptionClose**
> string CustomerSubscriptionClose (string customerId, string subscriptionId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionCloseExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var subscriptionId = subscriptionId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.CustomerSubscriptionClose(customerId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionClose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **subscriptionId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptionget"></a>
# **CustomerSubscriptionGet**
> CustomerPackSubscription CustomerSubscriptionGet (string customerId, string subscriptionId)



Get a subscription by its Ids

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionGetExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var subscriptionId = subscriptionId_example;  // string | 

            try
            {
                // 
                CustomerPackSubscription result = apiInstance.CustomerSubscriptionGet(customerId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **subscriptionId** | **string**|  | 

### Return type

[**CustomerPackSubscription**](CustomerPackSubscription.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptiongetall"></a>
# **CustomerSubscriptionGetAll**
> List<string> CustomerSubscriptionGetAll (string customerId)



Get all the current subscriptions of a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionGetAllExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service

            try
            {
                // 
                List&lt;string&gt; result = apiInstance.CustomerSubscriptionGetAll(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 

### Return type

**List<string>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptionrenew"></a>
# **CustomerSubscriptionRenew**
> string CustomerSubscriptionRenew (string customerId, string subscriptionId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionRenewExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var subscriptionId = subscriptionId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.CustomerSubscriptionRenew(customerId, subscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionRenew: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **subscriptionId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptionspend"></a>
# **CustomerSubscriptionSpend**
> Dictionary<string, long?> CustomerSubscriptionSpend (string customerId, string customerSubscriptionId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionSpendExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var customerSubscriptionId = customerSubscriptionId_example;  // string | 

            try
            {
                // 
                Dictionary&lt;string, long?&gt; result = apiInstance.CustomerSubscriptionSpend(customerId, customerSubscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionSpend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **customerSubscriptionId** | **string**|  | 

### Return type

**Dictionary<string, long?>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customersubscriptionvalues"></a>
# **CustomerSubscriptionValues**
> void CustomerSubscriptionValues (string customerId, int? page, int? numberPerPage, bool? loadDefaultUser)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerSubscriptionValuesExample
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

            var apiInstance = new SsProductApi();
            var customerId = customerId_example;  // string | The given id from the user service
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 
            var loadDefaultUser = true;  // bool? | 

            try
            {
                // 
                apiInstance.CustomerSubscriptionValues(customerId, page, numberPerPage, loadDefaultUser);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.CustomerSubscriptionValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**| The given id from the user service | 
 **page** | **int?**|  | 
 **numberPerPage** | **int?**|  | 
 **loadDefaultUser** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productconfigget"></a>
# **ProductConfigGet**
> ProductConf ProductConfigGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductConfigGetExample
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

            var apiInstance = new SsProductApi();

            try
            {
                // 
                ProductConf result = apiInstance.ProductConfigGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.ProductConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProductConf**](ProductConf.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productconfigput"></a>
# **ProductConfigPut**
> string ProductConfigPut (ProductConf a = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductConfigPutExample
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

            var apiInstance = new SsProductApi();
            var a = new ProductConf(); // ProductConf |  (optional) 

            try
            {
                // 
                string result = apiInstance.ProductConfigPut(a);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsProductApi.ProductConfigPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **a** | [**ProductConf**](ProductConf.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

