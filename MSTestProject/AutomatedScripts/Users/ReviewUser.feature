@JIRA_VISAI778 
Feature: Review User


  Background:
    * I go to the VSMC site
    * I should see the VSMC login page
    * I successfully login as a SYSADMIN

  Scenario: Review the details of a user (uid:43641b98-1147-43bb-b7c9-5a701ee1b7ec)
    * I add "my" user if they do not already exist
    * I click on the edit icon of "my" user
    * The First Name field should be set to "my users first name" on the user "details" page
    * The Last Name field should be set to "my users last name" on the user "details" page
    * The Email address field should be set to "my users email" on the user "details" page
