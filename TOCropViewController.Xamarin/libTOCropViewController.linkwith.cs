using ObjCRuntime;
[assembly: LinkerSafe]
[assembly: LinkWith ("libTOCropViewController.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64,
ForceLoad = true, SmartLink=true,
LinkerFlags = "-ObjC")]