#!/bin/sh
nuget pack XamExtensionsSvg.nuspec -symbols -Prop Configuration=Release -verbosity detailed -basepath ./ -OutputDirectory ./package
