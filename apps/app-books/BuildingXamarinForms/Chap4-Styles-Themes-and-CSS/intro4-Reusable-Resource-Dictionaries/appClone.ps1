# source, destination
$s = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap4-Styles-Themes-and-CSS\intro1-Creating-a-Page-Without-Style";
$d = "D:\Git\Ggg.Github\Ggg.Xamarin\apps\app-books\BuildingXamarinForms\Chap4-Styles-Themes-and-CSS\intro2-Resources-and-Dictionaries";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse