$time = Get-Date -Format yyyy-MM-dd-HH-mm-ss-tt

packages\NUnit.ConsoleRunner.3.6.1\tools\nunit3-console.exe --labels=All --out=TestResult.txt "--result=TestResult.xml;format=nunit2" Demo.Tests\bin\Debug\Demo.Tests.dll

$output = "MyResult-" + $time + ".html"

packages\SpecFlow.2.1.0\tools\specflow.exe nunitexecutionreport Demo.Tests/Demo.Tests.csproj /out:$output