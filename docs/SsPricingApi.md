# IO.Swagger.Api.SsPricingApi

All URIs are relative to *https://api.saas4saas.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomerBillClose**](SsPricingApi.md#customerbillclose) | **GET** /s4s-pricing/customer/{customer-id}/bill/{customer-bill-id}/close | 
[**CustomerBillGet**](SsPricingApi.md#customerbillget) | **GET** /s4s-pricing/customer/{customer-id}/bill/{customer-bill-id} | 
[**CustomerBillInitGet**](SsPricingApi.md#customerbillinitget) | **GET** /s4s-pricing/customer/{customer-id}/bill/init | 
[**CustomerBillInitPost**](SsPricingApi.md#customerbillinitpost) | **GET** /s4s-pricing/customer/{customer-id}/bill/initPost | 
[**CustomerBillOrGet**](SsPricingApi.md#customerbillorget) | **GET** /s4s-pricing/customer/{customer-id}/bill/or | 
[**CustomerBillValues**](SsPricingApi.md#customerbillvalues) | **GET** /s4s-pricing/customer/{customer-id}/bill/values | 
[**CustomerHistoryPlanValues**](SsPricingApi.md#customerhistoryplanvalues) | **GET** /s4s-pricing/customer/{customer-id}/history/plan/values | 
[**CustomerPlanAdd**](SsPricingApi.md#customerplanadd) | **POST** /s4s-pricing/customer/{customer-id}/plan | 
[**CustomerPlanAddCheck**](SsPricingApi.md#customerplanaddcheck) | **POST** /s4s-pricing/customer/{customer-id}/plan/addCheck | 
[**CustomerPlanClose**](SsPricingApi.md#customerplanclose) | **GET** /s4s-pricing/customer/{customer-id}/plan/{customer-plan-id}/close | 
[**CustomerPlanFamily**](SsPricingApi.md#customerplanfamily) | **GET** /s4s-pricing/customer/{customer-id}/plan/family | 
[**CustomerPlanGet**](SsPricingApi.md#customerplanget) | **GET** /s4s-pricing/customer/{customer-id}/plan/{customer-plan-id} | 
[**CustomerPlanGetAll**](SsPricingApi.md#customerplangetall) | **GET** /s4s-pricing/customer/{customer-id}/plan | 
[**CustomerPlanPay**](SsPricingApi.md#customerplanpay) | **GET** /s4s-pricing/customer/{customer-id}/plan/pay | 
[**CustomerPlanPlan**](SsPricingApi.md#customerplanplan) | **GET** /s4s-pricing/customer/{customer-id}/plan/plan | 
[**CustomerPlanValues**](SsPricingApi.md#customerplanvalues) | **GET** /s4s-pricing/customer/{customer-id}/plan/values | 
[**Pricing**](SsPricingApi.md#pricing) | **GET** /s4s-pricing/pricing | 
[**Pricing2**](SsPricingApi.md#pricing2) | **GET** /s4s-pricing/pricing2 | 
[**PricingConfigGet**](SsPricingApi.md#pricingconfigget) | **GET** /s4s-pricing/pricingConfig | 
[**PricingConfigPut**](SsPricingApi.md#pricingconfigput) | **PUT** /s4s-pricing/pricingConfig | 
[**PricingUiConf**](SsPricingApi.md#pricinguiconf) | **GET** /s4s-pricing/pricingUiConf | 
[**PricingUiConfigGet**](SsPricingApi.md#pricinguiconfigget) | **GET** /s4s-pricing/pricingUiConfig | 
[**PricingUiConfigPut**](SsPricingApi.md#pricinguiconfigput) | **PUT** /s4s-pricing/pricingUiConfig | 


<a name="customerbillclose"></a>
# **CustomerBillClose**
> CustomerBill CustomerBillClose (string customerId, string customerBillId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerBillCloseExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerBillId = customerBillId_example;  // string | 

            try
            {
                // 
                CustomerBill result = apiInstance.CustomerBillClose(customerId, customerBillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerBillClose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerBillId** | **string**|  | 

### Return type

[**CustomerBill**](CustomerBill.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerbillget"></a>
# **CustomerBillGet**
> CustomerBill CustomerBillGet (string customerId, string customerBillId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerBillGetExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerBillId = customerBillId_example;  // string | 

            try
            {
                // 
                CustomerBill result = apiInstance.CustomerBillGet(customerId, customerBillId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerBillGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerBillId** | **string**|  | 

### Return type

[**CustomerBill**](CustomerBill.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerbillinitget"></a>
# **CustomerBillInitGet**
> CustomerBill CustomerBillInitGet (string customerId, string billId, string customerPlanId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerBillInitGetExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var billId = billId_example;  // string | 
            var customerPlanId = customerPlanId_example;  // string | 

            try
            {
                // 
                CustomerBill result = apiInstance.CustomerBillInitGet(customerId, billId, customerPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerBillInitGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **billId** | **string**|  | 
 **customerPlanId** | **string**|  | 

### Return type

[**CustomerBill**](CustomerBill.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerbillinitpost"></a>
# **CustomerBillInitPost**
> CustomerBill CustomerBillInitPost (string customerId, string billId, string customerPlanId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerBillInitPostExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var billId = billId_example;  // string | 
            var customerPlanId = customerPlanId_example;  // string | 

            try
            {
                // 
                CustomerBill result = apiInstance.CustomerBillInitPost(customerId, billId, customerPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerBillInitPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **billId** | **string**|  | 
 **customerPlanId** | **string**|  | 

### Return type

[**CustomerBill**](CustomerBill.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerbillorget"></a>
# **CustomerBillOrGet**
> CustomerBill CustomerBillOrGet (string customerId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerBillOrGetExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 

            try
            {
                // 
                CustomerBill result = apiInstance.CustomerBillOrGet(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerBillOrGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 

### Return type

[**CustomerBill**](CustomerBill.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerbillvalues"></a>
# **CustomerBillValues**
> void CustomerBillValues (string customerId, int? page, int? numberPerPage)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerBillValuesExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 

            try
            {
                // 
                apiInstance.CustomerBillValues(customerId, page, numberPerPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerBillValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
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

<a name="customerhistoryplanvalues"></a>
# **CustomerHistoryPlanValues**
> void CustomerHistoryPlanValues (string customerId, int? page, int? numberPerPage)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerHistoryPlanValuesExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 

            try
            {
                // 
                apiInstance.CustomerHistoryPlanValues(customerId, page, numberPerPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerHistoryPlanValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
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

<a name="customerplanadd"></a>
# **CustomerPlanAdd**
> CustomerPlan CustomerPlanAdd (string customerId, CustomerPlan customerPlan = null)



Add a new Product to a Customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanAddExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerPlan = new CustomerPlan(); // CustomerPlan |  (optional) 

            try
            {
                // 
                CustomerPlan result = apiInstance.CustomerPlanAdd(customerId, customerPlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerPlan** | [**CustomerPlan**](CustomerPlan.md)|  | [optional] 

### Return type

[**CustomerPlan**](CustomerPlan.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanaddcheck"></a>
# **CustomerPlanAddCheck**
> CustomerPlan CustomerPlanAddCheck (string customerId, CustomerPlan customerPlan = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanAddCheckExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerPlan = new CustomerPlan(); // CustomerPlan |  (optional) 

            try
            {
                // 
                CustomerPlan result = apiInstance.CustomerPlanAddCheck(customerId, customerPlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanAddCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerPlan** | [**CustomerPlan**](CustomerPlan.md)|  | [optional] 

### Return type

[**CustomerPlan**](CustomerPlan.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanclose"></a>
# **CustomerPlanClose**
> string CustomerPlanClose (string customerId, string customerPlanId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanCloseExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerPlanId = customerPlanId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.CustomerPlanClose(customerId, customerPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanClose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerPlanId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanfamily"></a>
# **CustomerPlanFamily**
> CustomerPlan CustomerPlanFamily (string customerId, string family)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanFamilyExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var family = family_example;  // string | 

            try
            {
                // 
                CustomerPlan result = apiInstance.CustomerPlanFamily(customerId, family);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanFamily: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **family** | **string**|  | 

### Return type

[**CustomerPlan**](CustomerPlan.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanget"></a>
# **CustomerPlanGet**
> CustomerPlan CustomerPlanGet (string customerId, string customerPlanId)



Get a certain 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanGetExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerPlanId = customerPlanId_example;  // string | 

            try
            {
                // 
                CustomerPlan result = apiInstance.CustomerPlanGet(customerId, customerPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerPlanId** | **string**|  | 

### Return type

[**CustomerPlan**](CustomerPlan.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplangetall"></a>
# **CustomerPlanGetAll**
> List<string> CustomerPlanGetAll (string customerId)



Get all Products Customers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanGetAllExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 

            try
            {
                // 
                List&lt;string&gt; result = apiInstance.CustomerPlanGetAll(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 

### Return type

**List<string>**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanpay"></a>
# **CustomerPlanPay**
> string CustomerPlanPay (string customerId, string customerPlanId, string customerBillId, string whenPay)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanPayExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var customerPlanId = customerPlanId_example;  // string | 
            var customerBillId = customerBillId_example;  // string | 
            var whenPay = whenPay_example;  // string | 

            try
            {
                // 
                string result = apiInstance.CustomerPlanPay(customerId, customerPlanId, customerBillId, whenPay);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanPay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **customerPlanId** | **string**|  | 
 **customerBillId** | **string**|  | 
 **whenPay** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanplan"></a>
# **CustomerPlanPlan**
> Plan CustomerPlanPlan (string customerId, string planId)



Get all the actual customerPlanId for the planId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanPlanExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var planId = planId_example;  // string | 

            try
            {
                // 
                Plan result = apiInstance.CustomerPlanPlan(customerId, planId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
 **planId** | **string**|  | 

### Return type

[**Plan**](Plan.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customerplanvalues"></a>
# **CustomerPlanValues**
> void CustomerPlanValues (string customerId, int? page, int? numberPerPage)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomerPlanValuesExample
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

            var apiInstance = new SsPricingApi();
            var customerId = customerId_example;  // string | 
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 

            try
            {
                // 
                apiInstance.CustomerPlanValues(customerId, page, numberPerPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.CustomerPlanValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **string**|  | 
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

<a name="pricing"></a>
# **Pricing**
> PricingTableFull Pricing (string currency, string onlyPanId)



Get the actual pricing configuration, usefull for dynamic create a pricing table

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PricingExample
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

            var apiInstance = new SsPricingApi();
            var currency = currency_example;  // string | 
            var onlyPanId = onlyPanId_example;  // string | 

            try
            {
                // 
                PricingTableFull result = apiInstance.Pricing(currency, onlyPanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.Pricing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**|  | 
 **onlyPanId** | **string**|  | 

### Return type

[**PricingTableFull**](PricingTableFull.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricing2"></a>
# **Pricing2**
> PricingTable2Full Pricing2 (string currency, string onlyPanId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Pricing2Example
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

            var apiInstance = new SsPricingApi();
            var currency = currency_example;  // string | 
            var onlyPanId = onlyPanId_example;  // string | 

            try
            {
                // 
                PricingTable2Full result = apiInstance.Pricing2(currency, onlyPanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.Pricing2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**|  | 
 **onlyPanId** | **string**|  | 

### Return type

[**PricingTable2Full**](PricingTable2Full.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricingconfigget"></a>
# **PricingConfigGet**
> PricingConf PricingConfigGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PricingConfigGetExample
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

            var apiInstance = new SsPricingApi();

            try
            {
                // 
                PricingConf result = apiInstance.PricingConfigGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.PricingConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PricingConf**](PricingConf.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricingconfigput"></a>
# **PricingConfigPut**
> string PricingConfigPut (PricingConf a = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PricingConfigPutExample
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

            var apiInstance = new SsPricingApi();
            var a = new PricingConf(); // PricingConf |  (optional) 

            try
            {
                // 
                string result = apiInstance.PricingConfigPut(a);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.PricingConfigPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **a** | [**PricingConf**](PricingConf.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricinguiconf"></a>
# **PricingUiConf**
> PricingUiConf PricingUiConf ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PricingUiConfExample
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

            var apiInstance = new SsPricingApi();

            try
            {
                // 
                PricingUiConf result = apiInstance.PricingUiConf();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.PricingUiConf: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PricingUiConf**](PricingUiConf.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricinguiconfigget"></a>
# **PricingUiConfigGet**
> PricingUiConf PricingUiConfigGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PricingUiConfigGetExample
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

            var apiInstance = new SsPricingApi();

            try
            {
                // 
                PricingUiConf result = apiInstance.PricingUiConfigGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.PricingUiConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PricingUiConf**](PricingUiConf.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricinguiconfigput"></a>
# **PricingUiConfigPut**
> string PricingUiConfigPut (PricingUiConf a = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PricingUiConfigPutExample
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

            var apiInstance = new SsPricingApi();
            var a = new PricingUiConf(); // PricingUiConf |  (optional) 

            try
            {
                // 
                string result = apiInstance.PricingUiConfigPut(a);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsPricingApi.PricingUiConfigPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **a** | [**PricingUiConf**](PricingUiConf.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

