# WiniumDesktopDemo
Winium.Desktop demo project. (VS2017, C#, Win8)
* Key operation.
* Get Screenshot.

# How it works

* C:\Winium.Desktop.Driver へ [GitHub の Winium.Desktop リポジトリ](https://github.com/2gis/Winium.Desktop/releases) からダウンロードした実行ファイル Winium.Desktop.Driver.exe を配置してください。
* 本サンプルを動かす際は、 Winium.Desktop.Driver.exe を起動した状態で、Visual Studio のテストフレームワークから、単体テストを実行してください。
* Windows 8.1 Pro の電卓アプリでの動作を確認しています。</br>※Windows 10 の電卓アプリは、Win32 ではなく XAML ベースとなっているため、このままでは動作しません。

# How to check Control Information

* Windows SDK付属のInspectツールを利用して、コントロールの属性を確認します。</br>[Inspectツールを使ってUIを調査するには？［Windows 8／Windows 8.1ストアアプリ開発］](http://www.atmarkit.co.jp/ait/articles/1404/03/news004.html)

# Reference

* [Magic Samples](https://github.com/2gis/Winium.Desktop/wiki/Magic-Samples)
* [C#からWinium WebDriverを使ってみた。](https://www.ka-net.org/blog/?p=6463)