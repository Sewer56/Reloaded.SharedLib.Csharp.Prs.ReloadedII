<div align="center">
	<h1>RII Shared Library: Csharp-Prs</h1>
	<img src="https://i.imgur.com/BjPn7rU.png" width="150" align="center" />
	<br/> <br/>
	<strong>Sharing is Caring</strong><br/>
<b>Id: reloaded.sharedlib.csharp.prs</b>
</div>

## Shared Library
This is a Reloaded II shared library. For more information refer to Shared Library Documentation: https://github.com/Sewer56/Reloaded.SharedLib.Hooks.ReloadedII and [Inter-Mod-Communication](https://github.com/Reloaded-Project/Reloaded-II/blob/master/Docs/InterModCommunication.md#required-dependencies).

## How to Use (End Users)

**A.** Install Reloaded mod as usual.

**B.** Nothing else needs to be done. This mod will be auto-enabled if required by other mods.

## How to Use (Developers)
Using a shared library is identical to using a **Controller** in Inter Mod Communication.

**A.** Add the NuGet Package *Reloaded.SharedLib.CSharp.Prs.Interfaces* to your project: <a href="https://www.nuget.org/packages/Reloaded.SharedLib.CSharp.Prs.Interfaces"><img src="https://img.shields.io/nuget/v/Reloaded.SharedLib.CSharp.Prs.Interfaces.svg" alt="NuGet" /></a>

**B.** Add `reloaded.sharedlib.csharp.prs` as a dependency of the mod `(in ModConfig.json)`.

**C.** Use like a regular **Controller** via [Inter-Mod-Communication](https://github.com/Reloaded-Project/Reloaded-II/blob/master/Docs/InterModCommunication.md#required-dependencies)

Of course, you should also download and extract the shared library (mod) to your mods folder.