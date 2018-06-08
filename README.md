# 学委助手

学委除了要收作业，最烦的就是统计谁没有交作业啦，还有就是大家的命名不统一造成文件排序混乱，更加大了学委统计的难度。所以，写这个应用的目的就是查交和格式化文件命名。

## 简介
该应用采用 C# 编写 WinForm 界面，Python 编写处理脚本。通过调用 Python 打包的 exe 可执行文件实现其功能。

你可以在[ Application ](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/tree/master/Application) 中直接下载得到。

主要的功能如下：

- 统计未交作业的同学人数
- 查找并返回未交作业同学的学号和姓名
- 格式化文件命名
   - 默认为空格分隔：学号 姓名，如：3150707012 李靖
   - 你可以指定学号姓名间的分隔符，如：3150707012+李靖
- 扩展命名
   - 添加文件名前缀，如：15信管3150707012 李靖
   - 添加文件名后缀：如：3150707012 李靖15信管

## 概览

### 打开文件
![](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/raw/master/Preview/openFile.gif)

### 作业查交

![](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/raw/master/Preview/check.gif)

### 基础命名

![](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/raw/master/Preview/basicRename.gif)

### 扩展命名

![](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/raw/master/Preview/extraRename.gif)

## 使用方法

### 准备班级名单
- 名单为 Excel 表格形式
- 包含两列，列名为“学号”和“姓名”

如：

|学号|姓名|
|---|---|
|3150707001|张三|
|3150707002|李四|
|...|...|

### 检查文件

- 备份检查文件，以免应操作不当造成文件损坏
- 复制检查文件至新建文件夹中，注意，文件夹名称**不能**含有美元符'$'

### 启动应用
- 双击“学委助手.exe”
- 注意：pyHelper.exe 需要和"学委助手.exe"放置在在同一路径中，并且不要修改它的名字

### 执行操作
- 选择需要执行的功能即可

## 下载

[Download](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/raw/master/%E5%AD%A6%E5%A7%94%E5%8A%A9%E6%89%8BV1.2.zip)

## 修改日志

[See here](https://github.com/jl223vy/Helper_for_CommissaryInChargeOfStudies/blob/master/Docs/Change%20Logs.md)

## 最后

祝学委们玩得开心;)




