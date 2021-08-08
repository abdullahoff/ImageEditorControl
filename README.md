# ImageEditorControl

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)	
![.NET Framework version: >= 4.5](https://img.shields.io/badge/.NET%20Framework-%3E%3D%204.5-green.svg)
[![NuGet version](https://img.shields.io/nuget/v/ImageEditor)](https://www.nuget.org/packages/ImageEditor/)


Lightweight UI control for WPF applications offering image markup capabilities. 

![alt text](https://github.com/abdullahoff/ImageEditorControl/blob/main/ImageEditorExample.JPG?raw=true)

## Getting Started

1. Reference ImageEditor UI control via [Nuget](https://www.nuget.org/packages/ImageEditor/) or by manual download. Currently it requires at least .NET frammework 4.5 or .NET Core 3.0
2. Once installed via package manager, add assembly reference in the window where the control will be implemented in
```XAML
<Window x:Class="WpfApp1.MainWindow" xmlns:editor="clr-namespace:ImageEditor;assembly=ImageEditor">
```
3. Add the following XAML tag to initalize the Image Editor 
```XAML
  <editor:UserControl1 x:Name="imgEditor"/>
```

## Features
* Highlighting
* Text
* Paint Brush
* Geometric shapes
* Pencil
* Undo
* Resize
* Pan and Zoom

## Demo

Please clone the repository and then build the project called ImageEditorProject
