using UnityEngine;

/// <summary>
/// 防止代码运行时发生裁剪报错。将这个脚本添加到启动场景中。不会对逻辑有任何影响
/// </summary>
[UnityEngine.Scripting.Preserve]
[DisallowMultipleComponent]
public sealed class GameFrameXYooAssetMinigameGooglePlayCroppingHelper : MonoBehaviour
{
    private System.Type[] _types;

    [UnityEngine.Scripting.Preserve]
    private void Start()
    {
#if UNITY_ANDROID && GOOGLE_PLAY
        _types = new[]
        {
            typeof(GooglePlayFileSystem),
            typeof(GooglePlayFileSystemCreater),
            typeof(GPFSLoadAssetBundleOperation),
            typeof(GooglePlayWebPlayModeFileSystemProvider),
            typeof(GooglePlayWebPlayModeFileSystemProvider.Registrar),
        };
#endif
    }
}
