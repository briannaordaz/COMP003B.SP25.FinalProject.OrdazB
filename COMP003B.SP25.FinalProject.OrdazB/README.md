The purpose of this site is to create a system where you can book an airbnb.
You can firt by adding your User information like Name, Email, and Phone number. 
Then you can either add a property or book a property. To add a property you will have to identify the property's name, location, price, and then a small description about the property you wish to add.
To book a property you'll have to add a dates for when you'll CheckIn and Check out of the property, then you can add how many guests will be attending. 
After booking a property, you'll have to make a payment by adding the date of your payment and the amount you'll have to pay.
After successfully booking a property and making a payment, you can add a review by adding the date (of the review) and a comment.



#### * Models & Properties


- #####  **`User`** 
* UserID (pk)
* FristName
* LastName
* Email
* PhoneNumber

- ##### **`Property`**
* PropertyID (pk)
* PropertyName
* PropertyDescription
* PropertyLocaton
* Price

- ##### **`Booking`**
* BookingID (pk)
* UserID (fk)
* PropertyID (fk)
* CheckIn
* CheckOut
* Guests

##### **`- Payment`**
* PaymentID (pk)
* UserID (fk)
* BookingID (fk)
* DateOfPayment
* PaymentAmount


##### **`- Review`**
* ReviewID (pk)
* UserID (fk)
* PropertyID (fk)
* ReviewDate
* Comment