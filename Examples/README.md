# Examples
Each of these examples comes in two parts. In order to run an example, copy both the folders from their parent directory to your local Kingdoms & Castles mod directory. Be sure not to copy the parent directory along with them.
### SimpleDemo
In this example, DemoMod1 and DemoMod2 will both register themselves with the framework. Following that, DemoMod1 will attempt to load DemoMod2. If it is successful, DemoMod1 will log the string \"Successfully loaded DemoMod2\".
### AccessFields
In this example, AccessFields1 and AccessFields2 will both register themselves with the framework. Following that, AccessFields1 will attempt to load AccessFields2. If it is successful, AccessFields1 will log the contents of AccessFields2.myString.
### CallMethods
In this example, CallMethods1 and CallMethods2 will both register themselves with the framework. Following that, CallMethods1 will attempt to load CallMethods2. If it is successfull, CallMethods1 will log the result of a call to CallMethods2.AddSeventyThree twice, first called without a delegate and second called with a delegate.
### UseClasses
In this example, UseClasses1 and UseClasses2 will both register themselves with the framework. Following that, UseClasses1 will attempt to load UseClasses2. If it is successful, UseClasses1 will create an instance of the class Examples.UseClasses.UseClasses2.DemoClass twice, first using the parameterless constructor, then using the constructor which accepts a string. Both times after instantiation, it will log the contents of the instance\'s message field by calling LogMessage on the instance.
### PatchMethods
In this example, PatchMethods1 and PatchMethods2 will both register themselves with the framework. Following that, PatchMethods1 will attempt to load PatchMethods2. If it is successful, PatchMethods1 will apply a patch to PatchMethods2.SceneLoaded, which will cause the name of the PatchMethods2 instance to be logged before the string \"SceneLoaded\" is logged.