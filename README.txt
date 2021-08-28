Open browser and enter kclms.azurewebsites.net


To add/edit/remove orders, use Postman to simulate a HTTP request:

------Adding an order-----
Set the Request to Post
Enter the following in the URL entry: http://kclms.azurewebsites.net/api/v1/ordermanagement
Then under it, change to Body, select raw and choose JSON.
Use following template to add order:
{
 "DateOfPurchase" = <YYYY-MM-DDTHH-mm-ss> ,
 "StoreID" = <int from 1 and 2 (at the moment, more can be added)>,
 "ProductIds" = <List of ints from 0-9>,
 "Quantities" = <List of ints for respective product from Id>,
 "UnitPrices" = <List of doubles for respective single product>,
 "Amount" = <>
}


------Editing an order------
Set the Request to Put
Enter the following in the URL entry: http://kclms.azurewebsites.net/api/v1/ordermanagement
Then under it, change to Body, select raw and choose JSON
{
"Amount" = "",
"OrderId" =<int>
} 

-----Deleting an order-----
Set the Request to Delete
Enter the following in the URL entry: http://kclms.azurewebsites.net/api/v1/ordermanagement?id=<insert id of order>
Then under it, change to Body and make sure it's set to none
