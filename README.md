# Unity チュートリアル: Input System のセットアップ

このプロジェクトは、Unity Learn の公式コース「[Using the Input System in Unity](https://learn.unity.com/course/using-the-input-system-in-unity)」で学んだ内容を、**Roll-a-Ball** ゲームに適用するための実践プロジェクトです。

## プロジェクト概要

**Roll-a-Ball** は、プレイヤーがボールを転がして、フィールド上のアイテムを収集する3Dゲームです。このプロジェクトでは、Unity Learn コースで学習する Input System の概念を実際のゲームに実装し、従来の Input Manager API から新しい Input System への移行方法を習得できます。

### ベースプロジェクトについて

このプロジェクトは、Unity Technologies が提供する公式チュートリアルアセットをベースにしています：

- **アセット名**: Unity Learn | 3D Beginner: Roll-a-Ball | Complete Project | URP
- **提供元**: Unity Technologies
- **Asset Store URL**: https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-3d-beginner-roll-a-ball-complete-project-urp-77198
- **バージョン**: 4.0 (2024年8月7日リリース)
- **ライセンス**: 無料（Unity Asset Store 標準EULA）
- **対応Unity**: 6000.0.0f1, 2022.3.0f1, 2021.3.11f1

このアセットは、Unity の3D ゲーム開発の基礎を学ぶための初心者向けチュートリアルプロジェクトとして設計されています。

### Unity Learn コースについて

- **コース名**: Using the Input System in Unity
- **難易度**: 初心者向け (Beginner)
- **所要時間**: 約3時間25分
- **URL**: https://learn.unity.com/course/using-the-input-system-in-unity

## セットアップ手順

### 1. プロジェクトを開く

```bash
# Unity Hub からプロジェクトを開く
# 「プロジェクトを追加」→ このディレクトリを選択
```

または、Unity Hub の「開く」ボタンからこのプロジェクトフォルダを選択してください。

### 2. 依存パッケージの確認

プロジェクトを開くと、必要なパッケージが自動的にインポートされます：

- Input System (1.17.0)
- Universal Render Pipeline (17.3.0)
- Visual Scripting (1.9.9)
- Test Framework (1.6.0)

## ゲームの実行方法

1. Unity エディタでプロジェクトを開く
2. メインシーン `Assets/UnityTechnologies/RollABall/Roll-a-ball.unity` を開く
3. エディタ上部の **Play** ボタンをクリック (または `Ctrl+P` / `Cmd+P`)

### 操作方法

- **移動:** WASD キーまたは方向キー
- **目標:** 12個のアイテムをすべて収集すると勝利

## オンラインでプレイ

このゲームは Unity Play で公開されており、ブラウザから直接プレイできます：

https://play.unity.com/en/games/6ecfeebd-ced4-459c-ac34-d9e83ada7c8e/tutorial-input-system

Unity エディタをインストールせずに、ゲームの動作を確認できます。

## プロジェクト構成

```
Assets/UnityTechnologies/RollABall/
├── Scripts/              # ゲームロジック (C#)
│   ├── PlayerController.cs    # プレイヤーの移動とアイテム収集
│   ├── CameraController.cs    # カメラの追従
│   └── Rotator.cs             # アイテムの回転アニメーション
├── Prefabs/              # 再利用可能なゲームオブジェクト
│   └── Pick Up.prefab         # 収集アイテムのプレハブ
├── Materials/            # マテリアル
├── URP/                  # レンダーパイプライン設定
└── Roll-a-ball.unity     # メインシーン
```

## 学習リソース

### 公式リソース
- [Unity Learn: Using the Input System in Unity（このプロジェクトのベースコース）](https://learn.unity.com/course/using-the-input-system-in-unity)
- [Unity 公式 Input System ドキュメント](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html)
- [Roll-a-Ball チュートリアル](https://learn.unity.com/project/roll-a-ball)

### 追加リソース
- [Input System パッケージ GitHub](https://github.com/Unity-Technologies/InputSystem)
- [Input System フォーラム](https://forum.unity.com/forums/input-system.103/)

## ライセンスとクレジット

このプロジェクトは、Unity Technologies が提供する以下の公式リソースをベースにしています：

### ベースアセット
- **Unity Learn | 3D Beginner: Roll-a-Ball | Complete Project | URP**
- Unity Asset Store で無料配布
- URL: https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-3d-beginner-roll-a-ball-complete-project-urp-77198
- ライセンス: Unity Asset Store EULA に準拠

### 学習コース
- **Using the Input System in Unity**
- Unity Learn で無料公開
- URL: https://learn.unity.com/course/using-the-input-system-in-unity

### クレジット
- オリジナルプロジェクト: Unity Technologies
- チュートリアルコース: Unity Technologies
- このリポジトリ: 学習・実践目的のための改変版

## 貢献とフィードバック

質問や改善提案がある場合は、Issue を作成してください。

このプロジェクトは学習目的で作成されています。Unity Technologies の公式リソースを尊重し、適切に利用してください。
