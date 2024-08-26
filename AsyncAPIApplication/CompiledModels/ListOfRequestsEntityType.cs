﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using AsyncAPIApplication.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace AsyncAPIApplication.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class ListOfRequestsEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "AsyncAPIApplication.Models.ListOfRequests",
                typeof(ListOfRequests),
                baseEntityType,
                propertyCount: 5,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(ListOfRequests).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ListOfRequests).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                int (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.Id(entity),
                bool (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.Id(entity) == 0,
                int (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.Id(instance),
                bool (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.Id(instance) == 0);
            id.SetSetter(
                (ListOfRequests entity, int value) => ListOfRequestsUnsafeAccessors.Id(entity) = value);
            id.SetMaterializationSetter(
                (ListOfRequests entity, int value) => ListOfRequestsUnsafeAccessors.Id(entity) = value);
            id.SetAccessors(
                int (InternalEntityEntry entry) => (entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<int>(0) : (entry.FlaggedAsTemporary(0) && ListOfRequestsUnsafeAccessors.Id(((ListOfRequests)(entry.Entity))) == 0 ? entry.ReadTemporaryValue<int>(0) : ListOfRequestsUnsafeAccessors.Id(((ListOfRequests)(entry.Entity))))),
                int (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.Id(((ListOfRequests)(entry.Entity))),
                int (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                int (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                object (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            id.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                keyComparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));

            var estimatedTimeToCompleteTheTask = runtimeEntityType.AddProperty(
                "EstimatedTimeToCompleteTheTask",
                typeof(string),
                propertyInfo: typeof(ListOfRequests).GetProperty("EstimatedTimeToCompleteTheTask", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ListOfRequests).GetField("<EstimatedTimeToCompleteTheTask>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            estimatedTimeToCompleteTheTask.SetGetter(
                string (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(entity),
                bool (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(entity) == null,
                string (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(instance),
                bool (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(instance) == null);
            estimatedTimeToCompleteTheTask.SetSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(entity) = value);
            estimatedTimeToCompleteTheTask.SetMaterializationSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(entity) = value);
            estimatedTimeToCompleteTheTask.SetAccessors(
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.EstimatedTimeToCompleteTheTask(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(estimatedTimeToCompleteTheTask, 1),
                string (InternalEntityEntry entry) => entry.GetCurrentValue<string>(estimatedTimeToCompleteTheTask),
                object (ValueBuffer valueBuffer) => valueBuffer[1]);
            estimatedTimeToCompleteTheTask.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            estimatedTimeToCompleteTheTask.TypeMapping = SqliteStringTypeMapping.Default;

            var requestBody = runtimeEntityType.AddProperty(
                "RequestBody",
                typeof(string),
                propertyInfo: typeof(ListOfRequests).GetProperty("RequestBody", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ListOfRequests).GetField("<RequestBody>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            requestBody.SetGetter(
                string (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.RequestBody(entity),
                bool (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.RequestBody(entity) == null,
                string (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.RequestBody(instance),
                bool (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.RequestBody(instance) == null);
            requestBody.SetSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.RequestBody(entity) = value);
            requestBody.SetMaterializationSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.RequestBody(entity) = value);
            requestBody.SetAccessors(
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.RequestBody(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.RequestBody(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(requestBody, 2),
                string (InternalEntityEntry entry) => entry.GetCurrentValue<string>(requestBody),
                object (ValueBuffer valueBuffer) => valueBuffer[2]);
            requestBody.SetPropertyIndexes(
                index: 2,
                originalValueIndex: 2,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            requestBody.TypeMapping = SqliteStringTypeMapping.Default;

            var requestId = runtimeEntityType.AddProperty(
                "RequestId",
                typeof(string),
                propertyInfo: typeof(ListOfRequests).GetProperty("RequestId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ListOfRequests).GetField("<RequestId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            requestId.SetGetter(
                string (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.RequestId(entity),
                bool (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.RequestId(entity) == null,
                string (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.RequestId(instance),
                bool (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.RequestId(instance) == null);
            requestId.SetSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.RequestId(entity) = value);
            requestId.SetMaterializationSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.RequestId(entity) = value);
            requestId.SetAccessors(
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.RequestId(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.RequestId(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(requestId, 3),
                string (InternalEntityEntry entry) => entry.GetCurrentValue<string>(requestId),
                object (ValueBuffer valueBuffer) => valueBuffer[3]);
            requestId.SetPropertyIndexes(
                index: 3,
                originalValueIndex: 3,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            requestId.TypeMapping = SqliteStringTypeMapping.Default;

            var statusOfRequest = runtimeEntityType.AddProperty(
                "StatusOfRequest",
                typeof(string),
                propertyInfo: typeof(ListOfRequests).GetProperty("StatusOfRequest", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ListOfRequests).GetField("<StatusOfRequest>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            statusOfRequest.SetGetter(
                string (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.StatusOfRequest(entity),
                bool (ListOfRequests entity) => ListOfRequestsUnsafeAccessors.StatusOfRequest(entity) == null,
                string (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.StatusOfRequest(instance),
                bool (ListOfRequests instance) => ListOfRequestsUnsafeAccessors.StatusOfRequest(instance) == null);
            statusOfRequest.SetSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.StatusOfRequest(entity) = value);
            statusOfRequest.SetMaterializationSetter(
                (ListOfRequests entity, string value) => ListOfRequestsUnsafeAccessors.StatusOfRequest(entity) = value);
            statusOfRequest.SetAccessors(
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.StatusOfRequest(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => ListOfRequestsUnsafeAccessors.StatusOfRequest(((ListOfRequests)(entry.Entity))),
                string (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(statusOfRequest, 4),
                string (InternalEntityEntry entry) => entry.GetCurrentValue<string>(statusOfRequest),
                object (ValueBuffer valueBuffer) => valueBuffer[4]);
            statusOfRequest.SetPropertyIndexes(
                index: 4,
                originalValueIndex: 4,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            statusOfRequest.TypeMapping = SqliteStringTypeMapping.Default;

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var estimatedTimeToCompleteTheTask = runtimeEntityType.FindProperty("EstimatedTimeToCompleteTheTask")!;
            var requestBody = runtimeEntityType.FindProperty("RequestBody")!;
            var requestId = runtimeEntityType.FindProperty("RequestId")!;
            var statusOfRequest = runtimeEntityType.FindProperty("StatusOfRequest")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateSimpleNonNullableFactory<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((ListOfRequests)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int, string, string, string, string>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<int>(id)), (source.GetCurrentValue<string>(estimatedTimeToCompleteTheTask) == null ? null : ((ValueComparer<string>)(((IProperty)estimatedTimeToCompleteTheTask).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(estimatedTimeToCompleteTheTask))), (source.GetCurrentValue<string>(requestBody) == null ? null : ((ValueComparer<string>)(((IProperty)requestBody).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(requestBody))), (source.GetCurrentValue<string>(requestId) == null ? null : ((ValueComparer<string>)(((IProperty)requestId).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(requestId))), (source.GetCurrentValue<string>(statusOfRequest) == null ? null : ((ValueComparer<string>)(((IProperty)statusOfRequest).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(statusOfRequest))))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetValueComparer())).Snapshot(default(int))))));
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => ((ISnapshot)(new Snapshot<int>(default(int)))));
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((ListOfRequests)(source.Entity));
                    return ((ISnapshot)(new Snapshot<int>(((ValueComparer<int>)(((IProperty)id).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<int>(id)))));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 5,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 5,
                shadowCount: 0,
                relationshipCount: 1,
                storeGeneratedCount: 1);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Requests");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
