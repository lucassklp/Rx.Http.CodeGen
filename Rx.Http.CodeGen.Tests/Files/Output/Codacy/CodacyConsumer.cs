using System;
using Rx.Http;
using Rx.Http.Extensions;
using Codacy.Models;

namespace Codacy
{
    class CodacyConsumer : RxHttpClient
    {
        public CodacyConsumer(HttpClient httpClient) : base(httpClient, null)
        {
            httpClient.BaseAddress = new Uri("https://app.codacy.com/api/v3");
        }

        public IObservable<Models.Version> GetVersion()
        {
            return Get<Models.Version>($"/version");
        }
        public IObservable<RepositoryWithAnalysisListResponse> ListOrganizationRepositoriesWithAnalysis(string provider, string remoteOrganizationName, string cursor, int limit, string search, string repositories)
        {
            return Get<RepositoryWithAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
                options.AddQueryString("repositories", repositories);
            });
        }
        public IObservable<RepositoryWithAnalysisListResponse> SearchOrganizationRepositoriesWithAnalysis(SearchOrganizationRepositoriesWithAnalysis body, string provider, string remoteOrganizationName, string cursor, int limit)
        {
            return Post<RepositoryWithAnalysisListResponse>($"/search/analysis/organizations/{provider}/{remoteOrganizationName}/repositories", body, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<RepositoryWithAnalysisResponse> GetRepositoryWithAnalysis(string provider, string remoteOrganizationName, string repositoryName, string branch)
        {
            return Get<RepositoryWithAnalysisResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}", null, options => {
                options.AddQueryString("branch", branch);
            });
        }
        public IObservable<AnalysisToolsResponse> ListRepositoryTools(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<AnalysisToolsResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tools");
        }
        public IObservable<RxHttpResponse> ConfigureTool(ConfigureToolBody body, string provider, string remoteOrganizationName, string repositoryName, string toolUuid, bool deleteIssuesForDisabledPatterns)
        {
            return Patch($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tools/{toolUuid}", body, options => {
                options.AddQueryString("deleteIssuesForDisabledPatterns", deleteIssuesForDisabledPatterns);
            });
        }
        public IObservable<ConfiguredPatternsListResponse> ListRepositoryToolPatterns(string provider, string remoteOrganizationName, string repositoryName, string toolUuid, string languages, string categories, string severityLevels, string search, bool enabled, string sort, string direction, string cursor, int limit)
        {
            return Get<ConfiguredPatternsListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tools/{toolUuid}/patterns", null, options => {
                options.AddQueryString("languages", languages);
                options.AddQueryString("categories", categories);
                options.AddQueryString("severityLevels", severityLevels);
                options.AddQueryString("search", search);
                options.AddQueryString("enabled", enabled);
                options.AddQueryString("sort", sort);
                options.AddQueryString("direction", direction);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<RxHttpResponse> UpdateRepositoryToolPatterns(UpdatePatternsBody body, string provider, string remoteOrganizationName, string repositoryName, string toolUuid, string languages, string categories, string severityLevels, string search)
        {
            return Patch($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tools/{toolUuid}/patterns", body, options => {
                options.AddQueryString("languages", languages);
                options.AddQueryString("categories", categories);
                options.AddQueryString("severityLevels", severityLevels);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<FirstAnalysisOverviewResponse> GetFirstAnalysisOverview(string provider, string remoteOrganizationName, string repositoryName, string branch)
        {
            return Get<FirstAnalysisOverviewResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/analysisProgress", null, options => {
                options.AddQueryString("branch", branch);
            });
        }
        public IObservable<PullRequestWithAnalysisListResponse> ListRepositoryPullRequests(string provider, string remoteOrganizationName, string repositoryName, int limit, string cursor, string search, bool includeNotAnalyzed)
        {
            return Get<PullRequestWithAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests", null, options => {
                options.AddQueryString("limit", limit);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("search", search);
                options.AddQueryString("includeNotAnalyzed", includeNotAnalyzed);
            });
        }
        public IObservable<PullRequestWithAnalysis> GetRepositoryPullRequest(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<PullRequestWithAnalysis>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}");
        }
        public IObservable<PullRequestWithCoverageResponse> GetRepositoryPullRequestCoverage(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<PullRequestWithCoverageResponse>($"/coverage/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}");
        }
        public IObservable<PullRequestFilesCoverageResponse> GetRepositoryPullRequestFilesCoverage(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<PullRequestFilesCoverageResponse>($"/coverage/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/files");
        }
        public IObservable<RxHttpResponse> ReanalyzeCoverage(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get($"/coverage/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/reanalyze");
        }
        public IObservable<CommitWithAnalysisListResponse> GetPullRequestCommits(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber, int limit, string cursor)
        {
            return Get<CommitWithAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/commits", null, options => {
                options.AddQueryString("limit", limit);
                options.AddQueryString("cursor", cursor);
            });
        }
        public IObservable<RxHttpResponse> BypassPullRequestAnalysis(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Post($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/bypass");
        }
        public IObservable<CoveragePullRequestResponse> GetPullRequestCoverageReports(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<CoveragePullRequestResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/coverage/status");
        }
        public IObservable<PullRequestIssuesResponse> ListPullRequestIssues(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber, string status, bool onlyPotential, string cursor, int limit)
        {
            return Get<PullRequestIssuesResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/issues", null, options => {
                options.AddQueryString("status", status);
                options.AddQueryString("onlyPotential", onlyPotential);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<ClonesResponse> ListPullRequestClones(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber, string status, bool onlyPotential, string cursor, int limit)
        {
            return Get<ClonesResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/clones", null, options => {
                options.AddQueryString("status", status);
                options.AddQueryString("onlyPotential", onlyPotential);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<ClonesResponse> ListCommitClones(string provider, string remoteOrganizationName, string repositoryName, string commitUuid, string status, bool onlyPotential, string cursor, int limit)
        {
            return Get<ClonesResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{commitUuid}/clones", null, options => {
                options.AddQueryString("status", status);
                options.AddQueryString("onlyPotential", onlyPotential);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<LogsResponse> ListPullRequestLogs(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<LogsResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/logs");
        }
        public IObservable<LogsResponse> ListCommitLogs(string provider, string remoteOrganizationName, string repositoryName, string commitUuid)
        {
            return Get<LogsResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{commitUuid}/logs");
        }
        public IObservable<DeprecatedRepositoryQualitySettingsResponse> GetRepositoryQualitySettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<DeprecatedRepositoryQualitySettingsResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/qualitySettings");
        }
        public IObservable<FileAnalysisListResponse> ListCommitFiles(string provider, string remoteOrganizationName, string repositoryName, string commitUuid, string branch, string filter, string cursor, int limit, string search, string sortColumn, string columnOrder)
        {
            return Get<FileAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{commitUuid}/files", null, options => {
                options.AddQueryString("branch", branch);
                options.AddQueryString("filter", filter);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
                options.AddQueryString("sortColumn", sortColumn);
                options.AddQueryString("columnOrder", columnOrder);
            });
        }
        public IObservable<FileAnalysisListResponse> ListPullRequestFiles(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber, string cursor, int limit, string sortColumn, string columnOrder)
        {
            return Get<FileAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/files", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("sortColumn", sortColumn);
                options.AddQueryString("columnOrder", columnOrder);
            });
        }
        public IObservable<AddedStateResponse> FollowAddedRepository(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<AddedStateResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/follow");
        }
        public IObservable<RxHttpResponse> UnfollowRepository(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/follow");
        }
        public IObservable<RepositoryQualitySettingsResponse> GetQualitySettingsForRepository(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<RepositoryQualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/repository");
        }
        public IObservable<RepositoryQualitySettingsResponse> UpdateRepositoryQualitySettings(RepositoryQualitySettings body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Put<RepositoryQualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/repository", body);
        }
        public IObservable<SshKeySettingResponse> RegenerateUserSshKey(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<SshKeySettingResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/sshUserKey");
        }
        public IObservable<SshKeySettingResponse> RegenerateRepositorySshKey(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<SshKeySettingResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/sshRepositoryKey");
        }
        public IObservable<SshKeySettingResponse> GetRepositoryPublicSshKey(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<SshKeySettingResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/storedSshKey");
        }
        public IObservable<SyncProviderSettingResponse> SyncRepositoryWithProvider(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<SyncProviderSettingResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/sync");
        }
        public IObservable<BuildServerAnalysisSettingResponse> GetBuildServerAnalysisSetting(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<BuildServerAnalysisSettingResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/analysis");
        }
        public IObservable<BuildServerAnalysisSettingResponse> UpdateBuildServerAnalysisSetting(BuildServerAnalysisSettingRequest body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Patch<BuildServerAnalysisSettingResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/analysis", body);
        }
        public IObservable<RepositoryLanguageResponse> GetRepositoryLanguages(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<RepositoryLanguageResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/languages");
        }
        public IObservable<RxHttpResponse> PatchRepositoryLanguageResponseSettings(RepositoryLanguagesBody body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/languages", body);
        }
        public IObservable<FileExtensionsResponse> GetFileExtensionsSettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<FileExtensionsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/fileExtensions");
        }
        public IObservable<RxHttpResponse> PatchFileExtensionsSettings(FileExtensionsBody body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/fileExtensions", body);
        }
        public IObservable<QualitySettingsResponse> GetCommitQualitySettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<QualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/commits");
        }
        public IObservable<QualitySettingsResponse> UpdateCommitQualitySettings(QualityGate body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Put<QualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/commits", body);
        }
        public IObservable<QualitySettingsResponse> ResetCommitsQualitySettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<QualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/commits/reset");
        }
        public IObservable<QualitySettingsResponse> ResetPullRequestsQualitySettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<QualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/pullRequests/reset");
        }
        public IObservable<RepositoryQualitySettingsResponse> ResetRepositoryQualitySettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<RepositoryQualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/repository/reset");
        }
        public IObservable<QualitySettingsResponse> GetPullRequestQualitySettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<QualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/pullRequests");
        }
        public IObservable<QualitySettingsResponse> UpdatePullRequestQualitySettings(QualityGate body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Put<QualitySettingsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/settings/quality/pullRequests", body);
        }
        public IObservable<PullRequestWithAnalysisListResponse> ListOrganizationPullRequests(string provider, string remoteOrganizationName, int limit, string search, string repositories)
        {
            return Get<PullRequestWithAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/pullRequests", null, options => {
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
                options.AddQueryString("repositories", repositories);
            });
        }
        public IObservable<CommitAnalysisStatsListResponse> ListCommitAnalysisStats(string provider, string remoteOrganizationName, string repositoryName, string branch, int days)
        {
            return Get<CommitAnalysisStatsListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commitStatistics", null, options => {
                options.AddQueryString("branch", branch);
                options.AddQueryString("days", days);
            });
        }
        public IObservable<CategoryOverviewListResponse> ListCategoryOverviews(string provider, string remoteOrganizationName, string repositoryName, string branch)
        {
            return Get<CategoryOverviewListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/categoryOverviews", null, options => {
                options.AddQueryString("branch", branch);
            });
        }
        public IObservable<GetIssueResponse> GetIssue(string provider, string remoteOrganizationName, string repositoryName, int resultDataId)
        {
            return Get<GetIssueResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/issues/{resultDataId}");
        }
        public IObservable<SearchRepositoryIssuesListResponse> SearchRepositoryIssues(SearchRepositoryIssuesBody body, string provider, string remoteOrganizationName, string repositoryName, string cursor, int limit)
        {
            return Post<SearchRepositoryIssuesListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/issues/search", body, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<IssuesOverviewResponse> IssuesOverview(SearchRepositoryIssuesBody body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post<IssuesOverviewResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/issues/overview", body);
        }
        public IObservable<RxHttpResponse> UpdateIssueState(IssueStateBody body, string provider, string remoteOrganizationName, string repositoryName, string issueId)
        {
            return Patch($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/issues/{issueId}", body);
        }
        public IObservable<IgnoredIssuesListResponse> SearchRepositoryIgnoredIssues(SearchRepositoryIssuesBody body, string provider, string remoteOrganizationName, string repositoryName, string cursor, int limit)
        {
            return Post<IgnoredIssuesListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/ignoredIssues/search", body, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<CommitWithAnalysisListResponse> ListRepositoryCommits(string provider, string remoteOrganizationName, string repositoryName, string branch, string cursor, int limit)
        {
            return Get<CommitWithAnalysisListResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits", null, options => {
                options.AddQueryString("branch", branch);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<CommitWithAnalysis> GetCommit(string provider, string remoteOrganizationName, string repositoryName, string commitUuid)
        {
            return Get<CommitWithAnalysis>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{commitUuid}");
        }
        public IObservable<CommitDeltaStatistics> GetCommitDeltaStatistics(string provider, string remoteOrganizationName, string repositoryName, string commitUuid)
        {
            return Get<CommitDeltaStatistics>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{commitUuid}/deltaStatistics");
        }
        public IObservable<CommitDeltaIssuesResponse> ListCommitDeltaIssues(string provider, string remoteOrganizationName, string repositoryName, string srcCommitUuid, string targetCommitUuid, string status, bool onlyPotential, string cursor, int limit)
        {
            return Get<CommitDeltaIssuesResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{srcCommitUuid}/deltaIssues", null, options => {
                options.AddQueryString("targetCommitUuid", targetCommitUuid);
                options.AddQueryString("status", status);
                options.AddQueryString("onlyPotential", onlyPotential);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<UserResponse> GetUser()
        {
            return Get<UserResponse>($"/user");
        }
        public IObservable<RxHttpResponse> DeleteUser()
        {
            return Delete($"/user");
        }
        public IObservable<UserResponse> PatchUser(UserBody body)
        {
            return Patch<UserResponse>($"/user", body);
        }
        public IObservable<OrganizationListResponse> ListUserOrganizations(string cursor, int limit)
        {
            return Get<OrganizationListResponse>($"/user/organizations", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<OrganizationListResponse> ListOrganizations(string cursor, int limit, string provider)
        {
            return Get<OrganizationListResponse>($"/user/organizations/{provider}", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<OrganizationResponse> GetUserOrganization(string provider, string remoteOrganizationName)
        {
            return Get<OrganizationResponse>($"/user/organizations/{provider}/{remoteOrganizationName}");
        }
        public IObservable<IntegrationListResponse> ListUserIntegrations(string cursor, int limit)
        {
            return Get<IntegrationListResponse>($"/user/integrations", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<RxHttpResponse> DeleteIntegration(string accountProvider)
        {
            return Delete($"/user/integrations/{accountProvider}");
        }
        public IObservable<OrganizationWithMetaResponse> GetOrganization(string provider, string remoteOrganizationName)
        {
            return Get<OrganizationWithMetaResponse>($"/organizations/{provider}/{remoteOrganizationName}");
        }
        public IObservable<RxHttpResponse> DeleteOrganization(ChurnFeedback body, string provider, string remoteOrganizationName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}", body);
        }
        public IObservable<OrganizationResponse> GetOrganizationByInstallationId(string provider, int installationId)
        {
            return Get<OrganizationResponse>($"/organizations/{provider}/installation/{installationId}");
        }
        public IObservable<OrganizationBillingInformationResponse> OrganizationDetailedBilling(string provider, string remoteOrganizationName)
        {
            return Get<OrganizationBillingInformationResponse>($"/organizations/{provider}/{remoteOrganizationName}/billing");
        }
        public IObservable<RxHttpResponse> SyncMarketplaceBilling(string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/billing/sync");
        }
        public IObservable<RxHttpResponse> ApplyProviderSettings(string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/integrations/providerSettings/apply");
        }
        public IObservable<ProviderIntegrationSettingsBody> GetProviderSettings(string provider, string remoteOrganizationName)
        {
            return Get<ProviderIntegrationSettingsBody>($"/organizations/{provider}/{remoteOrganizationName}/integrations/providerSettings");
        }
        public IObservable<RxHttpResponse> UpdateProviderSettings(ProviderIntegrationSettingsPatchBody body, string provider, string remoteOrganizationName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/integrations/providerSettings", body);
        }
        public IObservable<RepositoryIntegrationSettings> GetRepositoryIntegrationsSettings(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<RepositoryIntegrationSettings>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/integrations/providerSettings");
        }
        public IObservable<RxHttpResponse> UpdateRepositoryIntegrationsSettings(ProviderIntegrationSettingsPatchBody body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/integrations/providerSettings", body);
        }
        public IObservable<RxHttpResponse> CreatePostCommitHook(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/integrations/postCommitHook");
        }
        public IObservable<RxHttpResponse> RefreshProviderRepositoryIntegration(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/integrations/refreshProvider");
        }
        public IObservable<RepositoryListResponse> ListOrganizationRepositories(string provider, string remoteOrganizationName, string cursor, int limit, string search, string filter, string languages)
        {
            return Get<RepositoryListResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
                options.AddQueryString("filter", filter);
                options.AddQueryString("languages", languages);
            });
        }
        public IObservable<OrganizationOnboardingProgressResponse> RetrieveOrganizationOnboardingProgress(string provider, string remoteOrganizationName)
        {
            return Get<OrganizationOnboardingProgressResponse>($"/onboarding/organizations/{provider}/{remoteOrganizationName}/progress");
        }
        public IObservable<ListPeopleResponse> ListPeopleFromOrganization(string provider, string remoteOrganizationName, string cursor, int limit, string search, bool onlyMembers)
        {
            return Get<ListPeopleResponse>($"/organizations/{provider}/{remoteOrganizationName}/people", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
                options.AddQueryString("onlyMembers", onlyMembers);
            });
        }
        public IObservable<RxHttpResponse> AddPeopleToOrganization(List<string> body, string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/people", body);
        }
        public IObservable<string> ListPeopleFromOrganizationCsv(string provider, string remoteOrganizationName)
        {
            return Get<string>($"/organizations/{provider}/{remoteOrganizationName}/peopleCsv");
        }
        public IObservable<RxHttpResponse> PatchOrganizationSettings(MembershipPrivilegesBody body, string provider, string remoteOrganizationName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/analysisConfigurationMinimumPermission", body);
        }
        public IObservable<RemovePeopleResponse> RemovePeopleFromOrganization(RemovePeopleBody body, string provider, string remoteOrganizationName)
        {
            return Post<RemovePeopleResponse>($"/organizations/{provider}/{remoteOrganizationName}/people/remove", body);
        }
        public IObservable<GitProviderAppPermissions> GitProviderAppPermissions(string provider, string remoteOrganizationName)
        {
            return Get<GitProviderAppPermissions>($"/organizations/{provider}/{remoteOrganizationName}/gitProviderAppPermissions");
        }
        public IObservable<SuggestedAuthorsResponse> PeopleSuggestionsForOrganization(string provider, string remoteOrganizationName, string cursor, int limit, string search)
        {
            return Get<SuggestedAuthorsResponse>($"/organizations/{provider}/{remoteOrganizationName}/people/suggestions", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<RxHttpResponse> ReanalyzeCommitById(CommitUuidRequest body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/reanalyzeCommit", body);
        }
        public IObservable<RepositoryResponse> GetRepository(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<RepositoryResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}");
        }
        public IObservable<RxHttpResponse> DeleteRepository(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}");
        }
        public IObservable<RepositorySuggestedAuthorsResponse> PeopleSuggestionsForRepository(string provider, string remoteOrganizationName, string repositoryName, string cursor, int limit, string search)
        {
            return Get<RepositorySuggestedAuthorsResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/people/suggestions", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<BranchListResponse> ListRepositoryBranches(string provider, string remoteOrganizationName, string repositoryName, bool enabled, string cursor, int limit, string search, string sort, string direction)
        {
            return Get<BranchListResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/branches", null, options => {
                options.AddQueryString("enabled", enabled);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
                options.AddQueryString("sort", sort);
                options.AddQueryString("direction", direction);
            });
        }
        public IObservable<RxHttpResponse> UpdateRepositoryBranchConfiguration(UpdateRepositoryBranchConfigurationBody body, string provider, string remoteOrganizationName, string repositoryName, string branchName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/branches/{branchName}", body);
        }
        public IObservable<RxHttpResponse> UpdateJoinMode(JoinModeRequest body, string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/joinMode", body);
        }
        public IObservable<RxHttpResponse> SetRepositoryBranchAsDefault(string provider, string remoteOrganizationName, string repositoryName, string branchName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/branches/{branchName}/setDefault");
        }
        public IObservable<RxHttpResponse> CreateBadgePullRequest(string remoteOrganizationName, string repositoryName)
        {
            return Post($"/organizations/gh/{remoteOrganizationName}/repositories/{repositoryName}/badge");
        }
        public IObservable<LeaveOrgCheckResult> CheckIfUserCanLeave(string provider, string remoteOrganizationName)
        {
            return Get<LeaveOrgCheckResult>($"/organizations/{provider}/{remoteOrganizationName}/people/leave/check");
        }
        public IObservable<ListRequestsToJoinResponse> ListOrganizationJoinRequests(string provider, string remoteOrganizationName, string cursor, int limit, string search)
        {
            return Get<ListRequestsToJoinResponse>($"/organizations/{provider}/{remoteOrganizationName}/join", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("search", search);
            });
        }
        public IObservable<JoinResponse> JoinOrganization(string provider, string remoteOrganizationName)
        {
            return Post<JoinResponse>($"/organizations/{provider}/{remoteOrganizationName}/join");
        }
        public IObservable<RxHttpResponse> DeclineRequestsToJoinOrganization(List<string> body, string provider, string remoteOrganizationName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/join", body);
        }
        public IObservable<RxHttpResponse> DeleteOrganizationJoinRequest(string provider, string remoteOrganizationName, int accountIdentifier)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/join/{accountIdentifier}");
        }
        public IObservable<RxHttpResponse> CleanCache(string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/cache/clean");
        }
        public IObservable<Repository> AddRepository(AddRepositoryBody body, string caller)
        {
            return Post<Repository>($"/repositories", body, options => {
                options.AddHeader("caller", caller);
            });
        }
        public IObservable<AddOrganizationResponse> AddOrganization(AddOrganizationBody body)
        {
            return Post<AddOrganizationResponse>($"/organizations", body);
        }
        public IObservable<ApiTokenListResponse> GetUserApiTokens(string cursor, int limit)
        {
            return Get<ApiTokenListResponse>($"/user/tokens", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<ApiToken> CreateUserApiToken()
        {
            return Post<ApiToken>($"/user/tokens");
        }
        public IObservable<RxHttpResponse> DeleteUserApiToken(int tokenId)
        {
            return Delete($"/user/tokens/{tokenId}");
        }
        public IObservable<RxHttpResponse> DeleteSubscription(ChurnFeedback body, string provider, string remoteOrganizationName)
        {
            return Delete($"/billing/{provider}/{remoteOrganizationName}/subscription", body);
        }
        public IObservable<ConfiguredLoginIntegrationListResponse> ListConfiguredLoginIntegrations(string cursor, int limit)
        {
            return Get<ConfiguredLoginIntegrationListResponse>($"/login/integrations", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<ProviderIntegrationListResponse> ListProviderIntegrations(string cursor, int limit)
        {
            return Get<ProviderIntegrationListResponse>($"/provider/integrations", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<ConfigurationStatusResponse> GetConfigurationStatus()
        {
            return Get<ConfigurationStatusResponse>($"/configuration/status");
        }
        public IObservable<HealthCheckResponse> Health()
        {
            return Get<HealthCheckResponse>($"/health");
        }
        public IObservable<LicenseResponse> GenerateLicense(License body)
        {
            return Post<LicenseResponse>($"/admin/license", body);
        }
        public IObservable<DeleteDormantAccountsResponse> DeleteDormantAccounts(string body)
        {
            return Delete<DeleteDormantAccountsResponse>($"/admin/dormantAccounts", body);
        }
        public IObservable<RxHttpResponse> UploadPenTestReport(MultipartFormDataContent body)
        {
            return Post($"/admin/security/penTest/reports", body);
        }
        public IObservable<LanguageListResponse> ListLanguagesWithTools()
        {
            return Get<LanguageListResponse>($"/languages/tools");
        }
        public IObservable<ToolListResponse> ListTools(string cursor, int limit)
        {
            return Get<ToolListResponse>($"/tools", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<PatternListResponse> ListPatterns(string toolUuid, string cursor, int limit)
        {
            return Get<PatternListResponse>($"/tools/{toolUuid}/patterns", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<PatternResponse> GetPattern(string toolUuid, string patternId)
        {
            return Get<PatternResponse>($"/tools/{toolUuid}/patterns/{patternId}");
        }
        public IObservable<DuplicationToolListResponse> ListDuplicationTools()
        {
            return Get<DuplicationToolListResponse>($"/duplicationTools");
        }
        public IObservable<MetricsToolListResponse> ListMetricsTools()
        {
            return Get<MetricsToolListResponse>($"/metricsTools");
        }
        public IObservable<FileListResponse> ListFiles(string provider, string remoteOrganizationName, string repositoryName, string branch, string search, string sort, string direction, string cursor, int limit)
        {
            return Get<FileListResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/files", null, options => {
                options.AddQueryString("branch", branch);
                options.AddQueryString("search", search);
                options.AddQueryString("sort", sort);
                options.AddQueryString("direction", direction);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<FileInformationWithAnalysis> GetFileWithAnalysis(string provider, string remoteOrganizationName, string repositoryName, int fileId)
        {
            return Get<FileInformationWithAnalysis>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/files/{fileId}");
        }
        public IObservable<FileClonesResponse> GetFileClones(string provider, string remoteOrganizationName, string repositoryName, int fileId, string cursor, int limit)
        {
            return Get<FileClonesResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/files/{fileId}/duplication", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<SearchRepositoryIssuesListResponse> GetFileIssues(string provider, string remoteOrganizationName, string repositoryName, int fileId, string cursor, int limit)
        {
            return Get<SearchRepositoryIssuesListResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/files/{fileId}/issues", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<CodingStandardsListResponse> ListCodingStandards(string provider, string remoteOrganizationName)
        {
            return Get<CodingStandardsListResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards");
        }
        public IObservable<RxHttpResponse> CreateCodingStandard(CreateCodingStandardBody body, string provider, string remoteOrganizationName, string sourceRepository, int sourceCodingStandard)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/codingStandards", body, options => {
                options.AddQueryString("sourceRepository", sourceRepository);
                options.AddQueryString("sourceCodingStandard", sourceCodingStandard);
            });
        }
        public IObservable<RxHttpResponse> CreateCodingStandardPreset(CreateCodingStandardPresetBody body, string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/presetsStandards", body);
        }
        public IObservable<CodingStandardResponse> GetCodingStandard(string provider, string remoteOrganizationName, int codingStandardId)
        {
            return Get<CodingStandardResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}");
        }
        public IObservable<RxHttpResponse> DeleteCodingStandard(string provider, string remoteOrganizationName, int codingStandardId)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}");
        }
        public IObservable<CodingStandardToolsListResponse> ListCodingStandardTools(string provider, string remoteOrganizationName, int codingStandardId)
        {
            return Get<CodingStandardToolsListResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/tools");
        }
        public IObservable<RxHttpResponse> SetDefaultCodingStandard(SetDefaultCodingStandardBody body, string provider, string remoteOrganizationName, int codingStandardId)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/setDefault", body);
        }
        public IObservable<ConfiguredPatternsListResponse> ListCodingStandardPatterns(string provider, string remoteOrganizationName, int codingStandardId, string toolUuid, string languages, string categories, string severityLevels, string sort, string direction, string cursor, int limit)
        {
            return Get<ConfiguredPatternsListResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/tools/{toolUuid}/patterns", null, options => {
                options.AddQueryString("languages", languages);
                options.AddQueryString("categories", categories);
                options.AddQueryString("severityLevels", severityLevels);
                options.AddQueryString("sort", sort);
                options.AddQueryString("direction", direction);
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<RxHttpResponse> UpdateCodingStandardPatterns(UpdatePatternsBody body, string provider, string remoteOrganizationName, int codingStandardId, string toolUuid, string languages, string categories, string severityLevels)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/tools/{toolUuid}/patterns/update", body, options => {
                options.AddQueryString("languages", languages);
                options.AddQueryString("categories", categories);
                options.AddQueryString("severityLevels", severityLevels);
            });
        }
        public IObservable<RxHttpResponse> UpdateCodingStandardToolConfiguration(ToolConfiguration body, string provider, string remoteOrganizationName, int codingStandardId, string toolUuid)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/tools/{toolUuid}", body);
        }
        public IObservable<CodingStandardRepositoriesListResponse> ListCodingStandardRepositories(string provider, string remoteOrganizationName, int codingStandardId, string cursor, int limit)
        {
            return Get<CodingStandardRepositoriesListResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/repositories", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<ApplyCodingStandardToRepositoriesResultResponse> ApplyCodingStandardToRepositories(ApplyCodingStandardToRepositoriesBody body, string provider, string remoteOrganizationName, int codingStandardId)
        {
            return Patch<ApplyCodingStandardToRepositoriesResultResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/repositories", body);
        }
        public IObservable<RxHttpResponse> UnlinkRepositoryFromCodingStandard(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/codingStandard");
        }
        public IObservable<RxHttpResponse> SetDefaultGatePolicy(string provider, string remoteOrganizationName, int gatePolicyId)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/{gatePolicyId}/setDefault");
        }
        public IObservable<RxHttpResponse> SetCodacyDefault(string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/setCodacyDefault");
        }
        public IObservable<GetGatePolicyResultResponse> GetGatePolicy(string provider, string remoteOrganizationName, int gatePolicyId)
        {
            return Get<GetGatePolicyResultResponse>($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/{gatePolicyId}");
        }
        public IObservable<RxHttpResponse> DeleteGatePolicy(string provider, string remoteOrganizationName, int gatePolicyId)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/{gatePolicyId}");
        }
        public IObservable<GetGatePolicyResultResponse> UpdateGatePolicy(UpdateGatePolicyBody body, string provider, string remoteOrganizationName, int gatePolicyId)
        {
            return Patch<GetGatePolicyResultResponse>($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/{gatePolicyId}", body);
        }
        public IObservable<GatePoliciesListResponse> ListGatePolicies(string provider, string remoteOrganizationName, string cursor, int limit)
        {
            return Get<GatePoliciesListResponse>($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<GetGatePolicyResultResponse> CreateGatePolicy(CreateGatePolicyBody body, string provider, string remoteOrganizationName)
        {
            return Post<GetGatePolicyResultResponse>($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies", body);
        }
        public IObservable<SyncProviderSettingOrganizationResponse> SyncOrganizationName(string provider, string remoteOrganizationName)
        {
            return Post<SyncProviderSettingOrganizationResponse>($"/organizations/{provider}/{remoteOrganizationName}/settings/sync");
        }
        public IObservable<CheckSubmodulesResponse> CheckSubmodules(string provider, string remoteOrganizationName)
        {
            return Get<CheckSubmodulesResponse>($"/organizations/{provider}/{remoteOrganizationName}/settings/submodules/check");
        }
        public IObservable<ListRepositoriesFollowingGatePolicyResultResponse> ListRepositoriesFollowingGatePolicy(string provider, string remoteOrganizationName, int gatePolicyId, string cursor, int limit)
        {
            return Get<ListRepositoriesFollowingGatePolicyResultResponse>($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/{gatePolicyId}/repositories", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<RxHttpResponse> ApplyGatePolicyToRepositories(ApplyGatePolicyToRepositoriesBody body, string provider, string remoteOrganizationName, int gatePolicyId)
        {
            return Put($"/organizations/{provider}/{remoteOrganizationName}/gatePolicies/{gatePolicyId}/repositories", body);
        }
        public IObservable<RxHttpResponse> CreateOrganizationHooks(string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/settings/hooks");
        }
        public IObservable<ApplyCodingStandardToRepositoriesResultResponse> PromoteDraftCodingStandard(string provider, string remoteOrganizationName, int codingStandardId)
        {
            return Post<ApplyCodingStandardToRepositoriesResultResponse>($"/organizations/{provider}/{remoteOrganizationName}/codingStandards/{codingStandardId}/promote");
        }
        public IObservable<ApiTokenListResponse> ListRepositoryApiTokens(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Get<ApiTokenListResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tokens");
        }
        public IObservable<RxHttpResponse> CreateRepositoryApiToken(string provider, string remoteOrganizationName, string repositoryName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tokens");
        }
        public IObservable<RxHttpResponse> DeleteRepositoryApiToken(string provider, string remoteOrganizationName, string repositoryName, int tokenId)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/tokens/{tokenId}");
        }
        public IObservable<CoverageReportResponse> ListCoverageReports(string provider, string remoteOrganizationName, string repositoryName, int limit)
        {
            return Get<CoverageReportResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/coverage/status", null, options => {
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<CodeBlockLineListResponse> GetCodeBlock(string provider, string remoteOrganizationName, string repositoryName, int fileId, int startLine, int endLine)
        {
            return Get<CodeBlockLineListResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/files/{fileId}/source", null, options => {
                options.AddQueryString("startLine", startLine);
                options.AddQueryString("endLine", endLine);
            });
        }
        public IObservable<GetFileCoverageResponse> GetFileCoverage(string provider, string remoteOrganizationName, string repositoryName, int fileId)
        {
            return Get<GetFileCoverageResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/files/{fileId}/coverage");
        }
        public IObservable<RxHttpResponse> UpdateFileState(FileStateBody body, string provider, string remoteOrganizationName, string repositoryName)
        {
            return Patch($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/file", body);
        }
        public IObservable<SrmItemsResponse> ListSecurityItems(string provider, string remoteOrganizationName, string cursor, int limit, string repositories, List<string> status, List<string> priority, List<string> category, List<string> scanType)
        {
            return Get<SrmItemsResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/items", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("repositories", repositories);
                options.AddQueryString("status", status);
                options.AddQueryString("priority", priority);
                options.AddQueryString("category", category);
                options.AddQueryString("scanType", scanType);
            });
        }
        public IObservable<SrmItemResponse> GetSecurityItem(string provider, string remoteOrganizationName, string srmItemId)
        {
            return Get<SrmItemResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/items/{srmItemId}");
        }
        public IObservable<SrmItemsResponse> SearchSecurityItems(SearchSrmItems body, string provider, string remoteOrganizationName, string cursor, int limit, string sort, string direction)
        {
            return Post<SrmItemsResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/items/search", body, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
                options.AddQueryString("sort", sort);
                options.AddQueryString("direction", direction);
            });
        }
        public IObservable<SrmDashboardResponse> GetSecurityDashboard(string provider, string remoteOrganizationName, string repositories, List<string> priority, List<string> category, List<string> scanType)
        {
            return Get<SrmDashboardResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/dashboard", null, options => {
                options.AddQueryString("repositories", repositories);
                options.AddQueryString("priority", priority);
                options.AddQueryString("category", category);
                options.AddQueryString("scanType", scanType);
            });
        }
        public IObservable<SrmDashboardResponse> SearchSecurityDashboard(SearchSrmDashboard body, string provider, string remoteOrganizationName)
        {
            return Post<SrmDashboardResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/dashboard", body);
        }
        public IObservable<SrmDashboardRepositoriesResponse> SearchSecurityDashboardRepositories(SearchSrmDashboardRepositories body, string provider, string remoteOrganizationName)
        {
            return Post<SrmDashboardRepositoriesResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/dashboard/repositories/search", body);
        }
        public IObservable<SrmDashboardHistoryResponse> SearchSecurityDashboardHistory(SearchSrmDashboardHistory body, string provider, string remoteOrganizationName)
        {
            return Post<SrmDashboardHistoryResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/dashboard/history/search", body);
        }
        public IObservable<SrmDashboardCategoriesResponse> SearchSecurityDashboardCategories(SearchSrmDashboardCategories body, string provider, string remoteOrganizationName)
        {
            return Post<SrmDashboardCategoriesResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/dashboard/categories/search", body);
        }
        public IObservable<SrmdastReportUploadResponse> UploadDastReport(MultipartFormDataContent body, string provider, string remoteOrganizationName, string toolName)
        {
            return Post<SrmdastReportUploadResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/tools/dast/{toolName}/reports", body);
        }
        public IObservable<SrmDastReportResponse> ListDastReports(string provider, string remoteOrganizationName, string cursor, int limit)
        {
            return Get<SrmDastReportResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/dast/reports", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<SecurityManagersResponse> ListSecurityManagers(string provider, string remoteOrganizationName, string cursor, int limit)
        {
            return Get<SecurityManagersResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/managers", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<RxHttpResponse> PostSecurityManager(SecurityManagerBody body, string provider, string remoteOrganizationName)
        {
            return Post($"/organizations/{provider}/{remoteOrganizationName}/security/managers", body);
        }
        public IObservable<RxHttpResponse> DeleteSecurityManager(string provider, string remoteOrganizationName, int userId)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/security/managers/{userId}");
        }
        public IObservable<SecurityRepositoriesResponse> ListSecurityRepositories(string provider, string remoteOrganizationName, string cursor, int limit)
        {
            return Get<SecurityRepositoriesResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/repositories", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<SecurityCategoriesResponse> ListSecurityCategories(string provider, string remoteOrganizationName, string cursor, int limit)
        {
            return Get<SecurityCategoriesResponse>($"/organizations/{provider}/{remoteOrganizationName}/security/categories", null, options => {
                options.AddQueryString("cursor", cursor);
                options.AddQueryString("limit", limit);
            });
        }
        public IObservable<JiraIntegrationResponse> GetJiraIntegration(string provider, string remoteOrganizationName)
        {
            return Get<JiraIntegrationResponse>($"/organizations/{provider}/{remoteOrganizationName}/integrations/jira");
        }
        public IObservable<JiraIntegrationResponse> CreateOrUpdateJiraIntegration(string oauthCode, string provider, string remoteOrganizationName)
        {
            return Put<JiraIntegrationResponse>($"/organizations/{provider}/{remoteOrganizationName}/integrations/jira", null, options => {
                options.AddQueryString("oauthCode", oauthCode);
            });
        }
        public IObservable<RxHttpResponse> DeleteJiraIntegration(string provider, string remoteOrganizationName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/integrations/jira");
        }
        public IObservable<SlackIntegrationResponse> GetSlackIntegration(string provider, string remoteOrganizationName)
        {
            return Get<SlackIntegrationResponse>($"/organizations/{provider}/{remoteOrganizationName}/integrations/slack");
        }
        public IObservable<SlackIntegrationResponse> CreateOrUpdateSlackIntegration(SlackIntegrationRequest body, string provider, string remoteOrganizationName)
        {
            return Put<SlackIntegrationResponse>($"/organizations/{provider}/{remoteOrganizationName}/integrations/slack", body);
        }
        public IObservable<RxHttpResponse> DeleteSlackIntegration(string provider, string remoteOrganizationName)
        {
            return Delete($"/organizations/{provider}/{remoteOrganizationName}/integrations/slack");
        }
        public IObservable<DiffResponse> GetPullRequestDiff(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<DiffResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/diff");
        }
        public IObservable<DiffResponse> GetPullRequestGitDiff(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<DiffResponse>($"/coverage/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/diff");
        }
        public IObservable<DiffResponse> GetCommitDiff(string provider, string remoteOrganizationName, string repositoryName, string commitUuid)
        {
            return Get<DiffResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/commits/{commitUuid}/diff");
        }
        public IObservable<DiffResponse> GetDiffBetweenCommits(string provider, string remoteOrganizationName, string repositoryName, string baseCommitUuid, string headCommitUuid)
        {
            return Get<DiffResponse>($"/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/base/{baseCommitUuid}/head/{headCommitUuid}/diff");
        }
        public IObservable<string> GetReportSecurityItems(string provider, string remoteOrganizationName)
        {
            return Get<string>($"/reports/organizations/{provider}/{remoteOrganizationName}/security/items");
        }
        public IObservable<CommitDetails> GetCommitDetails(string provider, string remoteOrganizationName, int commitId)
        {
            return Get<CommitDetails>($"/organizations/{provider}/{remoteOrganizationName}/commit/{commitId}");
        }
        public IObservable<HeartbeatResponse> Heartbeat(HeartbeatRequest body)
        {
            return Post<HeartbeatResponse>($"/session/heartbeat", body);
        }
        public IObservable<HasQuickfixSuggestionsResponse> HasQuickfixSuggestions(string provider, string remoteOrganizationName, string repositoryName, string branch)
        {
            return Get<HasQuickfixSuggestionsResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/issues/hasSuggestions", null, options => {
                options.AddQueryString("branch", branch);
            });
        }
        public IObservable<QuickfixPatchResponse> GetQuickfixesPatch(string provider, string remoteOrganizationName, string repositoryName, string branch)
        {
            return Get<QuickfixPatchResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/issues/patch", null, options => {
                options.AddQueryString("branch", branch);
            });
        }
        public IObservable<QuickfixPatchResponse> GetPullRequestQuickfixesPatch(string provider, string remoteOrganizationName, string repositoryName, int pullRequestNumber)
        {
            return Get<QuickfixPatchResponse>($"/analysis/organizations/{provider}/{remoteOrganizationName}/repositories/{repositoryName}/pullRequests/{pullRequestNumber}/issues/patch");
        }
        public IObservable<List<AuditLog>> ListAuditLogsForOrganization(string provider, string remoteOrganizationName)
        {
            return Get<List<AuditLog>>($"/organizations/{provider}/{remoteOrganizationName}/audit");
        }
    }
}
