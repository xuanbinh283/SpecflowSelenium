@JIRA_VISAI778 
Feature: Add User


  Background:
    * I go to the VSMC site
    * I should see the VSMC login page
    * I successfully login as a SYSADMIN

  @USERS @AUTO_READY
  Scenario: Add User, search, and verify data on main user screen (uid:e7090d62-8114-4873-a4ea-6dc721a67083)
    Note; we need to be careful with this script or run some cleanup script because the UI does not allow an Admin to delete users.
    And I click the Admin drop-down
    And I select the Users entry in the Admin drop-down
    And I should see the Users main page
    And I click the Add User button
    And I enter my user's first name
    And I enter my user's last name
    And I enter my user's email
    And I enter my user's password in the Password field
    And I enter my user's password in the Confirm Password field
    And I should see the Active checkbox is already checked
    And I check the Super User checkbox
    And I click the Add button on the Add User details page
    And I should see the Users main page
    And I search for my user by their email address
    And I should see my user in the list of users
    And The Full Name field should have my user lastname, firstname
    And The Email field should be my user's email
    And The Super User field should be set to Yes
    And The Status field should be set to Active
    And I should see a Last Updated timestamp of current time
    And The By field should be populated with SYSADMIN
    And I should see the edit icon for the user

  Scenario: Required fields on Add User (uid:81aae162-1d40-4e2c-96f5-9bdcac61f5a2)

  Scenario: Canceling adding a user (uid:1a8a9e54-0445-4f48-9b8f-af88e229f1ef)

  @AUTO_READY
  Scenario: Login in with a created user via automation (uid:3f31f790-c2d7-4b1f-8078-4c45a477af8d)
    * I log out of the system
    * I successfully login as my user
