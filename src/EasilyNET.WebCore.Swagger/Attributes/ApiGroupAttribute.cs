﻿// ReSharper disable MemberCanBePrivate.Global

namespace EasilyNET.WebCore.Swagger.Attributes;

/// <summary>
/// 被此特性标记的控制器可在Swagger文档分组中发挥作用.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ApiGroupAttribute(string title, string version, string description = "") : Attribute
{
    /// <summary>
    /// Doc名称,$"{Title}-{Version}"格式
    /// </summary>
    public string Name { get; } = $"{title}-{version}";

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; } = title;

    /// <summary>
    /// 版本
    /// </summary>
    public string Version { get; } = version;

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; } = description;
}