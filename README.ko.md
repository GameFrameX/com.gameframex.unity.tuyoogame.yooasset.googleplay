<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX YooAsset MiniGame GooglePlay

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay)](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

GameFrameX의 YooAsset Google Play 미니게임 런타임 컴포넌트입니다. Unity WebGL 플랫폼을 대상으로 Google Play 미니게임 파일 시스템 및 에셋 번들 로딩 흐름의 어댑터 구현을 제공합니다.

## 기능

- Google Play 미니게임 전용 IFileSystem 구현 제공
- Google Play 미니게임 SDK의 AssetBundle 다운로드 및 캐싱 워크플로우 적응
- 패키지 버전 요청, 매니페스트 로딩, 에셋 번들 다운로드 및 로딩 지원
- 원격 서비스 및 복호화 서비스 연동 가능

## 실행 환경

- Unity 2019.4
- 플랫폼: UNITY_WEBGL
- 조건부 컴파일: GOOGLEPLAYMINIGAME
- 의존성: YooAsset, StarkWebGL, GooglePlayWebGL

## 빠른 시작

### 설치

다음 방법 중 하나를 선택하세요:

1. Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:
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

   `scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

2. `manifest.json`의 `dependencies`에 직접 추가:
   ```json
   {
      "com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay": "https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay.git"
   }
   ```
3. Unity의 **Package Manager**에서 **Git URL**을 사용하여 추가: `https://github.com/gameframex/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay.git`
4. 리포지토리를 Unity 프로젝트의 `Packages` 디렉토리에 클론하세요. 자동으로 로드됩니다.
### 업그레이드 안내 (1.1.0)

1.1.0에서는 메인 패키지의 `WebPlayModeFileSystemProviderRegistry`에 참여하고 Provider/Registrar를 추가했습니다. 동시에 `com.gameframex.unity.tuyoogame.yooasset`를 ≥ 3.1.0으로 업그레이드하세요.

## 문서 및 자료

- [공식 문서](https://gameframex.doc.alianblank.com)

## 커뮤니티 및 지원

- QQ 그룹: [가입](https://qm.qq.com/q/3dIpogITg)

## 변경 로그

변경 로그는 [Releases](https://github.com/GameFrameX/com.gameframex.unity.tuyoogame.yooasset.minigame.googleplay/releases)에서 확인하세요.


## 의존성

| 패키지 | 설명 |
|--------|------|
| `com.gameframex.unity.tuyoogame.yooasset` | ≥ 3.1.0 |

## 등록 즉 디스패치 방식

이 패키지의 Registrar는 자체 `IWebPlayModeFileSystemProvider`(GooglePlay의 Priority 3)를 메인 패키지의 `WebPlayModeFileSystemProviderRegistry`에 자동 등록하므로, 설치만으로 디스패치가 활성화되며 플랫폼 분기가 필요 없습니다. 에셋 추상화 계층은 첫 Web 플레이 모드 초기화 시 Priority로 상호 배타적으로 해결하며(Priority가 가장 높은 것이 우선, 동일하면 먼저 등록된 것), 한 번의 초기화에서 하나의 플랫폼만 선택됩니다. 등록은 `BeforeSceneLoad` 단계에서 수행되어 첫 Web 초기화보다 이르며, Provider는 `UNITY_ANDROID && GOOGLE_PLAY` 조건 컴파일에서만 활성화됩니다.
## 라이선스

자세한 내용은 [LICENSE.md](LICENSE.md) 파일을 참조하세요.
