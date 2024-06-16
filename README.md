## Setup and Run Backend AspNet Application
  
1. **Download the files from Github**
2. **Using the visual studio**
3. **Open the solution**
4. **If Visual Studio does not have the DotNet Sdk 8 the IDE will advise to install the new version.**
5. **Verify if it is configured to run on http, even has configurations to run on https or using docker, I did not test, and probably have change the API port in frontend project.**
6. **Press the play button or F5 on keyboard.**

## Approach and Challenges, and Overcomes

I used the Asp Net 8 with Entity Framework Core 8, that is the lasted version, I configured SQLite due it is a serverless database, and I can embed it without much cost in software to use. I considered Mongo DB due they released an official Entity Framework Support to the Version 8 but due the time I to follow a way that I know.

The challenge was with Entity Framework, I have experience, most with version 6, but I believe that does not have much difference between these versions. It has some weird behaviours. Firstly the I resolved change the model of category and status, from string to int, due the idea that it is to be a list so I developed a another relation for this fields, so I put categoryId and statusId in Equipment model, but when I save the form, Even though I haven't configured directly the operations of CRUD in this tables it was saving the default values as new and auto increment the ID… and when back to the view list it showed nothing. So, I excluded the tables and just put a handle in frontend using Enums.


## Potential Improvements

- Implement correctly the Database relations with the table Status and Category, I would like to do the functions to add it in separate screen, initially I thought that it was possible to do in 6 hours.
- Configure the system to run on https, and docker, probably it will run but I did not tested, or configured the database in docker file.
- I have more ideas to expand it, but it is outside the scope of the test.
