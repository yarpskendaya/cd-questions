# Solution Structure

- How do the tests usually map onto production code structure?
- Is this usually MyClass -> MyClassTests in a direct mapping?
    (excluding simple bags of data)

- How does this differ between Unit Tests en Acceptance Tests?

- A general structure we maintain is:

```
src/
    /MyCompany.MyProduct.sln
    /MyCompany.MyProduct.App.csproj
    /MyCompany.MyProduct.Core.csproj
    /MyCompany.MyProduct.Db.csproj
    /MyCompany.MyProduct.Logs.csproj
    /MyCompany.MyProduct.Installer.csproj
    /MyCompany.MyProduct.Ui.csproj
    /Tests/
        /MyCompany.MyProduct.App.Tests.csproj
        /MyCompany.MyProduct.Core.Tests.csproj
        /MyCompany.MyProduct.Db.Tests.csproj
        /MyCompany.MyProduct.Logs.Tests.csproj
        /MyCompany.MyProduct.Ui.Tests.csproj

        /MyCompany.MyProduct.ComponentTests.csproj
        /MyCompany.MyProdcut.IntegrationTests.csproj
```