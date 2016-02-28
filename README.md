### .NET wrapper for the Sage One Accounting API

A .Net client library for using the Sage One Accounting API. 
Read more about the API at: [https://accounting.sageone.co.za/Marketing/DeveloperProgram.aspx](https://accounting.sageone.co.za/Marketing/DeveloperProgram.aspx) 

This project is under active development. If you wish to contribute, please follow the existing coding conventions and submit a pull request.
For more information and usage examples visit [http://pietervdw.github.io/sageone-api-wrapper/](http://pietervdw.github.io/sageone-api-wrapper/)

Currently, the following objects/methods are available in the library:

|                       | GetAll              | Get                | Save               | Delete             | Get w/ System Accounts | Get By Category   | Get Current		   | Has Activity	    | Calculate          | Email              |
| ------------          | ------------------- | ------------------ | ------------------ | ------------------ | ---------------------- | ----------------- | -----------------  | ------------------ | ------------------ | ------------------ |
| Account               | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark:     | :heavy_check_mark:| 				   |                    |                    |                    |
| Account Category      | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Additional Price List | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Additional Item Price | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Asset                 | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Asset Category        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Asset Locations       | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Asset Notes	        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Bank Account	        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Bank Account Category | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Customer		        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Customer Category     | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Customer Notes        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Company		        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |	:heavy_check_mark: |                    |                    |                    |
| Item			        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Item Notes            | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Item Category         | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Purchase Order        | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Sales Representative  | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   | :heavy_check_mark: |                    |                    |
| Supplier              | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   | 					|                    |                    |
| Supplier Category     | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   |                    |                    |                    |
| Supplier Invoice      | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   | 					| :heavy_check_mark: |                    |    
| Tax Invoice           | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | :heavy_check_mark: | 					      | 				  |					   | 					| :heavy_check_mark: | :heavy_check_mark: |
| Tax Type              | :heavy_check_mark:  | :heavy_check_mark: | :heavy_check_mark: | 					 | 					      | 				  |					   | 					|                    |                    |  
 

  
If you need to create test data for your developer account, take a look at the tests inside SampleDataCreate.cs

This project borrowed heavily from the concepts used by Scott Schluer and his [.Net Wrapper for the Highrise Api](https://github.com/scottschluer/highrise-api)


