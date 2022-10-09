FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FckinPianino/FckinPianino.csproj", "FckinPianino/"]
RUN dotnet restore "FckinPianino/FckinPianino.csproj"
COPY . .
WORKDIR "/src/FckinPianino"
RUN dotnet build "FckinPianino.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FckinPianino.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FckinPianino.dll"]
