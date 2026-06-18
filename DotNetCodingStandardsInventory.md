# DotNet Coding Standards Inventory

このファイルは、`HTML/coding-standards.html` を .NET / C# 公式規約ベースへ戻すために取得したソースと、反映先の対応を残す。

## 公式ソース

1. Common C# code conventions
   - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
2. C# identifier naming rules and conventions
   - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names
3. Code-style rules overview
   - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/
4. Code-style language and unnecessary code rules
   - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/language-rules
5. C# formatting options
   - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/csharp-formatting-options
6. .NET formatting options
   - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/dotnet-formatting-options
7. Code-style naming rules
   - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/naming-rules
8. Code-style rule options
   - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/code-style-rule-options

## coding-standards.html への反映

| HTML セクション | 反映した公式内容 |
| --- | --- |
| `#scope` | 取得対象ソースの範囲 |
| `#guidelines` | Common C# code conventions の文章ベース規約 |
| `#naming` | identifier naming rules, naming rules の既定慣例と rule 構成 |
| `#language-rules` | style rules overview / language rules の rule index |
| `#formatting` | C# formatting options, .NET formatting options の option 名と既定値 |
| `#enforcement` | code-style rule options の適用方法 |
| `#sources` | 参照元 URL 一覧 |

## 独自規約として退避した内容

以下は .NET 標準ではなく、`HTML/coding-standards-overrides.html` へ退避した。

- ケース識別子を前提とした命名
- ケース間で名前空間を共有しない方針
- `ID` / `TCP` / `UI` を常に大文字維持する方針
- `XXX.Client.UI` 形式を標準命名として扱う方針
- using をカテゴリ別に 1 行空けするルール
- namespace 前を 5 行空けるルール
- クラス内部を 5 行 / 3 行 / 1 行で空けるルール
- 単文字ループ変数を避ける方針
- `DB` などの略称を許容する方針

## 未反映確認

- 公式ソースのカテゴリ単位の取得: 完了
- 公式ソースの rule / option 一覧の反映: 完了
- 独自規約の分離: 完了
- 未反映 0 件の前提:
  - 文章ベース規約は `#guidelines` と `#naming` に反映済み
  - style rule は `#language-rules` にカテゴリ単位で反映済み
  - formatting option は `#formatting` に option 単位で反映済み

## 注意

この一覧は、「標準ベースを一度作り直す」ための照合基準であり、今後の更新時も再利用できる。
