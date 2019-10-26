# source, destination
$s = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap1-BuildingAppsUsingXamarin\intro1";
$d = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap1-BuildingAppsUsingXamarin\intro2";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse