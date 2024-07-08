using System;
using Rx.Http;
using Rx.Http.Extensions;
using DocuSign.Models;

namespace DocuSign
{
    class DocuSignConsumer : RxHttpClient
    {
        public DocuSignConsumer(HttpClient httpClient) : base(httpClient, null)
        {
            httpClient.BaseAddress = new Uri("https://api.docusign.net/Management");
        }

        public IObservable<OrganizationsResponse> OrganizationOrganizationGetListV2(string mode)
        {
            return Get<OrganizationsResponse>($"/v2/organizations", null, options => {
                options.AddQueryString("mode", mode);
            });
        }
        public IObservable<IndividualUserDataRedactionResponse> DataRedactionRedactIndividualMembershipData(IndividualMembershipDataRedactionRequest body, string accountId)
        {
            return Post<IndividualUserDataRedactionResponse>($"/v2/dataRedaction/accounts/{accountId}/user", body);
        }
        public IObservable<PermissionsResponse> AccountAccountsGetPermissionProfilesV2(string organizationId, string accountId)
        {
            return Get<PermissionsResponse>($"/v2/organizations/{organizationId}/accounts/{accountId}/permissions");
        }
        public IObservable<MemberGroupsResponse> AccountAccountsGetGroupsV2(string organizationId, string accountId, int start, int take, int end)
        {
            return Get<MemberGroupsResponse>($"/v2/organizations/{organizationId}/accounts/{accountId}/groups", null, options => {
                options.AddQueryString("start", start);
                options.AddQueryString("take", take);
                options.AddQueryString("end", end);
            });
        }
        public IObservable<OrganizationExportsResponse> OrganizationExportOrganizationExportGet(string organizationId)
        {
            return Get<OrganizationExportsResponse>($"/v2/organizations/{organizationId}/exports/userList");
        }
        public IObservable<OrganizationExportResponse> OrganizationExportOrganizationExportInsert(OrganizationExportRequest body, string organizationId)
        {
            return Post<OrganizationExportResponse>($"/v2/organizations/{organizationId}/exports/userList", body);
        }
        public IObservable<OrganizationExportsResponse> OrganizationExportOrganizationExportGetAccountCompare(string organizationId)
        {
            return Get<OrganizationExportsResponse>($"/v2/organizations/{organizationId}/exports/accountSettings");
        }
        public IObservable<OrganizationExportResponse> OrganizationExportOrganizationExportAccountCompare(OrganizationAccountsRequest body, string organizationId)
        {
            return Post<OrganizationExportResponse>($"/v2/organizations/{organizationId}/exports/accountSettings", body);
        }
        public IObservable<OrganizationExportResponse> OrganizationExportOrganizationExportGetByExportId(string organizationId, string exportId)
        {
            return Get<OrganizationExportResponse>($"/v2/organizations/{organizationId}/exports/userList/{exportId}");
        }
        public IObservable<object> OrganizationExportOrganizationExportDeleteByExportId(string organizationId, string exportId)
        {
            return Delete<object>($"/v2/organizations/{organizationId}/exports/userList/{exportId}");
        }
        public IObservable<OrganizationExportResponse> OrganizationExportOrganizationExportGetAccountSettingsExportByExportId(string organizationId, string exportId)
        {
            return Get<OrganizationExportResponse>($"/v2/organizations/{organizationId}/exports/accountSettings/{exportId}");
        }
        public IObservable<object> OrganizationExportOrganizationExportDeleteByAccountSettingsExportId(string organizationId, string exportId)
        {
            return Delete<object>($"/v2/organizations/{organizationId}/exports/accountSettings/{exportId}");
        }
        public IObservable<List<OrganizationAccountSettingsImportResponse>> OrganizationImportOrganizationImportAccountSettingsGet(string organizationId)
        {
            return Get<List<OrganizationAccountSettingsImportResponse>>($"/v2/organizations/{organizationId}/imports/accountSettings");
        }
        public IObservable<OrganizationAccountSettingsImportResponse> OrganizationImportOrganizationImportAccountSettingsPost(MultipartFormDataContent body, string organizationId)
        {
            return Post<OrganizationAccountSettingsImportResponse>($"/v2/organizations/{organizationId}/imports/accountSettings", body);
        }
        public IObservable<OrganizationAccountSettingsImportResponse> OrganizationImportOrganizationImportAccountSettingsGetById(string organizationId, string importId)
        {
            return Get<OrganizationAccountSettingsImportResponse>($"/v2/organizations/{organizationId}/imports/accountSettings/{importId}");
        }
        public IObservable<object> OrganizationImportOrganizationImportAccountSettingsDeleteById(string organizationId, string importId)
        {
            return Delete<object>($"/v2/organizations/{organizationId}/imports/accountSettings/{importId}");
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportUsersInsert(MultipartFormDataContent body, string organizationId)
        {
            return Post<OrganizationImportResponse>($"/v2/organizations/{organizationId}/imports/bulkUsers/add", body);
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportSingleAccountUsersInsert(MultipartFormDataContent body, string organizationId, string accountId)
        {
            return Post<OrganizationImportResponse>($"/v2/organizations/{organizationId}/accounts/{accountId}/imports/bulkUsers/add", body);
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportUsersUpdate(MultipartFormDataContent body, string organizationId)
        {
            return Post<OrganizationImportResponse>($"/v2/organizations/{organizationId}/imports/bulkUsers/update", body);
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportSingleAccountUsersUpdate(MultipartFormDataContent body, string organizationId, string accountId)
        {
            return Post<OrganizationImportResponse>($"/v2/organizations/{organizationId}/accounts/{accountId}/imports/bulkUsers/update", body);
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportUsersClose(MultipartFormDataContent body, string organizationId)
        {
            return Post<OrganizationImportResponse>($"/v2/organizations/{organizationId}/imports/bulkUsers/close", body);
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportUsersCloseExternal(string organizationId)
        {
            return Post<OrganizationImportResponse>($"/v2/organizations/{organizationId}/imports/bulkUsers/closeExternal");
        }
        public IObservable<OrganizationImportsResponse> OrganizationImportOrganizationImportUsersGet(string organizationId)
        {
            return Get<OrganizationImportsResponse>($"/v2/organizations/{organizationId}/imports/bulkUsers");
        }
        public IObservable<OrganizationImportResponse> OrganizationImportOrganizationImportUsersGetById(string organizationId, string importId)
        {
            return Get<OrganizationImportResponse>($"/v2/organizations/{organizationId}/imports/bulkUsers/{importId}");
        }
        public IObservable<object> OrganizationImportOrganizationImportUsersDeleteById(string organizationId, string importId)
        {
            return Delete<object>($"/v2/organizations/{organizationId}/imports/bulkUsers/{importId}");
        }
        public IObservable<RxHttpResponse> OrganizationImportOrganizationImportUsersGetCsvResults(string organizationId, string importId)
        {
            return Get($"/v2/organizations/{organizationId}/imports/bulkUsers/{importId}/resultsCsv");
        }
        public IObservable<IdentityProvidersResponse> OrganizationGetIdentityProviders(string organizationId)
        {
            return Get<IdentityProvidersResponse>($"/v2/organizations/{organizationId}/identityProviders");
        }
        public IObservable<IndividualUserDataRedactionResponse> DataRedactionRedactIndividualUserData(IndividualUserDataRedactionRequest body, string organizationId)
        {
            return Post<IndividualUserDataRedactionResponse>($"/v2/dataRedaction/organizations/{organizationId}/user", body);
        }
        public IObservable<DomainsResponse> OrganizationGetReservedDomains(string organizationId)
        {
            return Get<DomainsResponse>($"/v2/organizations/{organizationId}/reservedDomains");
        }
        public IObservable<UsersUpdateResponse> UserUsersUpdateV2(UpdateUsersRequest body, string organizationId)
        {
            return Post<UsersUpdateResponse>($"/v2/organizations/{organizationId}/users/profiles", body);
        }
        public IObservable<UsersUpdateResponse> UserUsersUpdateEmailAddressesV2(UpdateUsersEmailRequest body, string organizationId)
        {
            return Post<UsersUpdateResponse>($"/v2/organizations/{organizationId}/users/emailAddresses", body);
        }
        public IObservable<DeleteMembershipsResponse> UserUsersCloseMembershipsV2(DeleteMembershipsRequest body, string organizationId, string userId)
        {
            return Delete<DeleteMembershipsResponse>($"/v2/organizations/{organizationId}/users/{userId}/accounts", body);
        }
        public IObservable<OrganizationUsersResponse> OrganizationUserOrganizationUsersGetV2(string organizationId, int start, int take, int end, string email, string emailUserNameLike, string status, string membershipStatus, string accountId, string organizationReservedDomainId, string lastModifiedSince)
        {
            return Get<OrganizationUsersResponse>($"/v2/organizations/{organizationId}/users", null, options => {
                options.AddQueryString("start", start);
                options.AddQueryString("take", take);
                options.AddQueryString("end", end);
                options.AddQueryString("email", email);
                options.AddQueryString("email_user_name_like", emailUserNameLike);
                options.AddQueryString("status", status);
                options.AddQueryString("membership_status", membershipStatus);
                options.AddQueryString("account_id", accountId);
                options.AddQueryString("organization_reserved_domain_id", organizationReservedDomainId);
                options.AddQueryString("last_modified_since", lastModifiedSince);
            });
        }
        public IObservable<NewUserResponse> OrganizationUserUsersAddV2(NewUserRequest body, string organizationId)
        {
            return Post<NewUserResponse>($"/v2/organizations/{organizationId}/users", body);
        }
        public IObservable<UpdateResponse> OrganizationUserUsersActivateMembershipV2(ForceActivateMembershipRequest body, string organizationId, string userId, string membershipId)
        {
            return Post<UpdateResponse>($"/v2/organizations/{organizationId}/users/{userId}/memberships/{membershipId}", body);
        }
        public IObservable<UsersDrilldownResponse> OrganizationUserOrganizationUsersGetProfileV2(string organizationId, string email)
        {
            return Get<UsersDrilldownResponse>($"/v2/organizations/{organizationId}/users/profile", null, options => {
                options.AddQueryString("email", email);
            });
        }
        public IObservable<DeleteResponse> OrganizationUserDeleteIdentitiesV2(DeleteUserIdentityRequest body, string organizationId, string userId)
        {
            return Delete<DeleteResponse>($"/v2/organizations/{organizationId}/users/{userId}/identities", body);
        }
        public IObservable<NewUserResponse> OrganizationUserOrganizationUsersPostAccountUsersV2(NewAccountUserRequest body, string organizationId, string accountId)
        {
            return Post<NewUserResponse>($"/v2/organizations/{organizationId}/accounts/{accountId}/users", body);
        }
        public IObservable<DsGroupListResponse> DocuSignGroupsv21GetDsGroupsV21(string organizationId, string accountId, int page, int pageSize)
        {
            return Get<DsGroupListResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups", null, options => {
                options.AddQueryString("page", page);
                options.AddQueryString("page_size", pageSize);
            });
        }
        public IObservable<DsGroupResponse> DocuSignGroupsv21AddDsGroupV21(DsGroupAddRequest body, string organizationId, string accountId)
        {
            return Post<DsGroupResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups", body);
        }
        public IObservable<DsGroupResponse> DocuSignGroupsv21GetDsGroupV21(string organizationId, string accountId, string dsGroupId)
        {
            return Get<DsGroupResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups/{dsGroupId}");
        }
        public IObservable<RxHttpResponse> DocuSignGroupsv21DeleteDsGroupV21(string organizationId, string accountId, string dsGroupId)
        {
            return Delete($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups/{dsGroupId}");
        }
        public IObservable<DsGroupAndUsersResponse> DocuSignGroupsv21GetDsGroupUsersV21(string organizationId, string accountId, string dsGroupId, int page, int pageSize)
        {
            return Get<DsGroupAndUsersResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups/{dsGroupId}/users", null, options => {
                options.AddQueryString("page", page);
                options.AddQueryString("page_size", pageSize);
            });
        }
        public IObservable<AddDsGroupAndUsersResponse> DocuSignGroupsv21AddDsGroupUsersV21(DsGroupUsersAddRequest body, string organizationId, string accountId, string dsGroupId)
        {
            return Post<AddDsGroupAndUsersResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups/{dsGroupId}/users", body);
        }
        public IObservable<RemoveDsGroupUsersResponse> DocuSignGroupsv21RemoveDsGroupUsersV21(DsGroupUsersRemoveRequest body, string organizationId, string accountId, string dsGroupId)
        {
            return Delete<RemoveDsGroupUsersResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/dsgroups/{dsGroupId}/users", body);
        }
        public IObservable<ProductPermissionProfilesResponse> OrganizationProductPermissionProfileGetProductPermissionProfiles(string organizationId, string accountId)
        {
            return Get<ProductPermissionProfilesResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/products/permissionProfiles");
        }
        public IObservable<ProductPermissionProfilesResponse> OrganizationProductPermissionProfileGetUserProductPermissionProfiles(string organizationId, string accountId, string userId)
        {
            return Get<ProductPermissionProfilesResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/products/users/{userId}/permissionProfiles");
        }
        public IObservable<UserProductPermissionProfilesResponse> OrganizationProductPermissionProfilePostUserProductPermissionProfiles(ProductPermissionProfilesRequest body, string organizationId, string accountId, string userId)
        {
            return Post<UserProductPermissionProfilesResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/products/users/{userId}/permissionProfiles", body);
        }
        public IObservable<AddUserResponse> OrganizationUserOrganizationUsersPostAccountUsersV21(NewMultiProductUserAddRequest body, string organizationId, string accountId)
        {
            return Post<AddUserResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/users", body);
        }
        public IObservable<UsersDrilldownResponse> OrganizationUserOrganizationUsersGetDsProfiles(string organizationId, string email, bool sort)
        {
            return Get<UsersDrilldownResponse>($"/v2.1/organizations/{organizationId}/users/dsprofile", null, options => {
                options.AddQueryString("email", email);
                options.AddQueryString("sort", sort);
            });
        }
        public IObservable<UsersDrilldownResponse> OrganizationUserOrganizationUsersGetDsProfileByUserId(string organizationId, string userId, bool sort)
        {
            return Get<UsersDrilldownResponse>($"/v2.1/organizations/{organizationId}/users/{userId}/dsprofile", null, options => {
                options.AddQueryString("sort", sort);
            });
        }
        public IObservable<RemoveUserProductsResponse> OrganizationProductPermissionProfileRemoveUserProducts(UserProductProfileDeleteRequest body, string organizationId, string accountId)
        {
            return Delete<RemoveUserProductsResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/products/users", body);
        }
        public IObservable<UserProductPermissionProfilesResponse> OrganizationProductPermissionProfileGetUserProductPermissionProfilesByEmail(string organizationId, string accountId, string email)
        {
            return Get<UserProductPermissionProfilesResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/products/permissionProfiles/users", null, options => {
                options.AddQueryString("email", email);
            });
        }
        public IObservable<UserProductPermissionProfilesResponse> OrganizationProductPermissionProfilePostUserProductPermissionProfilesByEmail(UserProductPermissionProfilesRequest body, string organizationId, string accountId)
        {
            return Post<UserProductPermissionProfilesResponse>($"/v2.1/organizations/{organizationId}/accounts/{accountId}/products/permissionProfiles/users", body);
        }
        public IObservable<AssetGroupAccountsResponse> OrganizationProvisionAssetGroupGetAssetGroupAccountsByOrg(string organizationId, bool compliant)
        {
            return Get<AssetGroupAccountsResponse>($"/v1/organizations/{organizationId}/assetGroups/accounts", null, options => {
                options.AddQueryString("compliant", compliant);
            });
        }
        public IObservable<AssetGroupAccountClone> OrganizationProvisionAssetGroupCloneAssetGroupAccount(AssetGroupAccountClone body, string organizationId)
        {
            return Post<AssetGroupAccountClone>($"/v1/organizations/{organizationId}/assetGroups/accountClone", body);
        }
        public IObservable<AssetGroupAccountClones> OrganizationProvisionAssetGroupGetAssetGroupAccountClonesByOrgId(string organizationId, string sinceUpdatedDate, bool includeDetails)
        {
            return Get<AssetGroupAccountClones>($"/v1/organizations/{organizationId}/assetGroups/accountClones", null, options => {
                options.AddQueryString("since_updated_date", sinceUpdatedDate);
                options.AddQueryString("include_details", includeDetails);
            });
        }
        public IObservable<AssetGroupAccountClone> OrganizationProvisionAssetGroupGetAssetGroupAccountClone(string organizationId, string assetGroupId, string assetGroupWorkId, bool includeDetails)
        {
            return Get<AssetGroupAccountClone>($"/v1/organizations/{organizationId}/assetGroups/{assetGroupId}/accountClones/{assetGroupWorkId}", null, options => {
                options.AddQueryString("include_details", includeDetails);
            });
        }
    }
}
