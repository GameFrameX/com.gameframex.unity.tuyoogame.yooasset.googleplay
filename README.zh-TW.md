<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX YooAsset GooglePlay

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

GameFrameX 的 YooAsset Google Play 小遊戲運行時組件，面向 Unity WebGL 平台，提供與 Google Play 小遊戲檔案系統、資源包載入流程的適配實作。

## 功能特性

- 提供 Google Play 小遊戲專用的 IFileSystem 實作
- 適配 Google Play 小遊戲 SDK 的 AssetBundle 下載與快取流程
- 支援包版本請求、清單載入、資源包下載與載入
- 可對接遠端服務與解密服務

## 運行環境

- Unity 2019.4
- 平台：UNITY_WEBGL
- 條件編譯：GOOGLEPLAYMINIGAME
- 依賴：YooAsset、StarkWebGL、GooglePlayWebGL

## 快速開始

### 安裝

選擇以下任一方式：

1. 編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：
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

   `scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

2. 直接在 `manifest.json` 的 `dependencies` 節點下添加以下內容：
   ```json
   {
      "com.gameframex.unity.tuyoogame.yooasset.googleplay": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay.git"
   }
   ```
3. 在 Unity 的 `Package Manager` 中使用 `Git URL` 的方式添加庫，地址為：`https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay.git`
4. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。
### 升級說明（1.1.0）

1.1.0 版本接入主包的 `WebPlayModeFileSystemProviderRegistry` 註冊表，新增 Provider/Registrar。請同時將 `com.gameframex.unity.tuyoogame.yooasset` 升級至 ≥ 3.1.0。

## 文檔與資源

- [官方文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- QQ群: [加入](https://qm.qq.com/q/3dIpogITg)

## 更新日誌

查看 [Releases](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.googleplay/releases) 了解更新日誌。


## 依賴

| 套件 | 說明 |
|------|------|
| `com.gameframex.unity.tuyoogame.yooasset` | ≥ 3.1.0 |

## 註冊即分發機制

本包的 Registrar 會將自身的 `IWebPlayModeFileSystemProvider`（GooglePlay Priority 為 3）自註冊到主包的 `WebPlayModeFileSystemProviderRegistry`，安裝即生效、無需任何平台分支。資源抽象層在首次 Web 模式初始化時按 Priority 互斥解析（Priority 最高者優先，同優先級取註冊序首個），一次初始化只會選中一個平台。註冊發生在 `BeforeSceneLoad` 階段，早於首次 Web 初始化；Provider 僅在 `UNITY_ANDROID && GOOGLE_PLAY` 條件編譯下生效。
## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
