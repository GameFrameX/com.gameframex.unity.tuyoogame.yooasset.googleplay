## [Unreleased]

### Bug Fixes

* **runtime:** 移除 `YooAsset.GooglePlay.asmdef` 中两条 `com.bytedance.starksdk` versionDefines 残留（`DOUYIN_MINI_GAME` / `DOUYINMINIGAME`，疑似自抖音包复制遗留）：本包源码无任何消费点，GooglePlay 绑定不应依赖抖音 SDK 包

# [2.0.0](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay/compare/1.0.2...2.0.0) (2026-10-15)


### Bug Fixes

* **package:** 对齐 yooasset 3.1.0 依赖并修正品牌命名 ([ca2113c](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay/commit/ca2113cca336eb48cc0d58cb9df7cb631cb195e7))


### Features

* **package:** 包名截断 minigame 段并对齐家族命名 ([8f31547](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay/commit/8f31547ca5a6368f6bb4640f7187c2e2880637c0))
* **provider:** 接入主包小游戏注册表 ([e87bf46](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.googleplay/commit/e87bf46a95cc210a95552ef8e81ecfa96ee0e759))


### BREAKING CHANGES

* **package:** 包身份重命名，外部消费者依赖声明须改引新包名。
* **provider:** 不再依赖 com.gameframex.unity.asset。

## [1.0.2](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/compare/1.0.1...1.0.2) (2026-07-30)


### Bug Fixes

* 更新依赖项 com.gameframex.unity.tuyoogame.yooasset 至 2.9.4 ([f42ddcf](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/commit/f42ddcf94785e5e9395783ea0048316c940dd8bc))

## [1.0.1](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/compare/1.0.0...1.0.1) (2026-06-07)


### Bug Fixes

* 统一 LICENSE.md 为 Apache 2.0 标准完整文本 ([3cad3bb](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/commit/3cad3bb9d01fce72fde38d686d9d5b9518119cbd))
* 补全包规范文件（LICENSE/CHANGELOG/URL 字段/unity 字段） ([3992963](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/commit/3992963245a89b027009300b5d4ec3c8e6b2163b))

# 1.0.0 (2026-03-05)


### Features

* 添加 Google Play Asset Delivery 文件系统支持 ([2a5ff32](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/commit/2a5ff32065c39457f8dde25ed84f321b428a5cbf))

# 1.0.0 (2026-03-05)


### Features

* 添加 Unity 包配置文件和运行时文件夹 ([a548bb2](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.tiktok/commit/a548bb2a2627fbb5663c7e0b19e8c3b78d1ab7b9))
* 添加抖音小游戏文件系统支持 ([f08bcf9](https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.tiktok/commit/f08bcf9557c3862368ac41e45168841c412e6003))
