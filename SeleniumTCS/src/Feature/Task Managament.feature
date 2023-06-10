Feature: Task_Managament
	
Scenario: 01 Login to Todoist
	Given I have access to todoist.com
	And I have access to login form
	When I use my credentials
	Then I should see the main page

Scenario: 02 Create Project 
	Given I go to the left menu
	And I set the data of my project
	When I click on add project confirmation button
	Then My project should be displayed on the projects list

	
Scenario: 04 Delete Project
	Given My project is updated 
	When I click on delete button
	Then The project should not be displayed