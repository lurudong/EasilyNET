﻿using RabbitMQ.Client;

namespace EasilyNET.RabbitBus.AspNetCore.Abstraction;

internal interface IChannelPool : IDisposable
{
    /// <summary>
    /// 从池中获取Channel
    /// </summary>
    /// <returns></returns>
    IModel GetChannel();

    /// <summary>
    /// 归还Channel到池或者释放
    /// </summary>
    /// <param name="channel"></param>
    void ReturnChannel(IModel channel);
}