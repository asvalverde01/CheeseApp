# Usa una imagen base de .NET SDK para construir el proyecto
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copia los archivos de proyecto y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia el resto de los archivos y construye el proyecto
COPY . ./
RUN dotnet publish -c Release -o out

# Usa una imagen base de .NET Runtime para correr la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

# Exponer el puerto 80 para el tráfico HTTP
EXPOSE 80

# Ejecutar la aplicación
ENTRYPOINT ["dotnet", "CheeseApp.dll"]

