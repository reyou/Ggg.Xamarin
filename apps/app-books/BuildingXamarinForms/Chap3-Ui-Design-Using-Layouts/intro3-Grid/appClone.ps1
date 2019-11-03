# source, destination
$s = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap3-Ui-Design-Using-Layouts\intro6-ContentView";
$d = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap3-Ui-Design-Using-Layouts\intro7-Frame";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse