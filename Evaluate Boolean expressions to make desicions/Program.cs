using System.Xml.XPath;

string permission = "Manager";
int level = 30  ;



string superAdmin = "Welcome, Super Admin user.";
string admin = "Welcome, Admin user.";
string highManager = "Contact an Admin for access.";
string noRights = "You do not have sufficient privileges.";

var result = (permission.ToLower().Trim().Contains("admin")) && level >= 55 ? superAdmin :
                ((permission.ToLower().Trim().Contains("admin")) && level < 55) ? admin :
                    ((permission.ToLower().Trim().Contains("manager")) && level > 20 ? highManager : noRights);
Console.WriteLine(result);