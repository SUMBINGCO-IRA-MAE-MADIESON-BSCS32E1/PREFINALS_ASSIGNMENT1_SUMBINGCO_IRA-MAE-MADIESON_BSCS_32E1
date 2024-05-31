Onion Architecture: (Yes/No) 
Have you heard of the Onion Architecture principle in software design?

Yes, the onion architecture is a way of organizing software where you put the most important parts in the middle and surround them with layers. This makes it easier to manage and modify your software later.
 
 
MVC Pattern: (Yes/No) 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?

Yes, it divides web applications into three parts, the model, view, and controller.
 
 
Web API: (Yes/No) 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?

No. 
 
Application & Bottlenecks:
Onion Architecture:
Benefits: (1-3 keywords)
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)

Its benefits such as clear separation of concerns, enhanced testability, flexibility in modifications, and scalability. This architecture promotes modular design, making it easier to maintain and extend applications over time.


Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)

Yes, I've encountered difficulties in defining and maintaining precise boundaries between layers, which can feel overly intricate for straightforward applications. 
 

MVC:
Components: (1-3 keywords each)
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.

The model consists the application's data and business logic. The view presents this data to users through the user interface. The controller processes these interactions, orchestrating communication between the Model and View. 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)

Yes, modifications to one usually require adjustments in the other, leading to a lot of changes throughout the application.
 
Web API:
Differences from MVC: (Yes/No and Briefly Explain)
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.

Traditional MVC applications use Controllers to get data from Models and show it directly on web pages through Views. Web APIs, on the other hand, use Controllers to get data from Models but send this data back as JSON or XML for other applications to use, without directly showing it to users.
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)

Yes, the whole page frequently refreshes as a whole, which sometimes can be slow. 
