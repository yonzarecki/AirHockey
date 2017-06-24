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
    /// Extension methods for ChessAI.
    /// </summary>
    public static partial class ChessAIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gameXml'>
            /// </param>
            /// <param name='playerColor'>
            /// </param>
            /// <param name='timeLimitInSecs'>
            /// </param>
            public static Move GetBestMoveByGamexmlAndPlayercolorAndTimelimitinsecs(this IChessAI operations, string gameXml, string playerColor, int timeLimitInSecs)
            {
                return Task.Factory.StartNew(s => ((IChessAI)s).GetBestMoveByGamexmlAndPlayercolorAndTimelimitinsecsAsync(gameXml, playerColor, timeLimitInSecs), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='gameXml'>
            /// </param>
            /// <param name='playerColor'>
            /// </param>
            /// <param name='timeLimitInSecs'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Move> GetBestMoveByGamexmlAndPlayercolorAndTimelimitinsecsAsync(this IChessAI operations, string gameXml, string playerColor, int timeLimitInSecs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBestMoveByGamexmlAndPlayercolorAndTimelimitinsecsWithHttpMessagesAsync(gameXml, playerColor, timeLimitInSecs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
