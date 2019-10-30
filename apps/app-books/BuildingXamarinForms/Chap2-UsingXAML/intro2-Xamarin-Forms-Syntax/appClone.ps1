# source, destination
$s = "C:\xmrn\Chap2-UsingXAML\intro1-Markup-Extensions";
$d = "C:\xmrn\Chap2-UsingXAML\intro2-Xamarin-Forms-Syntax";

# Remove-Item $d -Force -Recurse
Copy-Item $s -Destination $d -Recurse