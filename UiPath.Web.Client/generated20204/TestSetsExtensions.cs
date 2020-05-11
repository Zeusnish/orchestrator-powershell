// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TestSets.
    /// </summary>
    public static partial class TestSetsExtensions
    {
            /// <summary>
            /// Returns a list of Test Sets
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Read.
            ///
            /// Required permissions: TestSets.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueIEnumerableTestSetDto Get(this ITestSets operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Test Sets
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Read.
            ///
            /// Required permissions: TestSets.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueIEnumerableTestSetDto> GetAsync(this ITestSets operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Test Set
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Write.
            ///
            /// Required permissions: TestSets.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='testSetDto'>
            /// The entity to post
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestSetDto Post(this ITestSets operations, TestSetDto testSetDto, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PostAsync(testSetDto, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Test Set
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Write.
            ///
            /// Required permissions: TestSets.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='testSetDto'>
            /// The entity to post
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestSetDto> PostAsync(this ITestSets operations, TestSetDto testSetDto, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(testSetDto, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return a specific Test Set identified by key
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Read.
            ///
            /// Required permissions: TestSets.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestSetDto GetById(this ITestSets operations, long id, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(id, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return a specific Test Set identified by key
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Read.
            ///
            /// Required permissions: TestSets.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestSetDto> GetByIdAsync(this ITestSets operations, long id, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing Test Set
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Write.
            ///
            /// Required permissions: TestSets.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='testSetDto'>
            /// The entity to put
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestSetDto PutById(this ITestSets operations, long id, TestSetDto testSetDto, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PutByIdAsync(id, testSetDto, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing Test Set
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Write.
            ///
            /// Required permissions: TestSets.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='testSetDto'>
            /// The entity to put
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestSetDto> PutByIdAsync(this ITestSets operations, long id, TestSetDto testSetDto, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(id, testSetDto, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a test set
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Write.
            ///
            /// Required permissions: TestSets.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteById(this ITestSets operations, long id, string ifMatch = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteByIdAsync(id, ifMatch, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a test set
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestSets or TestSets.Write.
            ///
            /// Required permissions: TestSets.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='ifMatch'>
            /// If-Match header
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this ITestSets operations, long id, string ifMatch = default(string), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(id, ifMatch, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}