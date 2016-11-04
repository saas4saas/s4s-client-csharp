# IO.Swagger.Api.SsResourceApi

All URIs are relative to *https://api.saas4saas.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomerResourceGet**](SsResourceApi.md#customerresourceget) | **GET** /s4s-resource/customer/{customer-id}/resource/{resourceid} | 
[**CustomerResourceLimitGet**](SsResourceApi.md#customerresourcelimitget) | **GET** /s4s-resource/customer/{customer-id}/resource/{resourceid}/limit | 
[**CustomerResourcePatch**](SsResourceApi.md#customerresourcepatch) | **PATCH** /s4s-resource/customer/{customer-id}/resource/{resourceid} | 
[**CustomerResourceProductGet**](SsResourceApi.md#customerresourceproductget) | **GET** /s4s-resource/customer/{customer-id}/resource/{resourceid}/product/{customer-product-id} | 
[**CustomerResourceProductLimitGet**](SsResourceApi.md#customerresourceproductlimitget) | **GET** /s4s-resource/customer/{customer-id}/resource/{resourceid}/product/{customer-product-id}/limit | 


<a name="customerresourceget"></a>
# **CustomerResourceGet**
> long? CustomerResourceGet (string customerId, string resourceid)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerResourceGetExample
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

            var apiInstance = new SsResourceApi();
            var customerId = customerId_example;  // string | 
            var resourceid = resourceid_example;  // string | 

            try
            {
                // 
                long? result = apiInstance.CustomerResourceGet(customerId, resourceid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsResourceApi.CustomerResourceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **resourceid** | **string**|  | 

### Return type

**long?**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerresourcelimitget"></a>
# **CustomerResourceLimitGet**
> long? CustomerResourceLimitGet (string customerId, string resourceid)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerResourceLimitGetExample
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

            var apiInstance = new SsResourceApi();
            var customerId = customerId_example;  // string | 
            var resourceid = resourceid_example;  // string | 

            try
            {
                // 
                long? result = apiInstance.CustomerResourceLimitGet(customerId, resourceid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsResourceApi.CustomerResourceLimitGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **resourceid** | **string**|  | 

### Return type

**long?**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerresourcepatch"></a>
# **CustomerResourcePatch**
> ResourcePatchResult CustomerResourcePatch (string customerId, string resourceid, ResourcePatch value = null)



Updates a resource of a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerResourcePatchExample
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

            var apiInstance = new SsResourceApi();
            var customerId = customerId_example;  // string | 
            var resourceid = resourceid_example;  // string | 
            var value = new ResourcePatch(); // ResourcePatch | The Operation and value to update the resource (optional) 

            try
            {
                // 
                ResourcePatchResult result = apiInstance.CustomerResourcePatch(customerId, resourceid, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsResourceApi.CustomerResourcePatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **resourceid** | **string**|  | 
 **value** | [**ResourcePatch**](ResourcePatch.md)| The Operation and value to update the resource | [optional] 

### Return type

[**ResourcePatchResult**](ResourcePatchResult.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerresourceproductget"></a>
# **CustomerResourceProductGet**
> long? CustomerResourceProductGet (string customerId, string resourceid, string customerProductId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerResourceProductGetExample
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

            var apiInstance = new SsResourceApi();
            var customerId = customerId_example;  // string | 
            var resourceid = resourceid_example;  // string | 
            var customerProductId = customerProductId_example;  // string | 

            try
            {
                // 
                long? result = apiInstance.CustomerResourceProductGet(customerId, resourceid, customerProductId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsResourceApi.CustomerResourceProductGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **resourceid** | **string**|  | 
 **customerProductId** | **string**|  | 

### Return type

**long?**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerresourceproductlimitget"></a>
# **CustomerResourceProductLimitGet**
> long? CustomerResourceProductLimitGet (string customerId, string resourceid, string customerProductId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerResourceProductLimitGetExample
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

            var apiInstance = new SsResourceApi();
            var customerId = customerId_example;  // string | 
            var resourceid = resourceid_example;  // string | 
            var customerProductId = customerProductId_example;  // string | 

            try
            {
                // 
                long? result = apiInstance.CustomerResourceProductLimitGet(customerId, resourceid, customerProductId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsResourceApi.CustomerResourceProductLimitGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **resourceid** | **string**|  | 
 **customerProductId** | **string**|  | 

### Return type

**long?**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

