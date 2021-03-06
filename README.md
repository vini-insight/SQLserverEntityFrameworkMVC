# SQLserverEntityFrameworkMVC
SQL server Entity Framework MVC

USANDO PROJETO:

    ACESSAR: http://localhost:5000/book/create E http://localhost:5000/author/create


Tutorial : https://www.learnentityframeworkcore.com/walkthroughs/aspnetcore-application

https://www.learnentityframeworkcore.com/walkthroughs/aspnetcore-application


### MUDANÇAS EM RELAÇÃO AO TUTORIAL:

PRIMEIRA:

FUNCIONOU SEM PRECISAR FAZER O SEGUINTE PASSO:

    Modify the .csproj file to include the following section:

    <ItemGroup>
        <DotNetCliToolReference
            Include="Microsoft.EntityFrameworkCore.Tools.DotNet"
            Version="1.0.0-msbuild3-final" />
    </ItemGroup>

This step is only necessary if the .csproj file wasn't automatically modified to add the entry when the Tools package was installed. See https://github.com/aspnet/EntityFramework/issues/7358.

SEGUNDA:
em relação a outros tutoriais, eu não precisei fazer referencia do DbContext (EFCoreWebDemoContext) na classe Startup.cs

TERCEIRA:
alteração na estrutura do projeto: no tutorial a classe do contexto do BD EFCoreWebDemoContext fica junto com o modelo. agora ela tem uma pasta exclusiva Data.


Dependencias:

    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.1

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.1


EFcore --version 3.1.3 INSTALADO GLOBALMENTE:

    dotnet ef migrations add CreateDatabase

    dotnet ef database update




# ERROS:

    Erro do Compilador CS0246
O nome do tipo ou do namespace 'tipo/namespace' não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
Neste caso tem que usar o namesmace completo, ou seja, colocar o nome do projeto.pasta. por exemplo: "using projeto1.model;" ao invés de "using model;




