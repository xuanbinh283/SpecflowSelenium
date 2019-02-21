@JIRA_VISAI778 @NAVIGATION
Feature: Navigation


  Background:
    Given I go to the VSMC site
    Then I should see the VSMC login page
    And I successfully login as a SYSADMIN

  @AUTO_READY @NAVIGATION
  Scenario: Navigation around the VSMC by menu and browser (uid:f2c9110d-5d63-4bc5-8942-5a9a303af079)
    And I should see the Search Engines page
    And I click the BACK button on the browser
    And I should see the Search Engines page
    And I refresh the page
    And I should see the Search Engines page
    And I click the Admin drop-down
    And I select the Users entry in the Admin drop-down
    And I should see the Users main page
    And I click the BACK button on the browser
    And I should see the Search Engines page
    And I click the FORWARD button on the browser
    And I should see the Users main page
    And I refresh the page
    And I should see the Users main page
    And I click the Search drop-down
    And I select the Search Engines entry in the Search drop-down
    And I should see the Search Engines page
    And I log out of the system
    And I should see the VSMC login page
    And I click the BACK button on the browser
    And I should see the VSMC login page
