# ASP.Net Core SRP & OCP Basic Samp

## Scenario

Sample violation of OCP 

```
...
if(user == "janitor"){
    // custom email body here
}
if(user == "waitress"){
	// custom email body here
}
if(user == "supervistor"){
	// custom email body here
}
// so on and so forth.
...
```
Instead of multiple if-else/else-if for sending custom body to different set of user, with OCP or Open-closed principle, we create an interface (can be inherited to different classes) that has its condition and custom implementation.
```
public interface IEmailNotification
{
	bool Rule(string rule);
    Task<bool> NotifyUser(string info);
}

public class EmailToSupervisor : IEmailNotification {
    ... contracts with IEmailNotification
}

public class EmailToJanitor : IEmailNotification {
    ... contracts with IEmailNotification
}

so on and so forth.
```
OCP states that the software entities (classes or methods) should be open for extension but closed for modification.

In our sample code above, our solution shows that it's open for extension because what if in the future we create another email notification for manager or for another users? What we can do with that is just simply inherit the `IEmailNotification` and do their custom implementation. Of course, our `IEmailNotifcation` is closed for modification since it's implemented to our classes which has the same approach but different in their custom implementation. If there will changes with `IEmailNotification`, then all the children classes must implement that additional or modified contract.

`EmailNotification` is just a simple scenario on how we can implement OCP, there are a lot of good scenarios where we can do the same logical approach so try it on your own. Some of the benefits of this are, clean and easy to maintain.
