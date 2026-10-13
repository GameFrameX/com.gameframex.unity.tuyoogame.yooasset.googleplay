using YooAsset;

#if UNITY_ANDROID && GOOGLE_PLAY

/// <summary>
/// Google Play Web 运行模式文件系统提供者（Play Asset Delivery）
/// </summary>
[UnityEngine.Scripting.Preserve]
internal sealed class GooglePlayWebPlayModeFileSystemProvider : IWebPlayModeFileSystemProvider
{
    public string ChannelName
    {
        get { return "GooglePlay"; }
    }

    public int Priority
    {
        get { return 3; }
    }

    public FileSystemParameters CreateFileSystemParameters(WebPlayModeProviderContext context)
    {
        // 创建谷歌 Play Asset Delivery 文件系统
        if (string.IsNullOrWhiteSpace(context.HostServerURL))
        {
            return GooglePlayFileSystemCreater.CreateFileSystemParameters(null);
        }

        return GooglePlayFileSystemCreater.CreateFileSystemParameters(context.HostServerURL);
    }

    /// <summary>
    /// 运行时自动注册
    /// </summary>
    [UnityEngine.Scripting.Preserve]
    internal static class Registrar
    {
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Register()
        {
            WebPlayModeFileSystemProviderRegistry.Register(new GooglePlayWebPlayModeFileSystemProvider());
        }
    }
}

#endif
