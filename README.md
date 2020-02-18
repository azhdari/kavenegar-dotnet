# .Net Core SDK

[![License](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://github.com/azhdari/kavenegar-dotnet/blob/master/LICENSE)
[![NuGet](https://img.shields.io/badge/nuget-2.0.0-blue.svg?style=flat-square)](https://www.nuget.org/packages/kavenegar-dotnetcore/2.0.0)

Checkout <a href="http://kavenegar.com/rest.html">Kavenegar RESTful API Document</a>

## Installation

First of all, You need to make an account on Kavenegar from <a href="https://panel.kavenegar.com/Client/Membership/Register">Here</a>
After that you just need to pick API-KEY up from <a href="http://panel.kavenegar.com/Client/setting/index">My Account</a> section.

From the command prompt
```bash
dotnet add package kavenegar-dotnetcore
```
or
```bash
Install-Package kavenegar-dotnetcore
```
or
```bash
paket add kavenegar-dotnetcore
```  

## Usage
How to send SMS:

```c#
try
{
	Kavenegar.KavenegarApi api = new Kavenegar.KavenegarApi("Your Api Key");
	var result = api.Send("SenderLine", "Your Receptor", "خدمات پیام کوتاه کاوه نگار");
	foreach (var r in result){
	  Console.Write("r.Messageid.ToString()");
  }
}
catch (Kavenegar.Exceptions.ApiException ex) 
{
	// در صورتی که خروجی وب سرویس 200 نباشد این خطارخ می دهد.
	Console.Write("Message : " + ex.Message);
}
catch (Kavenegar.Exceptions.HttpException ex) 
{
	// در زمانی که مشکلی در برقرای ارتباط با وب سرویس وجود داشته باشد این خطا رخ می دهد
	Console.Write("Message : " + ex.Message);
}
```

## Contribution
You're welcome to send PR.
<hr>
<div dir='rtl'>

## راهنما

### معرفی سرویس کاوه نگار

کاوه نگار یک وب سرویس ارسال و دریافت پیامک و تماس صوتی است که به راحتی میتوانید از آن استفاده نمایید.

### ساخت حساب کاربری

اگر در وب سرویس کاوه نگار عضو نیستید میتوانید از [لینک عضویت](http://panel.kavenegar.com/client/membership/register) ثبت نام  و اکانت آزمایشی برای تست API دریافت نمایید.

### مستندات

برای مشاهده اطلاعات کامل مستندات [وب سرویس پیامک](http://kavenegar.com/وب-سرویس-پیامک.html)  به صفحه [مستندات وب سرویس](http://kavenegar.com/rest.html) مراجعه نمایید.

### راهنمای فارسی

در صورتی که مایل هستید راهنمای فارسی کیت توسعه کاوه نگار را مطالعه کنید به صفحه [کد ارسال پیامک](http://kavenegar.com/sdk.html) مراجعه نمایید.

### اطالاعات بیشتر
برای مطالعه بیشتر به صفحه معرفی
[وب سرویس اس ام اس ](http://kavenegar.com)
کاوه نگار
مراجعه نمایید .

 اگر در استفاده از کیت های سرویس کاوه نگار مشکلی یا پیشنهادی  داشتید ما را با یک Pull Request  یا  ارسال ایمیل به support@kavenegar.com  خوشحال کنید.
 
##
![http://kavenegar.com](http://kavenegar.com/public/images/logo.png)		

[http://kavenegar.com](http://kavenegar.com)	

</div>


