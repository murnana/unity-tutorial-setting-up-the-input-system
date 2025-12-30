# Unity チュートリアル: Input System のセットアップ

このプロジェクトは、Unity Learn の公式コース「[Using the Input System in Unity](https://learn.unity.com/course/using-the-input-system-in-unity)」の課題を実践するための学習プロジェクトです。

## プロジェクト概要

このプロジェクトは、Unity の新しい Input System パッケージの使い方を学ぶためのプロジェクトです。Unity Learn の各 Challenge に従って、Input System のセットアップ方法と実践的な使い方を習得できます。

### 現在の状態

- **プロジェクト状態**: Challenge 3 完了
- **Input System パッケージ**: v1.17.0 インストール済み
- **学習目標**: Input System を使った実践的な車両制御の実装

### Unity Learn Challenge について

- **完了済み**: Challenge 1 & Challenge 2 & Challenge 3
- **コース**: Using the Input System in Unity
- **難易度**: 初心者向け (Beginner)
- **Challenge 1 URL**: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system
- **Challenge 2 URL**: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-2-configure-the-wheel-drive-component-s-handbrake-input
- **Challenge 3 URL**: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-3-configure-the-wheel-drive-component-s-acceleration-and-steering-angle-inputs
- **コース全体URL**: https://learn.unity.com/course/using-the-input-system-in-unity

## セットアップ手順

### 1. 必要な環境

- **Unity バージョン**: 6000.3.2f1 (Unity 6)
- **Unity Hub**: 最新版を推奨

### 2. プロジェクトを開く

```bash
# Unity Hub からプロジェクトを開く
# 「プロジェクトを追加」→ このディレクトリを選択
```

または、Unity Hub の「開く」ボタンからこのプロジェクトフォルダを選択してください。

### 3. 依存パッケージの確認

プロジェクトを開くと、必要なパッケージが自動的にインポートされます：

- **Input System** (1.17.0) - メインの学習対象パッケージ
- **Universal Render Pipeline** (17.3.0) - レンダリングパイプライン
- **Visual Scripting** (1.9.9) - ビジュアルスクリプティングツール
- **Test Framework** (1.6.0) - テストフレームワーク

## 実装済みの Challenge

### Challenge 1: Setting up the Input System

**学習内容:**
- Input System パッケージのセットアップ
- Input Actions Asset の作成と設定
- PlayerInput コンポーネントの使用
- 車両切り替え機能の実装

**実装内容:**
- Primary Input Actions Asset の作成
- CarSwitcher コンポーネントの実装
- TestTrack シーンのセットアップ
- Tab キーによる車両切り替え機能

### Challenge 2: Configure the Wheel Drive Component's Handbrake Input

**学習内容:**
- 1D Axis Input を使った車両制御
- Button と Modifier アクションの設定
- C# スクリプトでの Input System API の使用
- Input ライフサイクル管理（OnEnable/OnDisable）

**実装内容:**
- Handbrake アクションの追加（X キーにバインド）
- WheelDrive.cs への Input System 統合
- `GetHandBrakeInput()` メソッドの実装
- 各車両プレハブへの Input Actions 割り当て

### Challenge 3: Configure the Wheel Drive Component's Acceleration and Steering Angle Inputs

**学習内容:**
- 複数の 1D Axis Input の設定と管理
- Composite Binding（1D Axis）の使用
- 車両の加速・減速制御の実装
- ステアリング制御の実装
- イベントベースの入力処理（performed/canceled）

**実装内容:**
- Acceleration アクションの追加（W/S キーにバインド）
- Steering Angle アクションの追加（A/D キーにバインド）
- `GetTorqueInput()` メソッドの実装（加速制御）
- `GetAngleInput()` メソッドの実装（ステアリング制御）
- 既存の `Input.GetAxis()` コードの削除
- イベント登録の拡張（performed/canceled コールバック）

## プロジェクト構成

```
Assets/
├── DefaultVolumeProfile.asset                      # デフォルトのボリューム設定
├── UniversalRenderPipelineGlobalSettings.asset     # URP グローバル設定
├── Prefabs/
│   └── Vehicles/                                   # 車両プレハブ
│       ├── FamilyCar.prefab                        # ファミリーカー
│       ├── SportsCar.prefab                        # スポーツカー
│       └── Truck.prefab                            # トラック
├── Scenes/
│   └── TestTrack.unity                             # テストトラックシーン
├── Scripts/
│   ├── CarSwitcher.cs                              # 車両切り替えスクリプト
│   └── WheelDrive.cs                               # 車両駆動スクリプト
└── Settings/
    └── InputSystems/
        └── Primary Input Actions.inputactions      # 入力アクション定義

ProjectSettings/
└── (Unity プロジェクト設定ファイル群)
```

## 学習リソース

### 公式リソース
- [Unity Learn: Challenge 1 - Setting up the Input System](https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system)
- [Unity Learn: Using the Input System in Unity（コース全体）](https://learn.unity.com/course/using-the-input-system-in-unity)
- [Unity 公式 Input System ドキュメント](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/index.html)

### 追加リソース
- [Input System パッケージ GitHub](https://github.com/Unity-Technologies/InputSystem)
- [Input System フォーラム](https://forum.unity.com/forums/input-system.103/)

## プロジェクトの進行状況

### 完了したステップ
- ✅ プロジェクトの初期セットアップ
- ✅ Input System パッケージのインストール (v1.17.0)
- ✅ Challenge 1: Setting up the Input System
  - ✅ Input Actions Asset の作成
  - ✅ CarSwitcher スクリプトの実装
  - ✅ 車両切り替え機能の動作確認
- ✅ Challenge 2: Configure the Wheel Drive Component's Handbrake Input
  - ✅ Handbrake アクションの追加
  - ✅ WheelDrive.cs への Input System 統合
  - ✅ Input ライフサイクル管理の実装
  - ✅ 各車両への Input Actions 割り当て
- ✅ Challenge 3: Configure the Wheel Drive Component's Acceleration and Steering Angle Inputs
  - ✅ Acceleration アクションの追加（1D Axis Composite Binding）
  - ✅ Steering Angle アクションの追加（1D Axis Composite Binding）
  - ✅ イベントベース入力処理の実装
  - ✅ レガシー Input.GetAxis() コードの削除
  - ✅ 車両の加速・ステアリング制御の動作確認

### 次のステップ
- ⬜ Challenge 4 以降のコースに進む

## ライセンス

このプロジェクトは学習目的で作成されています。

### 学習コース
- **Using the Input System in Unity**
- Unity Learn で無料公開
- URL: https://learn.unity.com/course/using-the-input-system-in-unity
- 提供元: Unity Technologies

## 貢献とフィードバック

質問や改善提案がある場合は、Issue を作成してください。

このプロジェクトは学習目的で作成されています。
