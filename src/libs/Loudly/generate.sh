install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
cp ../../../openapi.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Loudly \
  --clientClassName LoudlyClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:API-KEY
