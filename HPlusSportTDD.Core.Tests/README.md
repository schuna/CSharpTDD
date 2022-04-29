## Sonarqube 
>dotnet sonarscanner begin /k:"Project" /d:sonar.host.url="http://localhost:9000" /d:sonar.login="key" /d:sonar.cs.dotcover.reportsPaths=**/*.html
dotnet build --no-incremental
dotnet dotcover test --dcReportType=HTML
dotnet sonarscanner end /d:sonar.login="key" 