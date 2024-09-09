

# Identity/Security
https://learn.microsoft.com/en-us/aspnet/core/blazor/security/?view=aspnetcore-8.0

# Custom IdentityUser 
https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-8.0

- Add StudentNo to IdentityUser(AppUser)

> Run this command to include changes to the Data Layer

Add-Migration -Context ApplicationDbContext -Project BlazorApp -StartupProject BlazorApp -Name CustomizedUserWithStudentNo

Change the -Name to reflect the changes made to the Database
Also check in appsetiings.json that Connection is correct

e.g.
Add-Migration -Context ApplicationDbContext -Project BlazorApp -StartupProject BlazorApp -Name AddedStudentRecord

Layout 
https://stackoverflow.com/questions/65654999/how-to-add-a-footer-in-default-mainlayout-razor




Sample: Contact == Student

## Upload Document
https://medium.com/@icollocollo/how-to-upload-files-in-blazor-net-8-19bf95b88e02
