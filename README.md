# FileUploadAPI

Esta API permite o upload de arquivos, com foco no upload de currículos em formato PDF. A API foi construída utilizando ASP.NET Core e oferece uma rota para enviar arquivos e retornar um arquivo específico como resposta.

## Endpoints

### 1. **POST /api/file/upload-curriculos**

Este endpoint permite o upload de um ou mais arquivos (por exemplo, currículos) e os processa. Após o upload, o arquivo será retornado como resposta.

#### Request:
- **Método:** `POST`
- **URL:** `/api/file/upload-curriculos`
- **Content-Type:** `multipart/form-data`
- **Corpo da Requisição:**
  - Envie um ou mais arquivos sob o campo `files`.

Exemplo de corpo da requisição (usando o Postman ou cURL):
```bash
curl -X POST https://localhost:5001/api/file/upload-curriculos \
  -F "files=@/path/to/your/file.pdf"
Response:
Status Code: 200 OK se o upload for bem-sucedido.

Corpo da Resposta:

O arquivo enviado será retornado, com o nome "Curriculos.pdf", mantendo o tipo de conteúdo original.

Exemplo de resposta (arquivo PDF retornado):

plaintext
Copy
Edit
Content-Type: application/pdf
Content-Disposition: inline; filename="Curriculos.pdf"
Erros:
400 Bad Request - Se nenhum arquivo for enviado.

Exemplo de resposta:

json
Copy
Edit
{
  "message": "Nenhum arquivo foi enviado"
}
Estrutura do Projeto
Controllers/FileController.cs: Contém o código principal da API que manipula os uploads de arquivos.

appsettings.json: Arquivo de configuração da aplicação.

Program.cs: Configuração do servidor e dos serviços.

Como Rodar a Aplicação
Pré-requisitos
Visual Studio ou VS Code com .NET SDK instalado.

.NET 6.0 ou superior.

Passos:
Clone o repositório:

bash
Copy
Edit
git clone https://github.com/your-username/FileUploadAPI.git
Navegue até o diretório do projeto:

bash
Copy
Edit
cd FileUploadAPI
Restaure as dependências do projeto:

bash
Copy
Edit
dotnet restore
Execute a aplicação:

bash
Copy
Edit
dotnet run
A API estará disponível em https://localhost:5001.

Tecnologias Utilizadas
ASP.NET Core: Framework para a criação da API.

C#: Linguagem de programação utilizada.

Swagger: Para documentação da API (caso configurado).
