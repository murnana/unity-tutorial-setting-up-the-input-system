# Unity チュートリアル: Input System のセットアップ

このプロジェクトは、Unity Learn の公式コース「[Using the Input System in Unity](https://learn.unity.com/course/using-the-input-system-in-unity)」の **Challenge 1: Setting up the Input System** を実践するための学習プロジェクトです。

## プロジェクト概要

このプロジェクトは、Unity の新しい Input System パッケージの使い方を学ぶための空のプロジェクトです。Unity Learn の Challenge 1 に従って、Input System のセットアップ方法と基本的な使い方を習得できます。

### 現在の状態

- **プロジェクト状態**: 空のプロジェクト（Challenge 1 用にリセット済み）
- **Input System パッケージ**: v1.17.0 インストール済み
- **学習目標**: Challenge 1 の課題に取り組み、Input System の基本を理解する

### Unity Learn Challenge について

- **Challenge 名**: Challenge 1: Setting up the Input System
- **コース**: Using the Input System in Unity
- **難易度**: 初心者向け (Beginner)
- **Challenge URL**: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system
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

## Challenge 1 の進め方

### 学習の流れ

1. **Unity Learn の Challenge 1 ページにアクセス**
   - URL: https://learn.unity.com/course/using-the-input-system-in-unity/tutorial/challenge-1-setup-the-input-system-and-convert-the-car-switcher-s-component-to-use-the-new-input-system

2. **Challenge の指示に従って実装**
   - Input System のセットアップ
   - Input Actions の作成
   - スクリプトでの使用方法

3. **このプロジェクトで実践**
   - 空のシーンから開始
   - Challenge の要件を満たす実装を追加

### 主な学習内容

- Input System パッケージのセットアップ
- Input Actions Asset の作成と設定
- PlayerInput コンポーネントの使用
- Input System Scripting API の基礎

## プロジェクト構成

```
Assets/
├── DefaultVolumeProfile.asset           # デフォルトのボリューム設定
├── UniversalRenderPipelineGlobalSettings.asset  # URP グローバル設定
└── (Challenge 1 で作成するアセットがここに追加されます)

ProjectSettings/
└── (Unity プロジェクト設定ファイル群)
```

現在、このプロジェクトは空の状態です。Challenge 1 の課題に取り組むことで、必要なアセットやスクリプトを追加していきます。

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
- ✅ 空のプロジェクトを準備

### 次のステップ
- ⬜ Challenge 1 の課題に取り組む
- ⬜ Input Actions Asset を作成
- ⬜ PlayerInput コンポーネントを設定
- ⬜ Input System を使用したスクリプトを実装

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
