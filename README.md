# please-scan-bn

* To migration
- dotnet ef migrations add <xxxx>
  - Example : dotnet ef migrations add Initial_001

* To remove migration
- dotnet ef migrations remove

* Note
- Swagger : https://api-dev.please-scan.com/swagger/index.html
- Local run : http://localhost:5102/api/ApiKey/org/default/action/VerifyApiKey/xxxx
- Dev run   : http://api-dev.please-scan.com/api/ApiKey/org/default/action/VerifyApiKey/xxxx

* Example
curl -s -X GET http://localhost:5102/api/ApiKey/org/default/action/VerifyApiKey/xxxx -u "dummy:seubpongNajePjameMonsar123987#211"
curl -s -X POST http://localhost:5102/api/ApiKey/org/default/action/GetApiKeys -u "dummy:seubpongNajePjameMonsar123987#211"
