﻿using ModelContextProtocol.Client;

namespace ModelContextProtocol.Server;

/// <summary>
/// Represents errors that occur in the MCP server.
/// </summary>
public class McpServerException : Exception
{
    /// <summary>
    /// Gets the error code if this exception was caused by a JSON-RPC error response.
    /// </summary>
    public int? ErrorCode { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="McpServerException"/> class with a specified error message.
    /// </summary>
    public McpServerException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="McpServerException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public McpServerException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="McpServerException"/> class with a specified error message and error code.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="errorCode">The error code associated with the JSON-RPC error response.</param>
    public McpServerException(string message, int errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="McpClientException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public McpServerException(string message, Exception innerException) : base(message, innerException)
    {
    }
}