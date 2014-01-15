2Checkout .NET Library
=====================

This library provides developers with a simple set of bindings to the 2Checkout purchase routine, Instant Notification Service and Back Office API.

Full documentation for each binding will be provided in the [Wiki](https://github.com/2checkout/2checkout-dotnet/wiki).

Installation
------------

Add TwoCheckout-latest.dll to your project's References and add it's dependencies listed below.
* [Json.NET 4.5](http://json.codeplex.com/releases/view/92198)


Example Purchase API Usage:
---------------------

*Example Usage:*

```csharp
TwocheckoutKey.PrivateKey = "9999999";
// TwocheckoutKey.Mode = "sandbox";  <-- Set Mode to use your 2Checkout sandbox account

try
{
    // Billing Address
    var billing = new Dictionary<string, string>();
    billing.Add("name", "Testing Tester");
    billing.Add("addrLine1", "123 test st");
    billing.Add("city", "Columbus");
    billing.Add("state", "OH");
    billing.Add("zipCode", "43123");
    billing.Add("country", "USA");
    billing.Add("email", "testingtester@2co.com");
    billing.Add("phoneNumber", "555-555-5555");

    // Order Details
    var dictionary = new Dictionary<string, object>();
    dictionary.Add("sellerId", "1817037");
    dictionary.Add("merchantOrderId", "123");
    dictionary.Add("token", "ZjI3NWFiMDItNTI3Ny00YWUzLThiNzYtZDQyNWQ2NGFkZDNk");
    dictionary.Add("currency", "USD");
    dictionary.Add("total", "1.00");
    dictionary.Add("billingAddr", billing);

    var result = TwocheckoutCharge.Authorize(dictionary);

    // Do something with the result by checking response code
    var response = result.responseCode
}
catch (TwocheckoutException e)
{
    // Do something with the exception like show and error to the user
}
```

*Example Response:*

```csharp
{TwoCheckout.Authorization}
  type: "AuthResponse"
  responseCode: "APPROVED"
  responseMsg: "Successfully authorized the provided credit card"
  total: 1.00
  currencyCode: "USD"
  merchantOrderId: "123"
  orderNumber: 105162018917
  transactionId: 105162018926
```

*Example Exception:*

```csharp
{
    {
        "validationErrors": null,
        "exception": {
            "errorMsg": "Unauthorized",
            "httpStatus": "401",
            "exception": false,
            "errorCode": "300"
        },
        "response": null
    }
}
```


Example Admin API Usage
-----------------

*Example Usage:*

```csharp
TwocheckoutConfig.ApiUsername = "APIuser1817037";
TwocheckoutConfig.ApiPassword = "APIpass1817037";

var dictionary = new Dictionary<string, string>();
dictionary.Add("sale_id", "4784990526");
var result = TwocheckoutSale.Refund(dictionary);
```

*Example Response:*

```csharp
{TwoCheckout.TwocheckoutResponse}
  response_code: "OK"
  response_message: "refund added to invoice"
```

Example Checkout Usage:
-----------------------

*Example Usage:*

```csharp
var dictionary = new Dictionary<string, string>();
dictionary.Add("sid", "1817037");
dictionary.Add("mode", "2CO");
dictionary.Add("li_0_type", "product");
dictionary.Add("li_0_name", "Example Product");
dictionary.Add("li_0_price", "1.00");

String PaymentForm = TwocheckoutCharge.Submit(dictionary);
```

Example Return Usage:
---------------------

*Example Usage:*

```csharp
var dictionary = new Dictionary<string, string>();
dictionary.Add("sid", Request.Params["sid"]);
dictionary.Add("order_number", Request.Params["order_number"]);
dictionary.Add("total", Request.Params["total"]);
dictionary.Add("key", Request.Params["key"]);

var result = TwocheckoutReturn.Check(dictionary, "tango");
```

*Example Response:*

```csharp
{TwoCheckout.TwocheckoutResponse}
  response_code: "Success"
  response_message: "Hash Matched"
```

Example INS Usage:
------------------

*Example Usage:*

```csharp
var dictionary = new Dictionary<string, string>();
dictionary.Add("vendor_id", Request.Params["vendor_id"]);
dictionary.Add("sale_id", Request.Params["sale_id"]);
dictionary.Add("invoice_id", Request.Params["invoice_id"]);
dictionary.Add("md5_hash", Request.Params["md5_hash"]);

var result = TwocheckoutNotification.Check(dictionary, "tango");
```

*Example Response:*

```csharp
{TwoCheckout.TwocheckoutResponse}
  response_code: "Success"
  response_message: "Hash Matched"
```

Exceptions:
------------------

TwocheckoutException exceptions are thrown by if an error has returned. It is best to catch these exceptions so that they can be gracefully handled in your application.

*Example Catch*

```csharp
TwocheckoutConfig.ApiUsername = "APIuser1817037";
TwocheckoutConfig.ApiPassword = "APIpass1817037";

try
{
	var dictionary = new Dictionary<string, string>();
	dictionary.Add("sale_id", "4784990526");
	var result = TwocheckoutSale.Refund(dictionary);
}
catch (TwocheckoutException e)
{
	e.message
}
```

*Example Exception*

```json
{
   "errors" : [
      {
         "code" : "PARAMETER_MISSING",
         "message" : "Required parameter missing: category",
         "parameter" : "category"
      }
   ]
}
```

Full documentation for each binding is provided in the [Wiki](https://github.com/2checkout/2checkout-dotnet/wiki).
