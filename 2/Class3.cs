﻿<? xml version = "1.0" encoding = "utf-8" ?>
< Project ToolsVersion = "15.0" xmlns = "http://schemas.microsoft.com/developer/msbuild/2003" >
  < Import Project = "$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition = "Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  < PropertyGroup >
    < Configuration Condition = " '$(Configuration)' == '' " > Debug </ Configuration >
    < Platform Condition = " '$(Platform)' == '' " > AnyCPU </ Platform >
    < ProjectGuid >{ F6F03803 - 1910 - 4654 - 801D - 7DE3EC82CBFD}</ ProjectGuid >
    < OutputType > WinExe </ OutputType >
    < RootNamespace > Dashboard </ RootNamespace >
    < AssemblyName > Dashboard </ AssemblyName >
    < TargetFrameworkVersion > v4.6.1 </ TargetFrameworkVersion >
    < FileAlignment > 512 </ FileAlignment >
    < ProjectTypeGuids >{ 60dc8134 - eba5 - 43b8 - bcc9 - bb4bc16c2548};
{ FAE04EC0 - 301F - 11D3 - BF4B - 00C04F79EFBC}</ ProjectTypeGuids >
    < WarningLevel > 4 </ WarningLevel >
    < AutoGenerateBindingRedirects > true </ AutoGenerateBindingRedirects >
  </ PropertyGroup >
  < PropertyGroup Condition = " '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' " >
    < PlatformTarget > AnyCPU </ PlatformTarget >
    < DebugSymbols > true </ DebugSymbols >
    < DebugType > full </ DebugType >
    < Optimize > false </ Optimize >
    < OutputPath > bin\Debug\</ OutputPath >
    < DefineConstants > DEBUG; TRACE </ DefineConstants >
    < ErrorReport > prompt </ ErrorReport >
    < WarningLevel > 4 </ WarningLevel >
  </ PropertyGroup >
  < PropertyGroup Condition = " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' " >
    < PlatformTarget > AnyCPU </ PlatformTarget >
    < DebugType > pdbonly </ DebugType >
    < Optimize > true </ Optimize >
    < OutputPath > bin\Release\</ OutputPath >
    < DefineConstants > TRACE </ DefineConstants >
    < ErrorReport > prompt </ ErrorReport >
    < WarningLevel > 4 </ WarningLevel >
  </ PropertyGroup >
  < ItemGroup >
    < Reference Include = "System" />
    < Reference Include = "System.Data" />
    < Reference Include = "System.Xml" />
    < Reference Include = "Microsoft.CSharp" />
    < Reference Include = "System.Core" />
    < Reference Include = "System.Xml.Linq" />
    < Reference Include = "System.Data.DataSetExtensions" />
    < Reference Include = "System.Net.Http" />
    < Reference Include = "System.Xaml" >
      < RequiredTargetFramework > 4.0 </ RequiredTargetFramework >
    </ Reference >
    < Reference Include = "WindowsBase" />
    < Reference Include = "PresentationCore" />
    < Reference Include = "PresentationFramework" />
  </ ItemGroup >
  < ItemGroup >
    < ApplicationDefinition Include = "App.xaml" >
      < Generator > MSBuild:Compile </ Generator >
      < SubType > Designer </ SubType >
    </ ApplicationDefinition >
    < Compile Include = "TestData\AssetClass.cs" />
    < Page Include = "MainWindow.xaml" >
      < Generator > MSBuild:Compile </ Generator >
      < SubType > Designer </ SubType >
    </ Page >
    < Compile Include = "App.xaml.cs" >
      < DependentUpon > App.xaml </ DependentUpon >
      < SubType > Code </ SubType >
    </ Compile >
    < Compile Include = "MainWindow.xaml.cs" >
      < DependentUpon > MainWindow.xaml </ DependentUpon >
      < SubType > Code </ SubType >
    </ Compile >
    < Page Include = "PieChart\PieChart\PieChartLayout.xaml" >
      < SubType > Designer </ SubType >
      < Generator > MSBuild:Compile </ Generator >
    </ Page >
    < Page Include = "PieChart\PieChart\PiePlotter.xaml" >
      < SubType > Designer </ SubType >
      < Generator > MSBuild:Compile </ Generator >
    </ Page >
  </ ItemGroup >
  < ItemGroup >
    < Compile Include = "PieChart\PieChart\IColorSelector.cs" />
    < Compile Include = "PieChart\PieChart\IndexedColourSelector.cs" />
    < Compile Include = "PieChart\PieChart\PieChartLayout.xaml.cs" >
      < DependentUpon > PieChartLayout.xaml </ DependentUpon >
    </ Compile >
    < Compile Include = "PieChart\PieChart\PiePlotter.xaml.cs" >
      < DependentUpon > PiePlotter.xaml </ DependentUpon >
    </ Compile >
    < Compile Include = "PieChart\Shapes\PiePiece.cs" />
    < Compile Include = "Properties\AssemblyInfo.cs" >
      < SubType > Code </ SubType >
    </ Compile >
    < Compile Include = "Properties\Resources.Designer.cs" >
      < AutoGen > True </ AutoGen >
      < DesignTime > True </ DesignTime >
      < DependentUpon > Resources.resx </ DependentUpon >
    </ Compile >
    < Compile Include = "Properties\Settings.Designer.cs" >
      < AutoGen > True </ AutoGen >
      < DependentUpon > Settings.settings </ DependentUpon >
      < DesignTimeSharedInput > True </ DesignTimeSharedInput >
    </ Compile >
    < EmbeddedResource Include = "Properties\Resources.resx" >
      < Generator > ResXFileCodeGenerator </ Generator >
      < LastGenOutput > Resources.Designer.cs </ LastGenOutput >
    </ EmbeddedResource >
    < None Include = "Properties\Settings.settings" >
      < Generator > SettingsSingleFileGenerator </ Generator >
      < LastGenOutput > Settings.Designer.cs </ LastGenOutput >
    </ None >
  </ ItemGroup >
  < ItemGroup />
  < Import Project = "$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</ Project >