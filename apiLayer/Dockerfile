FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS base
WORKDIR /source


COPY . .
RUN dotnet restore "apiLayer.csproj" --disable-parallel
RUN dotnet publish "apiLayer.csproj" -c release -o /app 


FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=base /app ./

Expose 5000
ENTRYPOINT ["dotnet","apiLayer.dll"]
