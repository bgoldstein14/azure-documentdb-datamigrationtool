﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.DocumentDb {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.DocumentDb.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocumentDB account end-point URL should be provided as part of the connection string.
        /// </summary>
        internal static string AccountEndpointMissing {
            get {
                return ResourceManager.GetString("AccountEndpointMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocumentDB account key should be provided as part of the connection string.
        /// </summary>
        internal static string AccountKeyMissing {
            get {
                return ResourceManager.GetString("AccountKeyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both IndexingPolicy and IndexingPolicyFile cannot be set at the same time.
        /// </summary>
        internal static string AmbiguousIndexingPolicy {
            get {
                return ResourceManager.GetString("AmbiguousIndexingPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both Query and QueryFile cannot be set at the same time.
        /// </summary>
        internal static string AmbiguousQuery {
            get {
                return ResourceManager.GetString("AmbiguousQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to buffer an item, slot is already occupied.
        /// </summary>
        internal static string BufferSlotIsOccupied {
            get {
                return ResourceManager.GetString("BufferSlotIsOccupied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploads data into one or more single partition DocumentDB collections in batches.
        /// </summary>
        internal static string BulkSinkDescription {
            get {
                return ResourceManager.GetString("BulkSinkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Documents collection name is required.
        /// </summary>
        internal static string CollectionNameMissing {
            get {
                return ResourceManager.GetString("CollectionNameMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocumentDB connection string is required.
        /// </summary>
        internal static string ConnectionStringMissing {
            get {
                return ResourceManager.GetString("ConnectionStringMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}-{1}-{2}-{3}{4}.
        /// </summary>
        internal static string CustomUserAgentSuffixFormat {
            get {
                return ResourceManager.GetString("CustomUserAgentSuffixFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Documents database name should be provided as part of the connection string.
        /// </summary>
        internal static string DatabaseNameMissing {
            get {
                return ResourceManager.GetString("DatabaseNameMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data item already contains field &quot;{0}&quot;.
        /// </summary>
        internal static string DataItemAlreadyContainsField {
            get {
                return ResourceManager.GetString("DataItemAlreadyContainsField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input does not represent a valid document.
        /// </summary>
        internal static string DocumentIsNotDataItem {
            get {
                return ResourceManager.GetString("DocumentIsNotDataItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document cannot be indexed in bulk because it exceeds specified script size limit.
        /// </summary>
        internal static string DocumentSizeExceedsBulkScriptSize {
            get {
                return ResourceManager.GetString("DocumentSizeExceedsBulkScriptSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create documents collection &quot;{0}&quot;.
        /// </summary>
        internal static string FailedToCreateCollectionFormat {
            get {
                return ResourceManager.GetString("FailedToCreateCollectionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create documents database &quot;{0}&quot;.
        /// </summary>
        internal static string FailedToCreateDatabaseFormat {
            get {
                return ResourceManager.GetString("FailedToCreateDatabaseFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create document: {0}.
        /// </summary>
        internal static string FailedToCreateDocumentFormat {
            get {
                return ResourceManager.GetString("FailedToCreateDocumentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create stored procedure &quot;{0}&quot;.
        /// </summary>
        internal static string FailedToCreateStoredProcedureFormat {
            get {
                return ResourceManager.GetString("FailedToCreateStoredProcedureFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to extract partition ket: {0}.
        /// </summary>
        internal static string FailedToExtractPartitionKeyFormat {
            get {
                return ResourceManager.GetString("FailedToExtractPartitionKeyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read javascript member expression: {0}.
        /// </summary>
        internal static string FailedToReadJavascriptMemberExpressionFormat {
            get {
                return ResourceManager.GetString("FailedToReadJavascriptMemberExpressionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read substitution: {0}.
        /// </summary>
        internal static string FailedToReadSubstituionFormat {
            get {
                return ResourceManager.GetString("FailedToReadSubstituionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}ActivityId: {1}.
        /// </summary>
        internal static string ImportErrorActivityIdFormat {
            get {
                return ResourceManager.GetString("ImportErrorActivityIdFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Batch size should be greater than zero.
        /// </summary>
        internal static string InvalidBatchSize {
            get {
                return ResourceManager.GetString("InvalidBatchSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collection throughput should be greater than zero.
        /// </summary>
        internal static string InvalidCollectionThroughput {
            get {
                return ResourceManager.GetString("InvalidCollectionThroughput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max script size should be greater than zero.
        /// </summary>
        internal static string InvalidMaxScriptSize {
            get {
                return ResourceManager.GetString("InvalidMaxScriptSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of parallel requests should be greater than zero.
        /// </summary>
        internal static string InvalidNumberOfParallelRequests {
            get {
                return ResourceManager.GetString("InvalidNumberOfParallelRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of retries should be greater than zero.
        /// </summary>
        internal static string InvalidNumberOfRetries {
            get {
                return ResourceManager.GetString("InvalidNumberOfRetries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Range from {0} to {1} is not valid.
        /// </summary>
        internal static string InvalidRangeFormat {
            get {
                return ResourceManager.GetString("InvalidRangeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retry interval cannot be negative.
        /// </summary>
        internal static string InvalidRetryInterval {
            get {
                return ResourceManager.GetString("InvalidRetryInterval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value &quot;{0}&quot; does not represent a valid number.
        /// </summary>
        internal static string NotANumberFormat {
            get {
                return ResourceManager.GetString("NotANumberFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation &quot;{0}&quot; is not supported.
        /// </summary>
        internal static string OperationNotSupportedFormat {
            get {
                return ResourceManager.GetString("OperationNotSupportedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploads data into partitioned DocumentDB collection.
        /// </summary>
        internal static string ParallelSinkDescription {
            get {
                return ResourceManager.GetString("ParallelSinkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -Sharded.
        /// </summary>
        internal static string ShardedImportDesignator {
            get {
                return ResourceManager.GetString("ShardedImportDesignator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocumentDB sink adapter should be initialized before it can be used.
        /// </summary>
        internal static string SinkIsNotInitialized {
            get {
                return ResourceManager.GetString("SinkIsNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reads data from DocumentDB collections.
        /// </summary>
        internal static string SourceDescription {
            get {
                return ResourceManager.GetString("SourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DocumentDB source adapter should be initialized before it can be used.
        /// </summary>
        internal static string SourceIsNotInitialized {
            get {
                return ResourceManager.GetString("SourceIsNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to persist documents bulk: {0}.
        /// </summary>
        internal static string UnexpectedAsyncFlushErrorMessageFormat {
            get {
                return ResourceManager.GetString("UnexpectedAsyncFlushErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected character at position {0}: &quot;{1}&quot;.
        /// </summary>
        internal static string UnexpectedCharacterFormat {
            get {
                return ResourceManager.GetString("UnexpectedCharacterFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Partition collection &quot;{0}&quot; is not expected.
        /// </summary>
        internal static string UnexpectedPartitionCollectionFormat {
            get {
                return ResourceManager.GetString("UnexpectedPartitionCollectionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dtr.
        /// </summary>
        internal static string UnknownEntryAssembly {
            get {
                return ResourceManager.GetString("UnknownEntryAssembly", resourceCulture);
            }
        }
    }
}
