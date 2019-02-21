namespace Example {

    public class Actionwords {

        public void IClickTheLogInButton() {

        }

        public void IClickTheSearchEnginesOption() {

        }

        public void IGoToTheVSMCSite() {

        }

        public void IShouldSeeTwoDisabledDeleteSelectedButton() {

        }

        public void IShouldSeeTwoEnabledAddSearchEngineButton() {

        }

        public void IShouldSeeASearchBox() {

        }

        public void IShouldSeeSearchEngineLabelTitlesOfNameKeyDocumentsLastUpdatedByEditAndDeleteHeadings() {

        }

        public void IShouldSeeMySearchEngine() {

        }

        public void IShouldSeeADefaultDisplayPerPageOf20() {

        }

        public void ICountTheNumberOfSearchEnginesOnThePage() {

        }

        public void IVerifyALabelOfDisplayingItems1CountOfTotalIsDisplayedOnThePage(string count, string total) {

        }

        public void IVerifyPagePageNumberIsSelected(string pageNumber) {

        }

        public void ISearchForTheSearchEngineByName(string the) {

        }

        public void IVerifyThatOnlySearchEnginesThatMatchTheSearchTextByNameAppear() {

        }

        public void ISearchForMySearchEngineByKey() {

        }

        public void IShouldNotSeeMySearchEngine() {

        }

        public void ISelectTheSearchEngine(string the) {

        }

        public void IVerifyMySearchEngineIsChecked() {

        }

        public void IUnselectMySearchEngine() {

        }

        public void IVerifyMySearchEngineIsUnchecked() {

        }

        public void ISelectTheMainCheckboxForSearchEngines() {

        }

        public void IVerifyThatAllSearchEnginesAreSelected() {

        }

        public void IClickOnTheNameColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByName() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByName() {

        }

        public void IClickOnTheKeyColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByKey() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByKey() {

        }

        public void IClickOnTheDocumentsColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByDocuments() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByDocuments() {

        }

        public void IClickOnTheLastUpdatedColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByLastUpdated() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByLastUpdated() {

        }

        public void IClickOnTheByColumnHeader() {

        }

        public void IShouldNotSeeTheCaretSymbolNextToTheByColumnHeader() {

        }

        public void IRefreshThePage() {

        }

        public void ILogOutOfTheSystem() {

        }

        public void IShouldSeeTheVSMCLoginPage() {

        }

        public void IShouldSeeTheToasterConfirmationThatTheLoginHasFailed() {

        }

        public void IShouldSeeTheSearchEnginesPage() {

        }

        public void IShouldNotSeeTheSearchEnginesPage() {

        }

        public void IPressTabOnTheEmailAddressField() {

        }

        public void IShouldSeeTheEmailIsRequiredMessage() {

        }

        public void IShouldSeeThePasswordIsRequiredMessage() {

        }

        public void TheLogInButtonShouldBeDisabled() {

        }

        public void TheLogInButtonShouldBeEnabled() {

        }

        public void IClearTheEmailAddressField() {

        }

        public void IClearThePasswordField() {

        }

        public void IUnsuccessfullyLoginAsASYSADMIN() {
            IClearTheEmailAddressField();
            IEnterASysadminEmailAddress();
            IClearThePasswordField();
            IEnterABadPassword();
            IClickTheLogInButton();
            IShouldSeeTheToasterConfirmationThatTheLoginHasFailed();
        }

        public void ISuccessfullyLoginAsASYSADMIN() {
            IClearTheEmailAddressField();
            IEnterASysadminEmailAddress();
            IClearThePasswordField();
            IEnterASysadminPassword();
            IClickTheLogInButton();
            IShouldSeeTheSearchEnginesPage();
        }

        public void IShouldSeeTheMessageTheScreenText(string theScreenText) {

        }

        public void IClickTheAddSearchEngineButton() {

        }

        public void IShouldSeeTheAddSearchEngineDetailsScreen() {

        }

        public void IEnterARandomAutomatedSearchEngineName() {

        }

        public void IVerifyThatTheKeyPrefixIsSetToKey(string key) {

        }

        public void IEnterADescriptionOfMyDescription(string myDescription) {

        }

        public void IClickTheSaveButtonOnTheSearchEngineDetailsPage() {

        }

        public void IShouldSeeTheAddSuccessfulToasterConfirmation() {

        }

        public void IShouldSeeTheSearchEngineInTheListOfSearchEngines(string the) {
            // Then I should see "my" search engine name
            IShouldSeeMySearchEngineName("my");
            // And I should see the key prefixed by STANDARD_KEY
            IShouldSeeTheKeyPrefixedBySTANDARDKEY();
            // And The key should contain "20" characters
            TheKeyShouldContainCharCountCharacters("20");
            // And I should see a document count of 0
            IShouldSeeADocumentCountOf0();
            // And I should see a Last Updated timestamp of current time
            IShouldSeeALastUpdatedTimestampOfCurrentTime();
            // And I should see a By field populated with "p_SYSTEM_ADMIN_NAME"
            IShouldSeeAByFieldPopulatedWithUser("p_SYSTEM_ADMIN_NAME");
            // And I should see the Edit icon for "my" search engine
            IShouldSeeTheEditIconForMySearchEngine("my");
            // And I should see the Delete icon for "my" search engine
            IShouldSeeTheDeleteIconForMySearchEngine("my");
        }

        public void IShouldSeeMySearchEngineName(string my) {

        }

        public void IShouldSeeTheKeyPrefixedBySTANDARDKEY() {

        }

        public void IShouldSeeADocumentCountOf0() {

        }

        public void IShouldSeeALastUpdatedTimestampOfCurrentTime() {

        }

        public void IShouldSeeAByFieldPopulatedWithUser(string user) {

        }

        public void IShouldSeeTheEditIconForMySearchEngine(string my) {

        }

        public void IShouldSeeTheDeleteIconForMySearchEngine(string my) {

        }

        public void TheKeyShouldContainCharCountCharacters(string charCount) {

        }

        public void IShouldSeeTheSearchResultOfP1(string p1) {

        }

        public void IClearTheSearchEngineBox() {

        }

        public void IShouldSeeDisplay1countOfTotalOnThePage() {

        }

        public void IClickTheTrashCanAssociatedWithMySearchEngine() {

        }

        public void IShouldSeeTheDeleteConfirmationModalForIdentifierSearchEngineS(string identifier) {

        }

        public void IClickYesOnTheDeleteConfirmationModal() {

        }

        public void IShouldSeeDeleteToasterConfirmationThatNumberSearchEnginesHaveBeenDeleted(string number) {

        }

        public void IShouldNotSeeTheSearchEngineInTheListOfSearchEngines(string the) {

        }

        public void IClickNoOnTheDeleteConfirmationModal() {

        }

        public void IAddTheSearchEngineIfItDoesNotAlreadyExist(string the) {

        }

        public void IClickTheAdminDropdown() {

        }

        public void ISelectTheUsersEntryInTheAdminDropdown() {

        }

        public void IShouldSeeTheUsersMainPage() {

        }

        public void IClickTheAddUserButton() {

        }

        public void IEnterMyUsersFirstName() {

        }

        public void IEnterMyUsersLastName() {

        }

        public void IEnterMyUsersEmail() {

        }

        public void IEnterMyUsersPasswordInThePasswordField() {

        }

        public void IEnterMyUsersPasswordInTheConfirmPasswordField() {

        }

        public void IShouldSeeTheActiveCheckboxIsAlreadyChecked() {

        }

        public void ICheckTheSuperUserCheckbox() {

        }

        public void IClickTheAddButtonOnTheAddUserDetailsPage() {

        }

        public void ISearchForMyUserByTheirEmailAddress() {

        }

        public void IShouldSeeMyUserInTheListOfUsers() {

        }

        public void TheFullNameFieldShouldHaveMyUserLastnameFirstname() {

        }

        public void TheEmailFieldShouldBeMyUsersEmail() {

        }

        public void TheSuperUserFieldShouldBeSetToYes() {

        }

        public void TheStatusFieldShouldBeSetToActive() {

        }

        public void TheByFieldShouldBePopulatedWithSYSADMIN() {

        }

        public void IShouldSeeTheEditIconForTheUser() {

        }

        public void IClickTheSearchDropdown() {

        }

        public void ISelectTheSearchEnginesEntryInTheSearchDropdown() {

        }

        public void IClickTheBACKButtonOnTheBrowser() {

        }

        public void IClickTheFORWARDButtonOnTheBrowser() {

        }

        public void TheNameFieldShouldBeSetToMySearchEngineNameOnSearchEnginePagePage(string page) {

        }

        public void TheKeyFieldHasMySearchEngineKeyOnTheSearchEngineTypePage(string type) {

        }

        public void TheDocumentsFieldShouldBeSetToDocCount(string docCount) {

        }

        public void IShouldSeeTheTrashCanIconForTheSearchEngine() {

        }

        public void IShouldSeeTheDeleteSelectedButtonOnTheSearchEnginesPageDisabled() {

        }

        public void IClickTheDeleteSelectedButtonOnTheSearchEnginePage() {

        }

        public void IShouldNotSeeTheDeleteToasterConfirmation() {

        }

        public void IEnterAnEmailAddressEmail(string email) {

        }

        public void IEnterAPasswordPassword(string password) {

        }

        public void IShouldSeeTheUserFullNameIsFullname(string fullname) {

        }

        public void IEnterASysadminEmailAddress() {
            IEnterAnEmailAddressEmail("p_sysadmin_login");
        }

        public void IEnterASysadminPassword() {
            IEnterAPasswordPassword("p_sysadmin_password");
        }

        public void IEnterABadPassword() {
            IEnterAPasswordPassword("password=p_bad_password");
        }

        public void IEnterASuperUserEmail() {
            IEnterAnEmailAddressEmail("p_superuser_email");
        }

        public void IEnterASuperUserPassword() {
            IEnterAPasswordPassword("password=p_superuser_password");
        }

        public void IEnterABadEmailAddress() {
            IEnterAnEmailAddressEmail("email=p_bad_email");
        }

        public void IEnterAShortPassword() {
            IEnterAPasswordPassword("password=p_short_password");
        }

        public void ISelectAllSearchEngines() {

        }

        public void IVerifyAllSearchEnginesAreSelectedOnTheCurrentPage() {

        }

        public void IUnselectAllSearchEngines() {

        }

        public void IVerifyAllSearchEnginesAreUnselectedOnTheCurrentPage() {

        }

        public void ICloseAllWebBrowsers() {

        }

        public void IClickOnTheEditIconOfP1SearchEngine(string p1) {

        }

        public void TheDescriptionFieldShouldBeSetToTheDescription(string theDescription) {

        }

        public void IClickOnTheTabNameTabOnTheSearchEngineDetailsPage(string tabName) {

        }

        public void TheSecretFieldShouldConsistOfNumberCharacters(string number) {

        }

        public void IShouldSeeTheMessageTheMsgOnTheSearchFeaturesTabOnTheSearchEngineDetailsPage(string theMsg) {

        }

        public void ISuccessfullyLoginAsMyUser() {
            IClearTheEmailAddressField();
            IEnterMyUserEmailAddress();
            IClearThePasswordField();
            IEnterMyUserPassword();
            IClickTheLogInButton();
            IShouldSeeTheSearchEnginesPage();
        }

        public void IEnterMyUserEmailAddress() {
            IEnterAnEmailAddressEmail("my_user_email");
        }

        public void IEnterMyUserPassword() {
            IEnterAPasswordPassword("my_user_password");
        }

        public void IAddTheUserIfTheyDoNotAlreadyExist(string the) {

        }

        public void IClickOnTheEditIconOfTheUser(string the) {

        }

        public void TheFirstNameFieldShouldBeSetToMyUsersFirstNameOnTheUsersDetailsPage(string myUsersFirstName, string details) {

        }

        public void TheFirstNameFieldShouldBeSetToFirstNameOnTheUserTypePage(string firstName, string type) {

        }

        public void TheLastNameFieldShouldBeSetToLastNameOnTheUserTypePage(string lastName, string type) {

        }

        public void TheEmailAddressFieldShouldBeSetToEmailAddressOnTheUserTypePage(string emailAddress, string type) {

        }
    }
}