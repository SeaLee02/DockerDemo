FROM registry.cn-hangzhou.aliyuncs.com/yoyosoft/dotnet/core/aspnet:3.1
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "YOYO.dll"]