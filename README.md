DEPRECATED!!! This SDK can only be used with the legacy 2Checkout platform which is depreciated. Please use [2checkout-dotnet-sdk](https://github.com/2Checkout/2checkout-dotnet-sdk) with the current 2Checkout platform.
=====================

This library provides developers with a simple set of bindings to the 2Checkout purchase routine, Instant Notification Service and Back Office API.

Full documentation for each binding is provided at [in the wiki](https://github.com/2Checkout/2checkout-dotnet/wiki).

Installation
------------

Add TwoCheckout.dll to your project's References and add it's dependencies listed below.
* [Json.NET 6.0.3](https://json.codeplex.com/releases/view/121470)


Example Payment API Usage:
---------------------

*Example Usage:*

```csharp
TwoCheckoutConfig.SellerID = "1817037";
TwoCheckoutConfig.PrivateKey = "8CE03B2D-FE41-4C53-9156-52A8ED5A0FA3";
//TwoCheckoutConfig.Sandbox = true;   <-- Set Mode to use your 2Checkout sandbox account

try
{
    var Billing = new AuthBillingAddress();
    Billing.addrLine1 = "123 test st";
    Billing.city = "Columbus";
    Billing.zipCode = "43123";
    Billing.state = "OH";
    Billing.country = "USA";
    Billing.name = "Testing Tester";
    Billing.email = "example@2co.com";
    Billing.phoneNumber = "5555555555";

    var Customer = new ChargeAuthorizeServiceOptions();
    Customer.total = (decimal)1.00;
    Customer.currency = "USD";
    Customer.merchantOrderId = "123";
    Customer.billingAddr = Billing;
    Customer.token = "MzIwNzI3ZWQtMjdiNy00NTVhLWFhZTEtZGUyZGQ3MTk1ZDMw";

    var Charge = new ChargeService();
    
    var result = Charge.Authorize(Customer);
    Console.Write(result);
}
catch (TwoCheckoutException e)
{
    Console.Write(e);
}
```

*Example Response:*

```csharp
{TwoCheckout.Authorization}
    responseMsg: "Successfully authorized the provided credit card"
    responseCode: "APPROVED"
    type: "AuthResponse"
    orderNumber: 205205956108
    merchantOrderId: "123"
    transactionId: 205205956117
    currencyCode: "USD"
    total: 1.00
    lineItems: ...
      {TwoCheckout.AuthLineitem}
        type: "product"
        name: "123"
        quantity: 1
        price: 1.0
        tangible: "N"
        productId: ""
        recurrence: null
        duration: null
        startupFee: null
        options: ...
        billingAddr: { }
      {TwoCheckout.AuthBillingAddress}
        name: "Testing Tester"
        addrLine1: "123 test st"
        addrLine2: null
        city: "Columbus"
        state: "OH"
        zipCode: "43123"
        country: "USA"
        email: "example@2co.com"
        phoneNumber: null
        phoneExt: null
```

*Example Exception:*

```csharp
Unauthorized
```


Example Admin API Usage
-----------------

*Example Usage:*

```csharp
TwoCheckoutConfig.ApiUsername = "APIuser1817037";
TwoCheckoutConfig.ApiPassword = "APIpass1817037";

try
{
    var ServiceObject = new SaleService();
    var ArgsObject = new SaleRefundServiceOptions();
    ArgsObject.invoice_id = invoice_id;
    ArgsObject.comment = "test refund";
    ArgsObject.category = 5;
    var result = ServiceObject.Refund(ArgsObject);
}
catch (TwoCheckoutException e)
{
    // read e.message
}
```

*Example Response:*

```csharp
{TwoCheckout.TwoCheckoutResponse}
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

String PaymentForm = ChargeService.Submit(dictionary);
```

Example Return Usage:
---------------------

*Example Usage:*

```csharp
TwoCheckoutConfig.SecretWord = "tango";
TwoCheckoutConfig.SellerID = "1817037";

var Return = new ReturnService();
var Args = new ReturnCheckServiceOptions();
Args.total = "0.01";
Args.order_number = Request.Params["order_number"];
Args.key = Request.Params["key"];
bool result = Return.Check(Args);
```

*Example Response:*

```csharp
true
```

Example INS Usage:
------------------

*Example Usage:*

```csharp
TwoCheckoutConfig.SecretWord = "tango";
TwoCheckoutConfig.SellerID = "1817037";

var Notification = new NotificationService();
var Args = new NotificationCheckServiceOptions();
Args.invoice_id = Request.Params["invoice_id"];
Args.sale_id = Request.Params["sale_id"];
Args.md5_hash = Request.Params["md5_hash"];
bool result = Notification.Check(Args);
```

*Example Response:*

```csharp
true
```

Exceptions:
------------------

TwoCheckoutException exceptions are thrown by if an error has returned. It is best to catch these exceptions so that they can be gracefully handled in your application.

*Example Catch*

```csharp
TwoCheckoutConfig.SellerID = "1817037";
TwoCheckoutConfig.PrivateKey = "8CE03B2D-FE41-4C53-9156-52A8ED5A0FA3";

try
{
    var Billing = new AuthBillingAddress();
    Billing.addrLine1 = "123 test st";
    Billing.city = "Columbus";
    Billing.zipCode = "43123";
    Billing.state = "OH";
    Billing.country = "USA";
    Billing.name = "Testing Tester";
    Billing.email = "example@2co.com";
    Billing.phone = "5555555555";

    var Customer = new ChargeAuthorizeServiceOptions();
    Customer.total = (decimal)1.00;
    Customer.currency = "USD";
    Customer.merchantOrderId = "123";
    Customer.billingAddr = Billing;
    Customer.token = "MzIwNzI3ZWQtMjdiNy00NTVhLWFhZTEtZGUyZGQ3MTk1ZDMw";

    var Charge = new ChargeService();
    
    var result = Charge.Authorize(Customer);
    Console.Write(result);
}
catch (TwoCheckoutException e)
{
    Console.Write(e);
}
```

*Example Exception*

```json
Unauthorized
```

Full documentation for each binding is provided at [in the wiki](https://github.com/2Checkout/2checkout-dotnet/wiki).

Acknowledgments
---------------
The current master branch replaces the use of dictionaries and static methods with the service option pattern demonstrated by [Jayme Davis] (https://github.com/jaymedavis).
