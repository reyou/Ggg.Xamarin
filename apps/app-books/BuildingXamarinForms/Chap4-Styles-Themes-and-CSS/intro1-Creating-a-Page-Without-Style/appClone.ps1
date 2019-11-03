# source, destination
$s = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap4-Styles-Themes-and-CSS\intro4-Reusable-Resource-Dictionaries";
$d = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap4-Styles-Themes-and-CSS\intro5-Styles";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse