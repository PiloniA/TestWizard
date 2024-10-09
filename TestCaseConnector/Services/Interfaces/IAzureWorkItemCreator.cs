using AzureDevOpsTestConnector.DTOs;

namespace AzureDevOpsTestConnector.Services.Interfaces;

public interface IAzureWorkItemCreator
{
    int CreateNewTestPlan(string patToken, string azureDevOpsUrl, string projectName, string testPlanName);

    int CreateNewTestSuite(string patToken, string azureDevOpsUrl, string projectName, string testSuiteName,
        int testPlanId, string testSuiteReqLinkIds);

    string CreateOrUpdateTestCase(WorkItemCreatorTestCaseData wICTestData);
}
