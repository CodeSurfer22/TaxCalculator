# TaxCalculator
# Instructions before running the application:
Expand the TaxCalculator.API project
Find and open the appsettings.json and locate the DefaultConnection string value as follows:
"DefaultConnection": "Server=DESKTOP-5C8O7N3\\SQLEXPRESS;Database=TaxCalculations;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true"
Replace the...DESKTOP-5C8O7N3\\SQLEXPRESS...portion with an accessible MS SQL Server name. If Windows authentication is not used then add in the username and password by for example modifying the connection string as follows:
"DefaultConnection": "Server=DESKTOP-5C8O7N3\\SQLEXPRESS;Database=TaxCalculations;User ID=yourUsername;Password=yourPassword;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true"
