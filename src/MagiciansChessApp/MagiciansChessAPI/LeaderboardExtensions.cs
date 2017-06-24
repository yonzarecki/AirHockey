﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MagiciansChessApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Leaderboard.
    /// </summary>
    public static partial class LeaderboardExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<LeaderboardEntry> GetLeaderboardEntries(this ILeaderboard operations)
            {
                return Task.Factory.StartNew(s => ((ILeaderboard)s).GetLeaderboardEntriesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LeaderboardEntry>> GetLeaderboardEntriesAsync(this ILeaderboard operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLeaderboardEntriesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='entry'>
            /// </param>
            public static void PostLeaderboardEntryByEntry(this ILeaderboard operations, LeaderboardEntry entry)
            {
                Task.Factory.StartNew(s => ((ILeaderboard)s).PostLeaderboardEntryByEntryAsync(entry), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='entry'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostLeaderboardEntryByEntryAsync(this ILeaderboard operations, LeaderboardEntry entry, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostLeaderboardEntryByEntryWithHttpMessagesAsync(entry, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
