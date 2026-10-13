<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX YooAsset GooglePlay

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

GameFrameX 的 YooAsset Google Play 小游戏运行时组件，面向 Unity WebGL 平台，提供与 Google Play 小游戏文件系统、资源包加载流程的适配实现。

## 功能特性

- 提供 Google Play 小游戏专用的 IFileSystem 实现
- 适配 Google Play 小游戏 SDK 的 AssetBundle 下载与缓存流程
- 支持包版本请求、清单加载、资源包下载与加载
- 可对接远程服务与解密服务

## 运行环境

- Unity 2019.4
- 平台：UNITY_WEBGL
- 条件编译：GOOGLEPLAYMINIGAME
- 依赖：YooAsset、StarkWebGL、GooglePlayWebGL

## 快速开始

### 安装

选择以下任一方式：

1. 编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
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

   `scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

2. 直接在 `manifest.json` 的 `dependencies` 节点下添加以下内容：
   ```json
   {
      "com.gameframex.unity.tuyoogame.yooasset.googleplay": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加库，地址为：`https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay.git`
4. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。
### 升级说明（1.1.0）

1.1.0 版本接入主包的 `WebPlayModeFileSystemProviderRegistry` 注册表，新增 Provider/Registrar。请同时将 `com.gameframex.unity.tuyoogame.yooasset` 升级至 ≥ 3.1.0。

## 文档与资源

- [官方文档](https://gameframex.doc.alianblank.com)

## 社区与支持

- QQ群: [加入](https://qm.qq.com/q/3dIpogITg)

## 更新日志

查看 [Releases](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/releases) 了解更新日志。


## 依赖

| 包 | 说明 |
|----|------|
| `com.gameframex.unity.tuyoogame.yooasset` | ≥ 3.1.0 |

## 注册即分发机制

本包的 Registrar 会将自身的 `IWebPlayModeFileSystemProvider`（GooglePlay Priority 为 3）自注册到主包的 `WebPlayModeFileSystemProviderRegistry`，安装即生效、无需任何平台分支。资源抽象层在首次 Web 模式初始化时按 Priority 互斥解析（Priority 最高者优先，同优先级取注册序首个），一次初始化只会选中一个平台。注册发生在 `BeforeSceneLoad` 阶段，早于首次 Web 初始化；Provider 仅在 `UNITY_ANDROID && GOOGLE_PLAY` 条件编译下生效。
## 开源协议

详见 [LICENSE.md](LICENSE.md) 文件。
