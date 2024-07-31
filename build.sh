#!/usr/bin/env sh

set -eu

dotnet tool restore
dotnet paket install
dotnet restore
dotnet pack -p:PackageTags=fable-all -p:FablePackageType=library -p:PackageVersion=0.0.7-core-beta Thoth.Json.Codec
