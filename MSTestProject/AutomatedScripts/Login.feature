@JIRA_VISAI778 @LOGIN
Feature: Login


  Background:
    Given I go to the VSMC site
    Then I should see the VSMC login page

  @AUTO_READY @LOGIN
  Scenario: Successful system admin login and logout (uid:5b840636-7944-4afa-8175-91d2b049f56d)
    Given I enter a sysadmin email address
    And I enter a sysadmin password
    Then The Log in button should be enabled
    When I click the Log in button
    Then I should see the Search Engines page
    And I should see the user full name is "System, Admin"
    Then I log out of the system
    Then I should see the VSMC login page
    Then I close all web browsers

  @AUTO_READY @LOGIN
  Scenario: Unsuccessful system administrator login (uid:f0d8da9d-7069-4218-ac00-ff5dd72a6eaf)
    And I unsuccessfully login as a SYSADMIN

  @LOGIN @AUTO_READY
  Scenario: Successful user login and logout (uid:a682a789-3be2-4b6a-a051-e5ba383e49fa)
    Given I enter a super user email
    And I enter a super user password
    Then The Log in button should be enabled
    When I click the Log in button
    And I should see the Search Engines page
    When I log out of the system
    Then I should see the VSMC login page

  @LOGIN @AUTO_READY
  Scenario: Required fields for login (uid:68fbf401-d6eb-44f8-9dcd-6f3d4972e868)
    When I press tab on the email address field
    Then I should see the Email is required message
    And I should see the Password is required message
    And The Log in button should be disabled

  @LOGIN @AUTO_READY
  Scenario: Login attempts are not restricted (uid:78590e2a-a8e8-4cfd-9564-4112fc501f09)
    Since most systems have a login attempts limited to 3 before you are locked out or 5 in the CMS case, attempt to login five unsuccessful time and then a sixth successful time.
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I successfully login as a SYSADMIN

  @LOGIN @AUTO_READY
  Scenario: Restrictions on email and password fields (uid:d40bf40f-8c25-4225-9fba-f173232b7e01)
    Given I enter a bad email address
    Then I should see the message "Email must be a valid email address"
    When I clear the email address field
    And I enter a sysadmin email address
    And I enter a short password
    Then I should see the message "Password must be at least 8 characters"
    And The Log in button should be disabled
