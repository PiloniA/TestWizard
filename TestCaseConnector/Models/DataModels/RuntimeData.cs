namespace AzureDevOpsTestConnector.Models.DataModels
{
    public class RuntimeData
    {
        public int ClassNameLine { get; internal set; }
        public int TestPlanAttributeLine { get; internal set; }
        public int TestSuiteAttributeLine { get; internal set; }
        public bool TestPlanAttributeFound { get; internal set; }
        public bool SpecflowFeatureFile { get; internal set; }
        public int ParentUserStoryAttributeLine { get; set; }
    }
}
