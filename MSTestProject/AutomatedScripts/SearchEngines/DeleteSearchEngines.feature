@JIRA_VISAI778 
Feature: Delete Search Engines


  Background:
    Given I go to the VSMC site
    And I should see the VSMC login page
    And I successfully login as a SYSADMIN

  @AUTO_READY @SEARCH_ENGINE
  Scenario: Delete search engine by icon - yes (uid:3f4237d8-6cd2-4932-84db-58746e91d5f0)
    Then I add "my" search engine if it does not already exist
    Then I search for "my" search engine by Name
    And I should see "my" search engine in the list of search engines
    When I click the trash can associated with my search engine
    Then I should see the Delete Confirmation modal for "my" search engine s
    And I click Yes on the Delete Confirmation modal
    And I should see Delete toaster confirmation that "1" search engines have been deleted
    And I should not see "my" search engine in the list of search engines

  @AUTO_READY @SEARCH_ENGINE
  Scenario: Delete search engine by icon - no (uid:beb6f288-e3af-4b6e-aa8c-2fa5ab53d2de)
    And I add "my" search engine if it does not already exist
    Then I search for "my" search engine by Name
    And I should see "my" search engine in the list of search engines
    When I click the trash can associated with my search engine
    Then I should see the Delete Confirmation modal for "my" search engine s
    And I click No on the Delete Confirmation modal
    And I should see my search engine

  @AUTO_READY @SEARCH_ENGINE
  Scenario: Delete search engine by button - yes (uid:23f02b0c-5872-458f-8b76-246f1d639f62)
    Then I add "my" search engine if it does not already exist
    Then I search for "my" search engine by Name
    And I should see "my" search engine in the list of search engines
    And I should see the Delete Selected button on the search engines page disabled
    And I select "my" search engine
    And I click the Delete Selected button on the search engine page
    Then I should see the Delete Confirmation modal for "my" search engine s
    And I click Yes on the Delete Confirmation modal
    And I should see Delete toaster confirmation that "1" search engines have been deleted
    And I should not see "my" search engine in the list of search engines

  @AUTO_READY @SEARCH_ENGINE
  Scenario: Delete search engine by button - no (uid:e6ad8020-86c7-4a7d-8cbd-157152e53599)
    Then I add "my" search engine if it does not already exist
    Then I search for "my" search engine by Name
    And I should see "my" search engine in the list of search engines
    And I should see the Delete Selected button on the search engines page disabled
    And I select "my" search engine
    And I click the Delete Selected button on the search engine page
    Then I should see the Delete Confirmation modal for "my" search engine s
    And I click No on the Delete Confirmation modal
    And I should not see the Delete toaster confirmation
    And I should see "my" search engine in the list of search engines

  @AUTO_READY @SEARCH_ENGINE
  Scenario: Delete multiple search engine by button - no and yes (uid:37ee2878-2ffc-4170-937e-d8ec42aa3e34)
    Then I add "my" search engine if it does not already exist
    Then I search for "my" search engine by Name
    And I should see "my" search engine in the list of search engines
    Then I add "second" search engine if it does not already exist
    And I search for "second" search engine by Name
    And I should see "second" search engine in the list of search engines
    And I should see the Delete Selected button on the search engines page disabled
    And I select all search engines
    And I verify all search engines are selected on the current page
    And I unselect all search engines
    And i verify all search engines are unselected on the current page
    And I select "my" search engine
    And I select "second" search engine
    And I click the Delete Selected button on the search engine page
    Then I should see the Delete Confirmation modal for "2" search engine s
    And I click No on the Delete Confirmation modal
    And I should see "my" search engine in the list of search engines
    And I should see "second" search engine in the list of search engines
    And I click Yes on the Delete Confirmation modal
    And I should see Delete toaster confirmation that "2" search engines have been deleted
    And I should not see "my" search engine in the list of search engines
    And I should not see "second" search engine in the list of search engines
