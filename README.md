# ImageRecognition
基于OpenCV实现的图片识别功能。该项目是参考OpenCV 和 EmguCV一些例子进行学习的项目。EmguCV中包含了很多示例，大家可以一一练习，再应用到合适场景中。

### 环境安装
OpenCV：https://sourceforge.net/projects/opencvlibrary/

EmguCV：https://sourceforge.net/projects/emgucv/（.net 使用的 OpenCV 封装。）

OpenCV下载后进行解压，将解压后的目录配置到环境变量中。
;xxx\opencv\opencv3\build\x64\vc15\bin

EmguCV 下载后解压，解压后目录中包含源码及示例。

### 引用清单
	示例：dll 目录如下
		xxx\opensf\opencv\emgucv\emgucv-windesktop 3.3.0.2824\libs
	添加引用
		Emgu.CV.World.dll
		Emgu.CV.UI.dll
	将x86、x64放置到项目bin目录下。
### 相关链接


- [OpenCV](https://opencv.org/)
- [EmguCV](http://www.emgu.com/wiki/index.php/Main_Page)
- [EmguCV入门指南-中文翻译版](https://wenku.baidu.com/view/d4217a62af1ffc4ffe47ac27.html)
- [opencvsharp（另一开源的.net驱动）](https://github.com/shimat/opencvsharp)

### 示例
- 脸部+眼部检测
- 马路行人检测
- 特征匹配（示例：微信“跳一跳”棋子匹配）