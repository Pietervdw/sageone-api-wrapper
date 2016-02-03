### .NET wrapper for the Sage One Accounting API

A .Net client library for using the Sage One Accounting API. 
Read more about the API at: [https://accounting.sageone.co.za/Marketing/DeveloperProgram.aspx](https://accounting.sageone.co.za/Marketing/DeveloperProgram.aspx) 

This project is under active development. If you wish to contribute, please follow the existing coding conventions and submit a pull request.
For more information and usage examples visit [http://www.mythicalmanmoth.com/2015/09/08/net-wrapper-sage-one-accounting-api/](http://www.mythicalmanmoth.com/2015/09/08/net-wrapper-sage-one-accounting-api/)

Currently, the following objects are represented in the library:

- Account
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  * Get with System Accounts
  * Get by Category
  
- Additional Price List
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  
- Additional Item Price
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  
- Asset
  * Get All
  * Get
  * Save (Create and Update)
  * Delete

- Asset Locations
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  
- Asset Notes
  * Get All
  * Get
  * Save (Create and Update)
  * Delete 

- Bank Account
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  
- Customer
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  
- Customer Notes
  * Get All
  * Get
  * Save (Create and Update)
  * Delete 
  
- Company
  * Get Current
  
- Item
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  
- Item Notes
  * Get All
  * Get
  * Save (Create and Update)
  * Delete 
  
- Categories (Account, Asset, Bank Account, Customer, Item, Supplier)
  * Get All
  * Get
  * Save (Create and Update) excl. Account Categories
  * Delete
  
- Purchase Order
  * Get All
  * Get
  * Save (Create and Update)
  * Calculate  
  
- Sales Representative
  * Get All
  * Get
  * Save (Create and Update)
  * Delete
  * HasActivity
  
- Supplier
  * Get All / Get All Async
  * Get
  * Save (Create and Update) / Save Async
  * Delete

- Supplier Invoice
  * Get All
  * Get
  * Save (Create and Update)
  * Calculate      
  
- Tax Invoice
  * Get All
  * Get
  * Save (Create and Update)
  * Calculate
  * Email  
  
- Tax Type
  * Get All
  * Get
  * Save (Create and Update)
  
If you need to create test data for your developer account, take a look at the tests inside SampleDataCreate.cs

This project borrowed heavily from the concepts used by Scott Schluer and his [.Net Wrapper for the Highrise Api](https://github.com/scottschluer/highrise-api)


