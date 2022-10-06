#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DCK.API.MOVIMENTOSMANUAIS/DCK.API.MOVIMENTOSMANUAIS.csproj", "DCK.API.MOVIMENTOSMANUAIS/"]
RUN dotnet restore "DCK.API.MOVIMENTOSMANUAIS/DCK.API.MOVIMENTOSMANUAIS.csproj"
COPY . .
WORKDIR "/src/DCK.API.MOVIMENTOSMANUAIS"
RUN dotnet build "DCK.API.MOVIMENTOSMANUAIS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DCK.API.MOVIMENTOSMANUAIS.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DCK.API.MOVIMENTOSMANUAIS.dll"]