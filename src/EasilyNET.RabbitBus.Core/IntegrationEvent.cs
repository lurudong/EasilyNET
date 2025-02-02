﻿using EasilyNET.Core.BaseType;
using System.Text.Json.Serialization;

namespace EasilyNET.RabbitBus.Core;

/// <summary>
/// 事件基本对象,所有的事件均需要继承此类
/// </summary>
public class IntegrationEvent : IIntegrationEvent
{
    /// <inheritdoc />
    [JsonInclude]
    public string EventId { get; } = SnowId.GenerateNewId().ToString();

    /// <inheritdoc />
    [JsonInclude]
    public DateTime EventCreateDate { get; } = DateTime.Now.ToLocalTime();
}