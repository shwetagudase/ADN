//MVC stand for Model view Controller 
//MVC is a design pattern used to develope scalable application
// It seperate appln into 3 resposibilties
//1) model 2) view 3) controller
// What is model - It is a data layer , Model represnets appln data and business logic 
// Responsibilities: DB interactn , data validation , business rules 
// example :
public class Customer {
    public string Name { get; set; }
    public string Email { get; set; }
};

// 2) View :view is UI layer , It is responsible for user interface , what user see is basically a view
//      example : form ,html data
// 3) Controller : is a Brain of MVC . controller connects model and view , it handles user request and appln flow
//      responsibilities: receive request , call model, send data to view
// terminal - dotnet new mvc -n filename

