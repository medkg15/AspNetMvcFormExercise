# ASP.NET MVC Form Exercise

## Objective

Implement a Sales Lead (e.g. "Contact Us") form using ASP.NET MVC.  An example of the form is shown below.

![alt text](/contact-form.png "Form Example")

## Requirements

* Utilize the features of ASP.NET MVC to develop the form - Razor, etc.
* Include client and server-side validation of the user's input using ASP.NET MVC techniques.
* Flow:
	* User requests the form at the URL /lead.
	* Display the form to the user.
	* User submits the form (standard server-side form POST).
	* Server processes the form submission, displaying errors or handling a successful request, as appropriate.

## Implementation

* A LeadController is provided as a starting point.
* The HTML for the form is provided, see /AspNetMvc/Views/Lead/Index.cshtml
* The objective of this exercise is not to handle the details of processing the Sales Lead Submission (e.g. send an email, store in a database, send to a web service, etc.)  Instead, these details are abstracted away behind the ILeadHandler interface.  Upon a valid lead submission, the lead data should be handed off to that implementation.  An instance of the ILeadHandler is provided via constructor injection into the LeadController.
```
_leadHandler.Handle(new CreateLead {
  FirstName = "...",
  ...
});
```

# Project Startup

Simply 'start' the project in Visual Studio to run within IIS Express.  The homepage has a link to the Lead form at the URL /lead.