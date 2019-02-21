@JIRA_VISAI778 
Feature: Review Search Engine


  Background:
    * I go to the VSMC site
    * I should see the VSMC login page
    * I successfully login as a SYSADMIN

  @AUTO_READY
  Scenario: Create a search engine with a description and verify initial values. (uid:c454f2b6-60de-4ff2-8122-8b1b0d0333ef)
    * I add "my" search engine if it does not already exist
    * I click on the edit icon of "my" search engine
    * The Name field should be set to my search engine name on search engine "details" page
    * The Description field should be set to "Automated created search engine"
    * I click on the "Advanced" tab on the search engine details page
    * The Key field has my search engine key on the search engine "details" page
    * The Secret field should consist of "20" characters
    * I click on the "Search Features" tab on the search engine details page
    * I should see the message "" on the Search Features tab on the search engine details page
