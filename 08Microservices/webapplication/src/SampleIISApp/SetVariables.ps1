foreach($key in
[System.Environment]::GetEnvironmentVariables('Process').Keys) {
if ([System.Environment]::GetEnvironmentVariable($key, 'Machine') -eq
$null) {
$value = [System.Environment]::GetEnvironmentVariable($key,
'Process')
[System.Environment]::SetEnvironmentVariable($key, $value,
'Machine')
}
}
C:\ServiceMonitor.exe W3SVC