![image](https://github.com/riley-ad-clark/flight-planner/assets/144390085/f589228d-e69a-4dec-a0d0-21a4778e5910)
# Welcome to SkyBooking!
This is the first of many full-stack projects developed by myself, <a href="https://github.com/Joseph-Wil">Joseph Terrado</a> and <a href="https://github.com/xiaofang82">Xiaofang Yang</a>!

## Work Distribution
 - All members: Initial product design, database migration
 - Riley: Home page functionality, and all other pages body design
 - Joseph: Destinations (airports) functionality, and header and footer design
 - Xiaofang: Bookings functionality, and edit / delete functions for flights
<br>
<b>Note: These are subject to change as the project continues development</b>

## Prerequisites
As with other projects, this web app requires a bit of set up to get started, see the applications below to ensure you are ready to begin.

- <a href="https://visualstudio.microsoft.com/vs/community/">Microsoft Visual Studio Community Edition</a>, and <a href="https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16">SQL Server Management Studio</a>

## Setup
The following steps are meant to ensure the user experience is as seamless as possible, if there are any errors, or missing steps you have encountered that _are not_ covered, please submit a pull request!

- **I) Ensure that Visual Studio has the correct components installed. To do so, follow the steps below:**
&nbsp;
<div align="center">Assuming a <b>Windows</b> machine is being used:</div>
&nbsp;
<div align="center">Open Control Panel > Uninstall a program > Locate 'Microsoft Visual Studio Installer' > Right click > Select change</div>
&nbsp;
<div align="center"><img src="https://github.com/riley-ad-clark/flight-planner/assets/144390085/01b341d2-e202-4d88-832b-a2bcc7a9a95a" height="50%" width="50%"></div>
&nbsp;
<div align="center">Select "Modify" > Tick the "ASP.NET and web development" box > see "Individual Components" > Select all boxes > Install </div>
&nbsp;
<div align="center"><img src="https://github.com/riley-ad-clark/flight-planner/assets/144390085/3b0eba64-0a7a-449a-8240-66dc14bda17f" height="75%" width="75%"></div>
&nbsp;

- **II) Launch Visual Studio, and select "Clone a repository", and paste the link to this GitHub repo in the "Repository Location" section**
<div align="center"><img src="https://github.com/riley-ad-clark/flight-planner/assets/144390085/dbb8ac0c-c784-434a-83fd-4fd3ee673371" height="75%" width="75%"></div>
</div>
&nbsp;

- **III) Once loaded, double click "FlightPlanner.sln" (found in the solution explorer on the right) and ensure you can see the following screen:**
<div align="center"><img src="https://github.com/riley-ad-clark/flight-planner/assets/144390085/2da2d43a-601c-45eb-993a-cd242f72b929" height="75%" width="75%"></div>
&nbsp;

- **IV) From this screen, select the following:**
&nbsp;
<div align="center">Tools (from the top menu) > NuGet Package Manager > Package Manager Console, this should open a new console</div>
&nbsp;
<div align="center"><img src="https://github.com/riley-ad-clark/flight-planner/assets/144390085/9a1681aa-6cc3-401d-a97b-32e40cd3463e" height="75%" width="75%"></div>
&nbsp;

- **V) Enter the following code in the console:**
&nbsp;
<div align="center"><code>PM> add-migration migration01 -Context ApplicationDbContext</code></div>
<div align="center">In short, this project uses a "code first" approach in terms of data storage. In doing so, we must manually connect to our local database, this is what the code above does.</div>






