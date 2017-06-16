﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MagiciansChessAPI
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for LeaderboardEntryOperations.
    /// </summary>
    public static partial class LeaderboardEntryOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='owner'>
            /// </param>
            public static IList<LeaderboardEntry> GetByOwner(this ILeaderboardEntryOperations operations, string owner)
            {
                return Task.Factory.StartNew(s => ((ILeaderboardEntryOperations)s).GetByOwnerAsync(owner), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='owner'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LeaderboardEntry>> GetByOwnerAsync(this ILeaderboardEntryOperations operations, string owner, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByOwnerWithHttpMessagesAsync(owner, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='todo'>
            /// </param>
            public static void PutByTodo(this ILeaderboardEntryOperations operations, LeaderboardEntry todo)
            {
                Task.Factory.StartNew(s => ((ILeaderboardEntryOperations)s).PutByTodoAsync(todo), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='todo'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByTodoAsync(this ILeaderboardEntryOperations operations, LeaderboardEntry todo, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutByTodoWithHttpMessagesAsync(todo, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='todo'>
            /// </param>
            public static void PostByTodo(this ILeaderboardEntryOperations operations, LeaderboardEntry todo)
            {
                Task.Factory.StartNew(s => ((ILeaderboardEntryOperations)s).PostByTodoAsync(todo), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='todo'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostByTodoAsync(this ILeaderboardEntryOperations operations, LeaderboardEntry todo, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostByTodoWithHttpMessagesAsync(todo, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='owner'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static LeaderboardEntry GetByIdByOwnerAndId(this ILeaderboardEntryOperations operations, string owner, int id)
            {
                return Task.Factory.StartNew(s => ((ILeaderboardEntryOperations)s).GetByIdByOwnerAndIdAsync(owner, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='owner'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LeaderboardEntry> GetByIdByOwnerAndIdAsync(this ILeaderboardEntryOperations operations, string owner, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdByOwnerAndIdWithHttpMessagesAsync(owner, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='owner'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void DeleteByOwnerAndId(this ILeaderboardEntryOperations operations, string owner, int id)
            {
                Task.Factory.StartNew(s => ((ILeaderboardEntryOperations)s).DeleteByOwnerAndIdAsync(owner, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='owner'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByOwnerAndIdAsync(this ILeaderboardEntryOperations operations, string owner, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteByOwnerAndIdWithHttpMessagesAsync(owner, id, null, cancellationToken).ConfigureAwait(false);
            }

    }
}