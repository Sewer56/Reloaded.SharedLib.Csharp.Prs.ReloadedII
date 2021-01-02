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

## How to Use The API (Programmers)

- Add the `Reloaded.SharedLib.CSharp.Prs.Interfaces` NuGet package to your project.
- Add the dependency `reloaded.sharedlib.csharp.prs` to `ModDependencies` in your `ModConfig.json`. 
- In your `Start()` function, acquire the Controller `_modLoader.GetController<IRedirectorController>()`

For more information and best practices, refer to [Reloaded-II Docs: Inter Mod Communication](https://reloaded-project.github.io/Reloaded-II/InterModCommunication/).