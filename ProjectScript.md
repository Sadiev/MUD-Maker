# Team Procedures for Creating\Deploying\Running Azure-Based MUD Maker Applications

## I Want to...

### Setup Azure Devops

* Go to [Azure DevOps Organization Dashboard for Team 2](https://dev.azure.com/MSSA-Team-2/)
* Click 'Create New Project'
* Enter a Project Name, Description, and Visibility of Public.
* Click 'Create'

### Setup Azure AD / Integrate with Azure Devops

* Insert step-by-step here

### Define and assign Roles in Azure AD

* Insert step-by-step here

### Create a Repo

* Within the Project on the Azure Devops Project Portal, click on 'Repos'
* On the right hand side of the screen, scroll to the bottom.  Under 'Or initialize with a README or gitignore, select 'Add a README'.
* On the drop down menu for 'Add a .gitignore' select 'VisualStudio'.
* Select 'Initialize'.

### Connect the repo to Visual Studio

* Within the Project on the Azure Devops Project Portal, click on 'Repos'.
* On the upper-right portion of the screen, click 'Clone'.
* Copy the URL next to 'HTTPS'
* Launch Visual Studio and select 'Clone or Checkout code' in the upper right of the 'Get Started' window.
* Under 'Repository location', paste the url copied in the previous step.
* Click 'Clone'.

### Initial a new MVC template application with Identity FrameWork pre-installed (this is a one time action by a single member of the team)

* Within the cloned project in Visual Studio, click File -> New -> Project
* Select ASP.NET Core Web Application.
* In the Configure New Project window, enter "MUD-Maker" for project name.
* Under location, navigate to the location of the local repository for MUD-maker create in the "Connect the repo to Visual Studio" step.
* Click create.
* On the "Create a new ASP.NET Core Web Application" window, select "Web Application (Model-View-Controller).
* Under "Authentication" click "Change"
* In the Change Authentication window select the radio button for "Individual User Accounts".
* Click "OK", then click "Create"
* Test the application (without debugging).  You should have a functioning web page with the ability to create new login accounts, and login/logout.
* If the application works correctly, commit the changes to the Master branch of the project.

### Create a new Development Branch (this is a one time action by a single member of the team)

* In the bottom right corner of Visual Studio, click the master branch, and then click "Mange Branches".
* In the Team Explorer slide out, right click on the "Master" branch, and select "New Branch From".
* In the "Enter a Branch" text box, type "Development".
* select "Create Branch".
* Once the Development branch is created, right click "Development" in the Team Explorer slide out, and select "Push Branch" from the pop-out menu.
