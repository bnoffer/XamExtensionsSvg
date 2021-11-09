#!/bin/sh
nuget pack XamExtensionsSvg.nuspec -Prop Configuration=Release -verbosity detailed -basepath ./ -OutputDirectory ./package
