

#C\#几种延迟测试

在 `.NET` 程序中好多地方都有延迟(`Lazy`)的痕迹,这一点在 `Linq` 中发扬广大。在 `.NET4.0` 中又引入了 `System.Lazy<T>` 。更加丰富了延迟的方式。

在示例代码分为以下方式

+ 顺序执行
+ Lazy延迟
+ 用 `yield` 延迟操作
+ 通过 `FindAll` 和 `Where` 比较 `where`的延迟
