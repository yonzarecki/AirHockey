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
    /// Extension methods for ChessTest.
    /// </summary>
    public static partial class ChessTestExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetInitialGame(this IChessTest operations)
            {
                return Task.Factory.StartNew(s => ((IChessTest)s).GetInitialGameAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetInitialGameAsync(this IChessTest operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInitialGameWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}