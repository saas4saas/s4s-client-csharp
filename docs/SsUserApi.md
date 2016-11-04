# IO.Swagger.Api.SsUserApi

All URIs are relative to *https://api.saas4saas.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountAdd**](SsUserApi.md#accountadd) | **POST** /s4s-user/account | 
[**AccountAutoLogin**](SsUserApi.md#accountautologin) | **GET** /s4s-user/account/autoLogin | 
[**AccountChangePasswordPatch**](SsUserApi.md#accountchangepasswordpatch) | **PATCH** /s4s-user/account/changePassword | 
[**AccountGetAll**](SsUserApi.md#accountgetall) | **GET** /s4s-user/account | 
[**AccountIdGet**](SsUserApi.md#accountidget) | **GET** /s4s-user/account/{account-id} | 
[**AccountIdKeysAdd**](SsUserApi.md#accountidkeysadd) | **POST** /s4s-user/account/{account-id}/keys | 
[**AccountIdKeysDel**](SsUserApi.md#accountidkeysdel) | **DELETE** /s4s-user/account/{account-id}/keys/{user-id} | 
[**AccountIdKeysGetAll**](SsUserApi.md#accountidkeysgetall) | **GET** /s4s-user/account/{account-id}/keys | 
[**AccountIdPrivateDataPut**](SsUserApi.md#accountidprivatedataput) | **PUT** /s4s-user/account/{account-id}/privateData | 
[**AccountIdPut**](SsUserApi.md#accountidput) | **PUT** /s4s-user/account/{account-id} | 
[**AccountIdStatusPut**](SsUserApi.md#accountidstatusput) | **PUT** /s4s-user/account/{account-id}/status | 
[**AccountIdUserAdd**](SsUserApi.md#accountiduseradd) | **POST** /s4s-user/account/{account-id}/user | 
[**AccountIdUserChangePwdToken**](SsUserApi.md#accountiduserchangepwdtoken) | **GET** /s4s-user/account/{account-id}/user/{user-id}/changePwdToken | 
[**AccountIdUserGet**](SsUserApi.md#accountiduserget) | **GET** /s4s-user/account/{account-id}/user/{user-id} | 
[**AccountIdUserLogin**](SsUserApi.md#accountiduserlogin) | **GET** /s4s-user/account/{account-id}/user/{user-id}/login | 
[**AccountIdUserPut**](SsUserApi.md#accountiduserput) | **PUT** /s4s-user/account/{account-id}/user/{user-id} | 
[**AccountIdUserResendEmailConfirmation**](SsUserApi.md#accountiduserresendemailconfirmation) | **GET** /s4s-user/account/{account-id}/user/{user-id}/resendEmailConfirmation | 
[**AccountLogin**](SsUserApi.md#accountlogin) | **POST** /s4s-user/account/login | 
[**AccountLoginOrAdd**](SsUserApi.md#accountloginoradd) | **POST** /s4s-user/account/loginOr | 
[**AccountRecover**](SsUserApi.md#accountrecover) | **POST** /s4s-user/account/recover | 
[**AccountUserChangePwdToken**](SsUserApi.md#accountuserchangepwdtoken) | **GET** /s4s-user/account/user/{user-id}/changePwdToken | 
[**AccountUserGet**](SsUserApi.md#accountuserget) | **GET** /s4s-user/account/user/{user-id} | 
[**AccountUserLogin**](SsUserApi.md#accountuserlogin) | **GET** /s4s-user/account/user/{user-id}/login | 
[**AccountUserPut**](SsUserApi.md#accountuserput) | **PUT** /s4s-user/account/user/{user-id} | 
[**AccountUserResendEmailConfirmation**](SsUserApi.md#accountuserresendemailconfirmation) | **GET** /s4s-user/account/user/{user-id}/resendEmailConfirmation | 
[**AccountUsernameChangePwdToken**](SsUserApi.md#accountusernamechangepwdtoken) | **GET** /s4s-user/account/username/changePwdToken | 
[**AccountUsernameGet**](SsUserApi.md#accountusernameget) | **GET** /s4s-user/account/username | 
[**AccountUsernameLogin**](SsUserApi.md#accountusernamelogin) | **GET** /s4s-user/account/username/login | 
[**AccountUsernamePut**](SsUserApi.md#accountusernameput) | **PUT** /s4s-user/account/username | 
[**AccountUsernameResendEmailConfirmation**](SsUserApi.md#accountusernameresendemailconfirmation) | **GET** /s4s-user/account/username/resendEmailConfirmation | 
[**Authenticate**](SsUserApi.md#authenticate) | **GET** /s4s-user/authenticate | 
[**Config**](SsUserApi.md#config) | **GET** /s4s-user/config | 
[**GoogleLogin**](SsUserApi.md#googlelogin) | **POST** /s4s-user/googleLogin | 
[**HtmlConf**](SsUserApi.md#htmlconf) | **GET** /s4s-user/htmlConf | 
[**SelfAccountGet**](SsUserApi.md#selfaccountget) | **GET** /s4s-user/selfAccount | 
[**SelfAccountKeysAdd**](SsUserApi.md#selfaccountkeysadd) | **POST** /s4s-user/selfAccount/keys | 
[**SelfAccountKeysDel**](SsUserApi.md#selfaccountkeysdel) | **DELETE** /s4s-user/selfAccount/keys/{user-id} | 
[**SelfAccountKeysGetAll**](SsUserApi.md#selfaccountkeysgetall) | **GET** /s4s-user/selfAccount/keys | 
[**SelfAccountPrivateDataPut**](SsUserApi.md#selfaccountprivatedataput) | **PUT** /s4s-user/selfAccount/privateData | 
[**SelfAccountPut**](SsUserApi.md#selfaccountput) | **PUT** /s4s-user/selfAccount | 
[**SelfAccountStatusPut**](SsUserApi.md#selfaccountstatusput) | **PUT** /s4s-user/selfAccount/status | 
[**SelfAccountUserAdd**](SsUserApi.md#selfaccountuseradd) | **POST** /s4s-user/selfAccount/user | 
[**SelfAccountUserChangePwdToken**](SsUserApi.md#selfaccountuserchangepwdtoken) | **GET** /s4s-user/selfAccount/user/{user-id}/changePwdToken | 
[**SelfAccountUserGet**](SsUserApi.md#selfaccountuserget) | **GET** /s4s-user/selfAccount/user/{user-id} | 
[**SelfAccountUserLogin**](SsUserApi.md#selfaccountuserlogin) | **GET** /s4s-user/selfAccount/user/{user-id}/login | 
[**SelfAccountUserPut**](SsUserApi.md#selfaccountuserput) | **PUT** /s4s-user/selfAccount/user/{user-id} | 
[**SelfAccountUserResendEmailConfirmation**](SsUserApi.md#selfaccountuserresendemailconfirmation) | **GET** /s4s-user/selfAccount/user/{user-id}/resendEmailConfirmation | 
[**SelfUserChangePwdToken**](SsUserApi.md#selfuserchangepwdtoken) | **GET** /s4s-user/selfUser/changePwdToken | 
[**SelfUserGet**](SsUserApi.md#selfuserget) | **GET** /s4s-user/selfUser | 
[**SelfUserLogin**](SsUserApi.md#selfuserlogin) | **GET** /s4s-user/selfUser/login | 
[**SelfUserPut**](SsUserApi.md#selfuserput) | **PUT** /s4s-user/selfUser | 
[**SelfUserResendEmailConfirmation**](SsUserApi.md#selfuserresendemailconfirmation) | **GET** /s4s-user/selfUser/resendEmailConfirmation | 
[**UserConfigGet**](SsUserApi.md#userconfigget) | **GET** /s4s-user/userConfig | 
[**UserConfigPut**](SsUserApi.md#userconfigput) | **PUT** /s4s-user/userConfig | 
[**UserUiConfigGet**](SsUserApi.md#useruiconfigget) | **GET** /s4s-user/userUiConfig | 
[**UserUiConfigPut**](SsUserApi.md#useruiconfigput) | **PUT** /s4s-user/userUiConfig | 


<a name="accountadd"></a>
# **AccountAdd**
> Account AccountAdd (Account newAccount = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountAddExample
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

            var apiInstance = new SsUserApi();
            var newAccount = new Account(); // Account |  (optional) 

            try
            {
                // 
                Account result = apiInstance.AccountAdd(newAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newAccount** | [**Account**](Account.md)|  | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountautologin"></a>
# **AccountAutoLogin**
> Session AccountAutoLogin (string rememberMeToken)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountAutoLoginExample
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

            var apiInstance = new SsUserApi();
            var rememberMeToken = rememberMeToken_example;  // string | 

            try
            {
                // 
                Session result = apiInstance.AccountAutoLogin(rememberMeToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountAutoLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rememberMeToken** | **string**|  | 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountchangepasswordpatch"></a>
# **AccountChangePasswordPatch**
> string AccountChangePasswordPatch (string changePwdToken, EmailRecover recover = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountChangePasswordPatchExample
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

            var apiInstance = new SsUserApi();
            var changePwdToken = changePwdToken_example;  // string | 
            var recover = new EmailRecover(); // EmailRecover |  (optional) 

            try
            {
                // 
                string result = apiInstance.AccountChangePasswordPatch(changePwdToken, recover);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountChangePasswordPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changePwdToken** | **string**|  | 
 **recover** | [**EmailRecover**](EmailRecover.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountgetall"></a>
# **AccountGetAll**
> void AccountGetAll (int? page, int? numberPerPage, bool? loadDefaultUser)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountGetAllExample
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

            var apiInstance = new SsUserApi();
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 
            var loadDefaultUser = true;  // bool? | 

            try
            {
                // 
                apiInstance.AccountGetAll(page, numberPerPage, loadDefaultUser);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="accountidget"></a>
# **AccountIdGet**
> Account AccountIdGet (string accountId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdGetExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 

            try
            {
                // 
                Account result = apiInstance.AccountIdGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 

### Return type

[**Account**](Account.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountidkeysadd"></a>
# **AccountIdKeysAdd**
> UserApi AccountIdKeysAdd (string accountId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdKeysAddExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 

            try
            {
                // 
                UserApi result = apiInstance.AccountIdKeysAdd(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdKeysAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 

### Return type

[**UserApi**](UserApi.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountidkeysdel"></a>
# **AccountIdKeysDel**
> string AccountIdKeysDel (string accountId, string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdKeysDelExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountIdKeysDel(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdKeysDel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountidkeysgetall"></a>
# **AccountIdKeysGetAll**
> void AccountIdKeysGetAll (string accountId, int? page, int? numberPerPage)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdKeysGetAllExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 

            try
            {
                // 
                apiInstance.AccountIdKeysGetAll(accountId, page, numberPerPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdKeysGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
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

<a name="accountidprivatedataput"></a>
# **AccountIdPrivateDataPut**
> string AccountIdPrivateDataPut (string accountId, Object privateData = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdPrivateDataPutExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var privateData = ;  // Object |  (optional) 

            try
            {
                // 
                string result = apiInstance.AccountIdPrivateDataPut(accountId, privateData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdPrivateDataPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **privateData** | **Object**|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountidput"></a>
# **AccountIdPut**
> Account AccountIdPut (string accountId, Account newAccount = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdPutExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var newAccount = new Account(); // Account |  (optional) 

            try
            {
                // 
                Account result = apiInstance.AccountIdPut(accountId, newAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **newAccount** | [**Account**](Account.md)|  | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountidstatusput"></a>
# **AccountIdStatusPut**
> string AccountIdStatusPut (string accountId, string status)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdStatusPutExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var status = status_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountIdStatusPut(accountId, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdStatusPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **status** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountiduseradd"></a>
# **AccountIdUserAdd**
> User AccountIdUserAdd (string accountId, User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdUserAddExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.AccountIdUserAdd(accountId, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdUserAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountiduserchangepwdtoken"></a>
# **AccountIdUserChangePwdToken**
> string AccountIdUserChangePwdToken (string accountId, string userId, string currentPwd)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdUserChangePwdTokenExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var userId = userId_example;  // string | 
            var currentPwd = currentPwd_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountIdUserChangePwdToken(accountId, userId, currentPwd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdUserChangePwdToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **userId** | **string**|  | 
 **currentPwd** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountiduserget"></a>
# **AccountIdUserGet**
> User AccountIdUserGet (string accountId, string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdUserGetExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // 
                User result = apiInstance.AccountIdUserGet(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountiduserlogin"></a>
# **AccountIdUserLogin**
> Session AccountIdUserLogin (string accountId, string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdUserLoginExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // 
                Session result = apiInstance.AccountIdUserLogin(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdUserLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountiduserput"></a>
# **AccountIdUserPut**
> User AccountIdUserPut (string accountId, string userId, User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdUserPutExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var userId = userId_example;  // string | 
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.AccountIdUserPut(accountId, userId, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdUserPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **userId** | **string**|  | 
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountiduserresendemailconfirmation"></a>
# **AccountIdUserResendEmailConfirmation**
> string AccountIdUserResendEmailConfirmation (string accountId, string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountIdUserResendEmailConfirmationExample
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

            var apiInstance = new SsUserApi();
            var accountId = accountId_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountIdUserResendEmailConfirmation(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountIdUserResendEmailConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | 
 **userId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountlogin"></a>
# **AccountLogin**
> Session AccountLogin (Login login = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountLoginExample
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

            var apiInstance = new SsUserApi();
            var login = new Login(); // Login |  (optional) 

            try
            {
                // 
                Session result = apiInstance.AccountLogin(login);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **login** | [**Login**](Login.md)|  | [optional] 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountloginoradd"></a>
# **AccountLoginOrAdd**
> Session AccountLoginOrAdd (Account account = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountLoginOrAddExample
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

            var apiInstance = new SsUserApi();
            var account = new Account(); // Account |  (optional) 

            try
            {
                // 
                Session result = apiInstance.AccountLoginOrAdd(account);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountLoginOrAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | [**Account**](Account.md)|  | [optional] 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountrecover"></a>
# **AccountRecover**
> string AccountRecover (EmailRecover recover = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountRecoverExample
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

            var apiInstance = new SsUserApi();
            var recover = new EmailRecover(); // EmailRecover |  (optional) 

            try
            {
                // 
                string result = apiInstance.AccountRecover(recover);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountRecover: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recover** | [**EmailRecover**](EmailRecover.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuserchangepwdtoken"></a>
# **AccountUserChangePwdToken**
> string AccountUserChangePwdToken (string userId, string currentPwd)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUserChangePwdTokenExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 
            var currentPwd = currentPwd_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountUserChangePwdToken(userId, currentPwd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUserChangePwdToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **currentPwd** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuserget"></a>
# **AccountUserGet**
> User AccountUserGet (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUserGetExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                User result = apiInstance.AccountUserGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuserlogin"></a>
# **AccountUserLogin**
> Session AccountUserLogin (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUserLoginExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                Session result = apiInstance.AccountUserLogin(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUserLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuserput"></a>
# **AccountUserPut**
> User AccountUserPut (string userId, User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUserPutExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.AccountUserPut(userId, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUserPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountuserresendemailconfirmation"></a>
# **AccountUserResendEmailConfirmation**
> string AccountUserResendEmailConfirmation (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUserResendEmailConfirmationExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountUserResendEmailConfirmation(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUserResendEmailConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountusernamechangepwdtoken"></a>
# **AccountUsernameChangePwdToken**
> string AccountUsernameChangePwdToken (string usr, string currentPwd)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUsernameChangePwdTokenExample
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

            var apiInstance = new SsUserApi();
            var usr = usr_example;  // string | 
            var currentPwd = currentPwd_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountUsernameChangePwdToken(usr, currentPwd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUsernameChangePwdToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usr** | **string**|  | 
 **currentPwd** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountusernameget"></a>
# **AccountUsernameGet**
> User AccountUsernameGet (string usr)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUsernameGetExample
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

            var apiInstance = new SsUserApi();
            var usr = usr_example;  // string | 

            try
            {
                // 
                User result = apiInstance.AccountUsernameGet(usr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUsernameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usr** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountusernamelogin"></a>
# **AccountUsernameLogin**
> Session AccountUsernameLogin (string usr)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUsernameLoginExample
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

            var apiInstance = new SsUserApi();
            var usr = usr_example;  // string | 

            try
            {
                // 
                Session result = apiInstance.AccountUsernameLogin(usr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUsernameLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usr** | **string**|  | 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountusernameput"></a>
# **AccountUsernamePut**
> User AccountUsernamePut (string usr, User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUsernamePutExample
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

            var apiInstance = new SsUserApi();
            var usr = usr_example;  // string | 
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.AccountUsernamePut(usr, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUsernamePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usr** | **string**|  | 
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountusernameresendemailconfirmation"></a>
# **AccountUsernameResendEmailConfirmation**
> string AccountUsernameResendEmailConfirmation (string usr)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountUsernameResendEmailConfirmationExample
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

            var apiInstance = new SsUserApi();
            var usr = usr_example;  // string | 

            try
            {
                // 
                string result = apiInstance.AccountUsernameResendEmailConfirmation(usr);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.AccountUsernameResendEmailConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usr** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticate"></a>
# **Authenticate**
> UtUser Authenticate (string authtoken)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthenticateExample
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

            var apiInstance = new SsUserApi();
            var authtoken = authtoken_example;  // string | 

            try
            {
                // 
                UtUser result = apiInstance.Authenticate(authtoken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.Authenticate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authtoken** | **string**|  | 

### Return type

[**UtUser**](UtUser.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="config"></a>
# **Config**
> UserConfig Config ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                UserConfig result = apiInstance.Config();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.Config: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserConfig**](UserConfig.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="googlelogin"></a>
# **GoogleLogin**
> Session GoogleLogin (GoogleAuth google = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GoogleLoginExample
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

            var apiInstance = new SsUserApi();
            var google = new GoogleAuth(); // GoogleAuth |  (optional) 

            try
            {
                // 
                Session result = apiInstance.GoogleLogin(google);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.GoogleLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **google** | [**GoogleAuth**](GoogleAuth.md)|  | [optional] 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="htmlconf"></a>
# **HtmlConf**
> UserUiConf HtmlConf ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HtmlConfExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                UserUiConf result = apiInstance.HtmlConf();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.HtmlConf: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserUiConf**](UserUiConf.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountget"></a>
# **SelfAccountGet**
> Account SelfAccountGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountGetExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                Account result = apiInstance.SelfAccountGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Account**](Account.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountkeysadd"></a>
# **SelfAccountKeysAdd**
> UserApi SelfAccountKeysAdd ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountKeysAddExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                UserApi result = apiInstance.SelfAccountKeysAdd();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountKeysAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserApi**](UserApi.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountkeysdel"></a>
# **SelfAccountKeysDel**
> string SelfAccountKeysDel (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountKeysDelExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.SelfAccountKeysDel(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountKeysDel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountkeysgetall"></a>
# **SelfAccountKeysGetAll**
> void SelfAccountKeysGetAll (int? page, int? numberPerPage)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountKeysGetAllExample
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

            var apiInstance = new SsUserApi();
            var page = 56;  // int? | 
            var numberPerPage = 56;  // int? | 

            try
            {
                // 
                apiInstance.SelfAccountKeysGetAll(page, numberPerPage);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountKeysGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="selfaccountprivatedataput"></a>
# **SelfAccountPrivateDataPut**
> string SelfAccountPrivateDataPut (Object privateData = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountPrivateDataPutExample
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

            var apiInstance = new SsUserApi();
            var privateData = ;  // Object |  (optional) 

            try
            {
                // 
                string result = apiInstance.SelfAccountPrivateDataPut(privateData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountPrivateDataPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **privateData** | **Object**|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountput"></a>
# **SelfAccountPut**
> Account SelfAccountPut (Account newAccount = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountPutExample
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

            var apiInstance = new SsUserApi();
            var newAccount = new Account(); // Account |  (optional) 

            try
            {
                // 
                Account result = apiInstance.SelfAccountPut(newAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newAccount** | [**Account**](Account.md)|  | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountstatusput"></a>
# **SelfAccountStatusPut**
> string SelfAccountStatusPut (string status)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountStatusPutExample
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

            var apiInstance = new SsUserApi();
            var status = status_example;  // string | 

            try
            {
                // 
                string result = apiInstance.SelfAccountStatusPut(status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountStatusPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountuseradd"></a>
# **SelfAccountUserAdd**
> User SelfAccountUserAdd (User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountUserAddExample
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

            var apiInstance = new SsUserApi();
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.SelfAccountUserAdd(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountUserAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountuserchangepwdtoken"></a>
# **SelfAccountUserChangePwdToken**
> string SelfAccountUserChangePwdToken (string userId, string currentPwd)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountUserChangePwdTokenExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 
            var currentPwd = currentPwd_example;  // string | 

            try
            {
                // 
                string result = apiInstance.SelfAccountUserChangePwdToken(userId, currentPwd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountUserChangePwdToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **currentPwd** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountuserget"></a>
# **SelfAccountUserGet**
> User SelfAccountUserGet (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountUserGetExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                User result = apiInstance.SelfAccountUserGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountuserlogin"></a>
# **SelfAccountUserLogin**
> Session SelfAccountUserLogin (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountUserLoginExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                Session result = apiInstance.SelfAccountUserLogin(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountUserLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountuserput"></a>
# **SelfAccountUserPut**
> User SelfAccountUserPut (string userId, User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountUserPutExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.SelfAccountUserPut(userId, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountUserPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfaccountuserresendemailconfirmation"></a>
# **SelfAccountUserResendEmailConfirmation**
> string SelfAccountUserResendEmailConfirmation (string userId)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfAccountUserResendEmailConfirmationExample
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

            var apiInstance = new SsUserApi();
            var userId = userId_example;  // string | 

            try
            {
                // 
                string result = apiInstance.SelfAccountUserResendEmailConfirmation(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfAccountUserResendEmailConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfuserchangepwdtoken"></a>
# **SelfUserChangePwdToken**
> string SelfUserChangePwdToken (string currentPwd)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfUserChangePwdTokenExample
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

            var apiInstance = new SsUserApi();
            var currentPwd = currentPwd_example;  // string | 

            try
            {
                // 
                string result = apiInstance.SelfUserChangePwdToken(currentPwd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfUserChangePwdToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentPwd** | **string**|  | 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfuserget"></a>
# **SelfUserGet**
> User SelfUserGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfUserGetExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                User result = apiInstance.SelfUserGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfuserlogin"></a>
# **SelfUserLogin**
> Session SelfUserLogin ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfUserLoginExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                Session result = apiInstance.SelfUserLogin();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfUserLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Session**](Session.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfuserput"></a>
# **SelfUserPut**
> User SelfUserPut (User user = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfUserPutExample
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

            var apiInstance = new SsUserApi();
            var user = new User(); // User |  (optional) 

            try
            {
                // 
                User result = apiInstance.SelfUserPut(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfUserPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**User**](User.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selfuserresendemailconfirmation"></a>
# **SelfUserResendEmailConfirmation**
> string SelfUserResendEmailConfirmation ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SelfUserResendEmailConfirmationExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                string result = apiInstance.SelfUserResendEmailConfirmation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.SelfUserResendEmailConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userconfigget"></a>
# **UserConfigGet**
> UserConfig UserConfigGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserConfigGetExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                UserConfig result = apiInstance.UserConfigGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.UserConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserConfig**](UserConfig.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userconfigput"></a>
# **UserConfigPut**
> string UserConfigPut (UserConfig a = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserConfigPutExample
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

            var apiInstance = new SsUserApi();
            var a = new UserConfig(); // UserConfig |  (optional) 

            try
            {
                // 
                string result = apiInstance.UserConfigPut(a);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.UserConfigPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **a** | [**UserConfig**](UserConfig.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="useruiconfigget"></a>
# **UserUiConfigGet**
> UserUiConf UserUiConfigGet ()





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserUiConfigGetExample
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

            var apiInstance = new SsUserApi();

            try
            {
                // 
                UserUiConf result = apiInstance.UserUiConfigGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.UserUiConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserUiConf**](UserUiConf.md)

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="useruiconfigput"></a>
# **UserUiConfigPut**
> string UserUiConfigPut (UserUiConf a = null)





### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserUiConfigPutExample
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

            var apiInstance = new SsUserApi();
            var a = new UserUiConf(); // UserUiConf |  (optional) 

            try
            {
                // 
                string result = apiInstance.UserUiConfigPut(a);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsUserApi.UserUiConfigPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **a** | [**UserUiConf**](UserUiConf.md)|  | [optional] 

### Return type

**string**

### Authorization

[tenantid](../README.md#tenantid), [token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

