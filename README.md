<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX YooAsset GooglePlay

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

GameFrameX YooAsset GooglePlay runtime component for Unity WebGL platform. Provides adapter implementation for Google Play Mini Game file system and asset bundle loading.

## Features

- Provides Google Play Mini Game specific IFileSystem implementation
- Adapts Google Play Mini Game SDK's AssetBundle download and caching workflow
- Supports package version requests, manifest loading, asset bundle download and loading
- Compatible with remote services and decryption services

## Requirements

- Unity 2019.4
- Platform: UNITY_WEBGL
- Conditional compilation: GOOGLEPLAYMINIGAME
- Dependencies: YooAsset, StarkWebGL, GooglePlayWebGL

## Quick Start

### Installation

Choose one of the following methods:

1. Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.tuyoogame.yooasset.googleplay": "1.0.0"
     }
   }
   ```

   `scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

2. Add to `manifest.json` dependencies:
   ```json
   {
      "com.gameframex.unity.tuyoogame.yooasset.googleplay": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay.git"
   }
   ```
3. Use **Package Manager** in Unity with **Git URL**: `https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay.git`
4. Clone the repository into your Unity project's `Packages` directory. It will be loaded automatically.
### Upgrade Notes (1.1.0)

In 1.1.0 the package joins the main YooAsset package's `WebPlayModeFileSystemProviderRegistry` and adds a Provider/Registrar pair. Upgrade `com.gameframex.unity.tuyoogame.yooasset` to ≥ 3.1.0 at the same time.

## Documentation & Resources

- [Official Documentation](https://gameframex.doc.alianblank.com)

## Community & Support

- QQ Group: [Join](https://qm.qq.com/q/3dIpogITg)

## Changelog

See [Releases](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/releases) for changelog.


## Dependencies

| Package | Description |
|---------|-------------|
| `com.gameframex.unity.tuyoogame.yooasset` | ≥ 3.1.0 |

## Register-and-Dispatch Mechanism

The package's Registrar self-registers its `IWebPlayModeFileSystemProvider` (Priority 3) into the main YooAsset package's `WebPlayModeFileSystemProviderRegistry`, so installation alone enables dispatch with no platform branching. The asset abstraction layer resolves providers by Priority during the first Web play mode initialization — the highest Priority wins (first registered wins on ties), so only one platform is selected per initialization. Registration runs at the `BeforeSceneLoad` stage, earlier than the first Web initialization; the provider is compiled only under `UNITY_ANDROID && GOOGLE_PLAY`.
## License

See [LICENSE.md](LICENSE.md) for license information.
