# APITemplate

O APITemplate é um projeto de API que serve como um modelo para a criação de outras APIs baseadas em .NET Core. Ele já está configurado com estrutura básica, incluindo uma classe de tabela pronta para uso.

## Recursos

- **Estrutura Pronta:** Este projeto é configurado e estruturado, pronto para ser usado como base para novos projetos de API.
- **Classe de Tabela:** Já contém uma classe de tabela (`TbEmployee` por exemplo) para demonstrar o uso de entidades de banco de dados.

## Uso

1. **Clonar o Repositório:**

```bash
git clone https://github.com/eliudefrancisco14/APITemplate.git
```

2. **Configuração:**

- Configure sua string de conexão com o banco de dados no arquivo `appsettings.json`.

- Faça essa configuração também no ficheiro localizado em `Model/DB/Context/APITemplateContext.cs`.

- Verifique se todos os pacotes necessários estão instalados (utilize `dotnet restore`).

- Use o comando `dotnet ef database update` para subir a migration Principal

3. **Execução:**

- Use `dotnet run` para iniciar a API.

- Acesse a API por meio da URL base, por exemplo: `https://localhost:5001`.

## Classe de Tabela

O projeto já contém uma classe de tabela (`TbEmployee`), que é um exemplo de como as entidades do banco de dados podem ser configuradas. Sinta-se à vontade para expandir ou modificar conforme necessário para suas necessidades específicas.

Exemplo:

```csharp
public class TbEmployee
{
 public int Id { get; set; }
 public string FirstName { get; set; }
 public string LastName { get; set; }
 public string Contact { get; set; }
}
```