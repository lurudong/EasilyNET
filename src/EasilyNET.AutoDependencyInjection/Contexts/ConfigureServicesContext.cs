﻿using Microsoft.Extensions.DependencyInjection;

namespace EasilyNET.AutoDependencyInjection.Contexts;

/// <summary>
/// 自定义配置服务上下文
/// </summary>
/// <remarks>
/// 配置服务上下文
/// </remarks>
/// <param name="services"></param>
public sealed class ConfigureServicesContext(IServiceCollection services)
{
    /// <summary>
    /// IServiceCollection
    /// </summary>
    public IServiceCollection Services { get; } = services;
}