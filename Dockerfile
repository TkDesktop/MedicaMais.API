FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o arquivo .csproj e restaura as dependências
COPY *.csproj ./
RUN dotnet restore

# Copia todo o código e compila a aplicação
COPY . ./
RUN dotnet publish -c Release -o /app/out

# Imagem final de execução (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Define a porta padrão do ASP.NET Core
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "NOME_DO_SEU_PROJETO.dll"]
