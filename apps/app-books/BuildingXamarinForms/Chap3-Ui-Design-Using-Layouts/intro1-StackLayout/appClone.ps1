# source, destination
$s = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap3-Ui-Design-Using-Layouts\intro1-StackLayout";
$d = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap3-Ui-Design-Using-Layouts\intro2-FlexLayout";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse