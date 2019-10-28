# Hair Salon

Web app that let's a user organize their hair salon's clients and stlyists.

## AUTHORS

Kira Roberts Oct. 2019. Built for Portland Epicodus C# track. 


## USE

App built for Epicodus C# program with the Entity Framework. Lets the user post restaurants with a description to a given cuisine type. Can also add reviews to specific restaurants.

## SET-UP

- from terminal, navigate to desktop and run 'git clone https://github.com/kiraroberts/HairSalon.Solution.git' 
- navigate to 'HairSalon' project directory and run 'dotnet restore'
- set up a database with MySQL Workbench called 'kira_roberts' with the following tables/columns:
    - 'stylists': StylistId (PK, NN, AI), Name
    - 'clients': ClientId (PK, NN, AI), Name, NewOrReturning, StylistId (PK, NN)
    - launch app from 'HairSalon' with 'dotnet watch run' command and open link

## TECH USED

C#, MySQL Workbench, EntityFramework, Razor, VS Code

## LICENSE

Open source, 2019 (MIT)
