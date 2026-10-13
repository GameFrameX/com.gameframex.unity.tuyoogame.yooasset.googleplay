<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX YooAsset MiniGame GooglePlay

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

GameFrameX の YooAsset Google Play ミニゲームランタイムコンポーネント。Unity WebGL プラットフォーム向けに、Google Play ミニゲームのファイルシステムとアセットバンドル読み込みフローの適配実装を提供します。

## 機能

- Google Play ミニゲーム専用の IFileSystem 実装を提供
- Google Play ミニゲーム SDK の AssetBundle ダウンロードとキャッシュワークフローに適配
- パッケージバージョンリクエスト、マニフェスト読み込み、アセットバンドルダウンロードと読み込みをサポート
- リモートサービスと復号サービスに対応

## 動作環境

- Unity 2019.4
- プラットフォーム：UNITY_WEBGL
- 条件付きコンパイル：GOOGLEPLAYMINIGAME
- 依存関係：YooAsset、StarkWebGL、GooglePlayWebGL

## クイックスタート

### インストール

以下のいずれかの方法を選択してください：

1. Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：
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
       "com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay": "1.0.0"
     }
   }
   ```

   `scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

2. `manifest.json` の `dependencies` に直接追加：
   ```json
   {
      "com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay.git"
   }
   ```
3. Unity の **Package Manager** で **Git URL** を使用して追加：`https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay.git`
4. リポジトリを Unity プロジェクトの `Packages` ディレクトリにクローンしてください。自動的に読み込まれます。
### アップグレード注意事項（1.1.0）

1.1.0 では、メインパッケージの `WebPlayModeFileSystemProviderRegistry` に参加し、Provider/Registrar を追加しました。同時に `com.gameframex.unity.tuyoogame.yooasset` を ≥ 3.1.0 にアップグレードしてください。

## ドキュメントとリソース

- [公式ドキュメント](https://gameframex.doc.alianblank.com)

## コミュニティとサポート

- QQグループ: [参加](https://qm.qq.com/q/3dIpogITg)

## 変更履歴

変更履歴は [Releases](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/releases) をご覧ください。


## 依存関係

| パッケージ | 説明 |
|----------|------|
| `com.gameframex.unity.tuyoogame.yooasset` | ≥ 3.1.0 |

## 登録即ディスパッチ機構

本パッケージの Registrar は、自身の `IWebPlayModeFileSystemProvider`（GooglePlay の Priority は 3）をメインパッケージの `WebPlayModeFileSystemProviderRegistry` に自己登録するため、インストールするだけでディスパッチが有効になり、プラットフォーム分岐は不要です。アセット抽象レイヤーは最初の Web プレイモード初期化時に Priority で排他的に解決し（Priority が最も高いものが優先、同値の場合は先に登録されたもの）、1 回の初期化で選択されるプラットフォームは 1 つだけです。登録は `BeforeSceneLoad` ステージで行われ、最初の Web 初期化より早く実行されます。Provider は `UNITY_ANDROID && GOOGLE_PLAY` 条件コンパイルでのみ有効です。
## ライセンス

詳しくは [LICENSE.md](LICENSE.md) をご参照ください。
