#!/usr/bin/env sh

set -eu

dotnet tool restore
dotnet restore
dotnet pack -p:PackageTags=fable-all -p:FablePackageType=library -p:PackageVersion=0.0.5-beta thoth-json-codec
