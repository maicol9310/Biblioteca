# Biblioteca

1 - Usar Biblioteca.Web como proyecto de inicio
2 - Usar los siguientes paquetes:
    
    Para Biblioteca.Web:

  <ItemGroup>
    <PackageReference Include="MediatR" Version="8.1.0" />
    <PackageReference Include="MediatR.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="5.0.10">
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.10">
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="5.0.2" />
  </ItemGroup>

    Para Biblioteca.Application:

  <ItemGroup>
    <PackageReference Include="AutoMapper" Version="12.0.1" />
    <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.0" />
    <PackageReference Include="FluentValidation" Version="11.5.1" />
    <PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="11.5.1" />
    <PackageReference Include="MediatR.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.10" />
    <PackageReference Include="Microsoft.Extensions.Configuration.Abstractions" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="6.0.0" />
  </ItemGroup>

    Para Biblioteca.Domain:

  <ItemGroup>
    <PackageReference Include="System.ComponentModel.Annotations" Version="5.0.0" />
  </ItemGroup>

    Para Biblioteca.Infrastructure:

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.10" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.10" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.10">
    <PackageReference Include="Microsoft.Extensions.Configuration.Abstractions" Version="6.0.0" />
  </ItemGroup>
   

3 - Ejecutar proyecto con .Net 5