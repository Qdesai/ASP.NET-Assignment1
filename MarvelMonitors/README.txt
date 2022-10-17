Name : MOHAMMED QAASIM DESAI 
Student Number : 0776412

!- I Started the Project on 10 october BUT i added a wrong datatype in the database and the webpage named "ModelYear" where i put datetime datatype however i only need the year.

As i have to make my assignment for monitors i researched and came to the conclusion that i will use these properties for the monitors 
-ID
1.ModelName
2.Manufacturer 
3.ScreenSize 
4.PanelTechnology
5.RefreshRate 
6.Resolution
7.Features 
8.Price

-------------- 12 october 2022 ---------------- 

2107 Created a Folder
2110 Started to make the project
2111 Run the project for the first time 
2113 It runs perfectly and the port also works but i will comment the ssl port so that it works in the college lab too.
2120 Added the controller MonitorsListController
2122 Added a View Folder named MonitorsList
2123 Added a View file
2130 url not working and not giving any error 
2135 i forget that the controller name and the view should be same (that is Index.cshtml) so i changed it and now its working.
2137 added the code to dynamically change the date of the copyright
2140 finally pushed the assignment to github. (The github repo was already created.)
2141 changed the Title of the page to look better.
2143 created the model and now building the database.
2147 Created a database context class
2150 Added the database connection strings 
2151 OOPSS!! its giving an error the connection string value cannot be null while scafolding 
2154 changed the connection strings and now the scafolding is started.
2155 completed scafolding.
2156 commited to github.

-------------- 13 october 2022 ---------------- 

0249 FINALLLYYY Completed the initaial create.
0253 DAMNN!!!! Errorrrr  " There is already an object named 'Monitor' in the database "
1001 When i came to college and tried the Update-Database it worked but i dont know how.
1015 i realized that i forgot to link controller with the header in the _layout.cshtml page so i added the link now.
1020 added the SeedData file under the Models Folder.
1035 added 1 record in the SeedData.cs just to check if it works.
1039 Updated the contents of program.cs now going to run the application hopefully it should work.
1042 Happy that it works i will be adding more contents to the SeedData later as i need 10 records for the assigment.
1116 Added code to the Models/Monitor.cs so that it the Title of the field is not shown as pascal casing (crunched).
1118 also added the code in the Models/Monitor.cs for the decimal datatype and assigned the range.
1148 leaving the class 
2312 cloned the repo and started working again.


-------------- 14 october 2022 ---------------- 

0044 After i cloned the repo i was not able to run the command update-database it gave the same error like before because,
	 I had a database in my laptop that was named same so i deleted the database and tried again.
0048 Updated the database again now it worked. 
0111 changed the index method in the MonitorsController inorder show the records that match the search. 
0128 added the textbox in the index page for the search string.
0132 changed the form post method to "GET".
0145 added a new class in the models folder named MonitorsScreeenSizeModel.
0147 populated the MonitorsScreeenSizeModel class.
0152 updated the index model 
0158 messed it up so tried again :(
0210 finally updated the index model successfully 
0230 updated the view/Monitors/Index.cshtml
0237 Finally checked the filter and the dropdown field and it works perfectly!!!
1125 Added the rating property to the Monitor.cs
1235 i had a hard time finding " [Bind("Id,Title,ReleaseDate,Genre,Price")] " in MonitorsController.cs atlast found it and added the " "Rating"
1245 edited the Views/Monitors/Index.cshtml and added the rating field 
1250 also updated the database View/Moitors/Create.cshtml and added the Rating field 
0135 insted of the normall input field i added the input type=number that limits the user input from 0-5 BUT it created a problem the edit.cshtml was 
	 not showing the ratings so atlast after trying a lot i changed it back to default.
0148 updated the SeedData and added the rating record in the database 
0153 fired the command for adding the migration rating with the -Context MarvelMonitors and also updated the database 
0215 added some of the validation i will add some later 


-------------- 15 october 2022 ---------------- 
0031 Completed the validation  


-------------- 16 october 2022 ---------------- 
2322 finally added 10 records for the assignment in the database.
2345 I tried this " <button asp-area="" asp-controller="Monitors" asp-action="Index">Check Out Our Latest Moniters</button> " to redirect the user to different page. BUT IT DIDNT WORK.

-------------- 17 october 2022 ---------------- 

0013 Figured out how ot redirect user with button.
0136 Completed the about us page.
0200 f****** i lost all of my work till 15 oct because of git conflict now doing it again 
0210 completed the seeddata 
0218 linked all the pages with the navigation bar.
0225 Arranged the about us page 
0228 Added button but coudnt redirect it to another page so i tried to do it with the onclick method and it worked
0235 got an image that is free to use.
0250 trying to insert images but cannot do it.
0334 still tring to find how to insert images.
0341 added the image finally ton the home page. 
0346 added the logo to the header.
0401 COmpleted the styling.
0430 added the google fonts and its working perfectly 
0438 Finalllyy completed Assignment 1!!!!!!
0440 Posting it to azure.
0452 tried a lot to post it to azure but its not posting. not giving any error (Same like it happened in class)