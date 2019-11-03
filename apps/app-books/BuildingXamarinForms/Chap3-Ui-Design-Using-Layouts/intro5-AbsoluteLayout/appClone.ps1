# source, destination
$s = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap3-Ui-Design-Using-Layouts\intro3-Grid";
$d = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap3-Ui-Design-Using-Layouts\intro4-RelativeLayout";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse