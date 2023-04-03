using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(Inside_the_Backrooms.BuildInfo.Name)]
[assembly: AssemblyDescription(Inside_the_Backrooms.BuildInfo.Description)]
[assembly: AssemblyCompany(Inside_the_Backrooms.BuildInfo.Company)]
[assembly: AssemblyProduct(Inside_the_Backrooms.BuildInfo.Name)]
[assembly: AssemblyCopyright("Copyright © " + Inside_the_Backrooms.BuildInfo.Author + " 2023")]
[assembly: AssemblyTrademark(Inside_the_Backrooms.BuildInfo.Company)]
[assembly: AssemblyVersion(Inside_the_Backrooms.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Inside_the_Backrooms.BuildInfo.Version)]


//Melon加载配置    buildinfo里的项目配置
[assembly: MelonInfo(typeof(Inside_the_Backrooms.Main), Inside_the_Backrooms.BuildInfo.Name, Inside_the_Backrooms.BuildInfo.Version, Inside_the_Backrooms.BuildInfo.Author)]

//根据游戏app.info文件修改这里  DEV   Game必须名字相对应
[assembly: MelonGame(Inside_the_Backrooms.BuildInfo.GameDev, Inside_the_Backrooms.BuildInfo.GameName)]